namespace projectSignUp
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.lblemail = new System.Windows.Forms.Label();
            this.textBoxconfirmpass = new System.Windows.Forms.TextBox();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.textboxemail = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblconfirmpass = new System.Windows.Forms.Label();
            this.buttonregister = new System.Windows.Forms.Button();
            this.btncacel = new System.Windows.Forms.Button();
            this.constraintlblpass = new System.Windows.Forms.Label();
            this.confirmpasslabel = new System.Windows.Forms.Label();
            this.checkBoxshowpass = new System.Windows.Forms.CheckBox();
            this.lBLSIGNUP = new System.Windows.Forms.Label();
            this.cmboboxrole = new System.Windows.Forms.ComboBox();
            this.lblrole = new System.Windows.Forms.Label();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.SuspendLayout();
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.White;
            this.lblemail.Location = new System.Drawing.Point(150, 105);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(53, 20);
            this.lblemail.TabIndex = 1;
            this.lblemail.Text = "Email";
            this.lblemail.Click += new System.EventHandler(this.lblemail_Click);
            // 
            // textBoxconfirmpass
            // 
            this.textBoxconfirmpass.Location = new System.Drawing.Point(240, 240);
            this.textBoxconfirmpass.Name = "textBoxconfirmpass";
            this.textBoxconfirmpass.Size = new System.Drawing.Size(100, 20);
            this.textBoxconfirmpass.TabIndex = 2;
            this.textBoxconfirmpass.TextChanged += new System.EventHandler(this.textBoxconfirmpass_TextChanged);
            // 
            // textBoxpass
            // 
            this.textBoxpass.Location = new System.Drawing.Point(240, 187);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.Size = new System.Drawing.Size(100, 20);
            this.textBoxpass.TabIndex = 3;
            this.textBoxpass.TextChanged += new System.EventHandler(this.textBoxpass_TextChanged);
            // 
            // textboxemail
            // 
            this.textboxemail.Location = new System.Drawing.Point(240, 105);
            this.textboxemail.Name = "textboxemail";
            this.textboxemail.Size = new System.Drawing.Size(100, 20);
            this.textboxemail.TabIndex = 4;
            this.textboxemail.TextChanged += new System.EventHandler(this.textboxemail_TextChanged);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.BackColor = System.Drawing.Color.Transparent;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpass.Location = new System.Drawing.Point(124, 187);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(86, 20);
            this.lblpass.TabIndex = 5;
            this.lblpass.Text = "Password";
            this.lblpass.Click += new System.EventHandler(this.lblpass_Click);
            // 
            // lblconfirmpass
            // 
            this.lblconfirmpass.AutoSize = true;
            this.lblconfirmpass.BackColor = System.Drawing.Color.Transparent;
            this.lblconfirmpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirmpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblconfirmpass.Location = new System.Drawing.Point(33, 240);
            this.lblconfirmpass.Name = "lblconfirmpass";
            this.lblconfirmpass.Size = new System.Drawing.Size(177, 24);
            this.lblconfirmpass.TabIndex = 6;
            this.lblconfirmpass.Text = "Confirm password";
            this.lblconfirmpass.Click += new System.EventHandler(this.lblconfirmpass_Click);
            // 
            // buttonregister
            // 
            this.buttonregister.BackColor = System.Drawing.Color.Transparent;
            this.buttonregister.FlatAppearance.BorderSize = 0;
            this.buttonregister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonregister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonregister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonregister.Location = new System.Drawing.Point(235, 388);
            this.buttonregister.Name = "buttonregister";
            this.buttonregister.Size = new System.Drawing.Size(105, 32);
            this.buttonregister.TabIndex = 7;
            this.buttonregister.Text = "Register";
            this.buttonregister.UseVisualStyleBackColor = false;
            this.buttonregister.Click += new System.EventHandler(this.buttonregister_Click);
            // 
            // btncacel
            // 
            this.btncacel.BackColor = System.Drawing.Color.Transparent;
            this.btncacel.FlatAppearance.BorderSize = 0;
            this.btncacel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btncacel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btncacel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncacel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncacel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncacel.Location = new System.Drawing.Point(354, 388);
            this.btncacel.Name = "btncacel";
            this.btncacel.Size = new System.Drawing.Size(105, 32);
            this.btncacel.TabIndex = 8;
            this.btncacel.Text = "cancel";
            this.btncacel.UseVisualStyleBackColor = false;
            this.btncacel.Click += new System.EventHandler(this.btncacel_Click);
            // 
            // constraintlblpass
            // 
            this.constraintlblpass.AutoSize = true;
            this.constraintlblpass.BackColor = System.Drawing.Color.Transparent;
            this.constraintlblpass.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.constraintlblpass.ForeColor = System.Drawing.Color.GhostWhite;
            this.constraintlblpass.Location = new System.Drawing.Point(23, 141);
            this.constraintlblpass.Name = "constraintlblpass";
            this.constraintlblpass.Size = new System.Drawing.Size(451, 28);
            this.constraintlblpass.TabIndex = 9;
            this.constraintlblpass.Text = "Password shouldnt start with a number, it should contain only numbers,letters,und" +
    "erscores and @\r\nPassword min_length=5 and max_length=10\r\n";
            this.constraintlblpass.Click += new System.EventHandler(this.constraintlblpass_Click);
            // 
            // confirmpasslabel
            // 
            this.confirmpasslabel.AutoSize = true;
            this.confirmpasslabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmpasslabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirmpasslabel.Location = new System.Drawing.Point(70, 217);
            this.confirmpasslabel.Name = "confirmpasslabel";
            this.confirmpasslabel.Size = new System.Drawing.Size(10, 13);
            this.confirmpasslabel.TabIndex = 10;
            this.confirmpasslabel.Text = " ";
            this.confirmpasslabel.Click += new System.EventHandler(this.confirmpasslabel_Click);
            // 
            // checkBoxshowpass
            // 
            this.checkBoxshowpass.AutoSize = true;
            this.checkBoxshowpass.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxshowpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxshowpass.Location = new System.Drawing.Point(322, 271);
            this.checkBoxshowpass.Name = "checkBoxshowpass";
            this.checkBoxshowpass.Size = new System.Drawing.Size(96, 17);
            this.checkBoxshowpass.TabIndex = 11;
            this.checkBoxshowpass.Text = "Hide password";
            this.checkBoxshowpass.UseVisualStyleBackColor = false;
            this.checkBoxshowpass.CheckedChanged += new System.EventHandler(this.checkBoxshowpass_CheckedChanged);
            // 
            // lBLSIGNUP
            // 
            this.lBLSIGNUP.AutoSize = true;
            this.lBLSIGNUP.BackColor = System.Drawing.Color.Transparent;
            this.lBLSIGNUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lBLSIGNUP.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBLSIGNUP.ForeColor = System.Drawing.Color.Thistle;
            this.lBLSIGNUP.Location = new System.Drawing.Point(144, 19);
            this.lBLSIGNUP.Name = "lBLSIGNUP";
            this.lBLSIGNUP.Size = new System.Drawing.Size(218, 55);
            this.lBLSIGNUP.TabIndex = 12;
            this.lBLSIGNUP.Text = "SIGN UP";
            this.lBLSIGNUP.Click += new System.EventHandler(this.lBLSIGNUP_Click);
            // 
            // cmboboxrole
            // 
            this.cmboboxrole.FormattingEnabled = true;
            this.cmboboxrole.Items.AddRange(new object[] {
            "ADMIN",
            "CUSTOMER"});
            this.cmboboxrole.Location = new System.Drawing.Point(240, 294);
            this.cmboboxrole.Name = "cmboboxrole";
            this.cmboboxrole.Size = new System.Drawing.Size(100, 21);
            this.cmboboxrole.TabIndex = 13;
            this.cmboboxrole.SelectedIndexChanged += new System.EventHandler(this.cmboboxrole_SelectedIndexChanged);
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.BackColor = System.Drawing.Color.Transparent;
            this.lblrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrole.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblrole.Location = new System.Drawing.Point(93, 289);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(117, 24);
            this.lblrole.TabIndex = 14;
            this.lblrole.Text = "Select Role";
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.AutoSize = true;
            this.gunaLinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.gunaLinkLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLinkLabel1.LinkColor = System.Drawing.Color.LightCyan;
            this.gunaLinkLabel1.Location = new System.Drawing.Point(413, 9);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(61, 18);
            this.gunaLinkLabel1.TabIndex = 27;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "HOME";
            this.gunaLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel1_LinkClicked);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.gunaLinkLabel1);
            this.Controls.Add(this.lblrole);
            this.Controls.Add(this.cmboboxrole);
            this.Controls.Add(this.lBLSIGNUP);
            this.Controls.Add(this.checkBoxshowpass);
            this.Controls.Add(this.confirmpasslabel);
            this.Controls.Add(this.constraintlblpass);
            this.Controls.Add(this.btncacel);
            this.Controls.Add(this.buttonregister);
            this.Controls.Add(this.lblconfirmpass);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.textboxemail);
            this.Controls.Add(this.textBoxpass);
            this.Controls.Add(this.textBoxconfirmpass);
            this.Controls.Add(this.lblemail);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox textBoxconfirmpass;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.TextBox textboxemail;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblconfirmpass;
        private System.Windows.Forms.Button buttonregister;
        private System.Windows.Forms.Button btncacel;
        private System.Windows.Forms.Label constraintlblpass;
        private System.Windows.Forms.Label confirmpasslabel;
        private System.Windows.Forms.CheckBox checkBoxshowpass;
        private System.Windows.Forms.Label lBLSIGNUP;
        private System.Windows.Forms.ComboBox cmboboxrole;
        private System.Windows.Forms.Label lblrole;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
    }
}