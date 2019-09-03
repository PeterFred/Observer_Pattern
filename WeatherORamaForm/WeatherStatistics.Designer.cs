namespace WeatherORamaForm
{
    partial class WeatherStatistics
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
            this.LabelMainHeader = new System.Windows.Forms.Label();
            this.LabelAverageHeader = new System.Windows.Forms.Label();
            this.LabelMaxHeader = new System.Windows.Forms.Label();
            this.LabelMinHeader = new System.Windows.Forms.Label();
            this.LabelAverageDisplay = new System.Windows.Forms.Label();
            this.LabelMaxDisplay = new System.Windows.Forms.Label();
            this.LabelMinDisplay = new System.Windows.Forms.Label();
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelMainHeader
            // 
            this.LabelMainHeader.AutoSize = true;
            this.LabelMainHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMainHeader.Location = new System.Drawing.Point(160, 49);
            this.LabelMainHeader.Name = "LabelMainHeader";
            this.LabelMainHeader.Size = new System.Drawing.Size(157, 20);
            this.LabelMainHeader.TabIndex = 0;
            this.LabelMainHeader.Text = "Weather Statistics";
            // 
            // LabelAverageHeader
            // 
            this.LabelAverageHeader.AutoSize = true;
            this.LabelAverageHeader.Location = new System.Drawing.Point(90, 107);
            this.LabelAverageHeader.Name = "LabelAverageHeader";
            this.LabelAverageHeader.Size = new System.Drawing.Size(77, 13);
            this.LabelAverageHeader.TabIndex = 1;
            this.LabelAverageHeader.Text = "Average Temp";
            // 
            // LabelMaxHeader
            // 
            this.LabelMaxHeader.AutoSize = true;
            this.LabelMaxHeader.Location = new System.Drawing.Point(90, 166);
            this.LabelMaxHeader.Name = "LabelMaxHeader";
            this.LabelMaxHeader.Size = new System.Drawing.Size(57, 13);
            this.LabelMaxHeader.TabIndex = 2;
            this.LabelMaxHeader.Text = "Max Temp";
            // 
            // LabelMinHeader
            // 
            this.LabelMinHeader.AutoSize = true;
            this.LabelMinHeader.Location = new System.Drawing.Point(90, 223);
            this.LabelMinHeader.Name = "LabelMinHeader";
            this.LabelMinHeader.Size = new System.Drawing.Size(54, 13);
            this.LabelMinHeader.TabIndex = 3;
            this.LabelMinHeader.Text = "Min Temp";
            // 
            // LabelAverageDisplay
            // 
            this.LabelAverageDisplay.AutoSize = true;
            this.LabelAverageDisplay.Location = new System.Drawing.Point(173, 107);
            this.LabelAverageDisplay.Name = "LabelAverageDisplay";
            this.LabelAverageDisplay.Size = new System.Drawing.Size(13, 13);
            this.LabelAverageDisplay.TabIndex = 4;
            this.LabelAverageDisplay.Text = "0";
            // 
            // LabelMaxDisplay
            // 
            this.LabelMaxDisplay.AutoSize = true;
            this.LabelMaxDisplay.Location = new System.Drawing.Point(173, 166);
            this.LabelMaxDisplay.Name = "LabelMaxDisplay";
            this.LabelMaxDisplay.Size = new System.Drawing.Size(13, 13);
            this.LabelMaxDisplay.TabIndex = 5;
            this.LabelMaxDisplay.Text = "0";
            // 
            // LabelMinDisplay
            // 
            this.LabelMinDisplay.AutoSize = true;
            this.LabelMinDisplay.Location = new System.Drawing.Point(173, 223);
            this.LabelMinDisplay.Name = "LabelMinDisplay";
            this.LabelMinDisplay.Size = new System.Drawing.Size(13, 13);
            this.LabelMinDisplay.TabIndex = 6;
            this.LabelMinDisplay.Text = "0";
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.Location = new System.Drawing.Point(112, 284);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(170, 23);
            this.ButtonRegister.TabIndex = 7;
            this.ButtonRegister.Text = "Register as Observer";
            this.ButtonRegister.UseVisualStyleBackColor = true;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Location = new System.Drawing.Point(112, 343);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(170, 23);
            this.ButtonRemove.TabIndex = 8;
            this.ButtonRemove.Text = "De-Register as Observer";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // WeatherStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ButtonRegister);
            this.Controls.Add(this.LabelMinDisplay);
            this.Controls.Add(this.LabelMaxDisplay);
            this.Controls.Add(this.LabelAverageDisplay);
            this.Controls.Add(this.LabelMinHeader);
            this.Controls.Add(this.LabelMaxHeader);
            this.Controls.Add(this.LabelAverageHeader);
            this.Controls.Add(this.LabelMainHeader);
            this.Name = "WeatherStatistics";
            this.Text = "WeatherStatistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelMainHeader;
        private System.Windows.Forms.Label LabelAverageHeader;
        private System.Windows.Forms.Label LabelMaxHeader;
        private System.Windows.Forms.Label LabelMinHeader;
        private System.Windows.Forms.Label LabelAverageDisplay;
        private System.Windows.Forms.Label LabelMaxDisplay;
        private System.Windows.Forms.Label LabelMinDisplay;
        private System.Windows.Forms.Button ButtonRegister;
        private System.Windows.Forms.Button ButtonRemove;
    }
}