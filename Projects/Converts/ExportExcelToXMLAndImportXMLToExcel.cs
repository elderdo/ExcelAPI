using Spire.Xls;

namespace NPOI_ExcelDemo
{
    class ExportExcelToXMLAndImportXMLToExcel
    {
        public void demo_ExportExcelToXml(string input, string output)
        {
            Workbook book = new Workbook();
            book.LoadFromFile(input);
            book.SaveAsXml(output);
        }
        public void Demo_ImportXMLToExcel(string input, string output)
        {
            Workbook book = new Workbook();
            book.LoadFromXml(input);
            book.SaveToFile(output);
        }
    }
}
