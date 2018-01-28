namespace Ribbon
{
	partial class FrmAbout
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(108, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "serfend 2017 For Excel";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(209, 48);
			this.label2.TabIndex = 1;
			this.label2.Text = "仅用于学习与研究，商业用途请右上角\r\n\r\nQQ:331945833\r\nWeChat:serfend";
			// 
			// FrmAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(257, 99);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmAbout";
			this.Opacity = 0.95D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FrmAbout";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}