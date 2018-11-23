/*
 * Creado por SharpDevelop.
 * Usuario: admin
 * Fecha: 02/06/2010
 * Hora: 12:59 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace SoporteDistrital
{
	partial class FrmCambiaContr
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtContrActual = new System.Windows.Forms.TextBox();
			this.txtNContras = new System.Windows.Forms.TextBox();
			this.txtConfContr = new System.Windows.Forms.TextBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btncancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Contraseña Actual";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nueva Contraseña";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 28);
			this.label3.TabIndex = 2;
			this.label3.Text = "Confirmar Contraseña";
			// 
			// txtContrActual
			// 
			this.txtContrActual.Location = new System.Drawing.Point(120, 13);
			this.txtContrActual.Name = "txtContrActual";
			this.txtContrActual.Size = new System.Drawing.Size(140, 20);
			this.txtContrActual.TabIndex = 3;
			// 
			// txtNContras
			// 
			this.txtNContras.Location = new System.Drawing.Point(120, 40);
			this.txtNContras.Name = "txtNContras";
			this.txtNContras.Size = new System.Drawing.Size(140, 20);
			this.txtNContras.TabIndex = 4;
			// 
			// txtConfContr
			// 
			this.txtConfContr.Location = new System.Drawing.Point(120, 67);
			this.txtConfContr.Name = "txtConfContr";
			this.txtConfContr.Size = new System.Drawing.Size(140, 20);
			this.txtConfContr.TabIndex = 5;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(77, 123);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 6;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// btncancelar
			// 
			this.btncancelar.Location = new System.Drawing.Point(213, 123);
			this.btncancelar.Name = "btncancelar";
			this.btncancelar.Size = new System.Drawing.Size(75, 23);
			this.btncancelar.TabIndex = 7;
			this.btncancelar.Text = "Cancelar";
			this.btncancelar.UseVisualStyleBackColor = true;
			this.btncancelar.Click += new System.EventHandler(this.BtncancelarClick);
			// 
			// FrmCambiaContr
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(352, 168);
			this.Controls.Add(this.btncancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.txtConfContr);
			this.Controls.Add(this.txtNContras);
			this.Controls.Add(this.txtContrActual);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmCambiaContr";
			this.Text = "Cambiar Contraseña";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtConfContr;
		private System.Windows.Forms.Button btncancelar;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.TextBox txtNContras;
		private System.Windows.Forms.TextBox txtContrActual;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
