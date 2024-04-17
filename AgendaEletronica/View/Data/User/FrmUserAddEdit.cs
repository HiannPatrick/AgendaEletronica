using AgendaEletronica.Controller;

using Forms.Inherited;

using System.ComponentModel.Design;
using System.Data;

using Util.Classes;

using static AgendaEletronica.Database.AgendaEletronicaDataSet;

namespace AgendaEletronica.View
{
	public partial class FrmUserAddEdit :FrmEditView
	{
		private int _userId = -1;

		private UserDataTable _dtUser = new UserDataTable();

		public FrmUserAddEdit()
		{
			InitializeComponent();

			this.Text = "Incluir Usuário";
		}

		public FrmUserAddEdit( int userId )
		{
			InitializeComponent();

			this._userId = userId;

			this.Text = "Editar Usuário";
		}

		private void FrmUserAddEdit_Load( object sender, EventArgs e )
		{
			this.bindCompany.DataSource = CompanyController.GetCompanies();

			if( _userId > 0 )
			{
				_dtUser = UserController.GetUser( _userId );

				this.txtId.Text = _dtUser[ 0 ].Id.ToString();
				this.txtName.Text = _dtUser[ 0 ].Name.Trim();
				this.txtUsuario.Text = _dtUser[ 0 ].User.Trim();
				this.mtxtPassword.Text = _dtUser[ 0 ].Password;
				this.cboEmpresa.SelectedValue = _dtUser[ 0 ].CompanyId;
				this.txtEmail.Text = _dtUser[ 0 ].Email;
				this.mtxtEmailPassword.Text = _dtUser[ 0 ].EmailPassword;
				this.txtSmtp.Text = _dtUser[ 0 ].Email_Smtp;
				this.txtPort.Text = _dtUser[ 0 ].Email_Port;
			}

			this.txtName.Focus();
		}

		protected override void tsbSalvar_Click( object sender, EventArgs e )
		{
			Cursor.Current = Cursors.WaitCursor;

			var drUser = _dtUser.Count > 0 ? _dtUser[0] : _dtUser.NewUserRow();

			drUser.Name = this.txtName.Text.Trim();
			drUser.User = this.txtUsuario.Text.Trim();
			drUser.Password = this.mtxtPassword.Text.Trim();
			drUser.Email = this.txtEmail.Text.Trim();
			drUser.EmailPassword = this.mtxtEmailPassword.Text.Trim();
			drUser.Email_Smtp = this.txtSmtp.Text.Trim();
			drUser.Email_Port = this.txtPort.Text.Trim();

			var drCompany = (CompanyRow)( (DataRowView)this.bindCompany.Current).Row;

			if( drCompany == null )
			{
				drUser.CompanyId = -1;
			}
			else
			{
				drUser.CompanyId = drCompany.Id;
			}

			if( drUser.RowState == System.Data.DataRowState.Detached )
			{
				drUser.Id = -1;

				_dtUser.Rows.Add( drUser );
			}

			bool bReturn = UserController.SaveUser( _dtUser );

			Cursor.Current = Cursors.Default;

			if( bReturn )
			{
				this.Close();
				return;
			}

			MessageBox.Show( "Não foi possível gravar o registro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error );
		}
	}
}
