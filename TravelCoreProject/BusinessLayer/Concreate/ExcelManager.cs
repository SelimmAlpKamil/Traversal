using BusinessLayer.Abstract;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class ExcelManager : IExcelService
    {
        public byte[] ExcelList<T>(List<T> t) where T : class
        {
            ExcelPackage package = new ExcelPackage();
            var excelSheeet = package.Workbook.Worksheets.Add("Sayfa1");

            excelSheeet.Cells["A1"].LoadFromCollection(t,true,OfficeOpenXml.Table.TableStyles.Dark10);

            return package.GetAsByteArray();



        }
    }
}
