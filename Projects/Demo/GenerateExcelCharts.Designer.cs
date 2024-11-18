namespace NPOI_ExcelDemo
{
    partial class ExcelCharts
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
            this.chartDataView = new System.Windows.Forms.DataGridView();
            this.Generate = new System.Windows.Forms.Button();
            this.ChartStyle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDataView
            // 
            this.chartDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chartDataView.Location = new System.Drawing.Point(33, 50);
            this.chartDataView.Name = "chartDataView";
            this.chartDataView.RowTemplate.Height = 23;
            this.chartDataView.Size = new System.Drawing.Size(345, 184);
            this.chartDataView.TabIndex = 0;
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Generate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Generate.Location = new System.Drawing.Point(415, 246);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(134, 25);
            this.Generate.TabIndex = 1;
            this.Generate.Text = "Generate Excel Chart";
            this.Generate.UseVisualStyleBackColor = false;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // ChartStyle
            // 
            this.ChartStyle.CausesValidation = false;
            this.ChartStyle.FormattingEnabled = true;
            this.ChartStyle.Location = new System.Drawing.Point(415, 50);
            this.ChartStyle.Name = "ChartStyle";
            this.ChartStyle.Size = new System.Drawing.Size(134, 20);
            this.ChartStyle.TabIndex = 2;
            this.ChartStyle.SelectedIndexChanged += new System.EventHandler(this.ChartStyle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chart type list:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chart Data:";
            // 
            // ExcelCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(584, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChartStyle);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.chartDataView);
            this.Name = "ExcelCharts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExcelCharts";
            this.Load += new System.EventHandler(this.ExcelCharts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView chartDataView;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.ComboBox ChartStyle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}