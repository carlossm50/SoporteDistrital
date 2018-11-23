/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 11/12/2009
 * Hora: 08:33 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace SoporteDistrital
{
	partial class FrmAsigTarjApoyo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.mtxtcedula = new System.Windows.Forms.MaskedTextBox();
			this.mtxtcelular = new System.Windows.Forms.MaskedTextBox();
			this.mtxtelefono = new System.Windows.Forms.MaskedTextBox();
			this.cmbfechaingreso = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.cmbfechanacimiento = new System.Windows.Forms.DateTimePicker();
			this.rdbfemenino = new System.Windows.Forms.RadioButton();
			this.rdbmasculino = new System.Windows.Forms.RadioButton();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtdireccion = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtapellido2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtapellido1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtTanda = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtIngresos = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbcargo = new System.Windows.Forms.ComboBox();
			this.txtCodCent = new System.Windows.Forms.MaskedTextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.txtNomCent = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtTarNo = new System.Windows.Forms.MaskedTextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.btnsiguiente = new System.Windows.Forms.Button();
			this.btnultimo = new System.Windows.Forms.Button();
			this.btnatras = new System.Windows.Forms.Button();
			this.btnprimero = new System.Windows.Forms.Button();
			this.btneditar = new System.Windows.Forms.Button();
			this.btnverinforme = new System.Windows.Forms.Button();
			this.btncancelar = new System.Windows.Forms.Button();
			this.btnguardar = new System.Windows.Forms.Button();
			this.btnnuevo = new System.Windows.Forms.Button();
			this.btnsalir = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.mtxtcedula);
			this.groupBox1.Controls.Add(this.mtxtcelular);
			this.groupBox1.Controls.Add(this.mtxtelefono);
			this.groupBox1.Controls.Add(this.cmbfechaingreso);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.cmbfechanacimiento);
			this.groupBox1.Controls.Add(this.rdbfemenino);
			this.groupBox1.Controls.Add(this.rdbmasculino);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtdireccion);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtapellido2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtapellido1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtnombre);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(595, 234);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos Generales";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(234, 19);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Buscar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// mtxtcedula
			// 
			this.mtxtcedula.Location = new System.Drawing.Point(92, 22);
			this.mtxtcedula.Mask = "999-0000000-0";
			this.mtxtcedula.Name = "mtxtcedula";
			this.mtxtcedula.PromptChar = ' ';
			this.mtxtcedula.Size = new System.Drawing.Size(136, 20);
			this.mtxtcedula.TabIndex = 31;
			this.mtxtcedula.Validating += new System.ComponentModel.CancelEventHandler(this.MtxtcedulaValidating);
			this.mtxtcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MtxtcedulaKeyPress);
			// 
			// mtxtcelular
			// 
			this.mtxtcelular.Enabled = false;
			this.mtxtcelular.Location = new System.Drawing.Point(426, 137);
			this.mtxtcelular.Mask = "(999) 000-0000";
			this.mtxtcelular.Name = "mtxtcelular";
			this.mtxtcelular.PromptChar = ' ';
			this.mtxtcelular.Size = new System.Drawing.Size(145, 20);
			this.mtxtcelular.TabIndex = 9;
			// 
			// mtxtelefono
			// 
			this.mtxtelefono.Enabled = false;
			this.mtxtelefono.Location = new System.Drawing.Point(92, 137);
			this.mtxtelefono.Mask = "(999) 000-0000";
			this.mtxtelefono.Name = "mtxtelefono";
			this.mtxtelefono.PromptChar = ' ';
			this.mtxtelefono.Size = new System.Drawing.Size(179, 20);
			this.mtxtelefono.TabIndex = 8;
			// 
			// cmbfechaingreso
			// 
			this.cmbfechaingreso.CustomFormat = "yyyy/MM/dd";
			this.cmbfechaingreso.Enabled = false;
			this.cmbfechaingreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.cmbfechaingreso.Location = new System.Drawing.Point(135, 189);
			this.cmbfechaingreso.Name = "cmbfechaingreso";
			this.cmbfechaingreso.Size = new System.Drawing.Size(136, 20);
			this.cmbfechaingreso.TabIndex = 17;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(18, 193);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 23);
			this.label9.TabIndex = 16;
			this.label9.Text = "Fecha Ingreso";
			// 
			// cmbfechanacimiento
			// 
			this.cmbfechanacimiento.CustomFormat = "yyyy/MM/dd";
			this.cmbfechanacimiento.Enabled = false;
			this.cmbfechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.cmbfechanacimiento.Location = new System.Drawing.Point(426, 78);
			this.cmbfechanacimiento.Name = "cmbfechanacimiento";
			this.cmbfechanacimiento.Size = new System.Drawing.Size(145, 20);
			this.cmbfechanacimiento.TabIndex = 6;
			// 
			// rdbfemenino
			// 
			this.rdbfemenino.Enabled = false;
			this.rdbfemenino.ImageIndex = 0;
			this.rdbfemenino.Location = new System.Drawing.Point(193, 159);
			this.rdbfemenino.Name = "rdbfemenino";
			this.rdbfemenino.Size = new System.Drawing.Size(82, 24);
			this.rdbfemenino.TabIndex = 11;
			this.rdbfemenino.Text = "FEMENINO";
			this.rdbfemenino.UseVisualStyleBackColor = true;
			// 
			// rdbmasculino
			// 
			this.rdbmasculino.Checked = true;
			this.rdbmasculino.Enabled = false;
			this.rdbmasculino.ImageIndex = 1;
			this.rdbmasculino.Location = new System.Drawing.Point(94, 159);
			this.rdbmasculino.Name = "rdbmasculino";
			this.rdbmasculino.Size = new System.Drawing.Size(99, 24);
			this.rdbmasculino.TabIndex = 10;
			this.rdbmasculino.TabStop = true;
			this.rdbmasculino.Text = "MASCULINO";
			this.rdbmasculino.UseVisualStyleBackColor = true;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(9, 165);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(61, 18);
			this.label12.TabIndex = 22;
			this.label12.Text = "Sexo ";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(309, 82);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(97, 23);
			this.label10.TabIndex = 18;
			this.label10.Text = "Fecha Nacimiento";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(9, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 14;
			this.label5.Text = "Cedula ";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(309, 140);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = "Celular";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(9, 140);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(61, 23);
			this.label7.TabIndex = 10;
			this.label7.Text = "Telefono";
			// 
			// txtdireccion
			// 
			this.txtdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtdireccion.Enabled = false;
			this.txtdireccion.Location = new System.Drawing.Point(92, 108);
			this.txtdireccion.Name = "txtdireccion";
			this.txtdireccion.Size = new System.Drawing.Size(479, 20);
			this.txtdireccion.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(9, 111);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(61, 23);
			this.label8.TabIndex = 8;
			this.label8.Text = "Direccion";
			// 
			// txtapellido2
			// 
			this.txtapellido2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtapellido2.Enabled = false;
			this.txtapellido2.Location = new System.Drawing.Point(92, 79);
			this.txtapellido2.Name = "txtapellido2";
			this.txtapellido2.Size = new System.Drawing.Size(179, 20);
			this.txtapellido2.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(9, 82);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "2do Apellido";
			// 
			// txtapellido1
			// 
			this.txtapellido1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtapellido1.Enabled = false;
			this.txtapellido1.Location = new System.Drawing.Point(392, 50);
			this.txtapellido1.Name = "txtapellido1";
			this.txtapellido1.Size = new System.Drawing.Size(179, 20);
			this.txtapellido1.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(309, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "1er Apellido";
			// 
			// txtnombre
			// 
			this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtnombre.Enabled = false;
			this.txtnombre.Location = new System.Drawing.Point(92, 50);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(179, 20);
			this.txtnombre.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(9, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombre";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtTanda);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.txtIngresos);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.cmbcargo);
			this.groupBox2.Controls.Add(this.txtCodCent);
			this.groupBox2.Controls.Add(this.button4);
			this.groupBox2.Controls.Add(this.txtNomCent);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.txtTarNo);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Location = new System.Drawing.Point(12, 257);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(592, 147);
			this.groupBox2.TabIndex = 29;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Datos Tarjeta";
			// 
			// txtTanda
			// 
			this.txtTanda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtTanda.Enabled = false;
			this.txtTanda.Location = new System.Drawing.Point(397, 97);
			this.txtTanda.MaxLength = 2;
			this.txtTanda.Name = "txtTanda";
			this.txtTanda.Size = new System.Drawing.Size(184, 20);
			this.txtTanda.TabIndex = 24;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(294, 100);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(105, 23);
			this.label14.TabIndex = 25;
			this.label14.Text = "Tanda";
			// 
			// txtIngresos
			// 
			this.txtIngresos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtIngresos.Enabled = false;
			this.txtIngresos.Location = new System.Drawing.Point(92, 97);
			this.txtIngresos.MaxLength = 10;
			this.txtIngresos.Name = "txtIngresos";
			this.txtIngresos.Size = new System.Drawing.Size(87, 20);
			this.txtIngresos.TabIndex = 23;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 23);
			this.label1.TabIndex = 22;
			this.label1.Text = "Ingresos";
			// 
			// cmbcargo
			// 
			this.cmbcargo.DisplayMember = "0";
			this.cmbcargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbcargo.Enabled = false;
			this.cmbcargo.FormattingEnabled = true;
			this.cmbcargo.Items.AddRange(new object[] {
									"MAESTRO/A BASICA",
									"DIRECTOR BASICA",
									"SUB-DIRECTOR BASICA",
									"CONSERJE",
									"CHOFER",
									"DIGITADOR",
									"DIRECTOR DISTRITAL",
									"SUB-DIRECTOR DISTRITAL",
									"PORTERO",
									"MAYORDOMO",
									"MENSAJERO",
									"JARDINERO",
									"TEC. DISTRITAL",
									"TEC. ADMINISTRATIVO",
									"TEC. AVE.",
									"INSTRUCTOR",
									"MAESTRO EF",
									"ORIENTADOR/A"});
			this.cmbcargo.Location = new System.Drawing.Point(92, 58);
			this.cmbcargo.Name = "cmbcargo";
			this.cmbcargo.Size = new System.Drawing.Size(179, 21);
			this.cmbcargo.TabIndex = 3;
			// 
			// txtCodCent
			// 
			this.txtCodCent.Enabled = false;
			this.txtCodCent.Location = new System.Drawing.Point(397, 19);
			this.txtCodCent.Mask = "99999999";
			this.txtCodCent.Name = "txtCodCent";
			this.txtCodCent.PromptChar = ' ';
			this.txtCodCent.Size = new System.Drawing.Size(77, 20);
			this.txtCodCent.TabIndex = 2;
			// 
			// button4
			// 
			this.button4.Enabled = false;
			this.button4.Location = new System.Drawing.Point(185, 17);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 19;
			this.button4.Text = "Buscar";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// txtNomCent
			// 
			this.txtNomCent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNomCent.Enabled = false;
			this.txtNomCent.Location = new System.Drawing.Point(397, 55);
			this.txtNomCent.MaxLength = 2;
			this.txtNomCent.Name = "txtNomCent";
			this.txtNomCent.Size = new System.Drawing.Size(184, 20);
			this.txtNomCent.TabIndex = 17;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(294, 58);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(105, 23);
			this.label11.TabIndex = 18;
			this.label11.Text = " Nombre del Centro";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(294, 22);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(105, 23);
			this.label13.TabIndex = 16;
			this.label13.Text = "Código del Centro";
			// 
			// txtTarNo
			// 
			this.txtTarNo.Enabled = false;
			this.txtTarNo.Location = new System.Drawing.Point(92, 22);
			this.txtTarNo.Mask = "99999-999";
			this.txtTarNo.Name = "txtTarNo";
			this.txtTarNo.PromptChar = ' ';
			this.txtTarNo.Size = new System.Drawing.Size(87, 20);
			this.txtTarNo.TabIndex = 1;
			this.txtTarNo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTarNoValidating);
			this.txtTarNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTarNoKeyPress);
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(6, 22);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(80, 20);
			this.label15.TabIndex = 14;
			this.label15.Text = "Tarjeta No.";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(6, 61);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(85, 23);
			this.label16.TabIndex = 2;
			this.label16.Text = "Cargo asignado";
			// 
			// btnsiguiente
			// 
			this.btnsiguiente.Enabled = false;
			this.btnsiguiente.Location = new System.Drawing.Point(106, 428);
			this.btnsiguiente.Name = "btnsiguiente";
			this.btnsiguiente.Size = new System.Drawing.Size(41, 23);
			this.btnsiguiente.TabIndex = 48;
			this.btnsiguiente.Text = ">";
			this.btnsiguiente.UseVisualStyleBackColor = true;
			this.btnsiguiente.Click += new System.EventHandler(this.BtnsiguienteClick);
			// 
			// btnultimo
			// 
			this.btnultimo.Enabled = false;
			this.btnultimo.Location = new System.Drawing.Point(149, 428);
			this.btnultimo.Name = "btnultimo";
			this.btnultimo.Size = new System.Drawing.Size(41, 23);
			this.btnultimo.TabIndex = 49;
			this.btnultimo.Text = ">>";
			this.btnultimo.UseVisualStyleBackColor = true;
			this.btnultimo.Click += new System.EventHandler(this.BtnultimoClick);
			// 
			// btnatras
			// 
			this.btnatras.Enabled = false;
			this.btnatras.Location = new System.Drawing.Point(62, 427);
			this.btnatras.Name = "btnatras";
			this.btnatras.Size = new System.Drawing.Size(41, 23);
			this.btnatras.TabIndex = 47;
			this.btnatras.Text = "<";
			this.btnatras.UseVisualStyleBackColor = true;
			this.btnatras.Click += new System.EventHandler(this.BtnatrasClick);
			// 
			// btnprimero
			// 
			this.btnprimero.Enabled = false;
			this.btnprimero.Location = new System.Drawing.Point(20, 427);
			this.btnprimero.Name = "btnprimero";
			this.btnprimero.Size = new System.Drawing.Size(41, 23);
			this.btnprimero.TabIndex = 46;
			this.btnprimero.Text = "<<";
			this.btnprimero.UseVisualStyleBackColor = true;
			this.btnprimero.Click += new System.EventHandler(this.BtnprimeroClick);
			// 
			// btneditar
			// 
			this.btneditar.Location = new System.Drawing.Point(293, 429);
			this.btneditar.Name = "btneditar";
			this.btneditar.Size = new System.Drawing.Size(41, 23);
			this.btneditar.TabIndex = 43;
			this.btneditar.Text = "Editar";
			this.btneditar.UseVisualStyleBackColor = true;
			this.btneditar.Click += new System.EventHandler(this.BtneditarClick);
			// 
			// btnverinforme
			// 
			this.btnverinforme.Location = new System.Drawing.Point(383, 429);
			this.btnverinforme.Name = "btnverinforme";
			this.btnverinforme.Size = new System.Drawing.Size(41, 23);
			this.btnverinforme.TabIndex = 45;
			this.btnverinforme.Text = "Ver Informe";
			this.btnverinforme.UseVisualStyleBackColor = true;
			// 
			// btncancelar
			// 
			this.btncancelar.Location = new System.Drawing.Point(336, 429);
			this.btncancelar.Name = "btncancelar";
			this.btncancelar.Size = new System.Drawing.Size(41, 23);
			this.btncancelar.TabIndex = 44;
			this.btncancelar.Text = "Cancelar";
			this.btncancelar.UseVisualStyleBackColor = true;
			this.btncancelar.Click += new System.EventHandler(this.BtncancelarClick);
			// 
			// btnguardar
			// 
			this.btnguardar.Location = new System.Drawing.Point(249, 428);
			this.btnguardar.Name = "btnguardar";
			this.btnguardar.Size = new System.Drawing.Size(41, 23);
			this.btnguardar.TabIndex = 42;
			this.btnguardar.Text = "Guardar";
			this.btnguardar.UseVisualStyleBackColor = true;
			this.btnguardar.Click += new System.EventHandler(this.BtnguardarClick);
			// 
			// btnnuevo
			// 
			this.btnnuevo.Location = new System.Drawing.Point(206, 428);
			this.btnnuevo.Name = "btnnuevo";
			this.btnnuevo.Size = new System.Drawing.Size(41, 23);
			this.btnnuevo.TabIndex = 41;
			this.btnnuevo.Text = "Nuevo";
			this.btnnuevo.UseVisualStyleBackColor = true;
			this.btnnuevo.Click += new System.EventHandler(this.BtnnuevoClick);
			// 
			// btnsalir
			// 
			this.btnsalir.Location = new System.Drawing.Point(552, 429);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(41, 23);
			this.btnsalir.TabIndex = 50;
			this.btnsalir.Text = "Salir";
			this.btnsalir.UseVisualStyleBackColor = true;
			this.btnsalir.Click += new System.EventHandler(this.Button2Click);
			// 
			// FrmAsigTarjApoyo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(620, 463);
			this.Controls.Add(this.btnsalir);
			this.Controls.Add(this.btnsiguiente);
			this.Controls.Add(this.btnultimo);
			this.Controls.Add(this.btnatras);
			this.Controls.Add(this.btnprimero);
			this.Controls.Add(this.btneditar);
			this.Controls.Add(this.btnverinforme);
			this.Controls.Add(this.btncancelar);
			this.Controls.Add(this.btnguardar);
			this.Controls.Add(this.btnnuevo);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FrmAsigTarjApoyo";
			this.Text = "FrmAsigTarjApoyo";
			this.Load += new System.EventHandler(this.FrmAsigTarjApoyoLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnprimero;
		private System.Windows.Forms.Button btnatras;
		private System.Windows.Forms.Button btnultimo;
		private System.Windows.Forms.Button btnsiguiente;
		private System.Windows.Forms.Button btnverinforme;
		private System.Windows.Forms.Button btnsalir;
		private System.Windows.Forms.Button btncancelar;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtTanda;
		private System.Windows.Forms.Button btnnuevo;
		private System.Windows.Forms.Button btnguardar;
		private System.Windows.Forms.Button btneditar;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.MaskedTextBox txtTarNo;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtNomCent;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.MaskedTextBox txtCodCent;
		private System.Windows.Forms.ComboBox cmbcargo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtIngresos;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtapellido1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtapellido2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtdireccion;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.RadioButton rdbmasculino;
		private System.Windows.Forms.RadioButton rdbfemenino;
		private System.Windows.Forms.DateTimePicker cmbfechanacimiento;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DateTimePicker cmbfechaingreso;
		private System.Windows.Forms.MaskedTextBox mtxtelefono;
		private System.Windows.Forms.MaskedTextBox mtxtcelular;
		private System.Windows.Forms.MaskedTextBox mtxtcedula;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
