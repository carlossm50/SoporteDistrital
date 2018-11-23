/*
 * Creado por SharpDevelop.
 * Usuario: dell
 * Fecha: 13/07/2011
 * Hora: 03:43 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace SoporteDistrital
{
	partial class Form1
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
			this.btnimportar = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnexportar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnimportar
			// 
			this.btnimportar.Location = new System.Drawing.Point(602, 295);
			this.btnimportar.Name = "btnimportar";
			this.btnimportar.Size = new System.Drawing.Size(75, 23);
			this.btnimportar.TabIndex = 0;
			this.btnimportar.Text = "Importar";
			this.btnimportar.UseVisualStyleBackColor = true;
			this.btnimportar.Click += new System.EventHandler(this.BtnimportarClick);
			// 
			// dataGridView1
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(8, 10);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(698, 277);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellDoubleClick);
			// 
			// btnexportar
			// 
			this.btnexportar.Location = new System.Drawing.Point(427, 295);
			this.btnexportar.Name = "btnexportar";
			this.btnexportar.Size = new System.Drawing.Size(169, 23);
			this.btnexportar.TabIndex = 2;
			this.btnexportar.Text = "Exportar a Base de Datos";
			this.btnexportar.UseVisualStyleBackColor = true;
			this.btnexportar.Click += new System.EventHandler(this.BtnexportarClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(713, 330);
			this.Controls.Add(this.btnexportar);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnimportar);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnexportar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnimportar;
	}
}
