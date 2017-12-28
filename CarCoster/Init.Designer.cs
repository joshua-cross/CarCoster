namespace CarCoster
{
    partial class Init
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
            this.label1 = new System.Windows.Forms.Label();
            this.DieselUpDown = new System.Windows.Forms.NumericUpDown();
            this.ConfirmFuelPriceButton = new System.Windows.Forms.Button();
            this.FuelUpDown = new System.Windows.Forms.NumericUpDown();
            this.FuelPriceLabel = new System.Windows.Forms.Label();
            this.MetricLabel = new System.Windows.Forms.Label();
            this.ImperialLabel = new System.Windows.Forms.Label();
            this.ImperialOrMetric = new System.Windows.Forms.TrackBar();
            this.ImperialOrMetricSystem = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ConfirmError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DieselUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuelUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImperialOrMetric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Imperial Or Metric System";
            // 
            // DieselUpDown
            // 
            this.DieselUpDown.DecimalPlaces = 2;
            this.DieselUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.DieselUpDown.Location = new System.Drawing.Point(16, 104);
            this.DieselUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.DieselUpDown.Name = "DieselUpDown";
            this.DieselUpDown.Size = new System.Drawing.Size(120, 29);
            this.DieselUpDown.TabIndex = 18;
            // 
            // ConfirmFuelPriceButton
            // 
            this.ConfirmFuelPriceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(141)))), ((int)(((byte)(42)))));
            this.ConfirmFuelPriceButton.FlatAppearance.BorderSize = 0;
            this.ConfirmFuelPriceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmFuelPriceButton.Location = new System.Drawing.Point(16, 248);
            this.ConfirmFuelPriceButton.Name = "ConfirmFuelPriceButton";
            this.ConfirmFuelPriceButton.Size = new System.Drawing.Size(98, 30);
            this.ConfirmFuelPriceButton.TabIndex = 17;
            this.ConfirmFuelPriceButton.Text = "Confirm";
            this.ConfirmFuelPriceButton.UseVisualStyleBackColor = false;
            this.ConfirmFuelPriceButton.Click += new System.EventHandler(this.ConfirmFuelPriceButton_Click);
            // 
            // FuelUpDown
            // 
            this.FuelUpDown.DecimalPlaces = 2;
            this.FuelUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.FuelUpDown.Location = new System.Drawing.Point(16, 36);
            this.FuelUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.FuelUpDown.Name = "FuelUpDown";
            this.FuelUpDown.Size = new System.Drawing.Size(120, 29);
            this.FuelUpDown.TabIndex = 16;
            // 
            // FuelPriceLabel
            // 
            this.FuelPriceLabel.AutoSize = true;
            this.FuelPriceLabel.Location = new System.Drawing.Point(12, 77);
            this.FuelPriceLabel.Name = "FuelPriceLabel";
            this.FuelPriceLabel.Size = new System.Drawing.Size(343, 24);
            this.FuelPriceLabel.TabIndex = 15;
            this.FuelPriceLabel.Text = "Current Petrol Price (Per Litre) in pence:";
            // 
            // MetricLabel
            // 
            this.MetricLabel.AutoSize = true;
            this.MetricLabel.Location = new System.Drawing.Point(204, 197);
            this.MetricLabel.Name = "MetricLabel";
            this.MetricLabel.Size = new System.Drawing.Size(61, 24);
            this.MetricLabel.TabIndex = 14;
            this.MetricLabel.Text = "Metric";
            // 
            // ImperialLabel
            // 
            this.ImperialLabel.AutoSize = true;
            this.ImperialLabel.Location = new System.Drawing.Point(12, 197);
            this.ImperialLabel.Name = "ImperialLabel";
            this.ImperialLabel.Size = new System.Drawing.Size(76, 24);
            this.ImperialLabel.TabIndex = 13;
            this.ImperialLabel.Text = "Imperial";
            // 
            // ImperialOrMetric
            // 
            this.ImperialOrMetric.Location = new System.Drawing.Point(94, 197);
            this.ImperialOrMetric.Maximum = 1;
            this.ImperialOrMetric.Name = "ImperialOrMetric";
            this.ImperialOrMetric.Size = new System.Drawing.Size(104, 45);
            this.ImperialOrMetric.TabIndex = 12;
            // 
            // ImperialOrMetricSystem
            // 
            this.ImperialOrMetricSystem.AutoSize = true;
            this.ImperialOrMetricSystem.Location = new System.Drawing.Point(12, 9);
            this.ImperialOrMetricSystem.Name = "ImperialOrMetricSystem";
            this.ImperialOrMetricSystem.Size = new System.Drawing.Size(299, 24);
            this.ImperialOrMetricSystem.TabIndex = 22;
            this.ImperialOrMetricSystem.Text = "Current Diesel (Per Litre) in pence:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // ConfirmError
            // 
            this.ConfirmError.ContainerControl = this;
            // 
            // Init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(368, 320);
            this.Controls.Add(this.FuelPriceLabel);
            this.Controls.Add(this.FuelUpDown);
            this.Controls.Add(this.ImperialOrMetricSystem);
            this.Controls.Add(this.DieselUpDown);
            this.Controls.Add(this.MetricLabel);
            this.Controls.Add(this.ImperialOrMetric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImperialLabel);
            this.Controls.Add(this.ConfirmFuelPriceButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Init";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Init_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DieselUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuelUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImperialOrMetric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown DieselUpDown;
        private System.Windows.Forms.Button ConfirmFuelPriceButton;
        private System.Windows.Forms.NumericUpDown FuelUpDown;
        private System.Windows.Forms.Label FuelPriceLabel;
        private System.Windows.Forms.Label MetricLabel;
        private System.Windows.Forms.Label ImperialLabel;
        private System.Windows.Forms.TrackBar ImperialOrMetric;
        private System.Windows.Forms.Label ImperialOrMetricSystem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ErrorProvider ConfirmError;
    }
}