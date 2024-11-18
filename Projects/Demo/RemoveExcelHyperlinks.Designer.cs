namespace NPOI_ExcelDemo
{
    partial class RemoveExcelHyperlinks
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
            this.HyperlinksList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Read = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.Remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HyperlinksList
            // 
            this.HyperlinksList.FormattingEnabled = true;
            this.HyperlinksList.ItemHeight = 12;
            this.HyperlinksList.Location = new System.Drawing.Point(46, 44);
            this.HyperlinksList.Name = "HyperlinksList";
            this.HyperlinksList.Size = new System.Drawing.Size(254, 184);
            this.HyperlinksList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hyperlinks text:";
            // 
            // Read
            // 
            this.Read.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Read.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Read.Location = new System.Drawing.Point(374, 44);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(145, 25);
            this.Read.TabIndex = 3;
            this.Read.Text = "Read Hyperlinks";
            this.Read.UseVisualStyleBackColor = false;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(53, 204);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(101, 12);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Hyperlink Adress";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(374, 204);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(162, 16);
            this.checkBox.TabIndex = 6;
            this.checkBox.Text = "Remove  hyperlinks text";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // Remove
            // 
            this.Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Remove.Location = new System.Drawing.Point(374, 245);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(145, 25);
            this.Remove.TabIndex = 4;
            this.Remove.Text = "Remove Hylinks";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // RemoveExcelHyperlinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(576, 292);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HyperlinksList);
            this.Name = "RemoveExcelHyperlinks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveExcelHyperlinks";
            this.Load += new System.EventHandler(this.RemoveExcelHyperlinks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox HyperlinksList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button Remove;
    }
}