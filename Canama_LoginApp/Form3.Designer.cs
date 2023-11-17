
namespace Canama_LoginApp
{
    partial class Form3
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
            this.pbOpenCamera = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Fullname = new System.Windows.Forms.Label();
            this.pbCapturedImage = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapturedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbOpenCamera
            // 
            this.pbOpenCamera.Location = new System.Drawing.Point(42, 47);
            this.pbOpenCamera.Name = "pbOpenCamera";
            this.pbOpenCamera.Size = new System.Drawing.Size(331, 208);
            this.pbOpenCamera.TabIndex = 0;
            this.pbOpenCamera.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open Camera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fullname
            // 
            this.Fullname.AutoSize = true;
            this.Fullname.Location = new System.Drawing.Point(539, 206);
            this.Fullname.Name = "Fullname";
            this.Fullname.Size = new System.Drawing.Size(35, 13);
            this.Fullname.TabIndex = 2;
            this.Fullname.Text = "label1";
            // 
            // pbCapturedImage
            // 
            this.pbCapturedImage.Location = new System.Drawing.Point(42, 261);
            this.pbCapturedImage.Name = "pbCapturedImage";
            this.pbCapturedImage.Size = new System.Drawing.Size(331, 208);
            this.pbCapturedImage.TabIndex = 3;
            this.pbCapturedImage.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(610, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "Detect Face";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(480, 300);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(180, 20);
            this.tbPass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password:";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(516, 384);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 7;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 533);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Go To Log in Page";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 582);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pbCapturedImage);
            this.Controls.Add(this.Fullname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbOpenCamera);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapturedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOpenCamera;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Fullname;
        private System.Windows.Forms.PictureBox pbCapturedImage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button button3;
    }
}