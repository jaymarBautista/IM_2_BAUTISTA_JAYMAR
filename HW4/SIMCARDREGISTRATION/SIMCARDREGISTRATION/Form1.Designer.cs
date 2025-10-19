
namespace SIMCARDREGISTRATION
{
    partial class Birthday
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.mobile = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonpicture = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.bday = new System.Windows.Forms.DateTimePicker();
            this.status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.location = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(129, 114);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(100, 22);
            this.firstname.TabIndex = 1;
            // 
            // mobile
            // 
            this.mobile.Location = new System.Drawing.Point(105, 67);
            this.mobile.Mask = "0000-000-0000";
            this.mobile.Name = "mobile";
            this.mobile.PromptChar = 'x';
            this.mobile.RejectInputOnFirstFailure = true;
            this.mobile.Size = new System.Drawing.Size(100, 22);
            this.mobile.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mobile";
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(384, 114);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(100, 22);
            this.lastname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lastname";
            // 
            // buttonpicture
            // 
            this.buttonpicture.Location = new System.Drawing.Point(363, 62);
            this.buttonpicture.Name = "buttonpicture";
            this.buttonpicture.Size = new System.Drawing.Size(86, 31);
            this.buttonpicture.TabIndex = 6;
            this.buttonpicture.Text = "Browse";
            this.buttonpicture.UseVisualStyleBackColor = true;
            this.buttonpicture.Click += new System.EventHandler(this.buttonpicture_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sex";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(106, 176);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(59, 21);
            this.male.TabIndex = 8;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(171, 177);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(75, 21);
            this.female.TabIndex = 9;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status";
            // 
            // bday
            // 
            this.bday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bday.Location = new System.Drawing.Point(129, 220);
            this.bday.Name = "bday";
            this.bday.Size = new System.Drawing.Size(200, 22);
            this.bday.TabIndex = 11;
            // 
            // status
            // 
            this.status.Items.AddRange(new object[] {
            "It\'s Complicated",
            "Single",
            "Married",
            "Widowed",
            "In a Relationship"});
            this.status.Location = new System.Drawing.Point(363, 171);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(121, 24);
            this.status.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Birthday";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.submit.Location = new System.Drawing.Point(363, 296);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(175, 41);
            this.submit.TabIndex = 14;
            this.submit.Text = "Submit Registration";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.button2_Click);
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(129, 255);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(285, 22);
            this.location.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "SIM CARD Registration";
            // 
            // Birthday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 371);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.location);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.status);
            this.Controls.Add(this.bday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonpicture);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label1);
            this.Name = "Birthday";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.MaskedTextBox mobile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonpicture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker bday;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

