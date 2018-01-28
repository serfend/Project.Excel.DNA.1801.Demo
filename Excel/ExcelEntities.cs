using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExcelDna.Integration;
using Microsoft.Office.Interop.Excel;
namespace Ribbon.Excel
{
	class ExcelEntities
	{
		public Application xlApp;
		public Workbook xlBook;
		public Worksheet xlSheet;
		public ExcelEntities()
		{
			xlApp = (Application)ExcelDnaUtil.Application;
			xlBook = xlApp.ActiveWorkbook;
			if (xlBook == null) return;
			xlSheet = xlBook.ActiveSheet;
		}
	}
}
