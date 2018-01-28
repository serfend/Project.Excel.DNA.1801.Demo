namespace Ribbon
{
	partial class FrmTestHttp
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.BtnNavigate = new System.Windows.Forms.Button();
			this.IpUrl = new System.Windows.Forms.TextBox();
			this.OpWebInfo = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// BtnNavigate
			// 
			this.BtnNavigate.Location = new System.Drawing.Point(319, 9);
			this.BtnNavigate.Name = "BtnNavigate";
			this.BtnNavigate.Size = new System.Drawing.Size(47, 25);
			this.BtnNavigate.TabIndex = 0;
			this.BtnNavigate.Text = "biu~";
			this.BtnNavigate.UseVisualStyleBackColor = true;
			this.BtnNavigate.Click += new System.EventHandler(this.BtnNavigate_Click);
			// 
			// IpUrl
			// 
			this.IpUrl.Location = new System.Drawing.Point(9, 10);
			this.IpUrl.Name = "IpUrl";
			this.IpUrl.Size = new System.Drawing.Size(303, 21);
			this.IpUrl.TabIndex = 1;
			// 
			// OpWebInfo
			// 
			this.OpWebInfo.Location = new System.Drawing.Point(9, 39);
			this.OpWebInfo.Multiline = true;
			this.OpWebInfo.Name = "OpWebInfo";
			this.OpWebInfo.Size = new System.Drawing.Size(357, 202);
			this.OpWebInfo.TabIndex = 2;
			// 
			// FrmTestHttp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 252);
			this.Controls.Add(this.OpWebInfo);
			this.Controls.Add(this.IpUrl);
			this.Controls.Add(this.BtnNavigate);
			this.Name = "FrmTestHttp";
			this.Text = "FrmTestHttp";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnNavigate;
		private System.Windows.Forms.TextBox IpUrl;
		private System.Windows.Forms.TextBox OpWebInfo;
	}
}