namespace AgendaEletronica.View
{
	partial class FrmUserAddEdit
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
			this.tabControl = new TabControl();
			this.tbpGeneral = new TabPage();
			this.panel1 = new Panel();
			this.lblName = new Label();
			this.cboEmpresa = new ComboBox();
			this.bindCompany = new BindingSource( this.components );
			this.lblEmpresa = new Label();
			this.mtxtPassword = new MaskedTextBox();
			this.lblPassword = new Label();
			this.txtUsuario = new TextBox();
			this.lblUser = new Label();
			this.txtName = new TextBox();
			this.txtId = new TextBox();
			this.lblId = new Label();
			this.tbpEmail = new TabPage();
			this.panel2 = new Panel();
			this.txtEmail = new TextBox();
			this.txtPort = new TextBox();
			this.txtSmtp = new TextBox();
			this.mtxtEmailPassword = new MaskedTextBox();
			this.lblPort = new Label();
			this.lblSmtp = new Label();
			this.lblEmailPassword = new Label();
			this.lblEmail = new Label();
			this.tabControl.SuspendLayout();
			this.tbpGeneral.SuspendLayout();
			this.panel1.SuspendLayout();
			( (System.ComponentModel.ISupportInitialize)this.bindCompany ).BeginInit();
			this.tbpEmail.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add( this.tbpGeneral );
			this.tabControl.Controls.Add( this.tbpEmail );
			this.tabControl.Dock = DockStyle.Fill;
			this.tabControl.Location = new Point( 0, 54 );
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new Size( 375, 205 );
			this.tabControl.TabIndex = 0;
			// 
			// tbpGeneral
			// 
			this.tbpGeneral.Controls.Add( this.panel1 );
			this.tbpGeneral.Location = new Point( 4, 24 );
			this.tbpGeneral.Name = "tbpGeneral";
			this.tbpGeneral.Padding = new Padding( 3 );
			this.tbpGeneral.Size = new Size( 367, 177 );
			this.tbpGeneral.TabIndex = 0;
			this.tbpGeneral.Text = "Geral";
			this.tbpGeneral.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = SystemColors.Control;
			this.panel1.BorderStyle = BorderStyle.Fixed3D;
			this.panel1.Controls.Add( this.lblName );
			this.panel1.Controls.Add( this.cboEmpresa );
			this.panel1.Controls.Add( this.lblEmpresa );
			this.panel1.Controls.Add( this.mtxtPassword );
			this.panel1.Controls.Add( this.lblPassword );
			this.panel1.Controls.Add( this.txtUsuario );
			this.panel1.Controls.Add( this.lblUser );
			this.panel1.Controls.Add( this.txtName );
			this.panel1.Controls.Add( this.txtId );
			this.panel1.Controls.Add( this.lblId );
			this.panel1.Dock = DockStyle.Fill;
			this.panel1.Location = new Point( 3, 3 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size( 361, 171 );
			this.panel1.TabIndex = 0;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new Point( 55, 47 );
			this.lblName.Name = "lblName";
			this.lblName.Size = new Size( 43, 15 );
			this.lblName.TabIndex = 2;
			this.lblName.Text = "Nome:";
			// 
			// cboEmpresa
			// 
			this.cboEmpresa.DataSource = this.bindCompany;
			this.cboEmpresa.DisplayMember = "Name";
			this.cboEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cboEmpresa.FormattingEnabled = true;
			this.cboEmpresa.Location = new Point( 104, 131 );
			this.cboEmpresa.Name = "cboEmpresa";
			this.cboEmpresa.Size = new Size( 185, 23 );
			this.cboEmpresa.TabIndex = 9;
			this.cboEmpresa.ValueMember = "Id";
			// 
			// bindCompany
			// 
			this.bindCompany.DataMember = "Company";
			this.bindCompany.DataSource = typeof( Database.AgendaEletronicaDataSet );
			// 
			// lblEmpresa
			// 
			this.lblEmpresa.AutoSize = true;
			this.lblEmpresa.Location = new Point( 43, 134 );
			this.lblEmpresa.Name = "lblEmpresa";
			this.lblEmpresa.Size = new Size( 55, 15 );
			this.lblEmpresa.TabIndex = 8;
			this.lblEmpresa.Text = "Empresa:";
			// 
			// mtxtPassword
			// 
			this.mtxtPassword.Location = new Point( 104, 102 );
			this.mtxtPassword.Name = "mtxtPassword";
			this.mtxtPassword.PasswordChar = '*';
			this.mtxtPassword.Size = new Size( 185, 23 );
			this.mtxtPassword.TabIndex = 7;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new Point( 56, 106 );
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new Size( 42, 15 );
			this.lblPassword.TabIndex = 6;
			this.lblPassword.Text = "Senha:";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new Point( 104, 73 );
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new Size( 185, 23 );
			this.txtUsuario.TabIndex = 5;
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Location = new Point( 48, 77 );
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new Size( 50, 15 );
			this.lblUser.TabIndex = 4;
			this.lblUser.Text = "Usuário:";
			// 
			// txtName
			// 
			this.txtName.Location = new Point( 104, 44 );
			this.txtName.Name = "txtName";
			this.txtName.Size = new Size( 185, 23 );
			this.txtName.TabIndex = 3;
			// 
			// txtId
			// 
			this.txtId.Location = new Point( 104, 15 );
			this.txtId.Name = "txtId";
			this.txtId.ReadOnly = true;
			this.txtId.Size = new Size( 43, 23 );
			this.txtId.TabIndex = 1;
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new Point( 78, 19 );
			this.lblId.Name = "lblId";
			this.lblId.Size = new Size( 20, 15 );
			this.lblId.TabIndex = 0;
			this.lblId.Text = "Id:";
			// 
			// tbpEmail
			// 
			this.tbpEmail.Controls.Add( this.panel2 );
			this.tbpEmail.Location = new Point( 4, 24 );
			this.tbpEmail.Name = "tbpEmail";
			this.tbpEmail.Padding = new Padding( 3 );
			this.tbpEmail.Size = new Size( 367, 177 );
			this.tbpEmail.TabIndex = 1;
			this.tbpEmail.Text = "E-mail";
			this.tbpEmail.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = SystemColors.Control;
			this.panel2.BorderStyle = BorderStyle.Fixed3D;
			this.panel2.Controls.Add( this.txtEmail );
			this.panel2.Controls.Add( this.txtPort );
			this.panel2.Controls.Add( this.txtSmtp );
			this.panel2.Controls.Add( this.mtxtEmailPassword );
			this.panel2.Controls.Add( this.lblPort );
			this.panel2.Controls.Add( this.lblSmtp );
			this.panel2.Controls.Add( this.lblEmailPassword );
			this.panel2.Controls.Add( this.lblEmail );
			this.panel2.Dock = DockStyle.Fill;
			this.panel2.Location = new Point( 3, 3 );
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size( 361, 171 );
			this.panel2.TabIndex = 0;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new Point( 106, 17 );
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new Size( 157, 23 );
			this.txtEmail.TabIndex = 1;
			// 
			// txtPort
			// 
			this.txtPort.Location = new Point( 106, 104 );
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new Size( 100, 23 );
			this.txtPort.TabIndex = 7;
			// 
			// txtSmtp
			// 
			this.txtSmtp.Location = new Point( 106, 75 );
			this.txtSmtp.Name = "txtSmtp";
			this.txtSmtp.Size = new Size( 157, 23 );
			this.txtSmtp.TabIndex = 5;
			// 
			// mtxtEmailPassword
			// 
			this.mtxtEmailPassword.Location = new Point( 106, 46 );
			this.mtxtEmailPassword.Name = "mtxtEmailPassword";
			this.mtxtEmailPassword.PasswordChar = '*';
			this.mtxtEmailPassword.Size = new Size( 157, 23 );
			this.mtxtEmailPassword.TabIndex = 3;
			// 
			// lblPort
			// 
			this.lblPort.AutoSize = true;
			this.lblPort.Location = new Point( 62, 108 );
			this.lblPort.Name = "lblPort";
			this.lblPort.Size = new Size( 38, 15 );
			this.lblPort.TabIndex = 6;
			this.lblPort.Text = "Porta:";
			// 
			// lblSmtp
			// 
			this.lblSmtp.AutoSize = true;
			this.lblSmtp.Location = new Point( 60, 79 );
			this.lblSmtp.Name = "lblSmtp";
			this.lblSmtp.Size = new Size( 40, 15 );
			this.lblSmtp.TabIndex = 4;
			this.lblSmtp.Text = "SMTP:";
			// 
			// lblEmailPassword
			// 
			this.lblEmailPassword.AutoSize = true;
			this.lblEmailPassword.Location = new Point( 4, 50 );
			this.lblEmailPassword.Name = "lblEmailPassword";
			this.lblEmailPassword.Size = new Size( 96, 15 );
			this.lblEmailPassword.TabIndex = 2;
			this.lblEmailPassword.Text = "Senha do E-mail:";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new Point( 56, 21 );
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new Size( 44, 15 );
			this.lblEmail.TabIndex = 0;
			this.lblEmail.Text = "E-mail:";
			// 
			// FrmUserAddEdit
			// 
			this.AutoScaleDimensions = new SizeF( 7F, 15F );
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size( 375, 259 );
			this.Controls.Add( this.tabControl );
			this.Name = "FrmUserAddEdit";
			this.Text = "Usuário";
			this.Load +=  this.FrmUserAddEdit_Load ;
			this.Controls.SetChildIndex( this.tabControl, 0 );
			this.tabControl.ResumeLayout( false );
			this.tbpGeneral.ResumeLayout( false );
			this.panel1.ResumeLayout( false );
			this.panel1.PerformLayout();
			( (System.ComponentModel.ISupportInitialize)this.bindCompany ).EndInit();
			this.tbpEmail.ResumeLayout( false );
			this.panel2.ResumeLayout( false );
			this.panel2.PerformLayout();
			this.ResumeLayout( false );
			this.PerformLayout();
		}

		#endregion

		private TabControl tabControl;
		private TabPage tbpGeneral;
		private Panel panel1;
		private TabPage tbpEmail;
		private Panel panel2;
		private TextBox txtName;
		private TextBox txtId;
		private Label label2;
		private Label lblId;
		private TextBox txtEmail;
		private TextBox txtPort;
		private TextBox txtSmtp;
		private MaskedTextBox mtxtEmailPassword;
		private Label lblPort;
		private Label lblSmtp;
		private Label lblEmailPassword;
		private Label lblEmail;
		private MaskedTextBox mtxtPassword;
		private Label lblPassword;
		private TextBox txtUsuario;
		private Label lblUser;
		private ComboBox cboEmpresa;
		private Label lblEmpresa;
		private BindingSource bindCompany;
		private TextBox textBox2;
		private TextBox textBox1;
		private MaskedTextBox maskedTextBox2;
		private MaskedTextBox mtxtEmail;
		private Label label4;
		private Label label3;
		private Label lblName;
	}
}