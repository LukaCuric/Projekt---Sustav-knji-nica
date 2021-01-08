
namespace Sustav_Knjižnica
{
    partial class Form1
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbYoutube = new System.Windows.Forms.PictureBox();
            this.pbFacebook = new System.Windows.Forms.PictureBox();
            this.pbInstagram = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbYoutube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInstagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(51)))), ((int)(((byte)(106)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(91, 213);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(193, 19);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Korisničko ime";
            this.txtUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUsername_MouseClick);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(51)))), ((int)(((byte)(106)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(91, 281);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(193, 19);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Lozinka";
            this.txtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPassword_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(127)))), ((int)(((byte)(85)))));
            this.panel1.Location = new System.Drawing.Point(91, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 4);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(127)))), ((int)(((byte)(85)))));
            this.panel2.Location = new System.Drawing.Point(91, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 4);
            this.panel2.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Cyan;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogin.Location = new System.Drawing.Point(44, 346);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(240, 38);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Prijava";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Cyan;
            this.button2.Location = new System.Drawing.Point(44, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "Registracija";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(283, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 30);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbYoutube
            // 
            this.pbYoutube.Image = global::Sustav_Knjižnica.Properties.Resources.youtube_icon;
            this.pbYoutube.Location = new System.Drawing.Point(221, 455);
            this.pbYoutube.Name = "pbYoutube";
            this.pbYoutube.Size = new System.Drawing.Size(63, 50);
            this.pbYoutube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbYoutube.TabIndex = 11;
            this.pbYoutube.TabStop = false;
            this.pbYoutube.Click += new System.EventHandler(this.pbYoutube_Click);
            // 
            // pbFacebook
            // 
            this.pbFacebook.Image = global::Sustav_Knjižnica.Properties.Resources.facebook_icon;
            this.pbFacebook.Location = new System.Drawing.Point(132, 455);
            this.pbFacebook.Name = "pbFacebook";
            this.pbFacebook.Size = new System.Drawing.Size(63, 50);
            this.pbFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFacebook.TabIndex = 10;
            this.pbFacebook.TabStop = false;
            this.pbFacebook.Click += new System.EventHandler(this.pbFacebook_Click);
            // 
            // pbInstagram
            // 
            this.pbInstagram.Image = global::Sustav_Knjižnica.Properties.Resources.instagram_icon;
            this.pbInstagram.Location = new System.Drawing.Point(44, 455);
            this.pbInstagram.Name = "pbInstagram";
            this.pbInstagram.Size = new System.Drawing.Size(63, 50);
            this.pbInstagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInstagram.TabIndex = 9;
            this.pbInstagram.TabStop = false;
            this.pbInstagram.Click += new System.EventHandler(this.pbInstagram_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Sustav_Knjižnica.Properties.Resources.password2;
            this.pictureBox3.Location = new System.Drawing.Point(44, 281);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sustav_Knjižnica.Properties.Resources.username;
            this.pictureBox2.Location = new System.Drawing.Point(44, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sustav_Knjižnica.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(102, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(51)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(333, 537);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbYoutube);
            this.Controls.Add(this.pbFacebook);
            this.Controls.Add(this.pbInstagram);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbYoutube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInstagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pbInstagram;
        private System.Windows.Forms.PictureBox pbFacebook;
        private System.Windows.Forms.PictureBox pbYoutube;
        private System.Windows.Forms.Button btnClose;
    }
}

