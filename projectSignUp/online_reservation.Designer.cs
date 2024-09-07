using System;

namespace projectSignUp
{
    partial class online_reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(online_reservation));
            this.lblonlineRes = new System.Windows.Forms.Label();
            this.lbljourneytype = new System.Windows.Forms.Label();
            this.lblarrivalcity = new System.Windows.Forms.Label();
            this.lbldeparcity = new System.Windows.Forms.Label();
            this.btnsearchflight = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdbtnOneway = new System.Windows.Forms.RadioButton();
            this.cmboboxArrivCity = new System.Windows.Forms.ComboBox();
            this.DeparDateTimepicker = new System.Windows.Forms.DateTimePicker();
            this.cmboboxdeparCity = new System.Windows.Forms.ComboBox();
            this.btnsearchall = new System.Windows.Forms.Button();
            this.lbldepardate = new System.Windows.Forms.Label();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.SuspendLayout();
            // 
            // lblonlineRes
            // 
            this.lblonlineRes.AutoSize = true;
            this.lblonlineRes.BackColor = System.Drawing.Color.LightCyan;
            this.lblonlineRes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblonlineRes.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblonlineRes.Location = new System.Drawing.Point(64, 50);
            this.lblonlineRes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblonlineRes.Name = "lblonlineRes";
            this.lblonlineRes.Size = new System.Drawing.Size(283, 82);
            this.lblonlineRes.TabIndex = 0;
            this.lblonlineRes.Text = "    ONLINE \r\nRESRVATION ";
            this.lblonlineRes.Click += new System.EventHandler(this.lblonlineRes_Click);
            // 
            // lbljourneytype
            // 
            this.lbljourneytype.AutoSize = true;
            this.lbljourneytype.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbljourneytype.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljourneytype.ForeColor = System.Drawing.Color.Black;
            this.lbljourneytype.Location = new System.Drawing.Point(427, 22);
            this.lbljourneytype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbljourneytype.Name = "lbljourneytype";
            this.lbljourneytype.Size = new System.Drawing.Size(159, 24);
            this.lbljourneytype.TabIndex = 1;
            this.lbljourneytype.Text = "JOURNEY TYPE";
            this.lbljourneytype.Click += new System.EventHandler(this.lbljourneytype_Click);
            // 
            // lblarrivalcity
            // 
            this.lblarrivalcity.AutoSize = true;
            this.lblarrivalcity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblarrivalcity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblarrivalcity.ForeColor = System.Drawing.Color.Black;
            this.lblarrivalcity.Location = new System.Drawing.Point(439, 110);
            this.lblarrivalcity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblarrivalcity.Name = "lblarrivalcity";
            this.lblarrivalcity.Size = new System.Drawing.Size(147, 24);
            this.lblarrivalcity.TabIndex = 3;
            this.lblarrivalcity.Text = "ARRIVAL CITY";
            this.lblarrivalcity.Click += new System.EventHandler(this.lblarrivalcity_Click);
            // 
            // lbldeparcity
            // 
            this.lbldeparcity.AutoSize = true;
            this.lbldeparcity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldeparcity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeparcity.ForeColor = System.Drawing.Color.Black;
            this.lbldeparcity.Location = new System.Drawing.Point(405, 66);
            this.lbldeparcity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldeparcity.Name = "lbldeparcity";
            this.lbldeparcity.Size = new System.Drawing.Size(181, 24);
            this.lbldeparcity.TabIndex = 4;
            this.lbldeparcity.Text = "DEPARTURE CITY";
            this.lbldeparcity.Click += new System.EventHandler(this.lbldeparcity_Click);
            // 
            // btnsearchflight
            // 
            this.btnsearchflight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsearchflight.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchflight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsearchflight.Location = new System.Drawing.Point(746, 344);
            this.btnsearchflight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsearchflight.Name = "btnsearchflight";
            this.btnsearchflight.Size = new System.Drawing.Size(139, 29);
            this.btnsearchflight.TabIndex = 16;
            this.btnsearchflight.Text = "Search Flights";
            this.btnsearchflight.UseVisualStyleBackColor = false;
            this.btnsearchflight.Click += new System.EventHandler(this.btnsearchflight_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(747, 379);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 27);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rdbtnOneway
            // 
            this.rdbtnOneway.AutoSize = true;
            this.rdbtnOneway.BackColor = System.Drawing.Color.Black;
            this.rdbtnOneway.Checked = true;
            this.rdbtnOneway.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnOneway.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.rdbtnOneway.Location = new System.Drawing.Point(627, 22);
            this.rdbtnOneway.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbtnOneway.Name = "rdbtnOneway";
            this.rdbtnOneway.Size = new System.Drawing.Size(89, 23);
            this.rdbtnOneway.TabIndex = 18;
            this.rdbtnOneway.TabStop = true;
            this.rdbtnOneway.Text = "One_way";
            this.rdbtnOneway.UseVisualStyleBackColor = false;
            this.rdbtnOneway.CheckedChanged += new System.EventHandler(this.rdbtnOneway_CheckedChanged);
            // 
            // cmboboxArrivCity
            // 
            this.cmboboxArrivCity.BackColor = System.Drawing.SystemColors.Info;
            this.cmboboxArrivCity.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cmboboxArrivCity.FormattingEnabled = true;
            this.cmboboxArrivCity.Items.AddRange(new object[] {
            "Karachi",
            "Islamabad",
            "Multan",
            "Lahore",
            "Gujranwala",
            "Attock",
            "Quetta",
            "Hydrabad"});
            this.cmboboxArrivCity.Location = new System.Drawing.Point(627, 110);
            this.cmboboxArrivCity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmboboxArrivCity.Name = "cmboboxArrivCity";
            this.cmboboxArrivCity.Size = new System.Drawing.Size(233, 23);
            this.cmboboxArrivCity.TabIndex = 21;
            this.cmboboxArrivCity.SelectedIndexChanged += new System.EventHandler(this.cmboboxArrivCity_SelectedIndexChanged);
            // 
            // DeparDateTimepicker
            // 
            this.DeparDateTimepicker.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeparDateTimepicker.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.DeparDateTimepicker.Location = new System.Drawing.Point(627, 154);
            this.DeparDateTimepicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeparDateTimepicker.Name = "DeparDateTimepicker";
            this.DeparDateTimepicker.Size = new System.Drawing.Size(233, 22);
            this.DeparDateTimepicker.TabIndex = 22;
            // 
            // cmboboxdeparCity
            // 
            this.cmboboxdeparCity.BackColor = System.Drawing.SystemColors.Info;
            this.cmboboxdeparCity.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cmboboxdeparCity.FormattingEnabled = true;
            this.cmboboxdeparCity.Items.AddRange(new object[] {
            "Karachi",
            "Islamabad",
            "Multan",
            "Lahore",
            "Gujranwala",
            "Attock",
            "Quetta",
            "Hydrabad"});
            this.cmboboxdeparCity.Location = new System.Drawing.Point(627, 66);
            this.cmboboxdeparCity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmboboxdeparCity.Name = "cmboboxdeparCity";
            this.cmboboxdeparCity.Size = new System.Drawing.Size(233, 23);
            this.cmboboxdeparCity.TabIndex = 23;
            this.cmboboxdeparCity.SelectedIndexChanged += new System.EventHandler(this.cmboboxdeparCity_SelectedIndexChanged_1);
            // 
            // btnsearchall
            // 
            this.btnsearchall.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsearchall.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchall.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsearchall.Location = new System.Drawing.Point(746, 304);
            this.btnsearchall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsearchall.Name = "btnsearchall";
            this.btnsearchall.Size = new System.Drawing.Size(139, 34);
            this.btnsearchall.TabIndex = 24;
            this.btnsearchall.Text = "All Flights";
            this.btnsearchall.UseVisualStyleBackColor = false;
            this.btnsearchall.Click += new System.EventHandler(this.btnsearchall_Click);
            // 
            // lbldepardate
            // 
            this.lbldepardate.AutoSize = true;
            this.lbldepardate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldepardate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepardate.ForeColor = System.Drawing.Color.Black;
            this.lbldepardate.Location = new System.Drawing.Point(400, 155);
            this.lbldepardate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldepardate.Name = "lbldepardate";
            this.lbldepardate.Size = new System.Drawing.Size(186, 24);
            this.lbldepardate.TabIndex = 2;
            this.lbldepardate.Text = "DEPARTURE DATE";
            this.lbldepardate.Click += new System.EventHandler(this.lbldepardate_Click);
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.AutoSize = true;
            this.gunaLinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.gunaLinkLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaLinkLabel1.LinkColor = System.Drawing.Color.CadetBlue;
            this.gunaLinkLabel1.Location = new System.Drawing.Point(12, 9);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(61, 18);
            this.gunaLinkLabel1.TabIndex = 27;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "HOME";
            this.gunaLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel1_LinkClicked);
            // 
            // online_reservation
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(903, 517);
            this.Controls.Add(this.gunaLinkLabel1);
            this.Controls.Add(this.btnsearchall);
            this.Controls.Add(this.cmboboxdeparCity);
            this.Controls.Add(this.DeparDateTimepicker);
            this.Controls.Add(this.cmboboxArrivCity);
            this.Controls.Add(this.rdbtnOneway);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnsearchflight);
            this.Controls.Add(this.lbldeparcity);
            this.Controls.Add(this.lblarrivalcity);
            this.Controls.Add(this.lbldepardate);
            this.Controls.Add(this.lbljourneytype);
            this.Controls.Add(this.lblonlineRes);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "online_reservation";
            this.Text = "online_reservation";
            this.Load += new System.EventHandler(this.online_reservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label lblonlineRes;
        private System.Windows.Forms.Label lbljourneytype;
        private System.Windows.Forms.Label lblarrivalcity;
        private System.Windows.Forms.Label lbldeparcity;
        private System.Windows.Forms.Button btnsearchflight;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdbtnOneway;
        private System.Windows.Forms.ComboBox cmboboxArrivCity;
        private System.Windows.Forms.DateTimePicker DeparDateTimepicker;
        private System.Windows.Forms.ComboBox cmboboxdeparCity;
        private System.Windows.Forms.Button btnsearchall;
        private System.Windows.Forms.Label lbldepardate;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
    }
}