namespace ShopProject
{
    partial class DetailsDesign
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
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AccountsButton = new System.Windows.Forms.Button();
            this.ViewAccLabel = new System.Windows.Forms.Label();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.OrdersLabel = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(118)))), ((int)(((byte)(103)))));
            this.HeaderPanel.Controls.Add(this.MinimizeButton);
            this.HeaderPanel.Controls.Add(this.ExitButton);
            this.HeaderPanel.Controls.Add(this.DetailsLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(581, 62);
            this.HeaderPanel.TabIndex = 1;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownPanel);
            this.HeaderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMovePanel);
            this.HeaderPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpPanel);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(118)))), ((int)(((byte)(103)))));
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.Location = new System.Drawing.Point(521, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeButton.TabIndex = 6;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.ExitMinimize);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(118)))), ((int)(((byte)(103)))));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(551, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 30);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitMinimize);
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsLabel.ForeColor = System.Drawing.Color.White;
            this.DetailsLabel.Location = new System.Drawing.Point(243, 19);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(93, 30);
            this.DetailsLabel.TabIndex = 0;
            this.DetailsLabel.Text = "Details";
            this.DetailsLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownPanel);
            this.DetailsLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMovePanel);
            this.DetailsLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpPanel);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(169, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 270);
            this.dataGridView1.TabIndex = 7;
            // 
            // AccountsButton
            // 
            this.AccountsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(118)))), ((int)(((byte)(103)))));
            this.AccountsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountsButton.FlatAppearance.BorderSize = 0;
            this.AccountsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountsButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountsButton.ForeColor = System.Drawing.Color.White;
            this.AccountsButton.Location = new System.Drawing.Point(12, 107);
            this.AccountsButton.Name = "AccountsButton";
            this.AccountsButton.Size = new System.Drawing.Size(135, 30);
            this.AccountsButton.TabIndex = 13;
            this.AccountsButton.Text = "View Accounts";
            this.AccountsButton.UseVisualStyleBackColor = false;
            this.AccountsButton.Click += new System.EventHandler(this.ViewButtons);
            // 
            // ViewAccLabel
            // 
            this.ViewAccLabel.AutoSize = true;
            this.ViewAccLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAccLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.ViewAccLabel.Location = new System.Drawing.Point(27, 79);
            this.ViewAccLabel.Name = "ViewAccLabel";
            this.ViewAccLabel.Size = new System.Drawing.Size(106, 16);
            this.ViewAccLabel.TabIndex = 14;
            this.ViewAccLabel.Text = "View all accounts:";
            // 
            // OrdersButton
            // 
            this.OrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(118)))), ((int)(((byte)(103)))));
            this.OrdersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrdersButton.FlatAppearance.BorderSize = 0;
            this.OrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersButton.ForeColor = System.Drawing.Color.White;
            this.OrdersButton.Location = new System.Drawing.Point(12, 190);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(135, 30);
            this.OrdersButton.TabIndex = 15;
            this.OrdersButton.Text = "View Orders";
            this.OrdersButton.UseVisualStyleBackColor = false;
            this.OrdersButton.Click += new System.EventHandler(this.ViewButtons);
            // 
            // OrdersLabel
            // 
            this.OrdersLabel.AutoSize = true;
            this.OrdersLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.OrdersLabel.Location = new System.Drawing.Point(36, 162);
            this.OrdersLabel.Name = "OrdersLabel";
            this.OrdersLabel.Size = new System.Drawing.Size(87, 16);
            this.OrdersLabel.TabIndex = 16;
            this.OrdersLabel.Text = "View all orders:";
            // 
            // DetailsDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(581, 350);
            this.Controls.Add(this.OrdersButton);
            this.Controls.Add(this.OrdersLabel);
            this.Controls.Add(this.AccountsButton);
            this.Controls.Add(this.ViewAccLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailsDesign";
            this.Text = "DetailsDesign";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.Button AccountsButton;
        private System.Windows.Forms.Label ViewAccLabel;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Label OrdersLabel;
    }
}