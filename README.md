# dax-signature-validation

Virtual Area dax-signature Validation

## Custom Integration Setup

### Front-End Development for Check-In Submit

First, you will need a form submission similar to below. You may customize as you please, but ensure the following:

1. The form submission is a POST
2. The form action URL is the area integration URL that is attempting to be checked in to (Note: this is different for every area)
3. The request must contain:
    - "mode" = "custom"
    - "barcode" = { entered barcode }
    
```
<form method="post" action="https://your-site.org/online/1234/checkin/submit?area_id=1234">
  <input type="hidden" name="mode" value="custom" />
  Enter Barcode: <input type="text" name="barcode" />
  <button type="submit">Check In</button>
</form>
```

### Redirect Result

When we redirect to the given Redirect URL for the provided area, we will include the following parameters in the query string for your validation:

1. status
    - "success": member assigned to barcode was found, unique, and passed any possible area restrictions
    - "not_found": member assigned to barcode was NOT found
    - "access_denied": member assigned to barcode was found, unique, but did NOT pass area restrictions
    - "duplicate_barcode": multiple members were found assigned to barcode
    - "invalid": custom integration set for area, but did not get "mode"="custom" in the request OR custom integration NOT set for area and did get "mode"="custom" in the request
2. daxExpiration
    - When the redirect link expires in UTC milliseconds since unix epoc (10 minutes from when the check in is submitted)
3. area_id
    - The Area ID where the member is checking in
4. daxSignature
    - HMAC SHA256 digest of:
        - input: [daxExpiration]+[status]+[area_id] (in that order) converted to an ASCII byte array
        - key: Your Validation Secret above converted from a Hexadecimal string to a byte array

**Example**
```
https://your-site.org/this_is_the_redirect_url?status=success
&area_id=0
&daxExpiration=1591715195767
&daxSignature=FF5CE3E9CE0ACD3D157251D6DCB3C066C0002ED3ED0AEBDF146290FD3E949B95
```

### Server Side Validation

After we redirect to the given redirect_url with the above parameters, you must validate the daxExpiration and daxSignature to ensure it has not expired or been tampered with.

1. daxExpiration
    - Ensure that the current time converted to UTC Milliseconds Unix epoc is less than the daxExpiration in the result.
2. daxSignature
    - First, from the check-in result, concatenate the daxExpiration, status, & area_id - in that order. Then, get the ASCII Bytes of that string.
    - Next, get the bytes from your Validation Secret, which is a Hex-String of a random 32 byte array.
    - Lastly, generate an HMAC SHA256 digest with the ASCII bytes of the concatenated results as the input and your Validation Secret byte array as the key. The Hex-String of this output should equal the daxSignature from check-in result.

**Use the code example in this repository for more information on Server Side Validation**
