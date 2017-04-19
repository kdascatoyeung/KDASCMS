using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*

namespace KDTHK_SYS_MAN_CONSOLE.utils
{
    class CustomUtil
    {
        public class ImportExcel2007
        {
            private Workbook excel;

            public ImportExcel2007(string filePath)
            {
                this.excel = new Workbook(filePath);
            }

            public ImportExcel2007(System.IO.Stream stream)
            {
                this.excel = new Workbook(stream);
            }

            protected DataTable SaveToDataTable(Worksheet sheet)
            {
                DataTable dataTable = new DataTable();
                uint firstRow = sheet.get_CellMap().get_FirstRow();
                uint lastRow = sheet.get_CellMap().get_LastRow();
                Row row = sheet.GetRow(firstRow);
                uint firstCol = sheet.get_CellMap().get_FirstCol();
                uint lastCol = sheet.get_CellMap().get_LastCol();
                for (uint num = firstCol; num <= lastCol; num += 1u)
                {
                    string columnName = (row.GetCell(num).GetFormattedValue() == "*") ? ("*" + num) : row.GetCell(num).GetFormattedValue();
                    dataTable.Columns.Add(columnName);
                }
                for (uint num2 = firstRow + 1u; num2 <= lastRow; num2 += 1u)
                {
                    Row row2 = sheet.GetRow(num2);
                    if (row2 != null)
                    {
                        DataRow dataRow = dataTable.NewRow();
                        for (uint num3 = firstCol; num3 <= lastCol; num3 += 1u)
                        {
                            ICell cell = row2.GetCell(num3);
                            if (cell != null)
                            {
                                dataRow[System.Convert.ToInt32(num3)] = ((cell.get_Value() != null) ? cell.get_Value().ToString() : string.Empty);
                            }
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                }
                return dataTable;
            }

            public DataTable toDataTable(int index)
            {
                Worksheet worksheet = this.excel.GetWorksheet(0);
                if (worksheet == null)
                {
                    throw new System.ApplicationException(string.Format("Index: {0} does not exist", index));
                }
                return this.SaveToDataTable(worksheet);
            }

            public DataTable toDataTable(string sheetName)
            {
                Worksheet worksheetByName = this.excel.GetWorksheetByName(sheetName);
                if (worksheetByName == null)
                {
                    throw new System.ApplicationException(string.Format("Name: {0} does not exist", sheetName));
                }
                return this.SaveToDataTable(worksheetByName);
            }

            public static System.DateTime ParseDateTime(string cellValue)
            {
                System.DateTime result = default(System.DateTime);
                double d = 0.0;
                if (double.TryParse(cellValue, out d))
                {
                    result = System.DateTime.FromOADate(d);
                }
                else
                {
                    System.DateTime.TryParse(cellValue, out result);
                }
                return result;
            }

            public static DataTable TranslateToTable(string filePath, string sheetName)
            {
                ImportExcel2007 importExcel = new ImportExcel2007(filePath);
                return importExcel.toDataTable(sheetName);
            }

            public static DataTable TranslateToTable(string filePath, int sheetIndex)
            {
                ImportExcel2007 importExcel = new ImportExcel2007(filePath);
                return importExcel.toDataTable(sheetIndex);
            }

            public static DataTable TranslateToTable(string filePath)
            {
                ImportExcel2007 importExcel = new ImportExcel2007(filePath);
                return importExcel.toDataTable(0);
            }

            public static DataTable TranslateToTable(System.IO.Stream stream, string sheetName)
            {
                ImportExcel2007 importExcel = new ImportExcel2007(stream);
                return importExcel.toDataTable(sheetName);
            }

            public static DataTable TranslateToTable(System.IO.Stream stream, int sheetIndex)
            {
                ImportExcel2007 importExcel = new ImportExcel2007(stream);
                return importExcel.toDataTable(sheetIndex);
            }

            public static DataTable TranslateToTable(System.IO.Stream stream)
            {
                ImportExcel2007 importExcel = new ImportExcel2007(stream);
                return importExcel.toDataTable(0);
            }
        }
    }
}
*/