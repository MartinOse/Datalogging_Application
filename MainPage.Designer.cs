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
            this.parametersInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chosenParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retrievingDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRetreivingDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.retrievingDataToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametersInfoToolStripMenuItem,
            this.chosenParametersToolStripMenuItem});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // parametersInfoToolStripMenuItem
            // 
            this.parametersInfoToolStripMenuItem.Name = "parametersInfoToolStripMenuItem";
            this.parametersInfoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.parametersInfoToolStripMenuItem.Text = "Parameters Info";
            this.parametersInfoToolStripMenuItem.Click += new System.EventHandler(this.parametersInfoToolStripMenuItem_Click);
            // 
            // chosenParametersToolStripMenuItem
            // 
            this.chosenParametersToolStripMenuItem.Name = "chosenParametersToolStripMenuItem";
            this.chosenParametersToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.chosenParametersToolStripMenuItem.Text = "Chosen Parameters";
            this.chosenParametersToolStripMenuItem.Click += new System.EventHandler(this.chosenParametersToolStripMenuItem_Click);
            // 
            // retrievingDataToolStripMenuItem
            // 
            this.retrievingDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openRetreivingDataToolStripMenuItem});
            this.retrievingDataToolStripMenuItem.Name = "retrievingDataToolStripMenuItem";
            this.retrievingDataToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.retrievingDataToolStripMenuItem.Text = "Retrieving Data";
            // 
            // openRetreivingDataToolStripMenuItem
            // 
            this.openRetreivingDataToolStripMenuItem.Name = "openRetreivingDataToolStripMenuItem";
            this.openRetreivingDataToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openRetreivingDataToolStripMenuItem.Text = "Open Retreiving Data";
            this.openRetreivingDataToolStripMenuItem.Click += new System.EventHandler(this.openRetreivingDataToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
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
        private System.Windows.Forms.ToolStripMenuItem parametersInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}