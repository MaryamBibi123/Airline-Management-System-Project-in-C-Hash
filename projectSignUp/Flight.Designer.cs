namespace projectSignUp
{
    partial class Flight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flight));
            this.FlightNolbl = new System.Windows.Forms.Label();
            this.airlinelbl = new System.Windows.Forms.Label();
            this.btnAddflight = new System.Windows.Forms.Button();
            this.btnCancelflight = new System.Windows.Forms.Button();
            this.Sourcelbl = new System.Windows.Forms.Label();
            this.DestinationLbl = new System.Windows.Forms.Label();
            this.cmboSource = new System.Windows.Forms.ComboBox();
            this.cmboDestin = new System.Windows.Forms.ComboBox();
            this.picBoxAdd = new System.Windows.Forms.PictureBox();
            this.picBoxDelete = new System.Windows.Forms.PictureBox();
            this.picBoxShowFlight = new System.Windows.Forms.PictureBox();
            this.btnback = new System.Windows.Forms.Button();
            this.cmboboxAirline = new Guna.UI.WinForms.GunaComboBox();
            this.flightIdtxtbox = new System.Windows.Forms.MaskedTextBox();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShowFlight)).BeginInit();
            this.SuspendLayout();
            // 
            // FlightNolbl
            // 
            this.FlightNolbl.AutoSize = true;
            this.FlightNolbl.BackColor = System.Drawing.Color.Transparent;
            this.FlightNolbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightNolbl.Location = new System.Drawing.Point(431, 141);
            this.FlightNolbl.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.FlightNolbl.Name = "FlightNolbl";
            this.FlightNolbl.Size = new System.Drawing.Size(84, 22);
            this.FlightNolbl.TabIndex = 0;
            this.FlightNolbl.Text = "Flight ID";
            this.FlightNolbl.Click += new System.EventHandler(this.FlightNolbl_Click);
            // 
            // airlinelbl
            // 
            this.airlinelbl.AutoSize = true;
            this.airlinelbl.BackColor = System.Drawing.Color.Transparent;
            this.airlinelbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airlinelbl.Location = new System.Drawing.Point(441, 180);
            this.airlinelbl.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.airlinelbl.Name = "airlinelbl";
            this.airlinelbl.Size = new System.Drawing.Size(65, 22);
            this.airlinelbl.TabIndex = 4;
            this.airlinelbl.Text = "Airline";
            this.airlinelbl.Click += new System.EventHandler(this.airlinelbl_Click);
            // 
            // btnAddflight
            // 
            this.btnAddflight.BackColor = System.Drawing.Color.Transparent;
            this.btnAddflight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddflight.FlatAppearance.BorderSize = 0;
            this.btnAddflight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnAddflight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnAddflight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddflight.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddflight.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddflight.Location = new System.Drawing.Point(531, 417);
            this.btnAddflight.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnAddflight.Name = "btnAddflight";
            this.btnAddflight.Size = new System.Drawing.Size(106, 36);
            this.btnAddflight.TabIndex = 9;
            this.btnAddflight.Text = "Add";
            this.btnAddflight.UseVisualStyleBackColor = false;
            this.btnAddflight.Click += new System.EventHandler(this.btnAddflight_Click);
            // 
            // btnCancelflight
            // 
            this.btnCancelflight.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelflight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelflight.FlatAppearance.BorderSize = 0;
            this.btnCancelflight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnCancelflight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnCancelflight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelflight.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelflight.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCancelflight.Location = new System.Drawing.Point(531, 371);
            this.btnCancelflight.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnCancelflight.Name = "btnCancelflight";
            this.btnCancelflight.Size = new System.Drawing.Size(106, 38);
            this.btnCancelflight.TabIndex = 10;
            this.btnCancelflight.Text = "Delete";
            this.btnCancelflight.UseVisualStyleBackColor = false;
            this.btnCancelflight.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Sourcelbl
            // 
            this.Sourcelbl.AutoSize = true;
            this.Sourcelbl.BackColor = System.Drawing.Color.Transparent;
            this.Sourcelbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sourcelbl.Location = new System.Drawing.Point(439, 252);
            this.Sourcelbl.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Sourcelbl.Name = "Sourcelbl";
            this.Sourcelbl.Size = new System.Drawing.Size(67, 22);
            this.Sourcelbl.TabIndex = 15;
            this.Sourcelbl.Text = "Source";
            // 
            // DestinationLbl
            // 
            this.DestinationLbl.AutoSize = true;
            this.DestinationLbl.BackColor = System.Drawing.Color.Transparent;
            this.DestinationLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLbl.Location = new System.Drawing.Point(412, 295);
            this.DestinationLbl.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.DestinationLbl.Name = "DestinationLbl";
            this.DestinationLbl.Size = new System.Drawing.Size(103, 22);
            this.DestinationLbl.TabIndex = 16;
            this.DestinationLbl.Text = "Destination";
            this.DestinationLbl.Click += new System.EventHandler(this.DestinationLbl_Click);
            // 
            // cmboSource
            // 
            this.cmboSource.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmboSource.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboSource.FormattingEnabled = true;
            this.cmboSource.Items.AddRange(new object[] {
            "Karachi",
            "Islamabad",
            "Multan",
            "Lahore",
            "Gujranwala",
            "Attock",
            "Quetta",
            "Hydrabad"});
            this.cmboSource.Location = new System.Drawing.Point(549, 251);
            this.cmboSource.Name = "cmboSource";
            this.cmboSource.Size = new System.Drawing.Size(135, 27);
            this.cmboSource.TabIndex = 17;
            // 
            // cmboDestin
            // 
            this.cmboDestin.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmboDestin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboDestin.FormattingEnabled = true;
            this.cmboDestin.Items.AddRange(new object[] {
            "Karachi",
            "Islamabad",
            "Multan",
            "Lahore",
            "Gujranwala",
            "Attock",
            "Quetta",
            "Hydrabad"});
            this.cmboDestin.Location = new System.Drawing.Point(549, 284);
            this.cmboDestin.Name = "cmboDestin";
            this.cmboDestin.Size = new System.Drawing.Size(135, 27);
            this.cmboDestin.TabIndex = 18;
            this.cmboDestin.SelectedIndexChanged += new System.EventHandler(this.cmboDestin_SelectedIndexChanged);
            // 
            // picBoxAdd
            // 
            this.picBoxAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBoxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxAdd.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAdd.Image")));
            this.picBoxAdd.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxAdd.InitialImage")));
            this.picBoxAdd.Location = new System.Drawing.Point(367, 62);
            this.picBoxAdd.Name = "picBoxAdd";
            this.picBoxAdd.Size = new System.Drawing.Size(105, 42);
            this.picBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAdd.TabIndex = 20;
            this.picBoxAdd.TabStop = false;
            this.picBoxAdd.Click += new System.EventHandler(this.picBoxAdd_Click);
            this.picBoxAdd.MouseEnter += new System.EventHandler(this.picBoxAdd_MouseEnter);
            // 
            // picBoxDelete
            // 
            this.picBoxDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBoxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxDelete.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDelete.Image")));
            this.picBoxDelete.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxDelete.InitialImage")));
            this.picBoxDelete.Location = new System.Drawing.Point(631, 62);
            this.picBoxDelete.Name = "picBoxDelete";
            this.picBoxDelete.Size = new System.Drawing.Size(123, 42);
            this.picBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDelete.TabIndex = 21;
            this.picBoxDelete.TabStop = false;
            this.picBoxDelete.Click += new System.EventHandler(this.picBoxDelete_Click);
            // 
            // picBoxShowFlight
            // 
            this.picBoxShowFlight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBoxShowFlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxShowFlight.Image = ((System.Drawing.Image)(resources.GetObject("picBoxShowFlight.Image")));
            this.picBoxShowFlight.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxShowFlight.InitialImage")));
            this.picBoxShowFlight.Location = new System.Drawing.Point(496, 62);
            this.picBoxShowFlight.Name = "picBoxShowFlight";
            this.picBoxShowFlight.Size = new System.Drawing.Size(118, 42);
            this.picBoxShowFlight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxShowFlight.TabIndex = 22;
            this.picBoxShowFlight.TabStop = false;
            this.picBoxShowFlight.Click += new System.EventHandler(this.picBoxShowFlight_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(24, 28);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(49, 49);
            this.btnback.TabIndex = 23;
            this.btnback.Text = "🔙";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // cmboboxAirline
            // 
            this.cmboboxAirline.BackColor = System.Drawing.Color.Transparent;
            this.cmboboxAirline.BaseColor = System.Drawing.Color.White;
            this.cmboboxAirline.BorderColor = System.Drawing.Color.Silver;
            this.cmboboxAirline.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboboxAirline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboboxAirline.FocusedColor = System.Drawing.Color.Empty;
            this.cmboboxAirline.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmboboxAirline.ForeColor = System.Drawing.Color.Black;
            this.cmboboxAirline.FormattingEnabled = true;
            this.cmboboxAirline.Items.AddRange(new object[] {
            "Serene",
            "PIA",
            "Airblue"});
            this.cmboboxAirline.Location = new System.Drawing.Point(549, 180);
            this.cmboboxAirline.Name = "cmboboxAirline";
            this.cmboboxAirline.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmboboxAirline.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmboboxAirline.Size = new System.Drawing.Size(135, 26);
            this.cmboboxAirline.TabIndex = 25;
            this.cmboboxAirline.SelectedIndexChanged += new System.EventHandler(this.cmboboxAirline_SelectedIndexChanged);
            // 
            // flightIdtxtbox
            // 
            this.flightIdtxtbox.Location = new System.Drawing.Point(549, 138);
            this.flightIdtxtbox.Name = "flightIdtxtbox";
            this.flightIdtxtbox.Size = new System.Drawing.Size(135, 29);
            this.flightIdtxtbox.TabIndex = 24;
            this.flightIdtxtbox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.flightIdtxtbox_MaskInputRejected);
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.AutoSize = true;
            this.gunaLinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.gunaLinkLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLinkLabel1.LinkColor = System.Drawing.Color.CadetBlue;
            this.gunaLinkLabel1.Location = new System.Drawing.Point(697, 18);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(61, 18);
            this.gunaLinkLabel1.TabIndex = 26;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "HOME";
            this.gunaLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel1_LinkClicked);
            // 
            // Flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 498);
            this.Controls.Add(this.gunaLinkLabel1);
            this.Controls.Add(this.cmboboxAirline);
            this.Controls.Add(this.flightIdtxtbox);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.picBoxShowFlight);
            this.Controls.Add(this.picBoxDelete);
            this.Controls.Add(this.picBoxAdd);
            this.Controls.Add(this.cmboDestin);
            this.Controls.Add(this.cmboSource);
            this.Controls.Add(this.DestinationLbl);
            this.Controls.Add(this.Sourcelbl);
            this.Controls.Add(this.btnCancelflight);
            this.Controls.Add(this.btnAddflight);
            this.Controls.Add(this.airlinelbl);
            this.Controls.Add(this.FlightNolbl);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.Name = "Flight";
            this.Text = "Flight";
            this.Load += new System.EventHandler(this.Flight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShowFlight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FlightNolbl;
        private System.Windows.Forms.Label airlinelbl;
        private System.Windows.Forms.Button btnAddflight;
        private System.Windows.Forms.Button btnCancelflight;
        private System.Windows.Forms.Label Sourcelbl;
        private System.Windows.Forms.Label DestinationLbl;
        private System.Windows.Forms.ComboBox cmboSource;
        private System.Windows.Forms.ComboBox cmboDestin;
        private System.Windows.Forms.PictureBox picBoxAdd;
        private System.Windows.Forms.PictureBox picBoxDelete;
        private System.Windows.Forms.PictureBox picBoxShowFlight;
        private System.Windows.Forms.Button btnback;
        private Guna.UI.WinForms.GunaComboBox cmboboxAirline;
        private System.Windows.Forms.MaskedTextBox flightIdtxtbox;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
    }
}