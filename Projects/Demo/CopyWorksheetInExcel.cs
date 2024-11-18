using Spire.Xls;
namespace NPOI_ExcelDemo
{
    class CopyWorksheetInExcel
    {
        public void demo_CopyWorksheetInExcel(string input, string output)
        {
            Workbook book = new Workbook();
            book.LoadFromFile(input);
            Worksheet sheet = book.Worksheets[0];
            Worksheet sheet1 = book.Worksheets.Add("Copied 1");
            Worksheet sheet2 = book.Worksheets.Add("Copied 2");
            book.Worksheets[1].CopyFrom(book.Worksheets[0]);
            book.Worksheets[2].CopyFrom(book.Worksheets[0]);
            book.SaveToFile(output);
        }
    }
}
