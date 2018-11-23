/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 14/02/2010
 * Hora: 03:18 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace SoporteDistrital
{
	partial class FrmConsultaPersonal
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaPersonal));
			this.mtxtcedula = new System.Windows.Forms.MaskedTextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.RegionalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fnacim = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CentroEd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CTMcertificacion = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.imprimirCertificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Buscar = new System.Windows.Forms.Button();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.salir = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.printButton = new System.Windows.Forms.Button();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.CTMcertificacion.SuspendLayout();
			this.SuspendLayout();
			// 
			// mtxtcedula
			// 
			this.mtxtcedula.Location = new System.Drawing.Point(76, 10);
			this.mtxtcedula.Mask = "999-0000000-0";
			this.mtxtcedula.Name = "mtxtcedula";
			this.mtxtcedula.PromptChar = ' ';
			this.mtxtcedula.Size = new System.Drawing.Size(136, 20);
			this.mtxtcedula.TabIndex = 22;
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
			this.dataGridView1.ContextMenuStrip = this.CTMcertificacion;
			this.dataGridView1.Location = new System.Drawing.Point(15, 59);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(907, 309);
			this.dataGridView1.TabIndex = 21;
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
			// CTMcertificacion
			// 
			this.CTMcertificacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.imprimirCertificaciónToolStripMenuItem});
			this.CTMcertificacion.Name = "CTMcertificacion";
			this.CTMcertificacion.Size = new System.Drawing.Size(191, 26);
			this.CTMcertificacion.Opening += new System.ComponentModel.CancelEventHandler(this.CTMcertificacionOpening);
			// 
			// imprimirCertificaciónToolStripMenuItem
			// 
			this.imprimirCertificaciónToolStripMenuItem.Name = "imprimirCertificaciónToolStripMenuItem";
			this.imprimirCertificaciónToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.imprimirCertificaciónToolStripMenuItem.Text = "Imprimir Certificación";
			this.imprimirCertificaciónToolStripMenuItem.Click += new System.EventHandler(this.ImprimirCertificaciónToolStripMenuItemClick);
			// 
			// Buscar
			// 
			this.Buscar.Location = new System.Drawing.Point(357, 419);
			this.Buscar.Name = "Buscar";
			this.Buscar.Size = new System.Drawing.Size(75, 23);
			this.Buscar.TabIndex = 20;
			this.Buscar.Text = "Buscar";
			this.Buscar.UseVisualStyleBackColor = true;
			this.Buscar.Click += new System.EventHandler(this.BuscarClick);
			// 
			// txtNom
			// 
			this.txtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNom.Location = new System.Drawing.Point(76, 33);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(223, 20);
			this.txtNom.TabIndex = 19;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(15, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 17);
			this.label2.TabIndex = 18;
			this.label2.Text = "Nombre";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(15, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 17;
			this.label1.Text = "Cédula";
			// 
			// salir
			// 
			this.salir.Location = new System.Drawing.Point(563, 419);
			this.salir.Name = "salir";
			this.salir.Size = new System.Drawing.Size(75, 23);
			this.salir.TabIndex = 23;
			this.salir.Text = "Salir";
			this.salir.UseVisualStyleBackColor = true;
			this.salir.Click += new System.EventHandler(this.SalirClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label3.Location = new System.Drawing.Point(12, 381);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 23);
			this.label3.TabIndex = 24;
			this.label3.Text = "TOTAL:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label4.Location = new System.Drawing.Point(73, 381);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(14, 13);
			this.label4.TabIndex = 25;
			this.label4.Text = "0";
			// 
			// printButton
			// 
			this.printButton.Location = new System.Drawing.Point(462, 419);
			this.printButton.Name = "printButton";
			this.printButton.Size = new System.Drawing.Size(75, 23);
			this.printButton.TabIndex = 26;
			this.printButton.Text = "Exportar";
			this.printButton.UseVisualStyleBackColor = true;
			this.printButton.Click += new System.EventHandler(this.BtnimprimirClick);
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
			// FrmConsultaPersonal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(931, 464);
			this.Controls.Add(this.printButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.salir);
			this.Controls.Add(this.mtxtcedula);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Buscar);
			this.Controls.Add(this.txtNom);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmConsultaPersonal";
			this.ShowInTaskbar = false;
			this.Text = "Consulta del personal en general";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.CTMcertificacion.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem imprimirCertificaciónToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip CTMcertificacion;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.Button printButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridViewTextBoxColumn tanda;
		private System.Windows.Forms.Button salir;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNom;
		private System.Windows.Forms.Button Buscar;
		private System.Windows.Forms.DataGridViewTextBoxColumn sueldo;
		private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tarjeta;
		private System.Windows.Forms.DataGridViewTextBoxColumn CentroEd;
		private System.Windows.Forms.DataGridViewTextBoxColumn fnacim;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn RegionalNo;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.MaskedTextBox mtxtcedula;
	}
}
