namespace WeatherSystem_RestAPI
{
    partial class Retrieving_Data
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
            this.txtRequestURL = new System.Windows.Forms.TextBox();
            this.lbURL = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.lbResponse = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtRequestURL
            // 
            this.txtRequestURL.Location = new System.Drawing.Point(197, 64);
            this.txtRequestURL.Name = "txtRequestURL";
            this.txtRequestURL.Size = new System.Drawing.Size(423, 22);
            this.txtRequestURL.TabIndex = 0;
            this.txtRequestURL.TextChanged += new System.EventHandler(this.txtRequestURL_TextChanged);
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Location = new System.Drawing.Point(61, 62);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(91, 16);
            this.lbURL.TabIndex = 1;
            this.lbURL.Text = "Request URL:";
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(197, 107);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(835, 316);
            this.txtResponse.TabIndex = 2;
            // 
            // lbResponse
            // 
            this.lbResponse.AutoSize = true;
            this.lbResponse.Location = new System.Drawing.Point(61, 107);
            this.lbResponse.Name = "lbResponse";
            this.lbResponse.Size = new System.Drawing.Size(69, 16);
            this.lbResponse.TabIndex = 4;
            this.lbResponse.Text = "Responsr:";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Retrieving_Data
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1118, 469);
            this.Controls.Add(this.lbResponse);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.lbURL);
            this.Controls.Add(this.txtRequestURL);
            this.Name = "Retrieving_Data";
            this.Text = "Retrieving Data From Weather Station";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRequestURL;
        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label lbResponse;
        private System.Windows.Forms.Timer timer1;
    }
}

