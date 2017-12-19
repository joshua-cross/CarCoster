namespace CarCoster
{
    partial class Overview
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
            this.SideBar = new System.Windows.Forms.Panel();
            this.SelectedButton = new System.Windows.Forms.Panel();
            this.AddCarButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OverviewText = new System.Windows.Forms.Label();
            this.SelectCar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SelectCarButton = new System.Windows.Forms.Button();
            this.carBox = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ManufactorerLogo = new System.Windows.Forms.Panel();
            this.CarInfo = new System.Windows.Forms.Label();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.Badge = new System.Windows.Forms.PictureBox();
            this.CarDetails = new System.Windows.Forms.Label();
            this.SideBar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.ManufactorerLogo.SuspendLayout();
            this.ImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Badge)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(141)))), ((int)(((byte)(42)))));
            this.SideBar.Controls.Add(this.SelectedButton);
            this.SideBar.Controls.Add(this.AddCarButton);
            this.SideBar.Controls.Add(this.CloseButton);
            this.SideBar.Controls.Add(this.SaveButton);
            this.SideBar.Controls.Add(this.panel3);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.ForeColor = System.Drawing.Color.White;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(143, 815);
            this.SideBar.TabIndex = 0;
            // 
            // SelectedButton
            // 
            this.SelectedButton.BackColor = System.Drawing.Color.Red;
            this.SelectedButton.Location = new System.Drawing.Point(131, 105);
            this.SelectedButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SelectedButton.Name = "SelectedButton";
            this.SelectedButton.Size = new System.Drawing.Size(12, 98);
            this.SelectedButton.TabIndex = 3;
            // 
            // AddCarButton
            // 
            this.AddCarButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddCarButton.FlatAppearance.BorderSize = 0;
            this.AddCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCarButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarButton.Location = new System.Drawing.Point(0, 203);
            this.AddCarButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(143, 98);
            this.AddCarButton.TabIndex = 5;
            this.AddCarButton.Text = "Add Car";
            this.AddCarButton.UseVisualStyleBackColor = true;
            this.AddCarButton.Click += new System.EventHandler(this.AddCarButton_Click);
            this.AddCarButton.MouseHover += new System.EventHandler(this.SaveButton_MouseHover);
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(0, 717);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(143, 98);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseHover += new System.EventHandler(this.SaveButton_MouseHover);
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(0, 105);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(143, 98);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Enter += new System.EventHandler(this.SaveButton_Enter);
            this.SaveButton.MouseHover += new System.EventHandler(this.SaveButton_MouseHover);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(143, 105);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 105);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(122)))));
            this.panel2.Controls.Add(this.OverviewText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(143, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1486, 81);
            this.panel2.TabIndex = 1;
            // 
            // OverviewText
            // 
            this.OverviewText.AutoSize = true;
            this.OverviewText.Location = new System.Drawing.Point(15, 30);
            this.OverviewText.Name = "OverviewText";
            this.OverviewText.Size = new System.Drawing.Size(96, 21);
            this.OverviewText.TabIndex = 0;
            this.OverviewText.Text = "Overview";
            // 
            // SelectCar
            // 
            this.SelectCar.AutoSize = true;
            this.SelectCar.Location = new System.Drawing.Point(6, 15);
            this.SelectCar.Name = "SelectCar";
            this.SelectCar.Size = new System.Drawing.Size(109, 21);
            this.SelectCar.TabIndex = 4;
            this.SelectCar.Text = "Your Cars:";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(143, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 734);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.carBox);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(160, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(439, 734);
            this.panel4.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.SelectCarButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 636);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(439, 98);
            this.panel6.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(141)))), ((int)(((byte)(42)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 92);
            this.button1.TabIndex = 1;
            this.button1.Text = "Remove Car";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SelectCarButton
            // 
            this.SelectCarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(141)))), ((int)(((byte)(42)))));
            this.SelectCarButton.FlatAppearance.BorderSize = 0;
            this.SelectCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectCarButton.Location = new System.Drawing.Point(279, 3);
            this.SelectCarButton.Name = "SelectCarButton";
            this.SelectCarButton.Size = new System.Drawing.Size(157, 92);
            this.SelectCarButton.TabIndex = 0;
            this.SelectCarButton.Text = "Select Car";
            this.SelectCarButton.UseVisualStyleBackColor = false;
            this.SelectCarButton.Click += new System.EventHandler(this.SelectCarButton_Click);
            // 
            // carBox
            // 
            this.carBox.BackColor = System.Drawing.Color.ForestGreen;
            this.carBox.ForeColor = System.Drawing.Color.White;
            this.carBox.FormattingEnabled = true;
            this.carBox.ItemHeight = 21;
            this.carBox.Location = new System.Drawing.Point(5, 59);
            this.carBox.Name = "carBox";
            this.carBox.Size = new System.Drawing.Size(431, 571);
            this.carBox.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.SelectCar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(439, 51);
            this.panel5.TabIndex = 5;
            // 
            // ManufactorerLogo
            // 
            this.ManufactorerLogo.Controls.Add(this.CarInfo);
            this.ManufactorerLogo.Controls.Add(this.ImagePanel);
            this.ManufactorerLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManufactorerLogo.Location = new System.Drawing.Point(599, 81);
            this.ManufactorerLogo.Name = "ManufactorerLogo";
            this.ManufactorerLogo.Size = new System.Drawing.Size(1030, 261);
            this.ManufactorerLogo.TabIndex = 7;
            // 
            // CarInfo
            // 
            this.CarInfo.AutoSize = true;
            this.CarInfo.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarInfo.Location = new System.Drawing.Point(340, 8);
            this.CarInfo.Name = "CarInfo";
            this.CarInfo.Size = new System.Drawing.Size(144, 39);
            this.CarInfo.TabIndex = 1;
            this.CarInfo.Text = "Car Info";
            // 
            // ImagePanel
            // 
            this.ImagePanel.Controls.Add(this.Badge);
            this.ImagePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ImagePanel.Location = new System.Drawing.Point(0, 0);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(334, 261);
            this.ImagePanel.TabIndex = 0;
            // 
            // Badge
            // 
            this.Badge.Location = new System.Drawing.Point(43, 8);
            this.Badge.Name = "Badge";
            this.Badge.Size = new System.Drawing.Size(251, 240);
            this.Badge.TabIndex = 0;
            this.Badge.TabStop = false;
            // 
            // CarDetails
            // 
            this.CarDetails.AutoSize = true;
            this.CarDetails.Location = new System.Drawing.Point(666, 354);
            this.CarDetails.Name = "CarDetails";
            this.CarDetails.Size = new System.Drawing.Size(114, 21);
            this.CarDetails.TabIndex = 8;
            this.CarDetails.Text = "Car Details";
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1629, 815);
            this.Controls.Add(this.CarDetails);
            this.Controls.Add(this.ManufactorerLogo);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SideBar);
            this.Font = new System.Drawing.Font("Bookman Old Style", 14.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Overview";
            this.Text = "Overview";
            this.Load += new System.EventHandler(this.Overview_Load);
            this.SideBar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ManufactorerLogo.ResumeLayout(false);
            this.ManufactorerLogo.PerformLayout();
            this.ImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Badge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label OverviewText;
        private System.Windows.Forms.Label SelectCar;
        private System.Windows.Forms.Panel SelectedButton;
        private System.Windows.Forms.Button AddCarButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button SelectCarButton;
        private System.Windows.Forms.ListBox carBox;
        private System.Windows.Forms.Panel ManufactorerLogo;
        private System.Windows.Forms.Label CarInfo;
        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.PictureBox Badge;
        private System.Windows.Forms.Label CarDetails;
        private System.Windows.Forms.Button button1;
    }
}