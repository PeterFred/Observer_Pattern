namespace WeatherORamaForm
{
    partial class CurrentConditionsDisplay
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
            this.LabelCurrentHeader = new System.Windows.Forms.Label();
            this.LabelTempHeader = new System.Windows.Forms.Label();
            this.LabelHudityHeader = new System.Windows.Forms.Label();
            this.LabelPressureHeader = new System.Windows.Forms.Label();
            this.LabelTempDisplay = new System.Windows.Forms.Label();
            this.LabelHumidityDisplay = new System.Windows.Forms.Label();
            this.LabelPressureDisplay = new System.Windows.Forms.Label();
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.ButtonDeRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelCurrentHeader
            // 
            this.LabelCurrentHeader.AutoSize = true;
            this.LabelCurrentHeader.Location = new System.Drawing.Point(162, 56);
            this.LabelCurrentHeader.Name = "LabelCurrentHeader";
            this.LabelCurrentHeader.Size = new System.Drawing.Size(93, 13);
            this.LabelCurrentHeader.TabIndex = 0;
            this.LabelCurrentHeader.Text = "Current Conditions";
            // 
            // LabelTempHeader
            // 
            this.LabelTempHeader.AutoSize = true;
            this.LabelTempHeader.Location = new System.Drawing.Point(88, 107);
            this.LabelTempHeader.Name = "LabelTempHeader";
            this.LabelTempHeader.Size = new System.Drawing.Size(34, 13);
            this.LabelTempHeader.TabIndex = 1;
            this.LabelTempHeader.Text = "Temp";
            // 
            // LabelHudityHeader
            // 
            this.LabelHudityHeader.AutoSize = true;
            this.LabelHudityHeader.Location = new System.Drawing.Point(88, 153);
            this.LabelHudityHeader.Name = "LabelHudityHeader";
            this.LabelHudityHeader.Size = new System.Drawing.Size(47, 13);
            this.LabelHudityHeader.TabIndex = 2;
            this.LabelHudityHeader.Text = "Humidity";
            // 
            // LabelPressureHeader
            // 
            this.LabelPressureHeader.AutoSize = true;
            this.LabelPressureHeader.Location = new System.Drawing.Point(88, 211);
            this.LabelPressureHeader.Name = "LabelPressureHeader";
            this.LabelPressureHeader.Size = new System.Drawing.Size(48, 13);
            this.LabelPressureHeader.TabIndex = 3;
            this.LabelPressureHeader.Text = "Pressure";
            // 
            // LabelTempDisplay
            // 
            this.LabelTempDisplay.AutoSize = true;
            this.LabelTempDisplay.Location = new System.Drawing.Point(162, 107);
            this.LabelTempDisplay.Name = "LabelTempDisplay";
            this.LabelTempDisplay.Size = new System.Drawing.Size(36, 13);
            this.LabelTempDisplay.TabIndex = 4;
            this.LabelTempDisplay.Text = "_temp";
            // 
            // LabelHumidityDisplay
            // 
            this.LabelHumidityDisplay.AutoSize = true;
            this.LabelHumidityDisplay.Location = new System.Drawing.Point(162, 153);
            this.LabelHumidityDisplay.Name = "LabelHumidityDisplay";
            this.LabelHumidityDisplay.Size = new System.Drawing.Size(51, 13);
            this.LabelHumidityDisplay.TabIndex = 5;
            this.LabelHumidityDisplay.Text = "_humidity";
            // 
            // LabelPressureDisplay
            // 
            this.LabelPressureDisplay.AutoSize = true;
            this.LabelPressureDisplay.Location = new System.Drawing.Point(162, 211);
            this.LabelPressureDisplay.Name = "LabelPressureDisplay";
            this.LabelPressureDisplay.Size = new System.Drawing.Size(53, 13);
            this.LabelPressureDisplay.TabIndex = 6;
            this.LabelPressureDisplay.Text = "_pressure";
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.Location = new System.Drawing.Point(165, 294);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(160, 23);
            this.ButtonRegister.TabIndex = 7;
            this.ButtonRegister.Text = "Register as an Observer";
            this.ButtonRegister.UseVisualStyleBackColor = true;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // ButtonDeRegister
            // 
            this.ButtonDeRegister.Location = new System.Drawing.Point(165, 339);
            this.ButtonDeRegister.Name = "ButtonDeRegister";
            this.ButtonDeRegister.Size = new System.Drawing.Size(160, 23);
            this.ButtonDeRegister.TabIndex = 8;
            this.ButtonDeRegister.Text = "De-Register as an Observer";
            this.ButtonDeRegister.UseVisualStyleBackColor = true;
            this.ButtonDeRegister.Click += new System.EventHandler(this.ButtonDeRegister_Click);
            // 
            // CurrentConditionsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.ButtonDeRegister);
            this.Controls.Add(this.ButtonRegister);
            this.Controls.Add(this.LabelPressureDisplay);
            this.Controls.Add(this.LabelHumidityDisplay);
            this.Controls.Add(this.LabelTempDisplay);
            this.Controls.Add(this.LabelPressureHeader);
            this.Controls.Add(this.LabelHudityHeader);
            this.Controls.Add(this.LabelTempHeader);
            this.Controls.Add(this.LabelCurrentHeader);
            this.Name = "CurrentConditionsDisplay";
            this.Text = "CurrentConditionsDisplay";
            this.Load += new System.EventHandler(this.CurrentConditionsDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelCurrentHeader;
        private System.Windows.Forms.Label LabelTempHeader;
        private System.Windows.Forms.Label LabelHudityHeader;
        private System.Windows.Forms.Label LabelPressureHeader;
        private System.Windows.Forms.Label LabelTempDisplay;
        private System.Windows.Forms.Label LabelHumidityDisplay;
        private System.Windows.Forms.Label LabelPressureDisplay;
        private System.Windows.Forms.Button ButtonRegister;
        private System.Windows.Forms.Button ButtonDeRegister;
    }
}