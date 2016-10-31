namespace ShopProject
{
    partial class Password
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
            this.ChangePasswordLabel = new System.Windows.Forms.Label();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.Submit1Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Submit2Button = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(118)))), ((int)(((byte)(103)))));
            this.HeaderPanel.Controls.Add(this.MinimizeButton);
            this.HeaderPanel.Controls.Add(this.ExitButton);
            this.HeaderPanel.Controls.Add(this.ChangePasswordLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(395, 62);
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
            this.MinimizeButton.Location = new System.Drawing.Point(333, 0);
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
            this.ExitButton.Location = new System.Drawing.Point(363, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 30);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitMinimize);
            // 
            // ChangePasswordLabel
            // 
            this.ChangePasswordLabel.AutoSize = true;
            this.ChangePasswordLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordLabel.ForeColor = System.Drawing.Color.White;
            this.ChangePasswordLabel.Location = new System.Drawing.Point(86, 18);
            this.ChangePasswordLabel.Name = "ChangePasswordLabel";
            this.ChangePasswordLabel.Size = new System.Drawing.Size(227, 30);
            this.ChangePasswordLabel.TabIndex = 0;
            this.ChangePasswordLabel.Text = "Change Password";
            this.ChangePasswordLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownPanel);
            this.ChangePasswordLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMovePanel);
            this.ChangePasswordLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpPanel);
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.ChangeLabel.Location = new System.Drawing.Point(86, 95);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(227, 17);
            this.ChangeLabel.TabIndex = 12;
            this.ChangeLabel.Text = "Please insert your registered Email:";
            // 
            // Submit1Button
            // 
            this.Submit1Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(118)))), ((int)(((byte)(103)))));
            this.Submit1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit1Button.FlatAppearance.BorderSize = 0;
            this.Submit1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit1Button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit1Button.ForeColor = System.Drawing.Color.White;
            this.Submit1Button.Location = new System.Drawing.Point(69, 177);
            this.Submit1Button.Name = "Submit1Button";
            this.Submit1Button.Size = new System.Drawing.Size(260, 30);
            this.Submit1Button.TabIndex = 14;
            this.Submit1Button.Text = "Submit";
            this.Submit1Button.UseVisualStyleBackColor = false;
            this.Submit1Button.Click += new System.EventHandler(this.SubmitButtons);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(69, 124);
            this.textBox1.MaxLength = 30;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 28);
            this.textBox1.TabIndex = 13;
            // 
            // Submit2Button
            // 
            this.Submit2Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(118)))), ((int)(((byte)(103)))));
            this.Submit2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit2Button.FlatAppearance.BorderSize = 0;
            this.Submit2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit2Button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit2Button.ForeColor = System.Drawing.Color.White;
            this.Submit2Button.Location = new System.Drawing.Point(69, 177);
            this.Submit2Button.Name = "Submit2Button";
            this.Submit2Button.Size = new System.Drawing.Size(260, 30);
            this.Submit2Button.TabIndex = 15;
            this.Submit2Button.Text = "Submit";
            this.Submit2Button.UseVisualStyleBackColor = false;
            this.Submit2Button.Visible = false;
            this.Submit2Button.Click += new System.EventHandler(this.SubmitButtons);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(118)))), ((int)(((byte)(103)))));
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.FlatAppearance.BorderSize = 0;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(69, 177);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(260, 30);
            this.ResetButton.TabIndex = 16;
            this.ResetButton.Text = "Reset Password!";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Visible = false;
            this.ResetButton.Click += new System.EventHandler(this.SubmitButtons);
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 250);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.Submit2Button);
            this.Controls.Add(this.ChangeLabel);
            this.Controls.Add(this.Submit1Button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Password";
            this.Text = "Password";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label ChangePasswordLabel;
        private System.Windows.Forms.Label ChangeLabel;
        private System.Windows.Forms.Button Submit1Button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Submit2Button;
        private System.Windows.Forms.Button ResetButton;
    }
}