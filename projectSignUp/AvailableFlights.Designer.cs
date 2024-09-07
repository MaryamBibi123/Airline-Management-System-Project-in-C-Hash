namespace projectSignUp
{
    partial class AvailableFlights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvailableFlights));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblselectflight = new System.Windows.Forms.Label();
            this.btnselectFlight = new System.Windows.Forms.Button();
            this.btnBookFlight = new System.Windows.Forms.Button();
            this.btbback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(496, 449);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(602, 222);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblselectflight
            // 
            this.lblselectflight.AutoSize = true;
            this.lblselectflight.BackColor = System.Drawing.Color.Teal;
            this.lblselectflight.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselectflight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblselectflight.Location = new System.Drawing.Point(535, 176);
            this.lblselectflight.Name = "lblselectflight";
            this.lblselectflight.Size = new System.Drawing.Size(240, 24);
            this.lblselectflight.TabIndex = 4;
            this.lblselectflight.Text = "Select your flight number!";
            // 
            // btnselectFlight
            // 
            this.btnselectFlight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnselectFlight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnselectFlight.BackgroundImage")));
            this.btnselectFlight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnselectFlight.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselectFlight.Location = new System.Drawing.Point(568, 66);
            this.btnselectFlight.Name = "btnselectFlight";
            this.btnselectFlight.Size = new System.Drawing.Size(181, 67);
            this.btnselectFlight.TabIndex = 5;
            this.btnselectFlight.UseVisualStyleBackColor = true;
            this.btnselectFlight.Click += new System.EventHandler(this.btnselectFlight_Click);
            // 
            // btnBookFlight
            // 
            this.btnBookFlight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBookFlight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBookFlight.BackgroundImage")));
            this.btnBookFlight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBookFlight.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookFlight.Location = new System.Drawing.Point(568, 271);
            this.btnBookFlight.Name = "btnBookFlight";
            this.btnBookFlight.Size = new System.Drawing.Size(181, 67);
            this.btnBookFlight.TabIndex = 6;
            this.btnBookFlight.UseVisualStyleBackColor = true;
            this.btnBookFlight.Click += new System.EventHandler(this.btnBookFlight_Click);
            // 
            // btbback
            // 
            this.btbback.BackColor = System.Drawing.Color.Transparent;
            this.btbback.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbback.Location = new System.Drawing.Point(700, 12);
            this.btbback.Name = "btbback";
            this.btbback.Size = new System.Drawing.Size(75, 39);
            this.btbback.TabIndex = 7;
            this.btbback.Text = "Back";
            this.btbback.UseVisualStyleBackColor = false;
            this.btbback.Click += new System.EventHandler(this.btbback_Click);
            // 
            // AvailableFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btbback);
            this.Controls.Add(this.btnBookFlight);
            this.Controls.Add(this.btnselectFlight);
            this.Controls.Add(this.lblselectflight);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AvailableFlights";
            this.Text = "AvailableFlights";
            this.Load += new System.EventHandler(this.AvailableFlights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblselectflight;
        private System.Windows.Forms.Button btnselectFlight;
        private System.Windows.Forms.Button btnBookFlight;
        private System.Windows.Forms.Button btbback;
    }
}