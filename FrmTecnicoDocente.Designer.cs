﻿/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 02/12/2009
 * Hora: 03:24 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace SoporteDistrital
{
	partial class FrmTecnicoDocente
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
			this.txtareaestudio = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.cmbNivel = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.cmbTitulo = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.mtxtcedula = new System.Windows.Forms.MaskedTextBox();
			this.mtxtcelular = new System.Windows.Forms.MaskedTextBox();
			this.mtxtelefono = new System.Windows.Forms.MaskedTextBox();
			this.cmbfechaingreso = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.cmbfechanacimiento = new System.Windows.Forms.DateTimePicker();
			this.cmbestatus = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
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
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtareaestudio);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.cmbNivel);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.cmbTitulo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.mtxtcedula);
			this.groupBox1.Controls.Add(this.mtxtcelular);
			this.groupBox1.Controls.Add(this.mtxtelefono);
			this.groupBox1.Controls.Add(this.cmbfechaingreso);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.cmbfechanacimiento);
			this.groupBox1.Controls.Add(this.cmbestatus);
			this.groupBox1.Controls.Add(this.label14);
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
			this.groupBox1.Size = new System.Drawing.Size(595, 290);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos Generales";
			// 
			// txtareaestudio
			// 
			this.txtareaestudio.FormattingEnabled = true;
			this.txtareaestudio.Items.AddRange(new object[] {
									"LETRAS",
									"LENGUA ESPAÑOLA",
									"MATEMATICA",
									"CIENCIAS SOCIALES",
									"CINECIAS NATURALES",
									"IDIOMAS",
									"INGLES",
									"FRACES",
									"EDUCACION FISICA",
									"INFORMATICA",
									"EDUCACION BASICA",
									"EDUCACION INICIAL",
									"QUIMICA",
									"FISICA",
									"BIOLOGIA"});
			this.txtareaestudio.Location = new System.Drawing.Point(95, 224);
			this.txtareaestudio.Name = "txtareaestudio";
			this.txtareaestudio.Size = new System.Drawing.Size(178, 21);
			this.txtareaestudio.TabIndex = 37;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(309, 192);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(82, 23);
			this.label13.TabIndex = 36;
			this.label13.Text = "Título";
			// 
			// cmbNivel
			// 
			this.cmbNivel.DisplayMember = "0";
			this.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbNivel.FormattingEnabled = true;
			this.cmbNivel.ItemHeight = 13;
			this.cmbNivel.Items.AddRange(new object[] {
									"SECUNDARIA",
									"UNIVERSITARIO"});
			this.cmbNivel.Location = new System.Drawing.Point(94, 189);
			this.cmbNivel.Name = "cmbNivel";
			this.cmbNivel.Size = new System.Drawing.Size(179, 21);
			this.cmbNivel.TabIndex = 12;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(7, 227);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(82, 23);
			this.label11.TabIndex = 33;
			this.label11.Text = "Area de estudio";
			// 
			// cmbTitulo
			// 
			this.cmbTitulo.DisplayMember = "0";
			this.cmbTitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTitulo.FormattingEnabled = true;
			this.cmbTitulo.ItemHeight = 13;
			this.cmbTitulo.Items.AddRange(new object[] {
									"BACHILLER",
									"LICENCIADO",
									"POST-GRADO",
									"MAESTRIA",
									"DOCTORADO"});
			this.cmbTitulo.Location = new System.Drawing.Point(392, 189);
			this.cmbTitulo.Name = "cmbTitulo";
			this.cmbTitulo.Size = new System.Drawing.Size(179, 21);
			this.cmbTitulo.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(9, 192);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 23);
			this.label1.TabIndex = 32;
			this.label1.Text = "Nivel academico";
			// 
			// mtxtcedula
			// 
			this.mtxtcedula.Location = new System.Drawing.Point(92, 22);
			this.mtxtcedula.Mask = "999-0000000-0";
			this.mtxtcedula.Name = "mtxtcedula";
			this.mtxtcedula.PromptChar = ' ';
			this.mtxtcedula.Size = new System.Drawing.Size(136, 20);
			this.mtxtcedula.TabIndex = 2;
			// 
			// mtxtcelular
			// 
			this.mtxtcelular.Location = new System.Drawing.Point(426, 137);
			this.mtxtcelular.Mask = "(999) 000-0000";
			this.mtxtcelular.Name = "mtxtcelular";
			this.mtxtcelular.PromptChar = ' ';
			this.mtxtcelular.Size = new System.Drawing.Size(145, 20);
			this.mtxtcelular.TabIndex = 9;
			// 
			// mtxtelefono
			// 
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
			this.cmbfechaingreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.cmbfechaingreso.Location = new System.Drawing.Point(426, 223);
			this.cmbfechaingreso.Name = "cmbfechaingreso";
			this.cmbfechaingreso.Size = new System.Drawing.Size(145, 20);
			this.cmbfechaingreso.TabIndex = 15;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(309, 227);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 23);
			this.label9.TabIndex = 16;
			this.label9.Text = "Fecha Ingreso";
			// 
			// cmbfechanacimiento
			// 
			this.cmbfechanacimiento.CustomFormat = "yyyy/MM/dd";
			this.cmbfechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.cmbfechanacimiento.Location = new System.Drawing.Point(426, 78);
			this.cmbfechanacimiento.Name = "cmbfechanacimiento";
			this.cmbfechanacimiento.Size = new System.Drawing.Size(145, 20);
			this.cmbfechanacimiento.TabIndex = 6;
			// 
			// cmbestatus
			// 
			this.cmbestatus.DisplayMember = "0";
			this.cmbestatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbestatus.FormattingEnabled = true;
			this.cmbestatus.ItemHeight = 13;
			this.cmbestatus.Items.AddRange(new object[] {
									"INACTIVO",
									"ACTIVO"});
			this.cmbestatus.Location = new System.Drawing.Point(392, 253);
			this.cmbestatus.Name = "cmbestatus";
			this.cmbestatus.Size = new System.Drawing.Size(179, 21);
			this.cmbestatus.TabIndex = 16;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(309, 254);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(56, 23);
			this.label14.TabIndex = 30;
			this.label14.Text = "Estado";
			// 
			// rdbfemenino
			// 
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
			// btnsiguiente
			// 
			this.btnsiguiente.Location = new System.Drawing.Point(101, 324);
			this.btnsiguiente.Name = "btnsiguiente";
			this.btnsiguiente.Size = new System.Drawing.Size(41, 23);
			this.btnsiguiente.TabIndex = 57;
			this.btnsiguiente.Text = ">";
			this.btnsiguiente.UseVisualStyleBackColor = true;
			this.btnsiguiente.Click += new System.EventHandler(this.BtnsiguienteClick);
			// 
			// btnultimo
			// 
			this.btnultimo.Location = new System.Drawing.Point(144, 324);
			this.btnultimo.Name = "btnultimo";
			this.btnultimo.Size = new System.Drawing.Size(41, 23);
			this.btnultimo.TabIndex = 58;
			this.btnultimo.Text = ">>";
			this.btnultimo.UseVisualStyleBackColor = true;
			this.btnultimo.Click += new System.EventHandler(this.BtnultimoClick);
			// 
			// btnatras
			// 
			this.btnatras.Location = new System.Drawing.Point(57, 323);
			this.btnatras.Name = "btnatras";
			this.btnatras.Size = new System.Drawing.Size(41, 23);
			this.btnatras.TabIndex = 56;
			this.btnatras.Text = "<";
			this.btnatras.UseVisualStyleBackColor = true;
			this.btnatras.Click += new System.EventHandler(this.BtnatrasClick);
			// 
			// btnprimero
			// 
			this.btnprimero.Location = new System.Drawing.Point(15, 323);
			this.btnprimero.Name = "btnprimero";
			this.btnprimero.Size = new System.Drawing.Size(41, 23);
			this.btnprimero.TabIndex = 55;
			this.btnprimero.Text = "<<";
			this.btnprimero.UseVisualStyleBackColor = true;
			this.btnprimero.Click += new System.EventHandler(this.BtnprimeroClick);
			// 
			// btneditar
			// 
			this.btneditar.Location = new System.Drawing.Point(288, 325);
			this.btneditar.Name = "btneditar";
			this.btneditar.Size = new System.Drawing.Size(41, 23);
			this.btneditar.TabIndex = 52;
			this.btneditar.Text = "Editar";
			this.btneditar.UseVisualStyleBackColor = true;
			this.btneditar.Click += new System.EventHandler(this.BtneditarClick);
			// 
			// btnverinforme
			// 
			this.btnverinforme.Location = new System.Drawing.Point(378, 325);
			this.btnverinforme.Name = "btnverinforme";
			this.btnverinforme.Size = new System.Drawing.Size(41, 23);
			this.btnverinforme.TabIndex = 54;
			this.btnverinforme.Text = "Ver Informe";
			this.btnverinforme.UseVisualStyleBackColor = true;
			// 
			// btncancelar
			// 
			this.btncancelar.Location = new System.Drawing.Point(331, 325);
			this.btncancelar.Name = "btncancelar";
			this.btncancelar.Size = new System.Drawing.Size(41, 23);
			this.btncancelar.TabIndex = 53;
			this.btncancelar.Text = "Cancelar";
			this.btncancelar.UseVisualStyleBackColor = true;
			this.btncancelar.Click += new System.EventHandler(this.BtncancelarClick);
			// 
			// btnguardar
			// 
			this.btnguardar.Location = new System.Drawing.Point(244, 324);
			this.btnguardar.Name = "btnguardar";
			this.btnguardar.Size = new System.Drawing.Size(41, 23);
			this.btnguardar.TabIndex = 51;
			this.btnguardar.Text = "Guardar";
			this.btnguardar.UseVisualStyleBackColor = true;
			this.btnguardar.Click += new System.EventHandler(this.BtnguardarClick);
			// 
			// btnnuevo
			// 
			this.btnnuevo.Location = new System.Drawing.Point(201, 324);
			this.btnnuevo.Name = "btnnuevo";
			this.btnnuevo.Size = new System.Drawing.Size(41, 23);
			this.btnnuevo.TabIndex = 50;
			this.btnnuevo.Text = "Nuevo";
			this.btnnuevo.UseVisualStyleBackColor = true;
			this.btnnuevo.Click += new System.EventHandler(this.BtnnuevoClick);
			// 
			// btnsalir
			// 
			this.btnsalir.Location = new System.Drawing.Point(566, 325);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(41, 23);
			this.btnsalir.TabIndex = 59;
			this.btnsalir.Text = "Salir";
			this.btnsalir.UseVisualStyleBackColor = true;
			this.btnsalir.Click += new System.EventHandler(this.Button2Click);
			// 
			// FrmTecnicoDocente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(626, 367);
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
			this.Controls.Add(this.groupBox1);
			this.Name = "FrmTecnicoDocente";
			this.Text = "FrmTecnicoDocente";
			this.Load += new System.EventHandler(this.FrmTecnicoDocenteLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnnuevo;
		private System.Windows.Forms.Button btnguardar;
		private System.Windows.Forms.Button btncancelar;
		private System.Windows.Forms.Button btnverinforme;
		private System.Windows.Forms.Button btneditar;
		private System.Windows.Forms.Button btnprimero;
		private System.Windows.Forms.Button btnatras;
		private System.Windows.Forms.Button btnultimo;
		private System.Windows.Forms.Button btnsiguiente;
		private System.Windows.Forms.Button btnsalir;
		private System.Windows.Forms.ComboBox txtareaestudio;
		private System.Windows.Forms.ComboBox cmbTitulo;
		private System.Windows.Forms.ComboBox cmbNivel;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label11;
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
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox cmbestatus;
		private System.Windows.Forms.DateTimePicker cmbfechanacimiento;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DateTimePicker cmbfechaingreso;
		private System.Windows.Forms.MaskedTextBox mtxtelefono;
		private System.Windows.Forms.MaskedTextBox mtxtcelular;
		private System.Windows.Forms.MaskedTextBox mtxtcedula;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
