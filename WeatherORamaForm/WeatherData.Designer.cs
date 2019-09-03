namespace WeatherORamaForm
{
    partial class WeatherData
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
            this.LabelWeatherHeader = new System.Windows.Forms.Label();
            this.LabelTempHeader = new System.Windows.Forms.Label();
            this.LabelPressureHeader = new System.Windows.Forms.Label();
            this.LabelHumidityHeader = new System.Windows.Forms.Label();
            this.TextBoxTempEnter = new System.Windows.Forms.TextBox();
            this.TextBoxHumidityEnter = new System.Windows.Forms.TextBox();
            this.TextBoxPressureEnter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelWeatherHeader
            // 
            this.LabelWeatherHeader.AutoSize = true;
            this.LabelWeatherHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWeatherHeader.Location = new System.Drawing.Point(130, 45);
            this.LabelWeatherHeader.Name = "LabelWeatherHeader";
            this.LabelWeatherHeader.Size = new System.Drawing.Size(179, 20);
            this.LabelWeatherHeader.TabIndex = 0;
            this.LabelWeatherHeader.Text = "WeatherData Station";
           
            // 
            // LabelTempHeader
            // 
            this.LabelTempHeader.AutoSize = true;
            this.LabelTempHeader.Location = new System.Drawing.Point(79, 156);
            this.LabelTempHeader.Name = "LabelTempHeader";
            this.LabelTempHeader.Size = new System.Drawing.Size(34, 13);
            this.LabelTempHeader.TabIndex = 1;
            this.LabelTempHeader.Text = "Temp";
            // 
            // LabelPressureHeader
            // 
            this.LabelPressureHeader.AutoSize = true;
            this.LabelPressureHeader.Location = new System.Drawing.Point(79, 271);
            this.LabelPressureHeader.Name = "LabelPressureHeader";
            this.LabelPressureHeader.Size = new System.Drawing.Size(48, 13);
            this.LabelPressureHeader.TabIndex = 2;
            this.LabelPressureHeader.Text = "Pressure";
            // 
            // LabelHumidityHeader
            // 
            this.LabelHumidityHeader.AutoSize = true;
            this.LabelHumidityHeader.Location = new System.Drawing.Point(79, 217);
            this.LabelHumidityHeader.Name = "LabelHumidityHeader";
            this.LabelHumidityHeader.Size = new System.Drawing.Size(47, 13);
            this.LabelHumidityHeader.TabIndex = 3;
            this.LabelHumidityHeader.Text = "Humidity";
            // 
            // TextBoxTempEnter
            // 
            this.TextBoxTempEnter.Location = new System.Drawing.Point(196, 156);
            this.TextBoxTempEnter.Name = "TextBoxTempEnter";
            this.TextBoxTempEnter.Size = new System.Drawing.Size(100, 20);
            this.TextBoxTempEnter.TabIndex = 4;
            this.TextBoxTempEnter.TextChanged += new System.EventHandler(this.TextBoxTempEnter_TextChanged);
            // 
            // TextBoxHumidityEnter
            // 
            this.TextBoxHumidityEnter.Location = new System.Drawing.Point(196, 214);
            this.TextBoxHumidityEnter.Name = "TextBoxHumidityEnter";
            this.TextBoxHumidityEnter.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHumidityEnter.TabIndex = 5;
            this.TextBoxHumidityEnter.TextChanged += new System.EventHandler(this.TextBoxHumidityEnter_TextChanged);
            // 
            // TextBoxPressureEnter
            // 
            this.TextBoxPressureEnter.Location = new System.Drawing.Point(196, 264);
            this.TextBoxPressureEnter.Name = "TextBoxPressureEnter";
            this.TextBoxPressureEnter.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPressureEnter.TabIndex = 6;
            this.TextBoxPressureEnter.TextChanged += new System.EventHandler(this.TextBoxPressureEnter_TextChanged);
            // 
            // WeatherData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 483);
            this.Controls.Add(this.TextBoxPressureEnter);
            this.Controls.Add(this.TextBoxHumidityEnter);
            this.Controls.Add(this.TextBoxTempEnter);
            this.Controls.Add(this.LabelHumidityHeader);
            this.Controls.Add(this.LabelPressureHeader);
            this.Controls.Add(this.LabelTempHeader);
            this.Controls.Add(this.LabelWeatherHeader);
            this.Name = "WeatherData";
            this.Text = "WeatherData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelWeatherHeader;
        private System.Windows.Forms.Label LabelTempHeader;
        private System.Windows.Forms.Label LabelPressureHeader;
        private System.Windows.Forms.Label LabelHumidityHeader;
        private System.Windows.Forms.TextBox TextBoxTempEnter;
        private System.Windows.Forms.TextBox TextBoxHumidityEnter;
        private System.Windows.Forms.TextBox TextBoxPressureEnter;
    }
}

