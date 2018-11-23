/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 11/13/2009
 * Time: 3:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SoporteDistrital
{
	partial class FrmRegional
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtRegNo = new System.Windows.Forms.TextBox();
			this.mtxtelefono = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtdireccion = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnsiguiente = new System.Windows.Forms.Button();
			this.btnultimo = new System.Windows.Forms.Button();
			this.btnatras = new System.Windows.Forms.Button();
			this.btnprimero = new System.Windows.Forms.Button();
			this.btneditar = new System.Windows.Forms.Button();
			this.btnverinforme = new System.Windows.Forms.Button();
			this.btncancelar = new System.Windows.Forms.Button();
			this.btnguardar = new System.Windows.Forms.Button();
			this.btnnuevo = new System.Windows.Forms.Button();
			this.btnsalir = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtRegNo);
			this.groupBox1.Controls.Add(this.mtxtelefono);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtdireccion);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtnombre);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(592, 198);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos Generales";
			// 
			// txtRegNo
			// 
			this.txtRegNo.Location = new System.Drawing.Point(98, 22);
			this.txtRegNo.MaxLength = 2;
			this.txtRegNo.Name = "txtRegNo";
			this.txtRegNo.Size = new System.Drawing.Size(100, 20);
			this.txtRegNo.TabIndex = 1;
			this.txtRegNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRegNoKeyPress);
			this.txtRegNo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtRegNoValidating);
			// 
			// mtxtelefono
			// 
			this.mtxtelefono.Location = new System.Drawing.Point(98, 121);
			this.mtxtelefono.Mask = "(999) 000-0000";
			this.mtxtelefono.Name = "mtxtelefono";
			this.mtxtelefono.PromptChar = ' ';
			this.mtxtelefono.Size = new System.Drawing.Size(179, 20);
			this.mtxtelefono.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(3, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 14;
			this.label5.Text = "Regional No.";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(3, 124);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(61, 23);
			this.label7.TabIndex = 10;
			this.label7.Text = "Telefono";
			// 
			// txtdireccion
			// 
			this.txtdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtdireccion.Location = new System.Drawing.Point(98, 85);
			this.txtdireccion.Name = "txtdireccion";
			this.txtdireccion.Size = new System.Drawing.Size(450, 20);
			this.txtdireccion.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(3, 88);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(61, 23);
			this.label8.TabIndex = 8;
			this.label8.Text = "Direccion";
			// 
			// txtnombre
			// 
			this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtnombre.Location = new System.Drawing.Point(98, 50);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(179, 20);
			this.txtnombre.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(3, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombre Regional";
			// 
			// btnsiguiente
			// 
			this.btnsiguiente.Location = new System.Drawing.Point(100, 228);
			this.btnsiguiente.Name = "btnsiguiente";
			this.btnsiguiente.Size = new System.Drawing.Size(41, 23);
			this.btnsiguiente.TabIndex = 57;
			this.btnsiguiente.Text = ">";
			this.btnsiguiente.UseVisualStyleBackColor = true;
			this.btnsiguiente.Click += new System.EventHandler(this.BtnsiguienteClick);
			// 
			// btnultimo
			// 
			this.btnultimo.Location = new System.Drawing.Point(143, 228);
			this.btnultimo.Name = "btnultimo";
			this.btnultimo.Size = new System.Drawing.Size(41, 23);
			this.btnultimo.TabIndex = 58;
			this.btnultimo.Text = ">>";
			this.btnultimo.UseVisualStyleBackColor = true;
			this.btnultimo.Click += new System.EventHandler(this.BtnultimoClick);
			// 
			// btnatras
			// 
			this.btnatras.Location = new System.Drawing.Point(56, 227);
			this.btnatras.Name = "btnatras";
			this.btnatras.Size = new System.Drawing.Size(41, 23);
			this.btnatras.TabIndex = 56;
			this.btnatras.Text = "<";
			this.btnatras.UseVisualStyleBackColor = true;
			this.btnatras.Click += new System.EventHandler(this.BtnatrasClick);
			// 
			// btnprimero
			// 
			this.btnprimero.Location = new System.Drawing.Point(14, 227);
			this.btnprimero.Name = "btnprimero";
			this.btnprimero.Size = new System.Drawing.Size(41, 23);
			this.btnprimero.TabIndex = 55;
			this.btnprimero.Text = "<<";
			this.btnprimero.UseVisualStyleBackColor = true;
			this.btnprimero.Click += new System.EventHandler(this.BtnprimeroClick);
			// 
			// btneditar
			// 
			this.btneditar.Location = new System.Drawing.Point(287, 229);
			this.btneditar.Name = "btneditar";
			this.btneditar.Size = new System.Drawing.Size(41, 23);
			this.btneditar.TabIndex = 52;
			this.btneditar.Text = "Editar";
			this.btneditar.UseVisualStyleBackColor = true;
			this.btneditar.Click += new System.EventHandler(this.BtneditarClick);
			// 
			// btnverinforme
			// 
			this.btnverinforme.Location = new System.Drawing.Point(377, 229);
			this.btnverinforme.Name = "btnverinforme";
			this.btnverinforme.Size = new System.Drawing.Size(41, 23);
			this.btnverinforme.TabIndex = 54;
			this.btnverinforme.Text = "Ver Informe";
			this.btnverinforme.UseVisualStyleBackColor = true;
			// 
			// btncancelar
			// 
			this.btncancelar.Location = new System.Drawing.Point(330, 229);
			this.btncancelar.Name = "btncancelar";
			this.btncancelar.Size = new System.Drawing.Size(41, 23);
			this.btncancelar.TabIndex = 53;
			this.btncancelar.Text = "Cancelar";
			this.btncancelar.UseVisualStyleBackColor = true;
			this.btncancelar.Click += new System.EventHandler(this.BtncancelarClick);
			// 
			// btnguardar
			// 
			this.btnguardar.Location = new System.Drawing.Point(243, 228);
			this.btnguardar.Name = "btnguardar";
			this.btnguardar.Size = new System.Drawing.Size(41, 23);
			this.btnguardar.TabIndex = 51;
			this.btnguardar.Text = "Guardar";
			this.btnguardar.UseVisualStyleBackColor = true;
			this.btnguardar.Click += new System.EventHandler(this.BtnguardarClick);
			// 
			// btnnuevo
			// 
			this.btnnuevo.Location = new System.Drawing.Point(200, 228);
			this.btnnuevo.Name = "btnnuevo";
			this.btnnuevo.Size = new System.Drawing.Size(41, 23);
			this.btnnuevo.TabIndex = 50;
			this.btnnuevo.Text = "Nuevo";
			this.btnnuevo.UseVisualStyleBackColor = true;
			this.btnnuevo.Click += new System.EventHandler(this.BtnnuevoClick);
			// 
			// btnsalir
			// 
			this.btnsalir.Location = new System.Drawing.Point(563, 227);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(41, 23);
			this.btnsalir.TabIndex = 59;
			this.btnsalir.Text = "Salir";
			this.btnsalir.UseVisualStyleBackColor = true;
			this.btnsalir.Click += new System.EventHandler(this.Button2Click);
			// 
			// FrmRegional
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(617, 274);
			this.Controls.Add(this.btnsalir);
			this.Controls.Add(this.btnsiguiente);
			this.Controls.Add(this.btnultimo);
			this.Controls.Add(this.btnatras);
			this.Controls.Add(this.btnprimero);
			this.Controls.Add(this.btneditar);
			this.Controls.Add(this.btnverinforme);
			this.Controls.Add(this.btncancelar);
			this.Controls.Add(this.btnguardar);
			this.Controls.Add(this.btnnuevo);
			this.Controls.Add(this.groupBox1);
			this.Name = "FrmRegional";
			this.Text = "Regional de Educación";
			this.Load += new System.EventHandler(this.FrmRegionalLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnprimero;
		private System.Windows.Forms.Button btnatras;
		private System.Windows.Forms.Button btnultimo;
		private System.Windows.Forms.Button btnsiguiente;
		private System.Windows.Forms.Button btnverinforme;
		private System.Windows.Forms.Button btnsalir;
		private System.Windows.Forms.Button btncancelar;
		private System.Windows.Forms.TextBox txtRegNo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtdireccion;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MaskedTextBox mtxtelefono;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnnuevo;
		private System.Windows.Forms.Button btnguardar;
		private System.Windows.Forms.Button btneditar;
	}
}
