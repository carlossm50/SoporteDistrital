/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 11/20/2009
 * Time: 10:01 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SoporteDistrital
{
	partial class FrmBuscaDistrito
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
			this.Cancelar = new System.Windows.Forms.Button();
			this.Aceptar = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.RegionalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Buscar = new System.Windows.Forms.Button();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCodDist = new System.Windows.Forms.MaskedTextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// Cancelar
			// 
			this.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancelar.Location = new System.Drawing.Point(269, 231);
			this.Cancelar.Name = "Cancelar";
			this.Cancelar.Size = new System.Drawing.Size(75, 23);
			this.Cancelar.TabIndex = 15;
			this.Cancelar.Text = "Cancelar";
			this.Cancelar.UseVisualStyleBackColor = true;
			// 
			// Aceptar
			// 
			this.Aceptar.Location = new System.Drawing.Point(172, 231);
			this.Aceptar.Name = "Aceptar";
			this.Aceptar.Size = new System.Drawing.Size(75, 23);
			this.Aceptar.TabIndex = 14;
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
									this.nombre});
			this.dataGridView1.Location = new System.Drawing.Point(21, 58);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(413, 150);
			this.dataGridView1.TabIndex = 2;
			// 
			// RegionalNo
			// 
			this.RegionalNo.DataPropertyName = "Codistrito";
			this.RegionalNo.Frozen = true;
			this.RegionalNo.HeaderText = "Distrito No.";
			this.RegionalNo.Name = "RegionalNo";
			this.RegionalNo.ReadOnly = true;
			// 
			// nombre
			// 
			this.nombre.DataPropertyName = "d_nombre";
			this.nombre.Frozen = true;
			this.nombre.HeaderText = "Nombre";
			this.nombre.Name = "nombre";
			this.nombre.ReadOnly = true;
			this.nombre.Width = 300;
			// 
			// Buscar
			// 
			this.Buscar.Location = new System.Drawing.Point(80, 231);
			this.Buscar.Name = "Buscar";
			this.Buscar.Size = new System.Drawing.Size(75, 23);
			this.Buscar.TabIndex = 12;
			this.Buscar.Text = "Buscar";
			this.Buscar.UseVisualStyleBackColor = true;
			this.Buscar.Click += new System.EventHandler(this.BuscarClick);
			// 
			// txtNom
			// 
			this.txtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNom.Location = new System.Drawing.Point(112, 29);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(223, 20);
			this.txtNom.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(21, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "Nombre Distrito";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(21, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "Distrito No.";
			// 
			// txtCodDist
			// 
			this.txtCodDist.Location = new System.Drawing.Point(112, 6);
			this.txtCodDist.Mask = "99";
			this.txtCodDist.Name = "txtCodDist";
			this.txtCodDist.PromptChar = ' ';
			this.txtCodDist.Size = new System.Drawing.Size(77, 20);
			this.txtCodDist.TabIndex = 1;
			// 
			// FrmBuscaDistrito
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancelar;
			this.ClientSize = new System.Drawing.Size(455, 260);
			this.Controls.Add(this.txtCodDist);
			this.Controls.Add(this.Cancelar);
			this.Controls.Add(this.Aceptar);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Buscar);
			this.Controls.Add(this.txtNom);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmBuscaDistrito";
			this.Text = "Busca Distrito";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.MaskedTextBox txtCodDist;
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
