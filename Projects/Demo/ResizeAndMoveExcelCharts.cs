using Spire.Xls;

namespace NPOI_ExcelDemo
{
    class ResizeAndMoveExcelCharts
    {
        public void demo_ResizeAndMoveExcelCharts(string input, string output)
        {
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(input);
            Worksheet sheet = workbook.Worksheets[0];
            Chart chart = sheet.Charts[0];
            chart.LeftColumn = 1;
            chart.TopRow = 7;
            chart.Width = 400;
            chart.Height = 250;
            workbook.SaveToFile(output);
        }

    }
}
