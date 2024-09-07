namespace projectSignUp
{
    partial class Loginformproject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginformproject));
            this.lblemail = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.checkBoxpass = new System.Windows.Forms.CheckBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.lblDontaccount = new System.Windows.Forms.Label();
            this.linklblRegister = new System.Windows.Forms.LinkLabel();
            this.txtboxemail = new System.Windows.Forms.TextBox();
            this.lbllogi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblemail.Location = new System.Drawing.Point(46, 122);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(62, 24);
            this.lblemail.TabIndex = 0;
            this.lblemail.Text = "Email";
            this.lblemail.Click += new System.EventHandler(this.lblusername_Click);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.BackColor = System.Drawing.Color.Transparent;
            this.lblpass.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpass.Location = new System.Drawing.Point(12, 160);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(96, 24);
            this.lblpass.TabIndex = 0;
            this.lblpass.Text = "Password";
            this.lblpass.Click += new System.EventHandler(this.lblpass_Click);
            // 
            // textBoxpass
            // 
            this.textBoxpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpass.Location = new System.Drawing.Point(136, 163);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.PasswordChar = '*';
            this.textBoxpass.Size = new System.Drawing.Size(155, 22);
            this.textBoxpass.TabIndex = 2;
            this.textBoxpass.TextChanged += new System.EventHandler(this.textBoxpass_TextChanged);
            // 
            // checkBoxpass
            // 
            this.checkBoxpass.AutoSize = true;
            this.checkBoxpass.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxpass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxpass.Location = new System.Drawing.Point(212, 208);
            this.checkBoxpass.Name = "checkBoxpass";
            this.checkBoxpass.Size = new System.Drawing.Size(96, 17);
            this.checkBoxpass.TabIndex = 3;
            this.checkBoxpass.Text = "Hide password";
            this.checkBoxpass.UseVisualStyleBackColor = false;
            this.checkBoxpass.CheckedChanged += new System.EventHandler(this.checkBoxpass_CheckedChanged);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginBtn.BackgroundImage")));
            this.LoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LoginBtn.Location = new System.Drawing.Point(106, 288);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(100, 33);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.Login_Click);
            // 
            // lblDontaccount
            // 
            this.lblDontaccount.AutoSize = true;
            this.lblDontaccount.BackColor = System.Drawing.Color.Transparent;
            this.lblDontaccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDontaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDontaccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDontaccount.Location = new System.Drawing.Point(46, 335);
            this.lblDontaccount.Name = "lblDontaccount";
            this.lblDontaccount.Size = new System.Drawing.Size(224, 24);
            this.lblDontaccount.TabIndex = 5;
            this.lblDontaccount.Text = "Dont have an account?\r\n";
            // 
            // linklblRegister
            // 
            this.linklblRegister.ActiveLinkColor = System.Drawing.Color.Black;
            this.linklblRegister.AutoSize = true;
            this.linklblRegister.BackColor = System.Drawing.Color.Transparent;
            this.linklblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblRegister.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.linklblRegister.Location = new System.Drawing.Point(80, 370);
            this.linklblRegister.Name = "linklblRegister";
            this.linklblRegister.Size = new System.Drawing.Size(171, 20);
            this.linklblRegister.TabIndex = 6;
            this.linklblRegister.TabStop = true;
            this.linklblRegister.Text = "Register an account";
            this.linklblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblRegister_LinkClicked);
            // 
            // txtboxemail
            // 
            this.txtboxemail.Location = new System.Drawing.Point(136, 122);
            this.txtboxemail.Name = "txtboxemail";
            this.txtboxemail.Size = new System.Drawing.Size(155, 20);
            this.txtboxemail.TabIndex = 0;
            this.txtboxemail.TextChanged += new System.EventHandler(this.txtboxemail_TextChanged);
            // 
            // lbllogi
            // 
            this.lbllogi.AutoSize = true;
            this.lbllogi.BackColor = System.Drawing.Color.Transparent;
            this.lbllogi.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogi.ForeColor = System.Drawing.Color.Purple;
            this.lbllogi.Location = new System.Drawing.Point(32, 47);
            this.lbllogi.Name = "lbllogi";
            this.lbllogi.Size = new System.Drawing.Size(259, 32);
            this.lbllogi.TabIndex = 7;
            this.lbllogi.Text = "LOGIN ACCOUNT";
            // 
            // Loginformproject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(332, 429);
            this.Controls.Add(this.lbllogi);
            this.Controls.Add(this.txtboxemail);
            this.Controls.Add(this.linklblRegister);
            this.Controls.Add(this.lblDontaccount);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.checkBoxpass);
            this.Controls.Add(this.textBoxpass);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblemail);
            this.Name = "Loginformproject";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Loginformproject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.CheckBox checkBoxpass;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label lblDontaccount;
        private System.Windows.Forms.LinkLabel linklblRegister;
        private System.Windows.Forms.TextBox txtboxemail;
        private System.Windows.Forms.Label lbllogi;
    }
}

