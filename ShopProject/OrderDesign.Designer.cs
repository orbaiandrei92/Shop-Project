namespace ShopProject
{
    partial class OrderDesign
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
            this.components = new System.ComponentModel.Container();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.TextBox();
            this.RegionLabel = new System.Windows.Forms.Label();
            this.Regionn = new System.Windows.Forms.TextBox();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.PostalCode = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.ComboBox();
            this.ShipVia = new System.Windows.Forms.ComboBox();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.FaxLabel = new System.Windows.Forms.Label();
            this.Fax = new System.Windows.Forms.TextBox();
            this.ShipViaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(118)))), ((int)(((byte)(103)))));
            this.HeaderPanel.Controls.Add(this.OrderLabel);
            this.HeaderPanel.Controls.Add(this.MinimizeButton);
            this.HeaderPanel.Controls.Add(this.ExitButton);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(620, 62);
            this.HeaderPanel.TabIndex = 0;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownPanel);
            this.HeaderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMovePanel);
            this.HeaderPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpPanel);
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLabel.ForeColor = System.Drawing.Color.White;
            this.OrderLabel.Location = new System.Drawing.Point(266, 19);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(80, 30);
            this.OrderLabel.TabIndex = 1;
            this.OrderLabel.Text = "Order";
            this.OrderLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownPanel);
            this.OrderLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMovePanel);
            this.OrderLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpPanel);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.Location = new System.Drawing.Point(560, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeButton.TabIndex = 10;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(590, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 30);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(118)))), ((int)(((byte)(103)))));
            this.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmButton.FlatAppearance.BorderSize = 0;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.ForeColor = System.Drawing.Color.White;
            this.ConfirmButton.Location = new System.Drawing.Point(330, 283);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(260, 30);
            this.ConfirmButton.TabIndex = 0;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // Address
            // 
            this.Address.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.Color.DarkGray;
            this.Address.Location = new System.Drawing.Point(30, 98);
            this.Address.MaxLength = 50;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(260, 28);
            this.Address.TabIndex = 7;
            this.toolTip1.SetToolTip(this.Address, "Address");
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.AddressLabel.Location = new System.Drawing.Point(27, 78);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(57, 17);
            this.AddressLabel.TabIndex = 13;
            this.AddressLabel.Text = "Address";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.CityLabel.Location = new System.Drawing.Point(27, 139);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(33, 17);
            this.CityLabel.TabIndex = 14;
            this.CityLabel.Text = "City";
            // 
            // City
            // 
            this.City.BackColor = System.Drawing.Color.WhiteSmoke;
            this.City.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.City.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City.ForeColor = System.Drawing.Color.DarkGray;
            this.City.Location = new System.Drawing.Point(30, 159);
            this.City.MaxLength = 25;
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(260, 28);
            this.City.TabIndex = 15;
            this.toolTip1.SetToolTip(this.City, "City");
            // 
            // RegionLabel
            // 
            this.RegionLabel.AutoSize = true;
            this.RegionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.RegionLabel.Location = new System.Drawing.Point(27, 201);
            this.RegionLabel.Name = "RegionLabel";
            this.RegionLabel.Size = new System.Drawing.Size(53, 17);
            this.RegionLabel.TabIndex = 16;
            this.RegionLabel.Text = "Region";
            // 
            // Regionn
            // 
            this.Regionn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Regionn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Regionn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regionn.ForeColor = System.Drawing.Color.DarkGray;
            this.Regionn.Location = new System.Drawing.Point(30, 221);
            this.Regionn.MaxLength = 25;
            this.Regionn.Name = "Regionn";
            this.Regionn.Size = new System.Drawing.Size(260, 28);
            this.Regionn.TabIndex = 17;
            this.toolTip1.SetToolTip(this.Regionn, "Region");
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostalCodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.PostalCodeLabel.Location = new System.Drawing.Point(327, 78);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(88, 17);
            this.PostalCodeLabel.TabIndex = 18;
            this.PostalCodeLabel.Text = "Postal Code";
            // 
            // PostalCode
            // 
            this.PostalCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PostalCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostalCode.ForeColor = System.Drawing.Color.DarkGray;
            this.PostalCode.Location = new System.Drawing.Point(330, 98);
            this.PostalCode.MaxLength = 12;
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.Size = new System.Drawing.Size(260, 28);
            this.PostalCode.TabIndex = 19;
            this.toolTip1.SetToolTip(this.PostalCode, "Postal Code");
            // 
            // Country
            // 
            this.Country.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Country.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Country.DropDownHeight = 120;
            this.Country.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Country.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Country.ForeColor = System.Drawing.Color.DarkGray;
            this.Country.FormattingEnabled = true;
            this.Country.IntegralHeight = false;
            this.Country.ItemHeight = 21;
            this.Country.Items.AddRange(new object[] {
            "Albania",
            "Andorra",
            "Armenia",
            "Austria",
            "Azerbaijan",
            "Belarus",
            "Belgium",
            "Bosnia and Herzegovina ",
            "Bulgaria",
            "Croatia",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Estonia",
            "Finland",
            "France",
            "Georgia",
            "Germany",
            "Greece",
            "Hungary",
            "Iceland",
            "Ireland",
            "Italy",
            "Kazakhstan",
            "Kosovo",
            "Latvia",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Malta",
            "Moldova",
            "Monaco",
            "Montenegro",
            "Netherlands",
            "Norway",
            "Poland",
            "Portugal",
            "Romania",
            "Russia",
            "San Marino",
            "Serbia",
            "Slovakia",
            "Slovenia",
            "Spain",
            "Sweden",
            "Switzerland",
            "Turkey",
            "Ukraine",
            "United Kingdom (UK)",
            "Vatican City (Holy See)"});
            this.Country.Location = new System.Drawing.Point(30, 284);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(260, 29);
            this.Country.Sorted = true;
            this.Country.TabIndex = 20;
            this.toolTip1.SetToolTip(this.Country, "Country");
            // 
            // ShipVia
            // 
            this.ShipVia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShipVia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShipVia.DropDownHeight = 120;
            this.ShipVia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShipVia.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipVia.ForeColor = System.Drawing.Color.DarkGray;
            this.ShipVia.FormattingEnabled = true;
            this.ShipVia.IntegralHeight = false;
            this.ShipVia.ItemHeight = 21;
            this.ShipVia.Items.AddRange(new object[] {
            "Cargo Romania",
            "DHL",
            "FAN Courier",
            "GLS",
            "Posta Romana"});
            this.ShipVia.Location = new System.Drawing.Point(330, 220);
            this.ShipVia.Name = "ShipVia";
            this.ShipVia.Size = new System.Drawing.Size(260, 29);
            this.ShipVia.Sorted = true;
            this.ShipVia.TabIndex = 21;
            this.toolTip1.SetToolTip(this.ShipVia, "Ship via");
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.CountryLabel.Location = new System.Drawing.Point(27, 264);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(59, 17);
            this.CountryLabel.TabIndex = 22;
            this.CountryLabel.Text = "Country";
            // 
            // FaxLabel
            // 
            this.FaxLabel.AutoSize = true;
            this.FaxLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FaxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.FaxLabel.Location = new System.Drawing.Point(327, 139);
            this.FaxLabel.Name = "FaxLabel";
            this.FaxLabel.Size = new System.Drawing.Size(29, 17);
            this.FaxLabel.TabIndex = 23;
            this.FaxLabel.Text = "Fax";
            // 
            // Fax
            // 
            this.Fax.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Fax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Fax.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fax.ForeColor = System.Drawing.Color.DarkGray;
            this.Fax.Location = new System.Drawing.Point(330, 159);
            this.Fax.MaxLength = 20;
            this.Fax.Name = "Fax";
            this.Fax.Size = new System.Drawing.Size(260, 28);
            this.Fax.TabIndex = 24;
            this.toolTip1.SetToolTip(this.Fax, "Fax");
            // 
            // ShipViaLabel
            // 
            this.ShipViaLabel.AutoSize = true;
            this.ShipViaLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipViaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.ShipViaLabel.Location = new System.Drawing.Point(327, 201);
            this.ShipViaLabel.Name = "ShipViaLabel";
            this.ShipViaLabel.Size = new System.Drawing.Size(58, 17);
            this.ShipViaLabel.TabIndex = 25;
            this.ShipViaLabel.Text = "Ship via";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(118)))), ((int)(((byte)(103)))));
            this.label1.Location = new System.Drawing.Point(10, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(118)))), ((int)(((byte)(103)))));
            this.label2.Location = new System.Drawing.Point(10, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(118)))), ((int)(((byte)(103)))));
            this.label3.Location = new System.Drawing.Point(10, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(118)))), ((int)(((byte)(103)))));
            this.label4.Location = new System.Drawing.Point(10, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(118)))), ((int)(((byte)(103)))));
            this.label5.Location = new System.Drawing.Point(310, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "*";
            // 
            // OrderDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 360);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShipViaLabel);
            this.Controls.Add(this.Fax);
            this.Controls.Add(this.FaxLabel);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.ShipVia);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.PostalCode);
            this.Controls.Add(this.PostalCodeLabel);
            this.Controls.Add(this.Regionn);
            this.Controls.Add(this.RegionLabel);
            this.Controls.Add(this.City);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderDesign";
            this.Text = "OrderDesign";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.Label RegionLabel;
        private System.Windows.Forms.TextBox Regionn;
        private System.Windows.Forms.Label PostalCodeLabel;
        private System.Windows.Forms.TextBox PostalCode;
        private System.Windows.Forms.ComboBox Country;
        private System.Windows.Forms.ComboBox ShipVia;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label FaxLabel;
        private System.Windows.Forms.TextBox Fax;
        private System.Windows.Forms.Label ShipViaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;       
        private System.Windows.Forms.ToolTip toolTip1;

    }
}