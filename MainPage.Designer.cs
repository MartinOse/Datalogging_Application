namespace WeatherSystem_RestAPI
{
    partial class MainPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chosenParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retrievingDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRetreivingDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutWeatherSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.retrievingDataToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chosenParametersToolStripMenuItem});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // chosenParametersToolStripMenuItem
            // 
            this.chosenParametersToolStripMenuItem.Name = "chosenParametersToolStripMenuItem";
            this.chosenParametersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.chosenParametersToolStripMenuItem.Text = "Chosen Parameters";
            this.chosenParametersToolStripMenuItem.Click += new System.EventHandler(this.chosenParametersToolStripMenuItem_Click);
            // 
            // retrievingDataToolStripMenuItem
            // 
            this.retrievingDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openRetreivingDataToolStripMenuItem});
            this.retrievingDataToolStripMenuItem.Name = "retrievingDataToolStripMenuItem";
            this.retrievingDataToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.retrievingDataToolStripMenuItem.Text = "Retrieving Data";
            // 
            // openRetreivingDataToolStripMenuItem
            // 
            this.openRetreivingDataToolStripMenuItem.Name = "openRetreivingDataToolStripMenuItem";
            this.openRetreivingDataToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.openRetreivingDataToolStripMenuItem.Text = "Open Retreiving Data";
            this.openRetreivingDataToolStripMenuItem.Click += new System.EventHandler(this.openRetreivingDataToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutWeatherSystemToolStripMenuItem,
            this.contactUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutWeatherSystemToolStripMenuItem
            // 
            this.aboutWeatherSystemToolStripMenuItem.Name = "aboutWeatherSystemToolStripMenuItem";
            this.aboutWeatherSystemToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.aboutWeatherSystemToolStripMenuItem.Text = "About Weather System";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.contactUsToolStripMenuItem.Text = "Contact Us";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chosenParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retrievingDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRetreivingDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutWeatherSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
    }
}