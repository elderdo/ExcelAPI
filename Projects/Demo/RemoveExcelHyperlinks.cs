using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Spire.Xls;
using System.IO;

namespace NPOI_ExcelDemo
{
    public partial class RemoveExcelHyperlinks : Form
    {
        public RemoveExcelHyperlinks()
        {
            InitializeComponent();
        }
        static Workbook book = new Workbook();

        static Worksheet sheet;
        private void Read_Click(object sender, EventArgs e)
        {
            sheet = book.Worksheets[0];
            HyperlinksList.SuspendLayout();
            int iHeight = 0;
            foreach (var item in sheet.HyperLinks)
            {
                LinkLabel LinkTo = new LinkLabel();
                LinkTo.Text = item.Name;
                LinkTo.Width = 200;
                LinkTo.Links.Add(0, sheet.HyperLinks.Count, item.Address);
                // Setting the display location in ListBox
                LinkTo.Location = new Point(0, iHeight * LinkTo.Height);
                LinkTo.Click += new EventHandler(LinkTo_Click);
                HyperlinksList.Controls.Add(LinkTo);
                iHeight++;
            }
            HyperlinksList.ResumeLayout();
        }
        void LinkTo_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "URL: " + (sender as LinkLabel).Links[0].LinkData.ToString();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            sheet = book.Worksheets[0];
            for (int i = 0; i < sheet.HyperLinks.Count; i++)
            {

                if (this.checkBox.Checked)
                {
                    sheet.HyperLinks[i].Range.Clear(ExcelClearOptions.ClearAll);
                }
                else
                    sheet.HyperLinks.RemoveAt(0);
            }
            this.Close();
            book.SaveToFile("result.xls", FileFormat.Version97to2003);
        }

        private void RemoveExcelHyperlinks_Load(object sender, EventArgs e)
        {
            book.LoadFromFile(@"..\..\ExcelDocument\HyperlinkSample.xls");
        }
    }
}
