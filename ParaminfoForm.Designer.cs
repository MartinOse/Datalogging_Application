namespace WeatherSystem_RestAPI
{
    partial class ParaminfoForm
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
            this.paraminfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvParaminfo = new System.Windows.Forms.DataGridView();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paraminfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParaminfo)).BeginInit();
            this.SuspendLayout();
            // 
            // paraminfoBindingSource
            // 
            this.paraminfoBindingSource.DataMember = "Param_info";
            // 
            // dgvParaminfo
            // 
            this.dgvParaminfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParaminfo.Location = new System.Drawing.Point(12, 12);
            this.dgvParaminfo.Name = "dgvParaminfo";
            this.dgvParaminfo.Size = new System.Drawing.Size(690, 346);
            this.dgvParaminfo.TabIndex = 2;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Navy;
            this.btn_close.Location = new System.Drawing.Point(632, 364);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 30);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // ParaminfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 400);
            this.Controls.Add(this.dgvParaminfo);
            this.Controls.Add(this.btn_close);
            this.Name = "ParaminfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Param_info";
            this.Load += new System.EventHandler(this.Param_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paraminfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParaminfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //private WeatherSystemDataSet weatherSystemDataSet;
        private System.Windows.Forms.BindingSource paraminfoBindingSource;
        //private WeatherSystemDataSetTableAdapters.Param_infoTableAdapter param_infoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameParamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitParamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvParaminfo;
        private System.Windows.Forms.Button btn_close;
    }
}