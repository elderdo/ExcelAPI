namespace NPOI_ExcelDemo
{
    partial class ImportDatafromExceltoDatatablecs
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
            this.ImportDataToDatatable = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ImportDataToDatatable
            // 
            this.ImportDataToDatatable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ImportDataToDatatable.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ImportDataToDatatable.Location = new System.Drawing.Point(192, 266);
            this.ImportDataToDatatable.Name = "ImportDataToDatatable";
            this.ImportDataToDatatable.Size = new System.Drawing.Size(176, 25);
            this.ImportDataToDatatable.TabIndex = 0;
            this.ImportDataToDatatable.Text = "Import Data to Datatable";
            this.ImportDataToDatatable.UseVisualStyleBackColor = true;
            this.ImportDataToDatatable.Click += new System.EventHandler(this.ImportDataToDatatable_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 43);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(560, 208);
            this.dataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datatable Data:";
            // 
            // ImportDatafromExceltoDatatablecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.ImportDataToDatatable);
            this.Name = "ImportDatafromExceltoDatatablecs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportDatafromExceltoDatatablecs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImportDataToDatatable;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
    }
}