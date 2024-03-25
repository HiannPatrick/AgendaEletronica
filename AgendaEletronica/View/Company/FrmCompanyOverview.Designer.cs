namespace AgendaEletronica.View
{
	partial class FrmCompanyOverview
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
			this.dgvCompany = new DataGridView();
			this.idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.bindCompany = new BindingSource( this.components );
			( (System.ComponentModel.ISupportInitialize)this.dgvCompany ).BeginInit();
			( (System.ComponentModel.ISupportInitialize)this.bindCompany ).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCompany
			// 
			this.dgvCompany.AllowUserToAddRows = false;
			this.dgvCompany.AllowUserToDeleteRows = false;
			this.dgvCompany.AllowUserToOrderColumns = true;
			this.dgvCompany.AutoGenerateColumns = false;
			this.dgvCompany.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCompany.Columns.AddRange( new DataGridViewColumn[] { this.idDataGridViewTextBoxColumn, this.nameDataGridViewTextBoxColumn } );
			this.dgvCompany.DataSource = this.bindCompany;
			this.dgvCompany.Dock = DockStyle.Fill;
			this.dgvCompany.Location = new Point( 0, 54 );
			this.dgvCompany.Name = "dgvCompany";
			this.dgvCompany.ReadOnly = true;
			this.dgvCompany.RowHeadersVisible = false;
			this.dgvCompany.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dgvCompany.Size = new Size( 800, 396 );
			this.dgvCompany.TabIndex = 1;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 42;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.FillWeight = 500F;
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bindCompany
			// 
			this.bindCompany.DataMember = "Company";
			this.bindCompany.DataSource = typeof( Database.AgendaEletronicaDataSet );
			// 
			// FrmCompanyOverview
			// 
			this.AutoScaleDimensions = new SizeF( 7F, 15F );
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size( 800, 450 );
			this.Controls.Add( this.dgvCompany );
			this.Name = "FrmCompanyOverview";
			this.Text = "Empresas";
			this.Load +=  this.FrmCompanyOverview_Load ;
			this.Controls.SetChildIndex( this.dgvCompany, 0 );
			( (System.ComponentModel.ISupportInitialize)this.dgvCompany ).EndInit();
			( (System.ComponentModel.ISupportInitialize)this.bindCompany ).EndInit();
			this.ResumeLayout( false );
			this.PerformLayout();
		}

		#endregion

		private DataGridView dgvCompany;
		private BindingSource bindCompany;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
	}
}