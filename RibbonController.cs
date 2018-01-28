using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ExcelDna.Integration.CustomUI;
using ExcelDna.Integration.Extensibility;
using System.Reflection;
namespace Ribbon
{
    [ComVisible(true)]
    public class RibbonController : ExcelRibbon
    {
		public override void RunTagMacro(IRibbonControl control)
		{
			//MessageBox.Show(MethodBase.GetCurrentMethod().Name);
			base.RunTagMacro(control);
		}
		public override void OnStartupComplete(ref Array custom)
		{
			//MessageBox.Show(MethodBase.GetCurrentMethod().Name);
			base.OnStartupComplete(ref custom);
		}
		public override void OnDisconnection(ext_DisconnectMode RemoveMode, ref Array custom)
		{
			//MessageBox.Show(MethodBase.GetCurrentMethod().Name);
			base.OnDisconnection(RemoveMode, ref custom);
		}
		public override void OnBeginShutdown(ref Array custom)
		{
			//MessageBox.Show(MethodBase.GetCurrentMethod().Name);
			base.OnBeginShutdown(ref custom);
		}
		public override object LoadImage(string imageId)
		{
			//MessageBox.Show(MethodBase.GetCurrentMethod().Name);
			return base.LoadImage(imageId);
		}
		public override void OnAddInsUpdate(ref Array custom)
		{
			//MessageBox.Show(MethodBase.GetCurrentMethod().Name);
			base.OnAddInsUpdate(ref custom);
		}
		public override string GetCustomUI(string RibbonID)
        {
			//MessageBox.Show(MethodBase.GetCurrentMethod().Name);
			//try
			//{
			//	System.Windows.Forms.Application.EnableVisualStyles();
			//	System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			//}
			//catch (Exception ex)
			//{

			//	MessageBox.Show(ex.Message);
			//}
			return @"
      <customUI xmlns='http://schemas.microsoft.com/office/2006/01/customui'>
      <ribbon>
        <tabs>
          <tab id='Tabffddg' label='aserfend'>
            <group id='GrpTest' label='测试'>
				<button id='btnTest' label='激活' onAction='OnBtnTest'/>
				<button id='btnTestHttp' label='网页' onAction='OnBtnTestHttp'/>
				<button id='BtnQueryExpress' label='查询快递' onAction='OnBtnQueryExpress'/>
            </group >
			<group id='GrpAbout' label='关于'>
				<button id='btnShowAbout' label='关于' onAction='OnBtnShowAbout'/>
			</group>
          </tab>
        </tabs>
      </ribbon>
    </customUI>";
        }
		public override void OnConnection(object Application, ext_ConnectMode ConnectMode, object AddInInst, ref Array custom)
		{
			//MessageBox.Show(MethodBase.GetCurrentMethod().Name);
			base.OnConnection(Application, ConnectMode, AddInInst, ref custom);
		}
		public void OnBtnTest(IRibbonControl control)
        {
			
			MessageBox.Show("已处于激活状态: " + control.Id + "," + control.Tag + "," + control.Context);
        }
		public void OnBtnShowAbout(IRibbonControl control)
		{
			new FrmAbout().Show();
		}
		public void OnBtnTestHttp(IRibbonControl control)
		{
			new FrmTestHttp().Show();
		}
		public void OnBtnQueryExpress(IRibbonControl control)
		{
			var eq = new Ribbon.QueryExpress.ExcelExpressQuery();
			eq.Run();
		}
	}
}
