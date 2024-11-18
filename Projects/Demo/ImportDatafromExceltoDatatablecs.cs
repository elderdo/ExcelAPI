using System;
using System.Data;
using System.Windows.Forms;
using Spire.Xls;


namespace NPOI_ExcelDemo
{
    public partial class ImportDatafromExceltoDatatablecs : Form
    {
        public ImportDatafromExceltoDatatablecs()
        {
            InitializeComponent();
        }

        private void ImportDataToDatatable_Click(object sender, EventArgs e)
        {
            Workbook book = new Workbook();
            book.LoadFromFile(@"..\..\ExcelDocument\DatatableSample.xlsx");
            Worksheet sheet = book.Worksheets[0];
            DataTable table = sheet.ExportDataTable();
            this.dataGridView.DataSource = table;

        }
    }
}
