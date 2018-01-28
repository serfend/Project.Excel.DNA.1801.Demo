namespace Ribbon.QueryExpress
{
	partial class FrmCancel
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
			this.BtnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BtnCancel
			// 
			this.BtnCancel.Location = new System.Drawing.Point(132, 56);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(70, 32);
			this.BtnCancel.TabIndex = 0;
			this.BtnCancel.Text = "取消";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// FrmCancel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(335, 100);
			this.Controls.Add(this.BtnCancel);
			this.Name = "FrmCancel";
			this.Text = "FrmCancel";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BtnCancel;
	}
}