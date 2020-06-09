using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualAreaCheckinApp
{
    public partial class VirtualCheckIn : Form
    {
        public VirtualCheckIn()
        {
            InitializeComponent();
        }

        private void validate_button_Click(object sender, EventArgs e)
        {
            var daxExpiration = daxExpiration_tb.Text;
            var status = status_tb.Text;
            var area_id = area_id_tb.Text;
            var validation_secret = validation_secret_tb.Text;
            var daxSignature = daxSignature_tb.Text;
            var response = validate_daxSignature(daxExpiration, status, area_id, validation_secret, daxSignature);

            if (response.is_valid)
            {
                is_valid_label.Text = "Validated!";
                is_valid_label.BackColor = Color.Green;
                is_valid_label.Visible = true;
            }
            else
            {
                is_valid_label.Text = response.error_message;
                is_valid_label.BackColor = Color.Red;
                is_valid_label.Visible = true;
            }
        }

        private IsValidResponse validate_daxSignature(string daxExpiration, string status, string area_id, string validation_secret, string daxSignature)
        {
            var current_time = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();
            if (current_time > Convert.ToInt64(daxExpiration))
                return new IsValidResponse { is_valid = false, error_message = "Expired" };

            byte[] generated_signature_bytes;

            var input_string = daxExpiration + status + area_id;

            byte[] input_bytes = Encoding.ASCII.GetBytes(input_string);

            byte[] secret_bytes = Enumerable.Range(0, validation_secret.Length)
                 .Where(x => x % 2 == 0)
                 .Select(x => Convert.ToByte(validation_secret.Substring(x, 2), 16))
                 .ToArray();

            byte[] input_daxSignature_bytes = Enumerable.Range(0, daxSignature.Length)
                 .Where(x => x % 2 == 0)
                 .Select(x => Convert.ToByte(daxSignature.Substring(x, 2), 16))
                 .ToArray();

            using (var sha = new System.Security.Cryptography.HMACSHA256(secret_bytes))
            {
                generated_signature_bytes = sha.ComputeHash(input_bytes);
            }

            var is_valid = input_daxSignature_bytes.SequenceEqual(generated_signature_bytes);

            if (is_valid)
                return new IsValidResponse { is_valid = true };
            else
                return new IsValidResponse { is_valid = false, error_message = "Invalid Signature" };
        }

        public class IsValidResponse
        {
            public bool is_valid { get; set; }
            public string error_message { get; set; }
        }
    }
}
