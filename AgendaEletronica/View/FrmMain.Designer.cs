namespace AgendaEletronica.Forms
{
	partial class FrmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.toolTip = new ToolTip( this.components );
			this.SuspendLayout();
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new SizeF( 7F, 15F );
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size( 737, 523 );
			this.Icon = (Icon)resources.GetObject( "$this.Icon" );
			this.Name = "FrmMain";
			this.Text = "FrmMain";
			this.Load +=  this.FrmMain_Load ;
			this.ResumeLayout( false );
			this.PerformLayout();
		}

		#endregion
		private System.Windows.Forms.ToolTip toolTip;
	}
}



