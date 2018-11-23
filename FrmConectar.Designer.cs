/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 25/03/2010
 * Hora: 10:36 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace SoporteDistrital
{
	partial class FrmConectar
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
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtcontrasena = new System.Windows.Forms.TextBox();
			this.BTNACEPTAR = new System.Windows.Forms.Button();
			this.LBmensaje = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "USUARIO";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(26, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "CONTRACEÑA";
			// 
			// txtUsuario
			// 
			this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUsuario.Location = new System.Drawing.Point(132, 35);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(201, 20);
			this.txtUsuario.TabIndex = 2;
			// 
			// txtcontrasena
			// 
			this.txtcontrasena.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtcontrasena.Location = new System.Drawing.Point(132, 62);
			this.txtcontrasena.Name = "txtcontrasena";
			this.txtcontrasena.PasswordChar = '*';
			this.txtcontrasena.Size = new System.Drawing.Size(201, 20);
			this.txtcontrasena.TabIndex = 3;
			// 
			// BTNACEPTAR
			// 
			this.BTNACEPTAR.Location = new System.Drawing.Point(148, 122);
			this.BTNACEPTAR.Name = "BTNACEPTAR";
			this.BTNACEPTAR.Size = new System.Drawing.Size(78, 31);
			this.BTNACEPTAR.TabIndex = 4;
			this.BTNACEPTAR.Text = "Aceptar";
			this.BTNACEPTAR.UseVisualStyleBackColor = true;
			this.BTNACEPTAR.Click += new System.EventHandler(this.BTNACEPTARClick);
			// 
			// LBmensaje
			// 
			this.LBmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBmensaje.ForeColor = System.Drawing.Color.Red;
			this.LBmensaje.Location = new System.Drawing.Point(132, 96);
			this.LBmensaje.Name = "LBmensaje";
			this.LBmensaje.Size = new System.Drawing.Size(100, 23);
			this.LBmensaje.TabIndex = 6;
			this.LBmensaje.Text = "mensaje";
			this.LBmensaje.Visible = false;
			// 
			// FrmConectar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(365, 168);
			this.Controls.Add(this.LBmensaje);
			this.Controls.Add(this.BTNACEPTAR);
			this.Controls.Add(this.txtcontrasena);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmConectar";
			this.ShowInTaskbar = false;
			this.Text = "Conectar";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button BTNACEPTAR;
		private System.Windows.Forms.TextBox txtcontrasena;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label LBmensaje;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
