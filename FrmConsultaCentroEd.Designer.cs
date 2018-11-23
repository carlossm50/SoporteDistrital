/*
 * Creado por SharpDevelop.
 * Usuario: admin
 * Fecha: 13/06/2010
 * Hora: 03:08 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace SoporteDistrital
{
	partial class FrmConsultaCentroEd
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaCentroEd));
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.salir = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.RegionalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CentroEd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fnacim = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Buscar = new System.Windows.Forms.Button();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtcodigo = new System.Windows.Forms.TextBox();
			this.btnimprimir = new System.Windows.Forms.Button();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.chbmat = new System.Windows.Forms.CheckBox();
			this.chbvesp = new System.Windows.Forms.CheckBox();
			this.chbnot = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label4.Location = new System.Drawing.Point(92, 394);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(14, 13);
			this.label4.TabIndex = 34;
			this.label4.Text = "0";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label3.Location = new System.Drawing.Point(31, 394);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 23);
			this.label3.TabIndex = 33;
			this.label3.Text = "TOTAL:";
			// 
			// salir
			// 
			this.salir.Location = new System.Drawing.Point(516, 432);
			this.salir.Name = "salir";
			this.salir.Size = new System.Drawing.Size(75, 23);
			this.salir.TabIndex = 32;
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
									this.CentroEd,
									this.tanda,
									this.fnacim,
									this.Tarjeta,
									this.cargo,
									this.sueldo});
			this.dataGridView1.Location = new System.Drawing.Point(31, 71);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(907, 309);
			this.dataGridView1.TabIndex = 30;
			// 
			// RegionalNo
			// 
			this.RegionalNo.DataPropertyName = "codigoCent";
			this.RegionalNo.HeaderText = "Codigo";
			this.RegionalNo.Name = "RegionalNo";
			this.RegionalNo.ReadOnly = true;
			// 
			// CentroEd
			// 
			this.CentroEd.DataPropertyName = "nombre";
			this.CentroEd.HeaderText = "Centro Educativo";
			this.CentroEd.Name = "CentroEd";
			this.CentroEd.ReadOnly = true;
			this.CentroEd.Width = 200;
			// 
			// tanda
			// 
			this.tanda.DataPropertyName = "tanda";
			this.tanda.HeaderText = "Tanda";
			this.tanda.Name = "tanda";
			this.tanda.ReadOnly = true;
			// 
			// fnacim
			// 
			this.fnacim.DataPropertyName = "direccion";
			this.fnacim.HeaderText = "Dirección";
			this.fnacim.Name = "fnacim";
			this.fnacim.ReadOnly = true;
			this.fnacim.Width = 200;
			// 
			// Tarjeta
			// 
			this.Tarjeta.DataPropertyName = "telefono";
			this.Tarjeta.HeaderText = "Teléfono";
			this.Tarjeta.Name = "Tarjeta";
			this.Tarjeta.ReadOnly = true;
			// 
			// cargo
			// 
			this.cargo.DataPropertyName = "cant_aulas";
			this.cargo.HeaderText = "Cant. Aulas";
			this.cargo.Name = "cargo";
			this.cargo.ReadOnly = true;
			// 
			// sueldo
			// 
			this.sueldo.DataPropertyName = "cant_secc";
			this.sueldo.HeaderText = "Cant. Secciones";
			this.sueldo.Name = "sueldo";
			this.sueldo.ReadOnly = true;
			// 
			// Buscar
			// 
			this.Buscar.Location = new System.Drawing.Point(314, 432);
			this.Buscar.Name = "Buscar";
			this.Buscar.Size = new System.Drawing.Size(75, 23);
			this.Buscar.TabIndex = 29;
			this.Buscar.Text = "Buscar";
			this.Buscar.UseVisualStyleBackColor = true;
			this.Buscar.Click += new System.EventHandler(this.BuscarClick);
			// 
			// txtNom
			// 
			this.txtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNom.Location = new System.Drawing.Point(112, 42);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(223, 20);
			this.txtNom.TabIndex = 28;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(31, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 17);
			this.label2.TabIndex = 27;
			this.label2.Text = "Nombre centro";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(31, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 23);
			this.label1.TabIndex = 26;
			this.label1.Text = "Codigo centro";
			// 
			// txtcodigo
			// 
			this.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtcodigo.Location = new System.Drawing.Point(112, 16);
			this.txtcodigo.Name = "txtcodigo";
			this.txtcodigo.Size = new System.Drawing.Size(86, 20);
			this.txtcodigo.TabIndex = 36;
			this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1KeyPress);
			// 
			// btnimprimir
			// 
			this.btnimprimir.Location = new System.Drawing.Point(412, 432);
			this.btnimprimir.Name = "btnimprimir";
			this.btnimprimir.Size = new System.Drawing.Size(75, 23);
			this.btnimprimir.TabIndex = 40;
			this.btnimprimir.Text = "Exportar";
			this.btnimprimir.UseVisualStyleBackColor = true;
			this.btnimprimir.Click += new System.EventHandler(this.BtnimprimirClick);
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
			// chbmat
			// 
			this.chbmat.Location = new System.Drawing.Point(368, 8);
			this.chbmat.Name = "chbmat";
			this.chbmat.Size = new System.Drawing.Size(104, 24);
			this.chbmat.TabIndex = 41;
			this.chbmat.Text = "MATUTINA";
			this.chbmat.UseVisualStyleBackColor = true;
			// 
			// chbvesp
			// 
			this.chbvesp.Location = new System.Drawing.Point(368, 27);
			this.chbvesp.Name = "chbvesp";
			this.chbvesp.Size = new System.Drawing.Size(104, 24);
			this.chbvesp.TabIndex = 42;
			this.chbvesp.Text = "VESPERTINA";
			this.chbvesp.UseVisualStyleBackColor = true;
			// 
			// chbnot
			// 
			this.chbnot.Location = new System.Drawing.Point(368, 45);
			this.chbnot.Name = "chbnot";
			this.chbnot.Size = new System.Drawing.Size(104, 24);
			this.chbnot.TabIndex = 43;
			this.chbnot.Text = "NOCTURNA";
			this.chbnot.UseVisualStyleBackColor = true;
			// 
			// FrmConsultaCentroEd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(968, 474);
			this.Controls.Add(this.chbnot);
			this.Controls.Add(this.chbvesp);
			this.Controls.Add(this.chbmat);
			this.Controls.Add(this.btnimprimir);
			this.Controls.Add(this.txtcodigo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.salir);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Buscar);
			this.Controls.Add(this.txtNom);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmConsultaCentroEd";
			this.ShowInTaskbar = false;
			this.Text = "Consultar Centro Educativo";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox chbmat;
		private System.Windows.Forms.CheckBox chbvesp;
		private System.Windows.Forms.CheckBox chbnot;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.Button btnimprimir;
		private System.Windows.Forms.TextBox txtcodigo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNom;
		private System.Windows.Forms.Button Buscar;
		private System.Windows.Forms.DataGridViewTextBoxColumn sueldo;
		private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
		private System.Windows.Forms.DataGridViewTextBoxColumn tanda;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tarjeta;
		private System.Windows.Forms.DataGridViewTextBoxColumn CentroEd;
		private System.Windows.Forms.DataGridViewTextBoxColumn fnacim;
		private System.Windows.Forms.DataGridViewTextBoxColumn RegionalNo;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button salir;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}
