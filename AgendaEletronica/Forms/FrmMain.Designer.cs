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
			this.menuStrip = new MenuStrip();
			this.fileMenu = new ToolStripMenuItem();
			this.newToolStripMenuItem = new ToolStripMenuItem();
			this.openToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator3 = new ToolStripSeparator();
			this.saveToolStripMenuItem = new ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator4 = new ToolStripSeparator();
			this.printToolStripMenuItem = new ToolStripMenuItem();
			this.printPreviewToolStripMenuItem = new ToolStripMenuItem();
			this.printSetupToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator5 = new ToolStripSeparator();
			this.exitToolStripMenuItem = new ToolStripMenuItem();
			this.cadastrosToolStripMenuItem = new ToolStripMenuItem();
			this.clientesToolStripMenuItem = new ToolStripMenuItem();
			this.cadastrosToolStripMenuItem1 = new ToolStripMenuItem();
			this.grupoToolStripMenuItem = new ToolStripMenuItem();
			this.regiõesDeClientesToolStripMenuItem = new ToolStripMenuItem();
			this.caixaDeSaídaToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripMenuItem2 = new ToolStripSeparator();
			this.usuáriosToolStripMenuItem = new ToolStripMenuItem();
			this.empresasToolStripMenuItem = new ToolStripMenuItem();
			this.relatóriosToolStripMenuItem = new ToolStripMenuItem();
			this.listagemDeContatosToolStripMenuItem = new ToolStripMenuItem();
			this.toolsMenu = new ToolStripMenuItem();
			this.optionsToolStripMenuItem = new ToolStripMenuItem();
			this.enviarEmailToolStripMenuItem = new ToolStripMenuItem();
			this.editMenu = new ToolStripMenuItem();
			this.undoToolStripMenuItem = new ToolStripMenuItem();
			this.redoToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator6 = new ToolStripSeparator();
			this.cutToolStripMenuItem = new ToolStripMenuItem();
			this.copyToolStripMenuItem = new ToolStripMenuItem();
			this.pasteToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator7 = new ToolStripSeparator();
			this.selectAllToolStripMenuItem = new ToolStripMenuItem();
			this.windowsMenu = new ToolStripMenuItem();
			this.newWindowToolStripMenuItem = new ToolStripMenuItem();
			this.cascadeToolStripMenuItem = new ToolStripMenuItem();
			this.tileVerticalToolStripMenuItem = new ToolStripMenuItem();
			this.tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
			this.closeAllToolStripMenuItem = new ToolStripMenuItem();
			this.arrangeIconsToolStripMenuItem = new ToolStripMenuItem();
			this.viewMenu = new ToolStripMenuItem();
			this.toolBarToolStripMenuItem = new ToolStripMenuItem();
			this.statusBarToolStripMenuItem = new ToolStripMenuItem();
			this.toolStrip = new ToolStrip();
			this.statusStrip = new StatusStrip();
			this.toolStripStatusLabel = new ToolStripStatusLabel();
			this.toolTip = new ToolTip( this.components );
			this.tsmiConnectionConfiguration = new ToolStripMenuItem();
			this.toolStripMenuItem1 = new ToolStripSeparator();
			this.menuStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange( new ToolStripItem[] { this.fileMenu, this.cadastrosToolStripMenuItem, this.relatóriosToolStripMenuItem, this.toolsMenu, this.editMenu, this.windowsMenu, this.viewMenu } );
			this.menuStrip.Location = new Point( 0, 0 );
			this.menuStrip.MdiWindowListItem = this.windowsMenu;
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Padding = new Padding( 7, 2, 0, 2 );
			this.menuStrip.Size = new Size( 737, 24 );
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "MenuStrip";
			// 
			// fileMenu
			// 
			this.fileMenu.DropDownItems.AddRange( new ToolStripItem[] { this.tsmiConnectionConfiguration, this.toolStripMenuItem1, this.newToolStripMenuItem, this.openToolStripMenuItem, this.toolStripSeparator3, this.saveToolStripMenuItem, this.saveAsToolStripMenuItem, this.toolStripSeparator4, this.printToolStripMenuItem, this.printPreviewToolStripMenuItem, this.printSetupToolStripMenuItem, this.toolStripSeparator5, this.exitToolStripMenuItem } );
			this.fileMenu.ImageTransparentColor = SystemColors.ActiveBorder;
			this.fileMenu.Name = "fileMenu";
			this.fileMenu.Size = new Size( 61, 20 );
			this.fileMenu.Text = "&Arquivo";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Image = (Image)resources.GetObject( "newToolStripMenuItem.Image" );
			this.newToolStripMenuItem.ImageTransparentColor = Color.Black;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys =  Keys.Control  |  Keys.N ;
			this.newToolStripMenuItem.Size = new Size( 201, 22 );
			this.newToolStripMenuItem.Text = "&Novo";
			this.newToolStripMenuItem.Click +=  this.ShowNewForm ;
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image = (Image)resources.GetObject( "openToolStripMenuItem.Image" );
			this.openToolStripMenuItem.ImageTransparentColor = Color.Black;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys =  Keys.Control  |  Keys.O ;
			this.openToolStripMenuItem.Size = new Size( 201, 22 );
			this.openToolStripMenuItem.Text = "&Abrir";
			this.openToolStripMenuItem.Click +=  this.OpenFile ;
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new Size( 198, 6 );
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Image = (Image)resources.GetObject( "saveToolStripMenuItem.Image" );
			this.saveToolStripMenuItem.ImageTransparentColor = Color.Black;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys =  Keys.Control  |  Keys.S ;
			this.saveToolStripMenuItem.Size = new Size( 201, 22 );
			this.saveToolStripMenuItem.Text = "&Salvar";
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new Size( 201, 22 );
			this.saveAsToolStripMenuItem.Text = "Salvar &Como...";
			this.saveAsToolStripMenuItem.Click +=  this.SaveAsToolStripMenuItem_Click ;
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new Size( 198, 6 );
			// 
			// printToolStripMenuItem
			// 
			this.printToolStripMenuItem.Image = (Image)resources.GetObject( "printToolStripMenuItem.Image" );
			this.printToolStripMenuItem.ImageTransparentColor = Color.Black;
			this.printToolStripMenuItem.Name = "printToolStripMenuItem";
			this.printToolStripMenuItem.ShortcutKeys =  Keys.Control  |  Keys.P ;
			this.printToolStripMenuItem.Size = new Size( 201, 22 );
			this.printToolStripMenuItem.Text = "Im&primir";
			// 
			// printPreviewToolStripMenuItem
			// 
			this.printPreviewToolStripMenuItem.Image = (Image)resources.GetObject( "printPreviewToolStripMenuItem.Image" );
			this.printPreviewToolStripMenuItem.ImageTransparentColor = Color.Black;
			this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
			this.printPreviewToolStripMenuItem.Size = new Size( 201, 22 );
			this.printPreviewToolStripMenuItem.Text = "Pre-&visualizar Impressão";
			// 
			// printSetupToolStripMenuItem
			// 
			this.printSetupToolStripMenuItem.Name = "printSetupToolStripMenuItem";
			this.printSetupToolStripMenuItem.Size = new Size( 201, 22 );
			this.printSetupToolStripMenuItem.Text = "Configurar Impressora";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new Size( 198, 6 );
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new Size( 201, 22 );
			this.exitToolStripMenuItem.Text = "&Sair";
			this.exitToolStripMenuItem.Click +=  this.ExitToolsStripMenuItem_Click ;
			// 
			// cadastrosToolStripMenuItem
			// 
			this.cadastrosToolStripMenuItem.DropDownItems.AddRange( new ToolStripItem[] { this.clientesToolStripMenuItem, this.caixaDeSaídaToolStripMenuItem, this.toolStripMenuItem2, this.usuáriosToolStripMenuItem, this.empresasToolStripMenuItem } );
			this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
			this.cadastrosToolStripMenuItem.Size = new Size( 71, 20 );
			this.cadastrosToolStripMenuItem.Text = "&Cadastros";
			// 
			// clientesToolStripMenuItem
			// 
			this.clientesToolStripMenuItem.DropDownItems.AddRange( new ToolStripItem[] { this.cadastrosToolStripMenuItem1, this.grupoToolStripMenuItem, this.regiõesDeClientesToolStripMenuItem } );
			this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
			this.clientesToolStripMenuItem.Size = new Size( 180, 22 );
			this.clientesToolStripMenuItem.Text = "Contatos";
			// 
			// cadastrosToolStripMenuItem1
			// 
			this.cadastrosToolStripMenuItem1.Name = "cadastrosToolStripMenuItem1";
			this.cadastrosToolStripMenuItem1.Size = new Size( 188, 22 );
			this.cadastrosToolStripMenuItem1.Text = "Cadastros";
			// 
			// grupoToolStripMenuItem
			// 
			this.grupoToolStripMenuItem.Name = "grupoToolStripMenuItem";
			this.grupoToolStripMenuItem.Size = new Size( 188, 22 );
			this.grupoToolStripMenuItem.Text = "Grupo de Contatos";
			// 
			// regiõesDeClientesToolStripMenuItem
			// 
			this.regiõesDeClientesToolStripMenuItem.Name = "regiõesDeClientesToolStripMenuItem";
			this.regiõesDeClientesToolStripMenuItem.Size = new Size( 188, 22 );
			this.regiõesDeClientesToolStripMenuItem.Text = "Regiões dos Contatos";
			// 
			// caixaDeSaídaToolStripMenuItem
			// 
			this.caixaDeSaídaToolStripMenuItem.Name = "caixaDeSaídaToolStripMenuItem";
			this.caixaDeSaídaToolStripMenuItem.Size = new Size( 180, 22 );
			this.caixaDeSaídaToolStripMenuItem.Text = "Caixa de Saída";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new Size( 177, 6 );
			// 
			// usuáriosToolStripMenuItem
			// 
			this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
			this.usuáriosToolStripMenuItem.Size = new Size( 180, 22 );
			this.usuáriosToolStripMenuItem.Text = "Usuários";
			// 
			// empresasToolStripMenuItem
			// 
			this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
			this.empresasToolStripMenuItem.Size = new Size( 180, 22 );
			this.empresasToolStripMenuItem.Text = "Empresas";
			// 
			// relatóriosToolStripMenuItem
			// 
			this.relatóriosToolStripMenuItem.DropDownItems.AddRange( new ToolStripItem[] { this.listagemDeContatosToolStripMenuItem } );
			this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
			this.relatóriosToolStripMenuItem.Size = new Size( 71, 20 );
			this.relatóriosToolStripMenuItem.Text = "&Relatórios";
			// 
			// listagemDeContatosToolStripMenuItem
			// 
			this.listagemDeContatosToolStripMenuItem.Name = "listagemDeContatosToolStripMenuItem";
			this.listagemDeContatosToolStripMenuItem.Size = new Size( 189, 22 );
			this.listagemDeContatosToolStripMenuItem.Text = "&Listagem de Contatos";
			// 
			// toolsMenu
			// 
			this.toolsMenu.DropDownItems.AddRange( new ToolStripItem[] { this.optionsToolStripMenuItem, this.enviarEmailToolStripMenuItem } );
			this.toolsMenu.Name = "toolsMenu";
			this.toolsMenu.Size = new Size( 84, 20 );
			this.toolsMenu.Text = "&Ferramentas";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new Size( 171, 22 );
			this.optionsToolStripMenuItem.Text = "&Importar Contatos";
			// 
			// enviarEmailToolStripMenuItem
			// 
			this.enviarEmailToolStripMenuItem.Name = "enviarEmailToolStripMenuItem";
			this.enviarEmailToolStripMenuItem.Size = new Size( 171, 22 );
			this.enviarEmailToolStripMenuItem.Text = "&Enviar E-mail";
			// 
			// editMenu
			// 
			this.editMenu.DropDownItems.AddRange( new ToolStripItem[] { this.undoToolStripMenuItem, this.redoToolStripMenuItem, this.toolStripSeparator6, this.cutToolStripMenuItem, this.copyToolStripMenuItem, this.pasteToolStripMenuItem, this.toolStripSeparator7, this.selectAllToolStripMenuItem } );
			this.editMenu.Name = "editMenu";
			this.editMenu.Size = new Size( 49, 20 );
			this.editMenu.Text = "&Editar";
			// 
			// undoToolStripMenuItem
			// 
			this.undoToolStripMenuItem.Image = (Image)resources.GetObject( "undoToolStripMenuItem.Image" );
			this.undoToolStripMenuItem.ImageTransparentColor = Color.Black;
			this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			this.undoToolStripMenuItem.ShortcutKeys =  Keys.Control  |  Keys.Z ;
			this.undoToolStripMenuItem.Size = new Size( 164, 22 );
			this.undoToolStripMenuItem.Text = "&Undo";
			// 
			// redoToolStripMenuItem
			// 
			this.redoToolStripMenuItem.Image = (Image)resources.GetObject( "redoToolStripMenuItem.Image" );
			this.redoToolStripMenuItem.ImageTransparentColor = Color.Black;
			this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
			this.redoToolStripMenuItem.ShortcutKeys =  Keys.Control  |  Keys.Y ;
			this.redoToolStripMenuItem.Size = new Size( 164, 22 );
			this.redoToolStripMenuItem.Text = "&Redo";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new Size( 161, 6 );
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.Image = (Image)resources.GetObject( "cutToolStripMenuItem.Image" );
			this.cutToolStripMenuItem.ImageTransparentColor = Color.Black;
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.ShortcutKeys =  Keys.Control  |  Keys.X ;
			this.cutToolStripMenuItem.Size = new Size( 164, 22 );
			this.cutToolStripMenuItem.Text = "Cu&t";
			this.cutToolStripMenuItem.Click +=  this.CutToolStripMenuItem_Click ;
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Image = (Image)resources.GetObject( "copyToolStripMenuItem.Image" );
			this.copyToolStripMenuItem.ImageTransparentColor = Color.Black;
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.ShortcutKeys =  Keys.Control  |  Keys.C ;
			this.copyToolStripMenuItem.Size = new Size( 164, 22 );
			this.copyToolStripMenuItem.Text = "&Copy";
			this.copyToolStripMenuItem.Click +=  this.CopyToolStripMenuItem_Click ;
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Image = (Image)resources.GetObject( "pasteToolStripMenuItem.Image" );
			this.pasteToolStripMenuItem.ImageTransparentColor = Color.Black;
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.ShortcutKeys =  Keys.Control  |  Keys.V ;
			this.pasteToolStripMenuItem.Size = new Size( 164, 22 );
			this.pasteToolStripMenuItem.Text = "&Paste";
			this.pasteToolStripMenuItem.Click +=  this.PasteToolStripMenuItem_Click ;
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new Size( 161, 6 );
			// 
			// selectAllToolStripMenuItem
			// 
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			this.selectAllToolStripMenuItem.ShortcutKeys =  Keys.Control  |  Keys.A ;
			this.selectAllToolStripMenuItem.Size = new Size( 164, 22 );
			this.selectAllToolStripMenuItem.Text = "Select &All";
			// 
			// windowsMenu
			// 
			this.windowsMenu.DropDownItems.AddRange( new ToolStripItem[] { this.newWindowToolStripMenuItem, this.cascadeToolStripMenuItem, this.tileVerticalToolStripMenuItem, this.tileHorizontalToolStripMenuItem, this.closeAllToolStripMenuItem, this.arrangeIconsToolStripMenuItem } );
			this.windowsMenu.Name = "windowsMenu";
			this.windowsMenu.Size = new Size( 68, 20 );
			this.windowsMenu.Text = "&Windows";
			// 
			// newWindowToolStripMenuItem
			// 
			this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
			this.newWindowToolStripMenuItem.Size = new Size( 150, 22 );
			this.newWindowToolStripMenuItem.Text = "&New Window";
			this.newWindowToolStripMenuItem.Click +=  this.ShowNewForm ;
			// 
			// cascadeToolStripMenuItem
			// 
			this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
			this.cascadeToolStripMenuItem.Size = new Size( 150, 22 );
			this.cascadeToolStripMenuItem.Text = "&Cascade";
			this.cascadeToolStripMenuItem.Click +=  this.CascadeToolStripMenuItem_Click ;
			// 
			// tileVerticalToolStripMenuItem
			// 
			this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
			this.tileVerticalToolStripMenuItem.Size = new Size( 150, 22 );
			this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
			this.tileVerticalToolStripMenuItem.Click +=  this.TileVerticalToolStripMenuItem_Click ;
			// 
			// tileHorizontalToolStripMenuItem
			// 
			this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
			this.tileHorizontalToolStripMenuItem.Size = new Size( 150, 22 );
			this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
			this.tileHorizontalToolStripMenuItem.Click +=  this.TileHorizontalToolStripMenuItem_Click ;
			// 
			// closeAllToolStripMenuItem
			// 
			this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
			this.closeAllToolStripMenuItem.Size = new Size( 150, 22 );
			this.closeAllToolStripMenuItem.Text = "C&lose All";
			this.closeAllToolStripMenuItem.Click +=  this.CloseAllToolStripMenuItem_Click ;
			// 
			// arrangeIconsToolStripMenuItem
			// 
			this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
			this.arrangeIconsToolStripMenuItem.Size = new Size( 150, 22 );
			this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
			this.arrangeIconsToolStripMenuItem.Click +=  this.ArrangeIconsToolStripMenuItem_Click ;
			// 
			// viewMenu
			// 
			this.viewMenu.DropDownItems.AddRange( new ToolStripItem[] { this.toolBarToolStripMenuItem, this.statusBarToolStripMenuItem } );
			this.viewMenu.Name = "viewMenu";
			this.viewMenu.Size = new Size( 68, 20 );
			this.viewMenu.Text = "&Visualizar";
			// 
			// toolBarToolStripMenuItem
			// 
			this.toolBarToolStripMenuItem.Checked = true;
			this.toolBarToolStripMenuItem.CheckOnClick = true;
			this.toolBarToolStripMenuItem.CheckState = CheckState.Checked;
			this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
			this.toolBarToolStripMenuItem.Size = new Size( 185, 22 );
			this.toolBarToolStripMenuItem.Text = "&Barra de Ferramentas";
			this.toolBarToolStripMenuItem.Click +=  this.ToolBarToolStripMenuItem_Click ;
			// 
			// statusBarToolStripMenuItem
			// 
			this.statusBarToolStripMenuItem.Checked = true;
			this.statusBarToolStripMenuItem.CheckOnClick = true;
			this.statusBarToolStripMenuItem.CheckState = CheckState.Checked;
			this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
			this.statusBarToolStripMenuItem.Size = new Size( 185, 22 );
			this.statusBarToolStripMenuItem.Text = "&Barra de Status";
			this.statusBarToolStripMenuItem.Click +=  this.StatusBarToolStripMenuItem_Click ;
			// 
			// toolStrip
			// 
			this.toolStrip.Location = new Point( 0, 24 );
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new Size( 737, 25 );
			this.toolStrip.TabIndex = 1;
			this.toolStrip.Text = "ToolStrip";
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange( new ToolStripItem[] { this.toolStripStatusLabel } );
			this.statusStrip.Location = new Point( 0, 501 );
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Padding = new Padding( 1, 0, 16, 0 );
			this.statusStrip.Size = new Size( 737, 22 );
			this.statusStrip.TabIndex = 2;
			this.statusStrip.Text = "StatusStrip";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new Size( 39, 17 );
			this.toolStripStatusLabel.Text = "Status";
			// 
			// tsmiConnectionConfiguration
			// 
			this.tsmiConnectionConfiguration.Image = (Image)resources.GetObject( "tsmiConnectionConfiguration.Image" );
			this.tsmiConnectionConfiguration.Name = "tsmiConnectionConfiguration";
			this.tsmiConnectionConfiguration.Size = new Size( 201, 22 );
			this.tsmiConnectionConfiguration.Text = "Con&figurar Conexão";
			this.tsmiConnectionConfiguration.Click +=  this.tsmiConnectionConfiguration_Click ;
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new Size( 198, 6 );
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new SizeF( 7F, 15F );
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size( 737, 523 );
			this.Controls.Add( this.statusStrip );
			this.Controls.Add( this.toolStrip );
			this.Controls.Add( this.menuStrip );
			this.Icon = (Icon)resources.GetObject( "$this.Icon" );
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip;
			this.Margin = new Padding( 4, 3, 4, 3 );
			this.Name = "FrmMain";
			this.Text = "FrmMain";
			this.menuStrip.ResumeLayout( false );
			this.menuStrip.PerformLayout();
			this.statusStrip.ResumeLayout( false );
			this.statusStrip.PerformLayout();
			this.ResumeLayout( false );
			this.PerformLayout();
		}
		#endregion


		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editMenu;
		private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewMenu;
		private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsMenu;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem windowsMenu;
		private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
		private System.Windows.Forms.ToolTip toolTip;
		private ToolStripMenuItem fileMenu;
		private ToolStripMenuItem newToolStripMenuItem;
		private ToolStripMenuItem openToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripMenuItem saveToolStripMenuItem;
		private ToolStripMenuItem saveAsToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator4;
		private ToolStripMenuItem printToolStripMenuItem;
		private ToolStripMenuItem printPreviewToolStripMenuItem;
		private ToolStripMenuItem printSetupToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator5;
		private ToolStripMenuItem exitToolStripMenuItem;
		private ToolStripMenuItem relatóriosToolStripMenuItem;
		private ToolStripMenuItem cadastrosToolStripMenuItem;
		private ToolStripMenuItem empresasToolStripMenuItem;
		private ToolStripMenuItem usuáriosToolStripMenuItem;
		private ToolStripMenuItem clientesToolStripMenuItem;
		private ToolStripMenuItem cadastrosToolStripMenuItem1;
		private ToolStripMenuItem grupoToolStripMenuItem;
		private ToolStripMenuItem regiõesDeClientesToolStripMenuItem;
		private ToolStripMenuItem caixaDeSaídaToolStripMenuItem;
		private ToolStripSeparator toolStripMenuItem2;
		private ToolStripMenuItem enviarEmailToolStripMenuItem;
		private ToolStripMenuItem listagemDeContatosToolStripMenuItem;
		private ToolStripMenuItem tsmiConnectionConfiguration;
		private ToolStripSeparator toolStripMenuItem1;
	}
}



