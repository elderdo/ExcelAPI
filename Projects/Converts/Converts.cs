using System.Text;
using Spire.Xls;


namespace NPOI_ExcelDemo
{
    class Converts
    {
        public void demo_Converts(string input, string format, string output)
        {
            Workbook book = new Workbook();
            book.LoadFromFile(input);
            ConvertFormat(book, format, output);
        }
        public void ConvertFormat(Workbook book, string format, string output)
        {
            switch (format)
            {
                case "PDF":
                    book.SaveToFile(output + ".pdf", FileFormat.PDF);
                    break;

                case "HTML":
                    int index = 0;
                    foreach (Worksheet sheet in book.Worksheets)
                    {
                        sheet.SaveToHtml(output + "_" + index.ToString() + ".htm");
                        index++;
                    }
                    break;

                case "TXT":
                    book.Worksheets[0].SaveToFile(output, " ", Encoding.UTF8);
                    break;


            }

        }
    }
}
