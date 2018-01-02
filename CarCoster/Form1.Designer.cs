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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CarBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.ElectricButton = new System.Windows.Forms.Button();
            this.HybridButton = new System.Windows.Forms.Button();
            this.DieselButton = new System.Windows.Forms.Button();
            this.PetrolButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MPGSort = new System.Windows.Forms.Button();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ConfirmYearButton = new System.Windows.Forms.Button();
            this.YearBox = new System.Windows.Forms.ListBox();
            this.ManufactorerLabel = new System.Windows.Forms.Label();
            this.ManufactorerSearch = new System.Windows.Forms.Label();
            this.MakeBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModBox = new System.Windows.Forms.TextBox();
            this.ModelSearch = new System.Windows.Forms.Label();
            this.ModelBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LoadCar = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.OverviewButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SideBarPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SelectedButton = new System.Windows.Forms.Panel();
            this.CompareButton = new System.Windows.Forms.Button();
            this.AddCarButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveText = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SideBarPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel25.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarBox
            // 
            this.CarBox.BackColor = System.Drawing.Color.ForestGreen;
            this.CarBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CarBox.ForeColor = System.Drawing.Color.White;
            this.CarBox.FormattingEnabled = true;
            this.CarBox.ItemHeight = 21;
            this.CarBox.Location = new System.Drawing.Point(10, 92);
            this.CarBox.Name = "CarBox";
            this.CarBox.Size = new System.Drawing.Size(490, 546);
            this.CarBox.TabIndex = 2;
            this.CarBox.SelectedIndexChanged += new System.EventHandler(this.CarBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.CarBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(143, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 815);
            this.panel2.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.LogoBox);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 725);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(515, 90);
            this.panel10.TabIndex = 6;
            // 
            // ElectricButton
            // 
            this.ElectricButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ElectricButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ElectricButton.FlatAppearance.BorderSize = 0;
            this.ElectricButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ElectricButton.Font = new System.Drawing.Font("Bookman Old Style", 11F);
            this.ElectricButton.Location = new System.Drawing.Point(125, 0);
            this.ElectricButton.Name = "ElectricButton";
            this.ElectricButton.Size = new System.Drawing.Size(115, 52);
            this.ElectricButton.TabIndex = 6;
            this.ElectricButton.Text = "Electric";
            this.ElectricButton.UseVisualStyleBackColor = false;
            this.ElectricButton.Click += new System.EventHandler(this.ElectricButton_Click);
            // 
            // HybridButton
            // 
            this.HybridButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.HybridButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.HybridButton.FlatAppearance.BorderSize = 0;
            this.HybridButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HybridButton.Font = new System.Drawing.Font("Bookman Old Style", 11F);
            this.HybridButton.Location = new System.Drawing.Point(0, 0);
            this.HybridButton.Name = "HybridButton";
            this.HybridButton.Size = new System.Drawing.Size(115, 52);
            this.HybridButton.TabIndex = 5;
            this.HybridButton.Text = "Hybrid";
            this.HybridButton.UseVisualStyleBackColor = false;
            this.HybridButton.Click += new System.EventHandler(this.HybridButton_Click);
            // 
            // DieselButton
            // 
            this.DieselButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.DieselButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DieselButton.FlatAppearance.BorderSize = 0;
            this.DieselButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DieselButton.Font = new System.Drawing.Font("Bookman Old Style", 11F);
            this.DieselButton.Location = new System.Drawing.Point(125, 0);
            this.DieselButton.Name = "DieselButton";
            this.DieselButton.Size = new System.Drawing.Size(115, 52);
            this.DieselButton.TabIndex = 4;
            this.DieselButton.Text = "Diesel";
            this.DieselButton.UseVisualStyleBackColor = false;
            this.DieselButton.Click += new System.EventHandler(this.DieselButton_Click);
            // 
            // PetrolButton
            // 
            this.PetrolButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.PetrolButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.PetrolButton.FlatAppearance.BorderSize = 0;
            this.PetrolButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PetrolButton.Font = new System.Drawing.Font("Bookman Old Style", 11F);
            this.PetrolButton.Location = new System.Drawing.Point(0, 0);
            this.PetrolButton.Name = "PetrolButton";
            this.PetrolButton.Size = new System.Drawing.Size(115, 52);
            this.PetrolButton.TabIndex = 3;
            this.PetrolButton.Text = "Petrol";
            this.PetrolButton.UseVisualStyleBackColor = false;
            this.PetrolButton.Click += new System.EventHandler(this.PetrolButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 11F);
            this.button1.Location = new System.Drawing.Point(125, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 71);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sort by MPG (Descending)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MPGSort
            // 
            this.MPGSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.MPGSort.Dock = System.Windows.Forms.DockStyle.Left;
            this.MPGSort.FlatAppearance.BorderSize = 0;
            this.MPGSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MPGSort.Font = new System.Drawing.Font("Bookman Old Style", 11F);
            this.MPGSort.Location = new System.Drawing.Point(0, 0);
            this.MPGSort.Name = "MPGSort";
            this.MPGSort.Size = new System.Drawing.Size(115, 71);
            this.MPGSort.TabIndex = 1;
            this.MPGSort.Text = "Sort by MPG (Ascending)";
            this.MPGSort.UseVisualStyleBackColor = false;
            this.MPGSort.Click += new System.EventHandler(this.MPGSort_Click);
            // 
            // LogoBox
            // 
            this.LogoBox.Location = new System.Drawing.Point(6, 3);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(100, 84);
            this.LogoBox.TabIndex = 0;
            this.LogoBox.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.ManufactorerSearch);
            this.panel4.Controls.Add(this.MakeBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(515, 86);
            this.panel4.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ManufactorerLabel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(515, 37);
            this.panel6.TabIndex = 0;
            // 
            // ConfirmYearButton
            // 
            this.ConfirmYearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ConfirmYearButton.FlatAppearance.BorderSize = 0;
            this.ConfirmYearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmYearButton.Location = new System.Drawing.Point(0, 0);
            this.ConfirmYearButton.Name = "ConfirmYearButton";
            this.ConfirmYearButton.Size = new System.Drawing.Size(99, 34);
            this.ConfirmYearButton.TabIndex = 2;
            this.ConfirmYearButton.Text = "Confirm";
            this.ConfirmYearButton.UseVisualStyleBackColor = false;
            this.ConfirmYearButton.Click += new System.EventHandler(this.ConfirmYearButton_Click);
            // 
            // YearBox
            // 
            this.YearBox.BackColor = System.Drawing.Color.White;
            this.YearBox.ForeColor = System.Drawing.Color.Black;
            this.YearBox.FormattingEnabled = true;
            this.YearBox.ItemHeight = 21;
            this.YearBox.Location = new System.Drawing.Point(62, 40);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(160, 25);
            this.YearBox.TabIndex = 1;
            // 
            // ManufactorerLabel
            // 
            this.ManufactorerLabel.AutoSize = true;
            this.ManufactorerLabel.Location = new System.Drawing.Point(6, 7);
            this.ManufactorerLabel.Name = "ManufactorerLabel";
            this.ManufactorerLabel.Size = new System.Drawing.Size(135, 21);
            this.ManufactorerLabel.TabIndex = 0;
            this.ManufactorerLabel.Text = "Manufactorer";
            // 
            // ManufactorerSearch
            // 
            this.ManufactorerSearch.AutoSize = true;
            this.ManufactorerSearch.Location = new System.Drawing.Point(14, 52);
            this.ManufactorerSearch.Name = "ManufactorerSearch";
            this.ManufactorerSearch.Size = new System.Drawing.Size(81, 21);
            this.ManufactorerSearch.TabIndex = 0;
            this.ManufactorerSearch.Text = "Search:";
            // 
            // MakeBox
            // 
            this.MakeBox.Location = new System.Drawing.Point(101, 46);
            this.MakeBox.Name = "MakeBox";
            this.MakeBox.Size = new System.Drawing.Size(399, 30);
            this.MakeBox.TabIndex = 1;
            this.MakeBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.ModelBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(658, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(510, 815);
            this.panel3.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.SaveText);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 725);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(510, 90);
            this.panel11.TabIndex = 6;
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
            this.ModelBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModelBox.ForeColor = System.Drawing.Color.White;
            this.ModelBox.FormattingEnabled = true;
            this.ModelBox.ItemHeight = 21;
            this.ModelBox.Location = new System.Drawing.Point(6, 91);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(490, 546);
            this.ModelBox.TabIndex = 3;
            this.ModelBox.SelectedIndexChanged += new System.EventHandler(this.ModelBox_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LoadCar
            // 
            this.LoadCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.LoadCar.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoadCar.FlatAppearance.BorderSize = 0;
            this.LoadCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadCar.Location = new System.Drawing.Point(0, 0);
            this.LoadCar.Name = "LoadCar";
            this.LoadCar.Size = new System.Drawing.Size(116, 90);
            this.LoadCar.TabIndex = 2;
            this.LoadCar.Text = "Load Car";
            this.LoadCar.UseVisualStyleBackColor = false;
            this.LoadCar.Click += new System.EventHandler(this.LoadCar_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(143, 105);
            this.LogoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 105);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SaveLabel
            // 
            this.SaveLabel.AutoSize = true;
            this.SaveLabel.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveLabel.Location = new System.Drawing.Point(3, 800);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(40, 15);
            this.SaveLabel.TabIndex = 2;
            this.SaveLabel.Text = "label1";
            // 
            // OverviewButton
            // 
            this.OverviewButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OverviewButton.FlatAppearance.BorderSize = 0;
            this.OverviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverviewButton.Location = new System.Drawing.Point(0, 105);
            this.OverviewButton.Name = "OverviewButton";
            this.OverviewButton.Size = new System.Drawing.Size(143, 100);
            this.OverviewButton.TabIndex = 3;
            this.OverviewButton.Text = "Overview";
            this.OverviewButton.UseVisualStyleBackColor = true;
            this.OverviewButton.Click += new System.EventHandler(this.OverviewButton_Click);
            this.OverviewButton.MouseHover += new System.EventHandler(this.SaveButton_MouseHover);
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(0, 717);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(143, 98);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.MouseHover += new System.EventHandler(this.SaveButton_MouseHover);
            // 
            // SideBarPanel
            // 
            this.SideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.SideBarPanel.Controls.Add(this.SettingsButton);
            this.SideBarPanel.Controls.Add(this.SelectedButton);
            this.SideBarPanel.Controls.Add(this.CompareButton);
            this.SideBarPanel.Controls.Add(this.AddCarButton);
            this.SideBarPanel.Controls.Add(this.CloseButton);
            this.SideBarPanel.Controls.Add(this.OverviewButton);
            this.SideBarPanel.Controls.Add(this.SaveLabel);
            this.SideBarPanel.Controls.Add(this.LogoPanel);
            this.SideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.SideBarPanel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SideBarPanel.Name = "SideBarPanel";
            this.SideBarPanel.Size = new System.Drawing.Size(143, 815);
            this.SideBarPanel.TabIndex = 0;
            this.SideBarPanel.MouseLeave += new System.EventHandler(this.SideBarPanel_MouseLeave);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.Location = new System.Drawing.Point(0, 405);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(143, 100);
            this.SettingsButton.TabIndex = 8;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // SelectedButton
            // 
            this.SelectedButton.BackColor = System.Drawing.Color.Red;
            this.SelectedButton.Location = new System.Drawing.Point(131, 307);
            this.SelectedButton.Name = "SelectedButton";
            this.SelectedButton.Size = new System.Drawing.Size(12, 98);
            this.SelectedButton.TabIndex = 0;
            // 
            // CompareButton
            // 
            this.CompareButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CompareButton.FlatAppearance.BorderSize = 0;
            this.CompareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompareButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompareButton.Location = new System.Drawing.Point(0, 305);
            this.CompareButton.Name = "CompareButton";
            this.CompareButton.Size = new System.Drawing.Size(143, 100);
            this.CompareButton.TabIndex = 6;
            this.CompareButton.Text = "Compare";
            this.CompareButton.UseVisualStyleBackColor = true;
            this.CompareButton.Click += new System.EventHandler(this.button1_Click);
            this.CompareButton.MouseHover += new System.EventHandler(this.SaveButton_MouseHover);
            // 
            // AddCarButton
            // 
            this.AddCarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(139)))));
            this.AddCarButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddCarButton.FlatAppearance.BorderSize = 0;
            this.AddCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCarButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarButton.Location = new System.Drawing.Point(0, 205);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(143, 100);
            this.AddCarButton.TabIndex = 5;
            this.AddCarButton.Text = "Add Car";
            this.AddCarButton.UseVisualStyleBackColor = false;
            this.AddCarButton.MouseHover += new System.EventHandler(this.SaveButton_MouseHover);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(124, 0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(116, 90);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save Car";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            this.SaveButton.MouseHover += new System.EventHandler(this.SaveButton_MouseHover);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel20);
            this.panel1.Controls.Add(this.panel17);
            this.panel1.Controls.Add(this.panel16);
            this.panel1.Controls.Add(this.panel15);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1160, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 815);
            this.panel1.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel25);
            this.panel8.Controls.Add(this.panel24);
            this.panel8.Controls.Add(this.panel23);
            this.panel8.Controls.Add(this.panel18);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(240, 305);
            this.panel8.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 305);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(240, 52);
            this.panel9.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 357);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(240, 10);
            this.panel12.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.PetrolButton);
            this.panel13.Controls.Add(this.DieselButton);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 367);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(240, 52);
            this.panel13.TabIndex = 3;
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 419);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(240, 10);
            this.panel14.TabIndex = 4;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.HybridButton);
            this.panel15.Controls.Add(this.ElectricButton);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 429);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(240, 52);
            this.panel15.TabIndex = 5;
            // 
            // panel16
            // 
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(0, 481);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(240, 10);
            this.panel16.TabIndex = 6;
            // 
            // panel17
            // 
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 491);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(240, 52);
            this.panel17.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restrictions:";
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.SaveButton);
            this.panel20.Controls.Add(this.LoadCar);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel20.Location = new System.Drawing.Point(0, 725);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(240, 90);
            this.panel20.TabIndex = 8;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.panel21);
            this.panel18.Controls.Add(this.YearBox);
            this.panel18.Controls.Add(this.panel19);
            this.panel18.Controls.Add(this.label2);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(0, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(240, 105);
            this.panel18.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year:";
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.label3);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel19.Location = new System.Drawing.Point(0, 0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(240, 37);
            this.panel19.TabIndex = 0;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.panel22);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel21.Location = new System.Drawing.Point(0, 71);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(240, 34);
            this.panel21.TabIndex = 3;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.ConfirmYearButton);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel22.Location = new System.Drawing.Point(0, 0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(99, 34);
            this.panel22.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select Year:";
            // 
            // panel23
            // 
            this.panel23.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel23.Location = new System.Drawing.Point(0, 105);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(240, 10);
            this.panel23.TabIndex = 3;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.label4);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel24.Location = new System.Drawing.Point(0, 115);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(240, 52);
            this.panel24.TabIndex = 4;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.button1);
            this.panel25.Controls.Add(this.MPGSort);
            this.panel25.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel25.Location = new System.Drawing.Point(0, 167);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(240, 71);
            this.panel25.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sorting:";
            // 
            // SaveText
            // 
            this.SaveText.AutoSize = true;
            this.SaveText.Font = new System.Drawing.Font("Bookman Old Style", 8F);
            this.SaveText.Location = new System.Drawing.Point(6, 12);
            this.SaveText.Name = "SaveText";
            this.SaveText.Size = new System.Drawing.Size(40, 15);
            this.SaveText.TabIndex = 5;
            this.SaveText.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1400, 815);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SideBarPanel);
            this.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SideBarPanel.ResumeLayout(false);
            this.SideBarPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox CarBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox ModelBox;
        private System.Windows.Forms.Label ManufactorerSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label ModelSearch;
        private System.Windows.Forms.TextBox MakeBox;
        private System.Windows.Forms.TextBox ModBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label ManufactorerLabel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SaveLabel;
        private System.Windows.Forms.Button OverviewButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel SideBarPanel;
        private System.Windows.Forms.Panel SelectedButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button AddCarButton;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button CompareButton;
        private System.Windows.Forms.ListBox YearBox;
        private System.Windows.Forms.Button ConfirmYearButton;
        private System.Windows.Forms.Button MPGSort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ElectricButton;
        private System.Windows.Forms.Button HybridButton;
        private System.Windows.Forms.Button DieselButton;
        private System.Windows.Forms.Button PetrolButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button LoadCar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SaveText;
    }
}

