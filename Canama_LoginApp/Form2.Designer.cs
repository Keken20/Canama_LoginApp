
namespace Canama_LoginApp
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbOpencamera = new System.Windows.Forms.PictureBox();
            this.btnCaptureImage = new System.Windows.Forms.Button();
            this.pbImageCaptured = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbUserType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpencamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageCaptured)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRATION PAGE";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbOpencamera);
            this.panel2.Controls.Add(this.btnCaptureImage);
            this.panel2.Controls.Add(this.pbImageCaptured);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(446, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 565);
            this.panel2.TabIndex = 1;
            // 
            // pbOpencamera
            // 
            this.pbOpencamera.Location = new System.Drawing.Point(37, 69);
            this.pbOpencamera.Name = "pbOpencamera";
            this.pbOpencamera.Size = new System.Drawing.Size(258, 202);
            this.pbOpencamera.TabIndex = 13;
            this.pbOpencamera.TabStop = false;
            // 
            // btnCaptureImage
            // 
            this.btnCaptureImage.Location = new System.Drawing.Point(361, 232);
            this.btnCaptureImage.Name = "btnCaptureImage";
            this.btnCaptureImage.Size = new System.Drawing.Size(113, 60);
            this.btnCaptureImage.TabIndex = 12;
            this.btnCaptureImage.Text = "Capture Image";
            this.btnCaptureImage.UseVisualStyleBackColor = true;
            this.btnCaptureImage.Click += new System.EventHandler(this.btnCaptureImage_Click);
            // 
            // pbImageCaptured
            // 
            this.pbImageCaptured.Location = new System.Drawing.Point(37, 277);
            this.pbImageCaptured.Name = "pbImageCaptured";
            this.pbImageCaptured.Size = new System.Drawing.Size(258, 202);
            this.pbImageCaptured.TabIndex = 4;
            this.pbImageCaptured.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "REGISTER IMAGE";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.cbUserType);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnRegister);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.txtUsername);
            this.panel3.Controls.Add(this.txtLname);
            this.panel3.Controls.Add(this.txtFname);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 565);
            this.panel3.TabIndex = 1;
            // 
            // cbUserType
            // 
            this.cbUserType.FormattingEnabled = true;
            this.cbUserType.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cbUserType.Location = new System.Drawing.Point(151, 232);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.Size = new System.Drawing.Size(153, 21);
            this.cbUserType.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "User Type:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(59, 290);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Last Name:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(151, 193);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(153, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(151, 154);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(153, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(151, 112);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(153, 20);
            this.txtLname.TabIndex = 4;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(151, 77);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(153, 20);
            this.txtFname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "REGISTER INFORMATION";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Go To Log in Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 665);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpencamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageCaptured)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCaptureImage;
        private System.Windows.Forms.PictureBox pbImageCaptured;
        private System.Windows.Forms.PictureBox pbOpencamera;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbUserType;
        private System.Windows.Forms.Button button1;
    }
}