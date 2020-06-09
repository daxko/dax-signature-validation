namespace VirtualAreaCheckinApp
{
    partial class VirtualCheckIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.daxExpiration_tb = new System.Windows.Forms.TextBox();
            this.area_id_tb = new System.Windows.Forms.TextBox();
            this.validation_secret_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.validate_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.daxSignature_tb = new System.Windows.Forms.TextBox();
            this.is_valid_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.status_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // daxExpiration_tb
            // 
            this.daxExpiration_tb.Location = new System.Drawing.Point(145, 40);
            this.daxExpiration_tb.Name = "daxExpiration_tb";
            this.daxExpiration_tb.Size = new System.Drawing.Size(238, 20);
            this.daxExpiration_tb.TabIndex = 1;
            // 
            // area_id_tb
            // 
            this.area_id_tb.Location = new System.Drawing.Point(145, 95);
            this.area_id_tb.Name = "area_id_tb";
            this.area_id_tb.Size = new System.Drawing.Size(238, 20);
            this.area_id_tb.TabIndex = 2;
            // 
            // validation_secret_tb
            // 
            this.validation_secret_tb.Location = new System.Drawing.Point(145, 121);
            this.validation_secret_tb.Multiline = true;
            this.validation_secret_tb.Name = "validation_secret_tb";
            this.validation_secret_tb.Size = new System.Drawing.Size(238, 50);
            this.validation_secret_tb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the below information to validate a custom check-in daxSignature result\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Validation Secret\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Area ID\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "daxExpiration\r\n";
            // 
            // validate_button
            // 
            this.validate_button.Location = new System.Drawing.Point(218, 244);
            this.validate_button.Name = "validate_button";
            this.validate_button.Size = new System.Drawing.Size(75, 23);
            this.validate_button.TabIndex = 8;
            this.validate_button.Text = "Validate\r\n";
            this.validate_button.UseVisualStyleBackColor = true;
            this.validate_button.Click += new System.EventHandler(this.validate_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "daxSignature To Validate";
            // 
            // daxSignature_tb
            // 
            this.daxSignature_tb.Location = new System.Drawing.Point(145, 177);
            this.daxSignature_tb.Multiline = true;
            this.daxSignature_tb.Name = "daxSignature_tb";
            this.daxSignature_tb.Size = new System.Drawing.Size(238, 50);
            this.daxSignature_tb.TabIndex = 9;
            // 
            // is_valid_label
            // 
            this.is_valid_label.AutoSize = true;
            this.is_valid_label.Location = new System.Drawing.Point(231, 270);
            this.is_valid_label.Name = "is_valid_label";
            this.is_valid_label.Size = new System.Drawing.Size(0, 13);
            this.is_valid_label.TabIndex = 12;
            this.is_valid_label.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "status\r\n";
            // 
            // status_tb
            // 
            this.status_tb.Location = new System.Drawing.Point(145, 66);
            this.status_tb.Name = "status_tb";
            this.status_tb.Size = new System.Drawing.Size(238, 20);
            this.status_tb.TabIndex = 13;
            // 
            // VirtualCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 347);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.status_tb);
            this.Controls.Add(this.is_valid_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.daxSignature_tb);
            this.Controls.Add(this.validate_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.validation_secret_tb);
            this.Controls.Add(this.area_id_tb);
            this.Controls.Add(this.daxExpiration_tb);
            this.Name = "VirtualCheckIn";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox daxExpiration_tb;
        private System.Windows.Forms.TextBox area_id_tb;
        private System.Windows.Forms.TextBox validation_secret_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button validate_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox daxSignature_tb;
        private System.Windows.Forms.Label is_valid_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox status_tb;
    }
}

