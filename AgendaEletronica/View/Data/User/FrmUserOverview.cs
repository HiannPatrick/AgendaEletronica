using AgendaEletronica.Controller;

using Forms.Inherited;

using System.Data;

using static AgendaEletronica.Database.AgendaEletronicaDataSet;

namespace AgendaEletronica.View
{
	public partial class FrmUserOverview :FrmDataView
	{
		public FrmUserOverview()
		{
			InitializeComponent();
		}

		private void FrmUserOverview_Load( object sender, EventArgs e )
		{
			this.bindUser.DataSource = UserController.GetUsers();
		}

		public override void tsbNovo_Click( object sender, EventArgs e )
		{
			new FrmUserAddEdit { MdiParent = this.MdiParent }.Show();
		}

		public override void tsbEditar_Click( object sender, EventArgs e )
		{
			var dr = (UserRow)( (DataRowView)this.bindUser.Current).Row;

			new FrmUserAddEdit( dr.Id ) { MdiParent = this.MdiParent }.Show();
		}
	}
}
