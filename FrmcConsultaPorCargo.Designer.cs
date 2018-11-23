/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 26/02/2010
 * Hora: 11:56 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace SoporteDistrital
{
	partial class FrmcConsultaPorCargo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmcConsultaPorCargo));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.salir = new System.Windows.Forms.Button();
			this.Buscar = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.RegionalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fnacim = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CentroEd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CBarea = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.printButton = new System.Windows.Forms.Button();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label1.Location = new System.Drawing.Point(59, 375);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(14, 13);
			this.label1.TabIndex = 47;
			this.label1.Text = "0";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label2.Location = new System.Drawing.Point(11, 375);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 23);
			this.label2.TabIndex = 46;
			this.label2.Text = "TOTAL:";
			// 
			// salir
			// 
			this.salir.Location = new System.Drawing.Point(525, 375);
			this.salir.Name = "salir";
			this.salir.Size = new System.Drawing.Size(75, 23);
			this.salir.TabIndex = 44;
			this.salir.Text = "Salir";
			this.salir.UseVisualStyleBackColor = true;
			this.salir.Click += new System.EventHandler(this.SalirClick);
			// 
			// Buscar
			// 
			this.Buscar.Location = new System.Drawing.Point(336, 375);
			this.Buscar.Name = "Buscar";
			this.Buscar.Size = new System.Drawing.Size(75, 23);
			this.Buscar.TabIndex = 42;
			this.Buscar.Text = "Buscar";
			this.Buscar.UseVisualStyleBackColor = true;
			this.Buscar.Click += new System.EventHandler(this.BuscarClick);
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
									this.Tarjeta,
									this.tanda,
									this.cargo,
									this.sueldo});
			this.dataGridView1.Location = new System.Drawing.Point(12, 48);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(907, 309);
			this.dataGridView1.TabIndex = 48;
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
			this.fnacim.DataPropertyName = "anoserv";
			this.fnacim.HeaderText = "Años servicio";
			this.fnacim.Name = "fnacim";
			this.fnacim.ReadOnly = true;
			// 
			// CentroEd
			// 
			this.CentroEd.DataPropertyName = "d_nombre";
			this.CentroEd.HeaderText = "Centro Educativo";
			this.CentroEd.Name = "CentroEd";
			this.CentroEd.ReadOnly = true;
			// 
			// Tarjeta
			// 
			this.Tarjeta.DataPropertyName = "tarjeta";
			this.Tarjeta.HeaderText = "Tarjeta";
			this.Tarjeta.Name = "Tarjeta";
			this.Tarjeta.ReadOnly = true;
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
			// CBarea
			// 
			this.CBarea.FormattingEnabled = true;
			this.CBarea.Items.AddRange(new object[] {
									"TODOS",
									"MAESTRO/A BASICA",
									"MAESTRO/A MEDIA GENERAL",
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
									"ORIENTADOR/A",
									"MAESTRO/A ADULTOS"});
			this.CBarea.Location = new System.Drawing.Point(82, 12);
			this.CBarea.Name = "CBarea";
			this.CBarea.Size = new System.Drawing.Size(179, 21);
			this.CBarea.TabIndex = 50;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 17);
			this.label3.TabIndex = 49;
			this.label3.Text = "Cargo";
			// 
			// printButton
			// 
			this.printButton.Location = new System.Drawing.Point(429, 376);
			this.printButton.Name = "printButton";
			this.printButton.Size = new System.Drawing.Size(75, 23);
			this.printButton.TabIndex = 51;
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
			// FrmcConsultaPorCargo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(932, 411);
			this.Controls.Add(this.printButton);
			this.Controls.Add(this.CBarea);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.salir);
			this.Controls.Add(this.Buscar);
			this.Name = "FrmcConsultaPorCargo";
			this.Text = "Consulta de personal por cargo";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.Button printButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn sueldo;
		private System.Windows.Forms.DataGridViewTextBoxColumn tanda;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tarjeta;
		private System.Windows.Forms.Button Buscar;
		private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
		private System.Windows.Forms.DataGridViewTextBoxColumn CentroEd;
		private System.Windows.Forms.DataGridViewTextBoxColumn fnacim;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn RegionalNo;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button salir;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox CBarea;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
