using AgendaEletronica.Controller;

using Forms.Inherited;

using System.Data;

using static AgendaEletronica.Database.AgendaEletronicaDataSet;

namespace AgendaEletronica.View
{
	public partial class FrmCompanyOverview :FrmDataView
	{
		public FrmCompanyOverview()
		{
			InitializeComponent();
		}

		public override void tsbNovo_Click( object sender, EventArgs e )
		{
			new FrmCompanyAddEdit().Show();
		}

		public override void tsbEditar_Click( object sender, EventArgs e )
		{
			/*
			 * 		public static DataRow GetCurrentRow( this BindingSource bind )
		{
			var dr = ( (DataRowView)bind.Current ).Row;

			return dr;
		}
			*/
			var dr = (CompanyRow)( (DataRowView)this.bindCompany.Current).Row;

			new FrmCompanyAddEdit( dr.Id ).Show();
		}

		private void FrmCompanyOverview_Load( object sender, EventArgs e )
		{
			this.bindCompany.DataSource = CompanyController.GetCompanies();
		}
	}
}
