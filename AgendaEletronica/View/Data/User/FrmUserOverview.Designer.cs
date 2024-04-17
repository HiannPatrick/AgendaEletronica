namespace AgendaEletronica.View
{
	partial class FrmUserOverview
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
			this.dgvUser = new DataGridView();
			this.bindUser = new BindingSource( this.components );
			this.idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			( (System.ComponentModel.ISupportInitialize)this.dgvUser ).BeginInit();
			( (System.ComponentModel.ISupportInitialize)this.bindUser ).BeginInit();
			this.SuspendLayout();
			// 
			// dgvUser
			// 
			this.dgvUser.AllowUserToAddRows = false;
			this.dgvUser.AllowUserToDeleteRows = false;
			this.dgvUser.AllowUserToOrderColumns = true;
			this.dgvUser.AutoGenerateColumns = false;
			this.dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUser.Columns.AddRange( new DataGridViewColumn[] { this.idDataGridViewTextBoxColumn, this.nameDataGridViewTextBoxColumn, this.emailDataGridViewTextBoxColumn } );
			this.dgvUser.DataSource = this.bindUser;
			this.dgvUser.Dock = DockStyle.Fill;
			this.dgvUser.Location = new Point( 0, 54 );
			this.dgvUser.MultiSelect = false;
			this.dgvUser.Name = "dgvUser";
			this.dgvUser.ReadOnly = true;
			this.dgvUser.RowHeadersVisible = false;
			this.dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dgvUser.Size = new Size( 800, 396 );
			this.dgvUser.TabIndex = 1;
			// 
			// bindUser
			// 
			this.bindUser.DataMember = "User";
			this.bindUser.DataSource = typeof( Database.AgendaEletronicaDataSet );
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// FrmUserOverview
			// 
			this.AutoScaleDimensions = new SizeF( 7F, 15F );
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size( 800, 450 );
			this.Controls.Add( this.dgvUser );
			this.Name = "FrmUserOverview";
			this.Text = "Usuários";
			this.Load +=  this.FrmUserOverview_Load ;
			this.Controls.SetChildIndex( this.dgvUser, 0 );
			( (System.ComponentModel.ISupportInitialize)this.dgvUser ).EndInit();
			( (System.ComponentModel.ISupportInitialize)this.bindUser ).EndInit();
			this.ResumeLayout( false );
			this.PerformLayout();
		}

		#endregion

		private DataGridView dgvUser;
		private BindingSource bindUser;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
	}
}