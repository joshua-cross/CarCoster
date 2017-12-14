namespace CarCoster
{
    partial class Form1
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
            this.SideBarPanel = new System.Windows.Forms.Panel();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.CarBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ManufactorerLabel = new System.Windows.Forms.Label();
            this.MakeBox = new System.Windows.Forms.TextBox();
            this.ManufactorerSearch = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModBox = new System.Windows.Forms.TextBox();
            this.ModelSearch = new System.Windows.Forms.Label();
            this.ModelBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.OverviewLabel = new System.Windows.Forms.Label();
            this.OverviewText = new System.Windows.Forms.Label();
            this.SideBarPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBarPanel
            // 
            this.SideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(141)))), ((int)(((byte)(42)))));
            this.SideBarPanel.Controls.Add(this.LogoPanel);
            this.SideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.SideBarPanel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SideBarPanel.Name = "SideBarPanel";
            this.SideBarPanel.Size = new System.Drawing.Size(109, 815);
            this.SideBarPanel.TabIndex = 0;
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(109, 77);
            this.LogoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 67);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(109, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1520, 77);
            this.panel1.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 26);
            this.Title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(83, 27);
            this.Title.TabIndex = 0;
            this.Title.Text = "label1";
            // 
            // CarBox
            // 
            this.CarBox.BackColor = System.Drawing.Color.ForestGreen;
            this.CarBox.ForeColor = System.Drawing.Color.White;
            this.CarBox.FormattingEnabled = true;
            this.CarBox.ItemHeight = 21;
            this.CarBox.Location = new System.Drawing.Point(9, 92);
            this.CarBox.Name = "CarBox";
            this.CarBox.Size = new System.Drawing.Size(490, 634);
            this.CarBox.TabIndex = 2;
            this.CarBox.SelectedIndexChanged += new System.EventHandler(this.CarBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.CarBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(109, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 738);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.MakeBox);
            this.panel4.Controls.Add(this.ManufactorerSearch);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(511, 86);
            this.panel4.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ManufactorerLabel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(511, 37);
            this.panel6.TabIndex = 2;
            // 
            // ManufactorerLabel
            // 
            this.ManufactorerLabel.AutoSize = true;
            this.ManufactorerLabel.Location = new System.Drawing.Point(13, 7);
            this.ManufactorerLabel.Name = "ManufactorerLabel";
            this.ManufactorerLabel.Size = new System.Drawing.Size(135, 21);
            this.ManufactorerLabel.TabIndex = 0;
            this.ManufactorerLabel.Text = "Manufactorer";
            // 
            // MakeBox
            // 
            this.MakeBox.Location = new System.Drawing.Point(100, 43);
            this.MakeBox.Name = "MakeBox";
            this.MakeBox.Size = new System.Drawing.Size(399, 30);
            this.MakeBox.TabIndex = 1;
            this.MakeBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ManufactorerSearch
            // 
            this.ManufactorerSearch.AutoSize = true;
            this.ManufactorerSearch.Location = new System.Drawing.Point(13, 46);
            this.ManufactorerSearch.Name = "ManufactorerSearch";
            this.ManufactorerSearch.Size = new System.Drawing.Size(81, 21);
            this.ManufactorerSearch.TabIndex = 0;
            this.ManufactorerSearch.Text = "Search:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.ModelBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(620, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(510, 738);
            this.panel3.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.ModBox);
            this.panel5.Controls.Add(this.ModelSearch);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(510, 86);
            this.panel5.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.ModelLabel);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(510, 37);
            this.panel7.TabIndex = 3;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(10, 7);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(66, 21);
            this.ModelLabel.TabIndex = 1;
            this.ModelLabel.Text = "Model";
            // 
            // ModBox
            // 
            this.ModBox.Location = new System.Drawing.Point(97, 43);
            this.ModBox.Name = "ModBox";
            this.ModBox.Size = new System.Drawing.Size(399, 30);
            this.ModBox.TabIndex = 2;
            this.ModBox.TextChanged += new System.EventHandler(this.ModBox_TextChanged);
            // 
            // ModelSearch
            // 
            this.ModelSearch.AutoSize = true;
            this.ModelSearch.Location = new System.Drawing.Point(10, 46);
            this.ModelSearch.Name = "ModelSearch";
            this.ModelSearch.Size = new System.Drawing.Size(81, 21);
            this.ModelSearch.TabIndex = 1;
            this.ModelSearch.Text = "Search:";
            // 
            // ModelBox
            // 
            this.ModelBox.BackColor = System.Drawing.Color.ForestGreen;
            this.ModelBox.ForeColor = System.Drawing.Color.White;
            this.ModelBox.FormattingEnabled = true;
            this.ModelBox.ItemHeight = 21;
            this.ModelBox.Location = new System.Drawing.Point(6, 92);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(490, 634);
            this.ModelBox.TabIndex = 3;
            this.ModelBox.SelectedIndexChanged += new System.EventHandler(this.ModelBox_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.OverviewText);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(1136, 77);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(493, 738);
            this.panel8.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.OverviewLabel);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(493, 37);
            this.panel9.TabIndex = 0;
            // 
            // OverviewLabel
            // 
            this.OverviewLabel.AutoSize = true;
            this.OverviewLabel.Location = new System.Drawing.Point(8, 7);
            this.OverviewLabel.Name = "OverviewLabel";
            this.OverviewLabel.Size = new System.Drawing.Size(96, 21);
            this.OverviewLabel.TabIndex = 0;
            this.OverviewLabel.Text = "Overview";
            // 
            // OverviewText
            // 
            this.OverviewText.AutoSize = true;
            this.OverviewText.Location = new System.Drawing.Point(8, 46);
            this.OverviewText.Name = "OverviewText";
            this.OverviewText.Size = new System.Drawing.Size(67, 21);
            this.OverviewText.TabIndex = 1;
            this.OverviewText.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1629, 815);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SideBarPanel);
            this.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SideBarPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBarPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ListBox CarBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox ModelBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label ManufactorerSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label ModelSearch;
        private System.Windows.Forms.TextBox MakeBox;
        private System.Windows.Forms.TextBox ModBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label ManufactorerLabel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label OverviewLabel;
        private System.Windows.Forms.Label OverviewText;
    }
}

