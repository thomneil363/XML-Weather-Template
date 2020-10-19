namespace XMLWeather
{
    partial class ForecastScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForecastScreen));
            this.forecastLabel = new System.Windows.Forms.Label();
            this.forecastLabel2 = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.date3 = new System.Windows.Forms.Label();
            this.date7 = new System.Windows.Forms.Label();
            this.date5 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.date4 = new System.Windows.Forms.Label();
            this.date6 = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.backgroundBox = new System.Windows.Forms.Label();
            this.avgLabel = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.windLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Niagara Solid", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(1, 55);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(333, 34);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // forecastLabel2
            // 
            this.forecastLabel2.BackColor = System.Drawing.Color.White;
            this.forecastLabel2.Font = new System.Drawing.Font("Niagara Solid", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel2.ForeColor = System.Drawing.Color.SteelBlue;
            this.forecastLabel2.Location = new System.Drawing.Point(0, 12);
            this.forecastLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel2.Name = "forecastLabel2";
            this.forecastLabel2.Size = new System.Drawing.Size(333, 34);
            this.forecastLabel2.TabIndex = 61;
            this.forecastLabel2.Text = "Today\'s Forecast";
            this.forecastLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.forecastLabel2.Click += new System.EventHandler(this.forecastLabel2_Click);
            // 
            // minLabel
            // 
            this.minLabel.BackColor = System.Drawing.Color.White;
            this.minLabel.Font = new System.Drawing.Font("Niagara Solid", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.minLabel.Location = new System.Drawing.Point(18, 268);
            this.minLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(177, 28);
            this.minLabel.TabIndex = 46;
            this.minLabel.Text = "Min Temperature";
            this.minLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maxLabel
            // 
            this.maxLabel.BackColor = System.Drawing.Color.White;
            this.maxLabel.Font = new System.Drawing.Font("Niagara Solid", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.maxLabel.Location = new System.Drawing.Point(18, 241);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(177, 27);
            this.maxLabel.TabIndex = 44;
            this.maxLabel.Text = "Max Temperature";
            this.maxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // date1
            // 
            this.date1.BackColor = System.Drawing.Color.White;
            this.date1.Font = new System.Drawing.Font("Niagara Solid", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.ForeColor = System.Drawing.Color.SteelBlue;
            this.date1.Location = new System.Drawing.Point(18, 168);
            this.date1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(100, 30);
            this.date1.TabIndex = 64;
            this.date1.Text = "Date";
            // 
            // date3
            // 
            this.date3.BackColor = System.Drawing.Color.White;
            this.date3.Font = new System.Drawing.Font("Niagara Solid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date3.ForeColor = System.Drawing.Color.SteelBlue;
            this.date3.Location = new System.Drawing.Point(172, 349);
            this.date3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(156, 24);
            this.date3.TabIndex = 69;
            this.date3.Text = "Date";
            this.date3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.date3.Click += new System.EventHandler(this.Date3_Click);
            // 
            // date7
            // 
            this.date7.BackColor = System.Drawing.Color.White;
            this.date7.Font = new System.Drawing.Font("Niagara Solid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date7.ForeColor = System.Drawing.Color.SteelBlue;
            this.date7.Location = new System.Drawing.Point(172, 426);
            this.date7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date7.Name = "date7";
            this.date7.Size = new System.Drawing.Size(155, 24);
            this.date7.TabIndex = 79;
            this.date7.Text = "Date";
            this.date7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.date7.Click += new System.EventHandler(this.Date7_Click);
            // 
            // date5
            // 
            this.date5.BackColor = System.Drawing.Color.White;
            this.date5.Font = new System.Drawing.Font("Niagara Solid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date5.ForeColor = System.Drawing.Color.SteelBlue;
            this.date5.Location = new System.Drawing.Point(172, 388);
            this.date5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date5.Name = "date5";
            this.date5.Size = new System.Drawing.Size(155, 24);
            this.date5.TabIndex = 74;
            this.date5.Text = "Date";
            this.date5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.date5.Click += new System.EventHandler(this.Date5_Click);
            // 
            // date2
            // 
            this.date2.BackColor = System.Drawing.Color.White;
            this.date2.Font = new System.Drawing.Font("Niagara Solid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.ForeColor = System.Drawing.Color.SteelBlue;
            this.date2.Location = new System.Drawing.Point(4, 349);
            this.date2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(156, 24);
            this.date2.TabIndex = 84;
            this.date2.Text = "Date";
            this.date2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.date2.Click += new System.EventHandler(this.Date2_Click);
            // 
            // date4
            // 
            this.date4.BackColor = System.Drawing.Color.White;
            this.date4.Font = new System.Drawing.Font("Niagara Solid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date4.ForeColor = System.Drawing.Color.SteelBlue;
            this.date4.Location = new System.Drawing.Point(4, 388);
            this.date4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date4.Name = "date4";
            this.date4.Size = new System.Drawing.Size(156, 24);
            this.date4.TabIndex = 89;
            this.date4.Text = "Date";
            this.date4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.date4.Click += new System.EventHandler(this.Date4_Click);
            // 
            // date6
            // 
            this.date6.BackColor = System.Drawing.Color.White;
            this.date6.Font = new System.Drawing.Font("Niagara Solid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date6.ForeColor = System.Drawing.Color.SteelBlue;
            this.date6.Location = new System.Drawing.Point(3, 426);
            this.date6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date6.Name = "date6";
            this.date6.Size = new System.Drawing.Size(156, 24);
            this.date6.TabIndex = 94;
            this.date6.Text = "Date";
            this.date6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.date6.Click += new System.EventHandler(this.Date6_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Niagara Solid", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(1, 123);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(333, 23);
            this.descriptionLabel.TabIndex = 95;
            this.descriptionLabel.Text = "Click on a date for a detailed view!";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundBox
            // 
            this.backgroundBox.BackColor = System.Drawing.Color.White;
            this.backgroundBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.backgroundBox.ForeColor = System.Drawing.Color.Transparent;
            this.backgroundBox.Location = new System.Drawing.Point(6, 158);
            this.backgroundBox.Name = "backgroundBox";
            this.backgroundBox.Size = new System.Drawing.Size(321, 158);
            this.backgroundBox.TabIndex = 1;
            this.backgroundBox.Text = "label1";
            this.backgroundBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // avgLabel
            // 
            this.avgLabel.BackColor = System.Drawing.Color.White;
            this.avgLabel.Font = new System.Drawing.Font("Niagara Solid", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.avgLabel.Location = new System.Drawing.Point(144, 168);
            this.avgLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.avgLabel.Name = "avgLabel";
            this.avgLabel.Size = new System.Drawing.Size(173, 33);
            this.avgLabel.TabIndex = 96;
            this.avgLabel.Text = "Average Temperature";
            this.avgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.White;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(29, 100);
            this.currentOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(279, 10);
            this.currentOutput.TabIndex = 97;
            // 
            // windLabel
            // 
            this.windLabel.BackColor = System.Drawing.Color.White;
            this.windLabel.Font = new System.Drawing.Font("Niagara Solid", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.windLabel.Location = new System.Drawing.Point(18, 214);
            this.windLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(177, 27);
            this.windLabel.TabIndex = 98;
            this.windLabel.Text = "Wind Speed";
            this.windLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(217, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.windLabel);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.avgLabel);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.date6);
            this.Controls.Add(this.date4);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date7);
            this.Controls.Add(this.date5);
            this.Controls.Add(this.date3);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.forecastLabel2);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.backgroundBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(333, 492);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label forecastLabel2;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label date3;
        private System.Windows.Forms.Label date7;
        private System.Windows.Forms.Label date5;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label date4;
        private System.Windows.Forms.Label date6;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label backgroundBox;
        private System.Windows.Forms.Label avgLabel;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
