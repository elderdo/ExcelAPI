using Spire.Xls;
using System.Data;
namespace NPOI_ExcelDemo
{
    class MergeExceFilesIntoOne
    {
        public void demo_MergeExceFilesIntoOne(string input1, string input2, string input3, string output)
        {
            Workbook book = new Workbook();
            book.LoadFromFile(input1);

            Workbook book2 = new Workbook();
            book2.LoadFromFile(input2);
            DataTable table2 = book2.Worksheets[0].ExportDataTable();

            Workbook book3 = new Workbook();
            book3.LoadFromFile(input3);
            DataTable table3 = book3.Worksheets[0].ExportDataTable();

            Worksheet sheet2 = book.CreateEmptySheet();
            sheet2.InsertDataTable(table2, true, 1, 1);
            Worksheet sheet3 = book.CreateEmptySheet();
            sheet3.InsertDataTable(table3, true, 1, 1);

            book.SaveToFile(output);

        }
    }
}
