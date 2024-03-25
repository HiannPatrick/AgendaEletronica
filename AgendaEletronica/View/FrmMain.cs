using Forms.Inherited;
using Forms.Inherited.MenuObjetos;

namespace AgendaEletronica.Forms
{
	public partial class FrmMain :FrmMdiParent
	{
		private int childFormNumber = 0;

		public FrmMain()
		{
			InitializeComponent();
		}

		private void tsmiConnectionConfiguration_Click( object sender, EventArgs e )
		{
			new DatabaseConnections.View.FrmConnections().Show();
		}

		private void FrmMain_Load( object sender, EventArgs e )
		{
			var submenuObjetos = new List<SubmenuObjetos>
			{
				new SubmenuObjetos
				{
					MenuRaiz = EnumMenuRaiz.Cadastros,
					Nome = "Empresas",
					Namespace = "AgendaEletronica.View.FrmCompanyOverview",
					TipoFormulario = EnumTipoFormulario.DataView,
					Assembly = ""
				},
				new SubmenuObjetos
				{
					MenuRaiz = EnumMenuRaiz.Ferramentas,
					Nome = "Configurar Conexão",
					Namespace = "DatabaseConnections.View.FrmConnections",
					TipoFormulario = EnumTipoFormulario.Tool,
					Assembly = "DatabaseConnections.dll"
				}
			};

			this.CriarMenuObjetos(submenuObjetos);
		}
	}
}
