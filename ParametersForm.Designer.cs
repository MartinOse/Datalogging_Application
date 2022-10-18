namespace WeatherSystem_RestAPI
{
    partial class ParametersForm
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
            this.dgvParam = new System.Windows.Forms.DataGridView();
            this.btnAddParam = new System.Windows.Forms.Button();
            this.cbParam = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParam)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParam
            // 
            this.dgvParam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParam.Location = new System.Drawing.Point(13, 75);
            this.dgvParam.Name = "dgvParam";
            this.dgvParam.RowHeadersWidth = 51;
            this.dgvParam.RowTemplate.Height = 24;
            this.dgvParam.Size = new System.Drawing.Size(641, 363);
            this.dgvParam.TabIndex = 0;
            // 
            // btnAddParam
            // 
            this.btnAddParam.Location = new System.Drawing.Point(677, 116);
            this.btnAddParam.Name = "btnAddParam";
            this.btnAddParam.Size = new System.Drawing.Size(94, 34);
            this.btnAddParam.TabIndex = 1;
            this.btnAddParam.Text = "Add";
            this.btnAddParam.UseVisualStyleBackColor = true;
            this.btnAddParam.Click += new System.EventHandler(this.btnAddParam_Click);
            // 
            // cbParam
            // 
            this.cbParam.FormattingEnabled = true;
            this.cbParam.Items.AddRange(new object[] {
            "10 Min Gust Time",
            "10 Min Gust Wind Direction",
            "10 Min Gust Wind Speed",
            "10 Min Rolling Avg Wind Direction",
            "10 Min Rolling Avg Wind Speed",
            "10 Minute Gust Time:Sensor2",
            "10 Minute Gust Wind Direction:Sensor2",
            "10 Minute Gust Wind Speed:Sensor2",
            "10 Minute Rolling Average Wind Direction:Sensor2",
            "10 Minute Rolling Average Wind Speed:Sensor2",
            "2 Min Rolling Avg Wind Direction",
            "2 Min Rolling Avg Wind Speed",
            "2 Minute Rolling Average Wind Direction:Sensor2",
            "2 Minute Rolling Average Wind Speed:Sensor2",
            "3 Sec Rolling Avg Wind Direction",
            "3 Sec Rolling Avg Wind Speed",
            "3 Second Roll Avg Wind Speed:Sensor2",
            "3 Second Rolling Average Wind Direction:Sensor2",
            "60 Min Gust Time",
            "60 Min Gust Wind Direction",
            "60 Min Gust Wind Speed",
            "60 Minute Gust Time:Sensor2",
            "60 Minute Gust Wind Direction:Sensor2",
            "60 Minute Gust Wind Speed:Sensor2",
            "Absolute Humidity",
            "Adjusted Altitude",
            "Adjusted Barometric Pressure",
            "Adjusted Wind Direction",
            "Adjusted Wind Direction:Sensor2",
            "Air Density Ratio",
            "Altitude (feet):",
            "Altitude: ",
            "Average Temperature Today",
            "Barometric press. offset (in Hg):",
            "Bottom of Form",
            "Degree day reference temp. (°F):",
            "Degree Day Start",
            "Degree day start day (1-31):",
            "Degree day start month:",
            "Degree Days",
            "Density Altitude",
            "Dew Point",
            "Dry Air Density",
            "Dry Air Pressure",
            "Extinction Coefficient",
            "Hail Rate",
            "Hail Today",
            "Heat Index",
            "Latitude:",
            "Longitude:",
            "Lux",
            "Parameter Settings",
            "Pressure: ",
            "Rain Offsets:Edit rain offsets",
            "Rain Rate",
            "Rain this month",
            "Rain this week",
            "Rain this year",
            "Rain Today",
            "Rain: ",
            "Raw Barometric Pressure",
            "Raw Wind Direction",
            "Raw Wind Direction:Sensor2",
            "Relative Humidity",
            "SAE Correction Factor",
            "Saturated Vapor Pressure",
            "Solar Radiation",
            "Start of Day",
            "Start of Month",
            "Start of Week",
            "Start of Year",
            "Temperature 1",
            "Temperature 1 offset (°F):",
            "Temperature 2",
            "Temperature 3",
            "Temperature 4",
            "Temperature: ",
            "Top of Form",
            "True North Offset",
            "Vapor Pressure",
            "Visibility",
            "Visibility: ",
            "Wet Air Density",
            "Wet Bulb Globe Temperature",
            "Wet Bulb Temperature",
            "Wind Chill",
            "Wind Speed",
            "Wind Speed: ",
            "Wind Speed:Sensor2"});
            this.cbParam.Location = new System.Drawing.Point(12, 28);
            this.cbParam.Name = "cbParam";
            this.cbParam.Size = new System.Drawing.Size(475, 24);
            this.cbParam.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(677, 267);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 33);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(677, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(677, 398);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 31);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Parameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbParam);
            this.Controls.Add(this.btnAddParam);
            this.Controls.Add(this.dgvParam);
            this.Name = "Parameters";
            this.Text = "Parameters";
            this.Load += new System.EventHandler(this.Parameters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParam;
        private System.Windows.Forms.Button btnAddParam;
        private System.Windows.Forms.ComboBox cbParam;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClose;
    }
}