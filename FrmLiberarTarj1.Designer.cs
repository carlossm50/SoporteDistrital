/*
 * Creado por SharpDevelop.
 * Usuario: admin
 * Fecha: 29/06/2010
 * Hora: 11:58 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace SoporteDistrital
{
	partial class FrmLiberarTarj1
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLiberarTarj1));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Buscar = new System.Windows.Forms.Button();
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CentroEd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.printButton = new System.Windows.Forms.Button();
			this.salir = new System.Windows.Forms.Button();
			this.lbsueldo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Buscar);
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
			this.groupBox1.Size = new System.Drawing.Size(595, 234);
			this.groupBox1.TabIndex = 70;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos Generales";
			// 
			// Buscar
			// 
			this.Buscar.Location = new System.Drawing.Point(236, 22);
			this.Buscar.Name = "Buscar";
			this.Buscar.Size = new System.Drawing.Size(75, 23);
			this.Buscar.TabIndex = 73;
			this.Buscar.Text = "Buscar";
			this.Buscar.UseVisualStyleBackColor = true;
			// 
			// mtxtcedula
			// 
			this.mtxtcedula.Location = new System.Drawing.Point(92, 22);
			this.mtxtcedula.Mask = "999-0000000-0";
			this.mtxtcedula.Name = "mtxtcedula";
			this.mtxtcedula.PromptChar = ' ';
			this.mtxtcedula.Size = new System.Drawing.Size(136, 20);
			this.mtxtcedula.TabIndex = 2;
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
			// cmbestatus
			// 
			this.cmbestatus.DisplayMember = "0";
			this.cmbestatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbestatus.Enabled = false;
			this.cmbestatus.FormattingEnabled = true;
			this.cmbestatus.ItemHeight = 13;
			this.cmbestatus.Items.AddRange(new object[] {
									"INACTIVO",
									"ACTIVO"});
			this.cmbestatus.Location = new System.Drawing.Point(392, 190);
			this.cmbestatus.Name = "cmbestatus";
			this.cmbestatus.Size = new System.Drawing.Size(179, 21);
			this.cmbestatus.TabIndex = 16;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(309, 193);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(56, 23);
			this.label14.TabIndex = 30;
			this.label14.Text = "Estado";
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
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Tarjeta,
									this.CentroEd,
									this.tanda,
									this.cargo,
									this.sueldo});
			this.dataGridView1.Location = new System.Drawing.Point(12, 265);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(593, 98);
			this.dataGridView1.TabIndex = 71;
			// 
			// Tarjeta
			// 
			this.Tarjeta.DataPropertyName = "tarjeta";
			this.Tarjeta.HeaderText = "Tarjeta";
			this.Tarjeta.Name = "Tarjeta";
			this.Tarjeta.ReadOnly = true;
			// 
			// CentroEd
			// 
			this.CentroEd.DataPropertyName = "nombre";
			this.CentroEd.HeaderText = "Centro Educativo";
			this.CentroEd.Name = "CentroEd";
			this.CentroEd.ReadOnly = true;
			// 
			// tanda
			// 
			this.tanda.DataPropertyName = "tanda";
			this.tanda.HeaderText = "Tanda";
			this.tanda.Name = "tanda";
			this.tanda.ReadOnly = true;
			// 
			// cargo
			// 
			this.cargo.DataPropertyName = "cargo";
			this.cargo.HeaderText = "Cargo";
			this.cargo.Name = "cargo";
			this.cargo.ReadOnly = true;
			// 
			// sueldo
			// 
			this.sueldo.DataPropertyName = "ingresos";
			this.sueldo.HeaderText = "Sueldo";
			this.sueldo.Name = "sueldo";
			this.sueldo.ReadOnly = true;
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			this.printPreviewDialog1.Load += new System.EventHandler(this.PrintPreviewDialog1Load);
			// 
			// printButton
			// 
			this.printButton.Location = new System.Drawing.Point(181, 383);
			this.printButton.Name = "printButton";
			this.printButton.Size = new System.Drawing.Size(75, 23);
			this.printButton.TabIndex = 74;
			this.printButton.Text = "Exportar";
			this.printButton.UseVisualStyleBackColor = true;
			this.printButton.Click += new System.EventHandler(this.PrintButtonClick);
			// 
			// salir
			// 
			this.salir.Location = new System.Drawing.Point(278, 383);
			this.salir.Name = "salir";
			this.salir.Size = new System.Drawing.Size(75, 23);
			this.salir.TabIndex = 73;
			this.salir.Text = "Salir";
			this.salir.UseVisualStyleBackColor = true;
			this.salir.Click += new System.EventHandler(this.SalirClick);
			// 
			// lbsueldo
			// 
			this.lbsueldo.AutoEllipsis = true;
			this.lbsueldo.AutoSize = true;
			this.lbsueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbsueldo.Location = new System.Drawing.Point(504, 383);
			this.lbsueldo.Name = "lbsueldo";
			this.lbsueldo.Size = new System.Drawing.Size(93, 13);
			this.lbsueldo.TabIndex = 75;
			this.lbsueldo.Text = "Sueldo en RD$";
			// 
			// label1
			// 
			this.label1.AutoEllipsis = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(395, 383);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 23);
			this.label1.TabIndex = 76;
			this.label1.Text = "Sueldo en RD$:";
			// 
			// printDialog1
			// 
			this.printDialog1.UseEXDialog = true;
			// 
			// FrmLiberarTarj1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 426);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbsueldo);
			this.Controls.Add(this.printButton);
			this.Controls.Add(this.salir);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Name = "FrmLiberarTarj1";
			this.Text = "Expedir Certificación";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbsueldo;
		private System.Windows.Forms.Button salir;
		private System.Windows.Forms.Button printButton;
		private System.Windows.Forms.Button Buscar;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.DataGridViewTextBoxColumn sueldo;
		private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
		private System.Windows.Forms.DataGridViewTextBoxColumn tanda;
		private System.Windows.Forms.DataGridViewTextBoxColumn CentroEd;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tarjeta;
		private System.Windows.Forms.DataGridView dataGridView1;
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
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
