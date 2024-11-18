using Spire.Xls;
namespace NPOI_ExcelDemo
{
    class CreatePivotTable
    {
        public void demo_CreatePivotTableInExcel(string filePath, string resultFilePath)
        {
            Workbook workbook = new Workbook();
            workbook = CreatePivotTableInExcel(filePath);
            workbook.SaveToFile(resultFilePath);
        }

        public Workbook CreatePivotTableInExcel(string filePath)
        {
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(filePath);
            Worksheet sheet = workbook.Worksheets[0];
            sheet.Name = "Data Source";
            Worksheet sheet2 = workbook.CreateEmptySheet();
            sheet2.Name = "Pivot Table";

            CellRange dataRange = sheet.Range["A1:G17"];
            PivotCache cache = workbook.PivotCaches.Add(dataRange);
            PivotTable pt = sheet2.PivotTables.Add("Pivot Table", sheet.Range["A1"], cache);

            var r1 = pt.PivotFields["Vendor No"];
            r1.Axis = AxisTypes.Row;
            pt.Options.RowHeaderCaption = "Vendor No";

            var r2 = pt.PivotFields["Name"];
            r2.Axis = AxisTypes.Row;


            pt.DataFields.Add(pt.PivotFields["Area"], "Average of Area", SubtotalTypes.Average);
            pt.DataFields.Add(pt.PivotFields["Sales"], "SUM of Sales", SubtotalTypes.Sum);
            pt.DataFields.Add(pt.PivotFields["OnHand"], "Max of OnHand", SubtotalTypes.Max);
            pt.DataFields.Add(pt.PivotFields["OnOrder"], "Min of OnOrder", SubtotalTypes.Min);
            pt.BuiltInStyle = PivotBuiltInStyles.PivotStyleMedium12;
            workbook.Worksheets[1].Remove();
            sheet = workbook.Worksheets[1];
            sheet.Columns[0].AutoFitColumns();
            sheet.Columns[0].AutoFitRows();
            sheet.AllocatedRange.AutoFitColumns();
            sheet.AllocatedRange.AutoFitRows();
            return workbook;

        }
    }
}
