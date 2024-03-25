using AgendaEletronica.Controller;

using Forms.Inherited;

using static AgendaEletronica.Database.AgendaEletronicaDataSet;

namespace AgendaEletronica.View
{
	public partial class FrmCompanyAddEdit :FrmEditView
	{
		private int _companyId = -1;

		private CompanyDataTable _dtCompany = new CompanyDataTable();

		public FrmCompanyAddEdit()
		{
			InitializeComponent();

			this.Text = "Incluir Empresa";
		}

		public FrmCompanyAddEdit(int companyId)
		{
			InitializeComponent();

			this._companyId = companyId;

			this.Text = "Editar Empresa";
		}

		private void FrmCompanyAddEdit_Load( object sender, EventArgs e )
		{
			if(_companyId > 0 ) 
			{
				_dtCompany = CompanyController.GetCompany(_companyId);

				this.txtId.Text = _dtCompany[ 0 ].Id.ToString();
				this.txtNome.Text = _dtCompany[ 0 ].Name.Trim();
			}

			this.txtNome.Focus();
		}

		protected override void tsbSalvar_Click( object sender, EventArgs e )
		{
			Cursor.Current = Cursors.WaitCursor;

			var drCompany = _dtCompany.Count > 0 ? _dtCompany[0] : _dtCompany.NewCompanyRow();

			drCompany.Name = this.txtNome.Text.Trim();

			if( drCompany.RowState  == System.Data.DataRowState.Added ||
				drCompany.RowState == System.Data.DataRowState.Detached)
			{
				drCompany.Id = -1;

				_dtCompany.Rows.Add( drCompany );
			}

			bool bReturn = CompanyController.SaveCompany( _dtCompany );

			Cursor.Current = Cursors.Default;

			if(bReturn )
			{
				this.Close();
				return;
			}
			
			MessageBox.Show("Não foi possível gravar o registro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error );
		}
	}
}
