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
            this.CloseButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OverviewText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SelectedButton = new System.Windows.Forms.Panel();
            this.AddCarButton = new System.Windows.Forms.Button();
            this.SideBar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(141)))), ((int)(((byte)(42)))));
            this.SideBar.Controls.Add(this.AddCarButton);
            this.SideBar.Controls.Add(this.CloseButton);
            this.SideBar.Controls.Add(this.SaveButton);
            this.SideBar.Controls.Add(this.panel3);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.ForeColor = System.Drawing.Color.White;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(109, 815);
            this.SideBar.TabIndex = 0;
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
            this.CloseButton.Size = new System.Drawing.Size(109, 98);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.MouseHover += new System.EventHandler(this.SaveButton_MouseHover);
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(0, 81);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(109, 98);
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
            this.panel3.Size = new System.Drawing.Size(109, 81);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 67);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(122)))));
            this.panel2.Controls.Add(this.OverviewText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(109, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1520, 81);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(109, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(35, 734);
            this.panel4.TabIndex = 6;
            // 
            // SelectedButton
            // 
            this.SelectedButton.BackColor = System.Drawing.Color.Red;
            this.SelectedButton.Location = new System.Drawing.Point(121, 81);
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
            this.AddCarButton.Location = new System.Drawing.Point(0, 179);
            this.AddCarButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(109, 98);
            this.AddCarButton.TabIndex = 5;
            this.AddCarButton.Text = "Save";
            this.AddCarButton.UseVisualStyleBackColor = true;
            this.AddCarButton.MouseHover += new System.EventHandler(this.SaveButton_MouseHover);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1629, 815);
            this.Controls.Add(this.SelectedButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel SelectedButton;
        private System.Windows.Forms.Button AddCarButton;
    }
}