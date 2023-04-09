namespace WeatherFeed
{
    partial class frmMain
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
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.lblEnterZipCode = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblLow = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblConditions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.Location = new System.Drawing.Point(254, 12);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(91, 27);
            this.btnGetWeather.TabIndex = 0;
            this.btnGetWeather.Text = "Get Weather";
            this.btnGetWeather.UseVisualStyleBackColor = true;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click);
            // 
            // lblEnterZipCode
            // 
            this.lblEnterZipCode.AutoSize = true;
            this.lblEnterZipCode.ForeColor = System.Drawing.Color.White;
            this.lblEnterZipCode.Location = new System.Drawing.Point(13, 15);
            this.lblEnterZipCode.Name = "lblEnterZipCode";
            this.lblEnterZipCode.Size = new System.Drawing.Size(81, 13);
            this.lblEnterZipCode.TabIndex = 1;
            this.lblEnterZipCode.Text = "Enter Zip Code:";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(101, 15);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(147, 20);
            this.txtZip.TabIndex = 2;
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLow.ForeColor = System.Drawing.Color.White;
            this.lblLow.Location = new System.Drawing.Point(16, 72);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(40, 24);
            this.lblLow.TabIndex = 3;
            this.lblLow.Text = "      ";
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblHigh.ForeColor = System.Drawing.Color.White;
            this.lblHigh.Location = new System.Drawing.Point(17, 118);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(40, 24);
            this.lblHigh.TabIndex = 4;
            this.lblHigh.Text = "      ";
            // 
            // lblConditions
            // 
            this.lblConditions.AutoSize = true;
            this.lblConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblConditions.ForeColor = System.Drawing.Color.White;
            this.lblConditions.Location = new System.Drawing.Point(17, 162);
            this.lblConditions.Name = "lblConditions";
            this.lblConditions.Size = new System.Drawing.Size(39, 20);
            this.lblConditions.TabIndex = 5;
            this.lblConditions.Text = "      ";
            this.lblConditions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnGetWeather;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(357, 281);
            this.Controls.Add(this.lblConditions);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.lblLow);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.lblEnterZipCode);
            this.Controls.Add(this.btnGetWeather);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Opacity = 0.95;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.Label lblEnterZipCode;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblConditions;
    }
}

