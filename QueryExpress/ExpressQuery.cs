using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotNet4.Utilities.UtilNet;
using DotNet4.Utilities.UtilCode;
namespace Ribbon.Query
{
	class ExpressQuery
	{
		//ps:快递公司编码:申通="shentong" EMS="ems" 顺丰="shunfeng" 圆通="yuantong" 中通="zhongtong" 韵达="yunda" 天天="tiantian" 汇通="huitongkuaidi" 全峰="quanfengkuaidi" 德邦="debangwuliu" 宅急送="zhaijisong"
		private string[] CompanyName ={
				"顺丰","申通","圆通","中通","韵达","EMS","汇通","天天","德邦","宅急送","全峰"
			};

		internal void GetRelOfExpress(object info)
		{
			throw new NotImplementedException();
		}

		private string[] CompanyId ={
				"shunfeng","shentong","yuantong","zhongtong","yunda","ems","huitongkuaidi","tiantian","debangwuliu","zhaijisong","quanfengkuaidi"
			};
		public virtual  string GetRelOfExpress(string id)
		{
			if (id == "") return "";
			var http = new HttpClient(); 
			string rels = null;
			int i;
			for (i = 0; i < CompanyId.Length; i++)
			{
				HttpItem tmpItem = new HttpItem() { URL = string.Format("http://www.kuaidi100.com/query?type={0}&postid={1}", CompanyId[i], id),UsedRandomAgent=true };
				rels = http.GetString(tmpItem);
				if (!rels.Contains("参数错误") && !rels.Contains("参数异常")) continue;
			}
			if (i >= CompanyId.Length) return "Exception.Messages:" + rels;// HttpUtil.GetElement(rels, "message\":\"", "\", ");

			string[] st = new string[] { "ftime\"" };
			string[] tmp = rels.Split(st, StringSplitOptions.RemoveEmptyEntries);
			string[] dateInfo = tmp;
			string b = HttpUtil.GetElement(tmp[1], "context\":\"", "\"");
			for (int j = 1; j < tmp.Length; j++)
			{
				dateInfo[j] = HttpUtil.GetElement(tmp[j], "\"", "\"");
			}

			rels = string.Format("{0}${1}${2}", dateInfo[1], b, dateInfo[dateInfo.Length - 1]);

			return string.Format("{0}${1}", CompanyName[i], rels);
		}

	}
}
