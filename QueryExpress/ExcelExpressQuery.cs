using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ribbon.QueryExpress
{
	class ExcelExpressQuery:Query.ExpressQuery
	{
		private Excel.ExcelEntities xl = new Excel.ExcelEntities();
		
		public void Run()
		{


			try
			{
				var queryNum = xl.xlSheet.UsedRange.Rows.Count;
				Task<string>[] tasks = new Task<string>[queryNum - 1];
				int[] tmpTarget = new int[queryNum];
				for (int i = 2; i <= queryNum; i++)
				{
					if (xl.xlSheet.Cells[i, 1].value is string thisLineInfo)
						if (thisLineInfo.Length > 0)
						{
							xl.xlSheet.Cells[i, 2].value = "加载中..." + thisLineInfo;
							tasks[i - 2] = new Task<string>(info => GetRelOfExpress((string)info), thisLineInfo);
							tmpTarget[i - 2] = i;
							tasks[i - 2].Start();
							tasks[i - 2].ContinueWith(t => xl.xlSheet.Cells[tmpTarget[i - 2], 2].value = t.Result);
						}
				}
				var frmCancel = new FrmCancel();
				frmCancel.ShowDialog();
				if (frmCancel.DialogResult == DialogResult.Cancel)
					return;
				else
					Thread.Sleep(1000);
			}
			catch (Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}
		public override string GetRelOfExpress(string id)
		{
			Thread.Sleep(new Random().Next(1000, 2000));
			return "正常的返回结果";
			if (id == null || id.Length == 0) return "";
			return base.GetRelOfExpress(id);
		}
	}
}
