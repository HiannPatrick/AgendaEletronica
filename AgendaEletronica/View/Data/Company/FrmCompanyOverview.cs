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

		private void FrmCompanyOverview_Load( object sender, EventArgs e )
		{
			this.bindCompany.DataSource = CompanyController.GetCompanies();
		}

		public override void tsbNovo_Click( object sender, EventArgs e )
		{
			new FrmCompanyAddEdit { MdiParent = this.MdiParent }.Show();
		}

		public override void tsbEditar_Click( object sender, EventArgs e )
		{
			var dr = (CompanyRow)( (DataRowView)this.bindCompany.Current).Row;

			new FrmCompanyAddEdit( dr.Id ) { MdiParent = this.MdiParent }.Show();
		}
	}
}
