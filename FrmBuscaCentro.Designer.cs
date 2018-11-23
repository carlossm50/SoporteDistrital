/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 11/23/2009
 * Time: 11:00 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SoporteDistrital
{
	partial class FrmBuscaCentro
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
			this.txtCodCent = new System.Windows.Forms.MaskedTextBox();
			this.Cancelar = new System.Windows.Forms.Button();
			this.Aceptar = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Buscar = new System.Windows.Forms.Button();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.RegionalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtCodCent
			// 
			this.txtCodCent.Location = new System.Drawing.Point(112, 5);
			this.txtCodCent.Mask = "99999999";
			this.txtCodCent.Name = "txtCodCent";
			this.txtCodCent.PromptChar = ' ';
			this.txtCodCent.Size = new System.Drawing.Size(77, 20);
			this.txtCodCent.TabIndex = 16;
			// 
			// Cancelar
			// 
			this.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancelar.Location = new System.Drawing.Point(357, 225);
			this.Cancelar.Name = "Cancelar";
			this.Cancelar.Size = new System.Drawing.Size(75, 23);
			this.Cancelar.TabIndex = 23;
			this.Cancelar.Text = "Cancelar";
			this.Cancelar.UseVisualStyleBackColor = true;
			// 
			// Aceptar
			// 
			this.Aceptar.Location = new System.Drawing.Point(260, 225);
			this.Aceptar.Name = "Aceptar";
			this.Aceptar.Size = new System.Drawing.Size(75, 23);
			this.Aceptar.TabIndex = 22;
			this.Aceptar.Text = "Aceptar";
			this.Aceptar.UseVisualStyleBackColor = true;
			this.Aceptar.Click += new System.EventHandler(this.AceptarClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.RegionalNo,
									this.nombre,
									this.tanda});
			this.dataGridView1.Location = new System.Drawing.Point(21, 57);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(511, 150);
			this.dataGridView1.TabIndex = 17;
			// 
			// Buscar
			// 
			this.Buscar.Location = new System.Drawing.Point(168, 225);
			this.Buscar.Name = "Buscar";
			this.Buscar.Size = new System.Drawing.Size(75, 23);
			this.Buscar.TabIndex = 21;
			this.Buscar.Text = "Buscar";
			this.Buscar.UseVisualStyleBackColor = true;
			this.Buscar.Click += new System.EventHandler(this.BuscarClick);
			// 
			// txtNom
			// 
			this.txtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNom.Location = new System.Drawing.Point(112, 28);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(223, 20);
			this.txtNom.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(21, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 20;
			this.label2.Text = "Nombre Centro";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(21, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 23);
			this.label1.TabIndex = 19;
			this.label1.Text = "Codigo centro";
			// 
			// RegionalNo
			// 
			this.RegionalNo.DataPropertyName = "codigoCent";
			this.RegionalNo.Frozen = true;
			this.RegionalNo.HeaderText = "Código centro";
			this.RegionalNo.Name = "RegionalNo";
			this.RegionalNo.ReadOnly = true;
			// 
			// nombre
			// 
			this.nombre.DataPropertyName = "nombre";
			this.nombre.Frozen = true;
			this.nombre.HeaderText = "Nombre";
			this.nombre.Name = "nombre";
			this.nombre.ReadOnly = true;
			this.nombre.Width = 300;
			// 
			// tanda
			// 
			this.tanda.DataPropertyName = "tanda";
			this.tanda.Frozen = true;
			this.tanda.HeaderText = "Tanda";
			this.tanda.Name = "tanda";
			this.tanda.ReadOnly = true;
			// 
			// FrmBuscaCentro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancelar;
			this.ClientSize = new System.Drawing.Size(634, 260);
			this.Controls.Add(this.txtCodCent);
			this.Controls.Add(this.Cancelar);
			this.Controls.Add(this.Aceptar);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Buscar);
			this.Controls.Add(this.txtNom);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmBuscaCentro";
			this.Text = "Busca Centro";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn tanda;
		private System.Windows.Forms.MaskedTextBox txtCodCent;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNom;
		private System.Windows.Forms.Button Buscar;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn RegionalNo;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button Aceptar;
		private System.Windows.Forms.Button Cancelar;
	}
}
