/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 11/19/2009
 * Time: 8:12 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SoporteDistrital
{
	partial class FrmCentroEd
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
			this.txtcantSecc = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtcantAulas = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDistNo = new System.Windows.Forms.MaskedTextBox();
			this.RBNot = new System.Windows.Forms.RadioButton();
			this.RBVesp = new System.Windows.Forms.RadioButton();
			this.RBMat = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.txtNomDist = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCodCent = new System.Windows.Forms.MaskedTextBox();
			this.mtxtelefono = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtdireccion = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnsalir = new System.Windows.Forms.Button();
			this.btnsiguiente = new System.Windows.Forms.Button();
			this.btnultimo = new System.Windows.Forms.Button();
			this.btnatras = new System.Windows.Forms.Button();
			this.btnprimero = new System.Windows.Forms.Button();
			this.btneditar = new System.Windows.Forms.Button();
			this.btnverinforme = new System.Windows.Forms.Button();
			this.btncancelar = new System.Windows.Forms.Button();
			this.btnguardar = new System.Windows.Forms.Button();
			this.btnnuevo = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtcantSecc);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtcantAulas);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtDistNo);
			this.groupBox1.Controls.Add(this.RBNot);
			this.groupBox1.Controls.Add(this.RBVesp);
			this.groupBox1.Controls.Add(this.RBMat);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.txtNomDist);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtCodCent);
			this.groupBox1.Controls.Add(this.mtxtelefono);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtdireccion);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtnombre);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(592, 213);
			this.groupBox1.TabIndex = 21;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos Generales";
			// 
			// txtcantSecc
			// 
			this.txtcantSecc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtcantSecc.Location = new System.Drawing.Point(92, 184);
			this.txtcantSecc.MaxLength = 2;
			this.txtcantSecc.Name = "txtcantSecc";
			this.txtcantSecc.Size = new System.Drawing.Size(47, 20);
			this.txtcantSecc.TabIndex = 8;
			this.txtcantSecc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtcantSeccKeyPress);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(6, 187);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(85, 23);
			this.label9.TabIndex = 23;
			this.label9.Text = "Cant. Secciones";
			// 
			// txtcantAulas
			// 
			this.txtcantAulas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtcantAulas.Location = new System.Drawing.Point(92, 154);
			this.txtcantAulas.MaxLength = 2;
			this.txtcantAulas.Name = "txtcantAulas";
			this.txtcantAulas.Size = new System.Drawing.Size(47, 20);
			this.txtcantAulas.TabIndex = 7;
			this.txtcantAulas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtcantAulasKeyPress);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 157);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 23);
			this.label6.TabIndex = 21;
			this.label6.Text = "Cant. Aulas";
			// 
			// txtDistNo
			// 
			this.txtDistNo.Location = new System.Drawing.Point(387, 19);
			this.txtDistNo.Mask = "9";
			this.txtDistNo.Name = "txtDistNo";
			this.txtDistNo.PromptChar = ' ';
			this.txtDistNo.Size = new System.Drawing.Size(77, 20);
			this.txtDistNo.TabIndex = 2;
			this.txtDistNo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDistNoValidating);
			this.txtDistNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDistNoKeyPress);
			// 
			// RBNot
			// 
			this.RBNot.Location = new System.Drawing.Point(387, 157);
			this.RBNot.Name = "RBNot";
			this.RBNot.Size = new System.Drawing.Size(105, 24);
			this.RBNot.TabIndex = 11;
			this.RBNot.TabStop = true;
			this.RBNot.Text = "NOCTURNA";
			this.RBNot.UseVisualStyleBackColor = true;
			// 
			// RBVesp
			// 
			this.RBVesp.Location = new System.Drawing.Point(387, 136);
			this.RBVesp.Name = "RBVesp";
			this.RBVesp.Size = new System.Drawing.Size(96, 24);
			this.RBVesp.TabIndex = 10;
			this.RBVesp.TabStop = true;
			this.RBVesp.Text = "VESPERTINA";
			this.RBVesp.UseVisualStyleBackColor = true;
			// 
			// RBMat
			// 
			this.RBMat.Location = new System.Drawing.Point(387, 118);
			this.RBMat.Name = "RBMat";
			this.RBMat.Size = new System.Drawing.Size(84, 24);
			this.RBMat.TabIndex = 9;
			this.RBMat.TabStop = true;
			this.RBMat.Text = "MATUTINA";
			this.RBMat.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(294, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 23);
			this.label4.TabIndex = 20;
			this.label4.Text = "Tanda";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(470, 16);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 3;
			this.button4.Text = "Buscar";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// txtNomDist
			// 
			this.txtNomDist.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNomDist.Enabled = false;
			this.txtNomDist.Location = new System.Drawing.Point(387, 47);
			this.txtNomDist.MaxLength = 2;
			this.txtNomDist.Name = "txtNomDist";
			this.txtNomDist.Size = new System.Drawing.Size(184, 20);
			this.txtNomDist.TabIndex = 17;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(294, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 23);
			this.label3.TabIndex = 18;
			this.label3.Text = " Nombre Distrito";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(294, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 23);
			this.label1.TabIndex = 16;
			this.label1.Text = "Distrito No.";
			// 
			// txtCodCent
			// 
			this.txtCodCent.Location = new System.Drawing.Point(92, 22);
			this.txtCodCent.Mask = "99999999";
			this.txtCodCent.Name = "txtCodCent";
			this.txtCodCent.PromptChar = ' ';
			this.txtCodCent.Size = new System.Drawing.Size(87, 20);
			this.txtCodCent.TabIndex = 1;
			this.txtCodCent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodCentKeyPress);
			// 
			// mtxtelefono
			// 
			this.mtxtelefono.Location = new System.Drawing.Point(92, 121);
			this.mtxtelefono.Mask = "(999) 000-0000";
			this.mtxtelefono.Name = "mtxtelefono";
			this.mtxtelefono.PromptChar = ' ';
			this.mtxtelefono.Size = new System.Drawing.Size(179, 20);
			this.mtxtelefono.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 28);
			this.label5.TabIndex = 14;
			this.label5.Text = "Codigo del centro";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 124);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(61, 23);
			this.label7.TabIndex = 10;
			this.label7.Text = "Telefono";
			// 
			// txtdireccion
			// 
			this.txtdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtdireccion.Location = new System.Drawing.Point(92, 85);
			this.txtdireccion.Name = "txtdireccion";
			this.txtdireccion.Size = new System.Drawing.Size(479, 20);
			this.txtdireccion.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(6, 88);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(61, 23);
			this.label8.TabIndex = 8;
			this.label8.Text = "Direccion";
			// 
			// txtnombre
			// 
			this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtnombre.Location = new System.Drawing.Point(92, 50);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(179, 20);
			this.txtnombre.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombre Centro";
			// 
			// btnsalir
			// 
			this.btnsalir.Location = new System.Drawing.Point(563, 244);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(41, 23);
			this.btnsalir.TabIndex = 79;
			this.btnsalir.Text = "Salir";
			this.btnsalir.UseVisualStyleBackColor = true;
			this.btnsalir.Click += new System.EventHandler(this.Button2Click);
			// 
			// btnsiguiente
			// 
			this.btnsiguiente.Location = new System.Drawing.Point(99, 244);
			this.btnsiguiente.Name = "btnsiguiente";
			this.btnsiguiente.Size = new System.Drawing.Size(41, 23);
			this.btnsiguiente.TabIndex = 77;
			this.btnsiguiente.Text = ">";
			this.btnsiguiente.UseVisualStyleBackColor = true;
			this.btnsiguiente.Click += new System.EventHandler(this.BtnsiguienteClick);
			// 
			// btnultimo
			// 
			this.btnultimo.Location = new System.Drawing.Point(142, 244);
			this.btnultimo.Name = "btnultimo";
			this.btnultimo.Size = new System.Drawing.Size(41, 23);
			this.btnultimo.TabIndex = 78;
			this.btnultimo.Text = ">>";
			this.btnultimo.UseVisualStyleBackColor = true;
			this.btnultimo.Click += new System.EventHandler(this.BtnultimoClick);
			// 
			// btnatras
			// 
			this.btnatras.Location = new System.Drawing.Point(55, 243);
			this.btnatras.Name = "btnatras";
			this.btnatras.Size = new System.Drawing.Size(41, 23);
			this.btnatras.TabIndex = 76;
			this.btnatras.Text = "<";
			this.btnatras.UseVisualStyleBackColor = true;
			this.btnatras.Click += new System.EventHandler(this.BtnatrasClick);
			// 
			// btnprimero
			// 
			this.btnprimero.Location = new System.Drawing.Point(13, 243);
			this.btnprimero.Name = "btnprimero";
			this.btnprimero.Size = new System.Drawing.Size(41, 23);
			this.btnprimero.TabIndex = 75;
			this.btnprimero.Text = "<<";
			this.btnprimero.UseVisualStyleBackColor = true;
			this.btnprimero.Click += new System.EventHandler(this.BtnprimeroClick);
			// 
			// btneditar
			// 
			this.btneditar.Location = new System.Drawing.Point(286, 245);
			this.btneditar.Name = "btneditar";
			this.btneditar.Size = new System.Drawing.Size(41, 23);
			this.btneditar.TabIndex = 72;
			this.btneditar.Text = "Editar";
			this.btneditar.UseVisualStyleBackColor = true;
			this.btneditar.Click += new System.EventHandler(this.BtneditarClick);
			// 
			// btnverinforme
			// 
			this.btnverinforme.Location = new System.Drawing.Point(376, 245);
			this.btnverinforme.Name = "btnverinforme";
			this.btnverinforme.Size = new System.Drawing.Size(41, 23);
			this.btnverinforme.TabIndex = 74;
			this.btnverinforme.Text = "Ver Informe";
			this.btnverinforme.UseVisualStyleBackColor = true;
			// 
			// btncancelar
			// 
			this.btncancelar.Location = new System.Drawing.Point(329, 245);
			this.btncancelar.Name = "btncancelar";
			this.btncancelar.Size = new System.Drawing.Size(41, 23);
			this.btncancelar.TabIndex = 73;
			this.btncancelar.Text = "Cancelar";
			this.btncancelar.UseVisualStyleBackColor = true;
			this.btncancelar.Click += new System.EventHandler(this.BtncancelarClick);
			// 
			// btnguardar
			// 
			this.btnguardar.Location = new System.Drawing.Point(242, 244);
			this.btnguardar.Name = "btnguardar";
			this.btnguardar.Size = new System.Drawing.Size(41, 23);
			this.btnguardar.TabIndex = 71;
			this.btnguardar.Text = "Guardar";
			this.btnguardar.UseVisualStyleBackColor = true;
			this.btnguardar.Click += new System.EventHandler(this.BtnguardarClick);
			// 
			// btnnuevo
			// 
			this.btnnuevo.Location = new System.Drawing.Point(199, 244);
			this.btnnuevo.Name = "btnnuevo";
			this.btnnuevo.Size = new System.Drawing.Size(41, 23);
			this.btnnuevo.TabIndex = 70;
			this.btnnuevo.Text = "Nuevo";
			this.btnnuevo.UseVisualStyleBackColor = true;
			this.btnnuevo.Click += new System.EventHandler(this.BtnnuevoClick);
			// 
			// FrmCentroEd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(631, 293);
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
			this.Name = "FrmCentroEd";
			this.Text = "Centro Educativo";
			this.Load += new System.EventHandler(this.FrmCentroEdLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox txtcantSecc;
		private System.Windows.Forms.TextBox txtcantAulas;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnprimero;
		private System.Windows.Forms.Button btnatras;
		private System.Windows.Forms.Button btnultimo;
		private System.Windows.Forms.Button btnsiguiente;
		private System.Windows.Forms.Button btnverinforme;
		private System.Windows.Forms.Button btnsalir;
		private System.Windows.Forms.Button btncancelar;
		private System.Windows.Forms.RadioButton RBNot;
		private System.Windows.Forms.RadioButton RBVesp;
		private System.Windows.Forms.RadioButton RBMat;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNomDist;
		private System.Windows.Forms.MaskedTextBox txtCodCent;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtdireccion;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MaskedTextBox mtxtelefono;
		private System.Windows.Forms.MaskedTextBox txtDistNo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnnuevo;
		private System.Windows.Forms.Button btnguardar;
		private System.Windows.Forms.Button btneditar;
	}
}
