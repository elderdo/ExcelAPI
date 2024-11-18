using Spire.Xls;
using System.Drawing.Imaging;
namespace NPOI_ExcelDemo
{
    class SaveExcelAsImage
    {
        public void demo_SaveAsImage(string input, string output)
        {
            Workbook book = new Workbook();
            book.LoadFromFile(input);
            int index = 0;
            book.ConverterSetting.SheetFitToPage = true;
            foreach (Worksheet sheet in book.Worksheets)
            {
                if (sheet.IsEmpty != true)
                {
                    sheet.SaveToImage(output + "_" + index.ToString() + ".png", ImageFormat.Png);

                    index++;
                }
            }

        }
    }
}