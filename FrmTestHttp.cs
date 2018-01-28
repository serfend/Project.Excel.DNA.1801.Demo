using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DotNet4.Utilities.UtilNet;
namespace Ribbon
{
	public partial class FrmTestHttp : Form
	{
		public FrmTestHttp()
		{

			InitializeComponent();
		}

		private void BtnNavigate_Click(object sender, EventArgs e)
		{
			HttpClient http = new HttpClient() { Item=new HttpItem() { URL =IpUrl.Text,Verb =HttpVerb.GET,UsedRandomAgent=true} };
			OpWebInfo.Text= http.GetString();
		}
	}
}
