/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 26/02/2010
 * Hora: 06:24 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace SoporteDistrital
{
	partial class FrmConsultaPersArea
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaPersArea));
			this.salir = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.RegionalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fnacim = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CentroEd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Buscar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbNivel = new System.Windows.Forms.ComboBox();
			this.CBarea = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.printButton = new System.Windows.Forms.Button();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// salir
			// 
			this.salir.Location = new System.Drawing.Point(386, 446);
			this.salir.Name = "salir";
			this.salir.Size = new System.Drawing.Size(75, 23);
			this.salir.TabIndex = 30;
			this.salir.Text = "Salir";
			this.salir.UseVisualStyleBackColor = true;
			this.salir.Click += new System.EventHandler(this.SalirClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.RegionalNo,
									this.nombre,
									this.fnacim,
									this.CentroEd,
									this.cargo});
			this.dataGridView1.Location = new System.Drawing.Point(14, 85);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(633, 275);
			this.dataGridView1.TabIndex = 28;
			// 
			// RegionalNo
			// 
			this.RegionalNo.DataPropertyName = "cedula";
			this.RegionalNo.HeaderText = "Cédula";
			this.RegionalNo.Name = "RegionalNo";
			this.RegionalNo.ReadOnly = true;
			// 
			// nombre
			// 
			this.nombre.DataPropertyName = "nombre";
			this.nombre.HeaderText = "Nombre";
			this.nombre.Name = "nombre";
			this.nombre.ReadOnly = true;
			this.nombre.Width = 200;
			// 
			// fnacim
			// 
			this.fnacim.DataPropertyName = "nivelacad";
			this.fnacim.HeaderText = "Nivel académico";
			this.fnacim.Name = "fnacim";
			this.fnacim.ReadOnly = true;
			// 
			// CentroEd
			// 
			this.CentroEd.DataPropertyName = "titulo";
			this.CentroEd.HeaderText = "Título";
			this.CentroEd.Name = "CentroEd";
			this.CentroEd.ReadOnly = true;
			// 
			// cargo
			// 
			this.cargo.DataPropertyName = "areaestudio";
			this.cargo.HeaderText = "Area";
			this.cargo.Name = "cargo";
			this.cargo.ReadOnly = true;
			// 
			// Buscar
			// 
			this.Buscar.Location = new System.Drawing.Point(197, 446);
			this.Buscar.Name = "Buscar";
			this.Buscar.Size = new System.Drawing.Size(75, 23);
			this.Buscar.TabIndex = 27;
			this.Buscar.Text = "Buscar";
			this.Buscar.UseVisualStyleBackColor = true;
			this.Buscar.Click += new System.EventHandler(this.BuscarClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbNivel);
			this.groupBox1.Controls.Add(this.CBarea);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(14, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(604, 76);
			this.groupBox1.TabIndex = 39;
			this.groupBox1.TabStop = false;
			// 
			// cmbNivel
			// 
			this.cmbNivel.DisplayMember = "0";
			this.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbNivel.FormattingEnabled = true;
			this.cmbNivel.ItemHeight = 13;
			this.cmbNivel.Items.AddRange(new object[] {
									"",
									"BACHILLER",
									"LICENCIADO",
									"POST-GRADO",
									"MAESTRIA",
									"DOCTORADO"});
			this.cmbNivel.Location = new System.Drawing.Point(76, 39);
			this.cmbNivel.Name = "cmbNivel";
			this.cmbNivel.Size = new System.Drawing.Size(179, 21);
			this.cmbNivel.TabIndex = 41;
			// 
			// CBarea
			// 
			this.CBarea.FormattingEnabled = true;
			this.CBarea.Items.AddRange(new object[] {
									"",
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
									"BIOLOGIA",
									"OTROS"});
			this.CBarea.Location = new System.Drawing.Point(76, 12);
			this.CBarea.Name = "CBarea";
			this.CBarea.Size = new System.Drawing.Size(179, 21);
			this.CBarea.TabIndex = 40;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 17);
			this.label3.TabIndex = 39;
			this.label3.Text = "Área";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 39);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 21);
			this.label4.TabIndex = 31;
			this.label4.Text = "Título";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label1.Location = new System.Drawing.Point(62, 373);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(14, 13);
			this.label1.TabIndex = 41;
			this.label1.Text = "0";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label2.Location = new System.Drawing.Point(14, 373);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 23);
			this.label2.TabIndex = 40;
			this.label2.Text = "TOTAL:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(303, 396);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(14, 13);
			this.label5.TabIndex = 43;
			this.label5.Text = "0";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(215, 396);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 23);
			this.label6.TabIndex = 42;
			this.label6.Text = "LICENCIADOS:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(547, 373);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(14, 13);
			this.label7.TabIndex = 45;
			this.label7.Text = "0";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(460, 373);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(96, 23);
			this.label8.TabIndex = 44;
			this.label8.Text = "POST-GRADO:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(547, 419);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(14, 13);
			this.label9.TabIndex = 49;
			this.label9.Text = "0";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(462, 419);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(96, 23);
			this.label10.TabIndex = 48;
			this.label10.Text = "DOCTORADO:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(547, 396);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(14, 13);
			this.label11.TabIndex = 47;
			this.label11.Text = "0";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Black;
			this.label12.Location = new System.Drawing.Point(479, 396);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(79, 23);
			this.label12.TabIndex = 46;
			this.label12.Text = "MAESTRIA:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(303, 373);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(14, 13);
			this.label13.TabIndex = 51;
			this.label13.Text = "0";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Black;
			this.label14.Location = new System.Drawing.Point(201, 373);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(119, 23);
			this.label14.TabIndex = 50;
			this.label14.Text = "BACHILLER(ES) :";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.Black;
			this.label15.Location = new System.Drawing.Point(496, 439);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(65, 23);
			this.label15.TabIndex = 52;
			this.label15.Text = "OTROS: 0";
			// 
			// printButton
			// 
			this.printButton.Location = new System.Drawing.Point(294, 446);
			this.printButton.Name = "printButton";
			this.printButton.Size = new System.Drawing.Size(75, 23);
			this.printButton.TabIndex = 53;
			this.printButton.Text = "Exportar";
			this.printButton.UseVisualStyleBackColor = true;
			this.printButton.Click += new System.EventHandler(this.PrintButtonClick);
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
			// 
			// FrmConsultaPersArea
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(662, 477);
			this.Controls.Add(this.printButton);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.salir);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Buscar);
			this.Name = "FrmConsultaPersArea";
			this.Text = "Consulta de personal por area de estudio";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.Button printButton;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbNivel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox CBarea;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button Buscar;
		private System.Windows.Forms.DataGridViewTextBoxColumn CentroEd;
		private System.Windows.Forms.DataGridViewTextBoxColumn fnacim;
		private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn RegionalNo;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button salir;
	}
}
