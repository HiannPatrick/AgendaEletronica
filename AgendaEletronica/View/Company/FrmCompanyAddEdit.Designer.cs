namespace AgendaEletronica.View
{
	partial class FrmCompanyAddEdit
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
			this.panel1 = new Panel();
			this.lblId = new Label();
			this.lblNome = new Label();
			this.txtId = new TextBox();
			this.txtNome = new TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = BorderStyle.Fixed3D;
			this.panel1.Controls.Add( this.txtNome );
			this.panel1.Controls.Add( this.txtId );
			this.panel1.Controls.Add( this.lblNome );
			this.panel1.Controls.Add( this.lblId );
			this.panel1.Dock = DockStyle.Fill;
			this.panel1.Location = new Point( 0, 54 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size( 310, 89 );
			this.panel1.TabIndex = 2;
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new Point( 41, 16 );
			this.lblId.Name = "lblId";
			this.lblId.Size = new Size( 20, 15 );
			this.lblId.TabIndex = 0;
			this.lblId.Text = "Id:";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new Point( 18, 42 );
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new Size( 43, 15 );
			this.lblNome.TabIndex = 0;
			this.lblNome.Text = "Nome:";
			// 
			// txtId
			// 
			this.txtId.Location = new Point( 65, 12 );
			this.txtId.Name = "txtId";
			this.txtId.ReadOnly = true;
			this.txtId.Size = new Size( 57, 23 );
			this.txtId.TabIndex = 1;
			// 
			// txtNome
			// 
			this.txtNome.Location = new Point( 65, 38 );
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new Size( 218, 23 );
			this.txtNome.TabIndex = 1;
			// 
			// FrmCompanyAddEdit
			// 
			this.AutoScaleDimensions = new SizeF( 7F, 15F );
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size( 310, 143 );
			this.Controls.Add( this.panel1 );
			this.Name = "FrmCompanyAddEdit";
			this.Text = "Empresa";
			this.Load +=  this.FrmCompanyAddEdit_Load ;
			this.Controls.SetChildIndex( this.panel1, 0 );
			this.panel1.ResumeLayout( false );
			this.panel1.PerformLayout();
			this.ResumeLayout( false );
			this.PerformLayout();
		}

		#endregion

		private Panel panel1;
		private TextBox txtNome;
		private TextBox txtId;
		private Label lblNome;
		private Label lblId;
	}
}