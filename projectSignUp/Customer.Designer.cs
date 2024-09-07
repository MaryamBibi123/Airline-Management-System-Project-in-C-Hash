namespace projectSignUp
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.lblphone = new System.Windows.Forms.Label();
            this.lblcusName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.masktxtname = new System.Windows.Forms.MaskedTextBox();
            this.masktxtphone = new System.Windows.Forms.MaskedTextBox();
            this.lbldetails = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.comboBoxCity = new Guna.UI.WinForms.GunaComboBox();
            this.SuspendLayout();
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.BackColor = System.Drawing.Color.Transparent;
            this.lblphone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(27, 180);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(132, 22);
            this.lblphone.TabIndex = 2;
            this.lblphone.Text = "Phone Number";
            // 
            // lblcusName
            // 
            this.lblcusName.AutoSize = true;
            this.lblcusName.BackColor = System.Drawing.Color.Transparent;
            this.lblcusName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcusName.Location = new System.Drawing.Point(16, 143);
            this.lblcusName.Name = "lblcusName";
            this.lblcusName.Size = new System.Drawing.Size(143, 22);
            this.lblcusName.TabIndex = 3;
            this.lblcusName.Text = "Customer Name";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(115, 214);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(44, 22);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            this.lblCity.Click += new System.EventHandler(this.lblCity_Click);
            // 
            // masktxtname
            // 
            this.masktxtname.Location = new System.Drawing.Point(188, 146);
            this.masktxtname.Name = "masktxtname";
            this.masktxtname.Size = new System.Drawing.Size(100, 20);
            this.masktxtname.TabIndex = 8;
            // 
            // masktxtphone
            // 
            this.masktxtphone.Location = new System.Drawing.Point(188, 180);
            this.masktxtphone.Name = "masktxtphone";
            this.masktxtphone.Size = new System.Drawing.Size(100, 20);
            this.masktxtphone.TabIndex = 9;
            // 
            // lbldetails
            // 
            this.lbldetails.AutoSize = true;
            this.lbldetails.BackColor = System.Drawing.Color.Transparent;
            this.lbldetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbldetails.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbldetails.ForeColor = System.Drawing.Color.Navy;
            this.lbldetails.Location = new System.Drawing.Point(48, 47);
            this.lbldetails.Name = "lbldetails";
            this.lbldetails.Size = new System.Drawing.Size(253, 29);
            this.lbldetails.TabIndex = 10;
            this.lbldetails.Text = "ENTER YOUR DETAILS";
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Transparent;
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.btnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(119, 300);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(109, 43);
            this.btnDone.TabIndex = 11;
            this.btnDone.Text = "Done✔️";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxCity.BaseColor = System.Drawing.Color.White;
            this.comboBoxCity.BorderColor = System.Drawing.Color.Silver;
            this.comboBoxCity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCity.FocusedColor = System.Drawing.Color.Empty;
            this.comboBoxCity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxCity.ForeColor = System.Drawing.Color.Black;
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Items.AddRange(new object[] {
            "Karachi",
            "Islamabad",
            "Multan",
            "Lahore",
            "Gujranwala",
            "Attock",
            "Quetta",
            "Hydrabad"});
            this.comboBoxCity.Location = new System.Drawing.Point(188, 214);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboBoxCity.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboBoxCity.Size = new System.Drawing.Size(100, 26);
            this.comboBoxCity.TabIndex = 26;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lbldetails);
            this.Controls.Add(this.masktxtphone);
            this.Controls.Add(this.masktxtname);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblcusName);
            this.Controls.Add(this.lblphone);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblcusName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.MaskedTextBox masktxtname;
        private System.Windows.Forms.MaskedTextBox masktxtphone;
        private System.Windows.Forms.Label lbldetails;
        private System.Windows.Forms.Button btnDone;
        private Guna.UI.WinForms.GunaComboBox comboBoxCity;
    }
}