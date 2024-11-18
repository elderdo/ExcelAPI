using System;
using System.Data;
using System.Windows.Forms;
using Spire.Xls;
namespace NPOI_ExcelDemo
{
    public partial class ExcelCharts : Form
    {
        public ExcelCharts()
        {
            InitializeComponent();
        }

        private void ExcelCharts_Load(object sender, EventArgs e)
        {
            foreach (ExcelChartType type in Enum.GetValues(typeof(ExcelChartType)))
            {
                this.ChartStyle.Items.Add(type.ToString());
            }
            this.ChartStyle.SelectedText = "Area3D";
            Workbook book = new Workbook();
            book.LoadFromFile(@"..\..\ExcelDocument\ChartData.xlsx");
            this.chartDataView.DataSource = book.Worksheets[0].ExportDataTable();

        }

        private void Generate_Click(object sender, EventArgs e)
        {
            Workbook book = new Workbook();
            Worksheet sheet = book.Worksheets[0];
            DataTable table = this.chartDataView.DataSource as DataTable;
            sheet.InsertDataTable(table, true, 1, 1);
            SetChart(sheet);
            sheetStyle(book, sheet);
            book.SaveToFile(@"..\..\ResultFiles\" + this.ChartStyle.Text.ToString() + ".xls");
            Close();
        }
        private void SetChart(Worksheet sheet)
        {
            sheet.Name = "Chart data";
            sheet.GridLinesVisible = false;

            ExcelChartType chartFormat = (ExcelChartType)Enum.Parse(typeof(ExcelChartType), this.ChartStyle.Text.ToString());
            //Writes chart data
            //CreateChartData(sheet);
            //Add a new  chart worsheet to workbook
            Chart chart = sheet.Charts.Add();

            //Set region of chart data

            chart.DataRange = sheet.Range["A1:C7"];
            chart.SeriesDataFromRange = false;

            //Set position of chart
            chart.LeftColumn = 1;
            chart.TopRow = 8;
            chart.RightColumn = 11;
            chart.BottomRow = 29;
            chart.ChartType = chartFormat;


            //Chart title
            chart.ChartTitle = "Sales market by country";
            chart.ChartTitleArea.IsBold = true;
            chart.ChartTitleArea.Size = 12;

            chart.PrimaryCategoryAxis.Title = "Country";
            chart.PrimaryCategoryAxis.Font.IsBold = true;
            chart.PrimaryCategoryAxis.TitleArea.IsBold = true;

            chart.PrimaryValueAxis.Title = "Sales(in Dollars)";
            chart.PrimaryValueAxis.HasMajorGridLines = false;
            chart.PrimaryValueAxis.TitleArea.TextRotationAngle = 90;
            chart.PrimaryValueAxis.MinValue = 1000;
            chart.PrimaryValueAxis.TitleArea.IsBold = true;


            foreach (Spire.Xls.Charts.ChartSerie cs in chart.Series)
            {
                cs.Format.Options.IsVaryColor = true;
                cs.DataPoints.DefaultDataPoint.DataLabels.HasValue = true;
            }

            chart.Legend.Position = LegendPositionType.Top;

        }
        public static void sheetStyle(Workbook book, Worksheet sheet)
        {
            CellStyle oddStyle = book.Styles.Add("oddStyle");
            oddStyle.Borders[BordersLineType.EdgeLeft].LineStyle = LineStyleType.Thin;
            oddStyle.Borders[BordersLineType.EdgeRight].LineStyle = LineStyleType.Thin;
            oddStyle.Borders[BordersLineType.EdgeTop].LineStyle = LineStyleType.Thin;
            oddStyle.Borders[BordersLineType.EdgeBottom].LineStyle = LineStyleType.Thin;
            oddStyle.KnownColor = ExcelColors.LightGreen1;

            CellStyle evenStyle = book.Styles.Add("evenStyle");
            evenStyle.Borders[BordersLineType.EdgeLeft].LineStyle = LineStyleType.Thin;
            evenStyle.Borders[BordersLineType.EdgeRight].LineStyle = LineStyleType.Thin;
            evenStyle.Borders[BordersLineType.EdgeTop].LineStyle = LineStyleType.Thin;
            evenStyle.Borders[BordersLineType.EdgeBottom].LineStyle = LineStyleType.Thin;
            evenStyle.KnownColor = ExcelColors.LightTurquoise;


            foreach (CellRange range in sheet.AllocatedRange.Rows)
            {
                if (range.Row % 2 == 0)
                    range.CellStyleName = evenStyle.Name;
                else
                    range.CellStyleName = oddStyle.Name;
            }

            //Sets header style
            CellStyle styleHeader = sheet.Rows[0].Style;
            styleHeader.Borders[BordersLineType.EdgeLeft].LineStyle = LineStyleType.Thin;
            styleHeader.Borders[BordersLineType.EdgeRight].LineStyle = LineStyleType.Thin;
            styleHeader.Borders[BordersLineType.EdgeTop].LineStyle = LineStyleType.Thin;
            styleHeader.Borders[BordersLineType.EdgeBottom].LineStyle = LineStyleType.Thin;
            styleHeader.VerticalAlignment = VerticalAlignType.Center;
            styleHeader.KnownColor = ExcelColors.Green;
            styleHeader.Font.KnownColor = ExcelColors.White;
            styleHeader.Font.IsBold = true;

            sheet.Columns[sheet.AllocatedRange.LastColumn - 1].Style.NumberFormat = "\"$\"#,##0";
            sheet.Columns[sheet.AllocatedRange.LastColumn - 2].Style.NumberFormat = "\"$\"#,##0";

            sheet.AllocatedRange.AutoFitColumns();
            sheet.AllocatedRange.AutoFitRows();

            sheet.Rows[0].RowHeight = 20;
        }

        private void ChartStyle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
