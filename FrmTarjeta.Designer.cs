/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 11/20/2009
 * Time: 10:41 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SoporteDistrital
{
	partial class FrmTarjeta
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
			this.txtIngresos = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbcargo = new System.Windows.Forms.ComboBox();
			this.txtCodCent = new System.Windows.Forms.MaskedTextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.txtNomCent = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTarNo = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
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
			this.groupBox1.Controls.Add(this.txtIngresos);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cmbcargo);
			this.groupBox1.Controls.Add(this.txtCodCent);
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.txtNomCent);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtTarNo);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(592, 147);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos Generales";
			// 
			// txtIngresos
			// 
			this.txtIngresos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtIngresos.Location = new System.Drawing.Point(92, 97);
			this.txtIngresos.MaxLength = 10;
			this.txtIngresos.Name = "txtIngresos";
			this.txtIngresos.Size = new System.Drawing.Size(87, 20);
			this.txtIngresos.TabIndex = 23;
			this.txtIngresos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1KeyPress);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 23);
			this.label4.TabIndex = 22;
			this.label4.Text = "Ingresos";
			// 
			// cmbcargo
			// 
			this.cmbcargo.DisplayMember = "0";
			this.cmbcargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbcargo.FormattingEnabled = true;
			this.cmbcargo.Items.AddRange(new object[] {
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
			this.cmbcargo.Location = new System.Drawing.Point(92, 58);
			this.cmbcargo.Name = "cmbcargo";
			this.cmbcargo.Size = new System.Drawing.Size(179, 21);
			this.cmbcargo.TabIndex = 3;
			// 
			// txtCodCent
			// 
			this.txtCodCent.Location = new System.Drawing.Point(397, 19);
			this.txtCodCent.Mask = "99999999";
			this.txtCodCent.Name = "txtCodCent";
			this.txtCodCent.PromptChar = ' ';
			this.txtCodCent.Size = new System.Drawing.Size(77, 20);
			this.txtCodCent.TabIndex = 2;
			this.txtCodCent.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodCentValidating);
			this.txtCodCent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodCentKeyPress);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(480, 16);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 19;
			this.button4.Text = "Buscar";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// txtNomCent
			// 
			this.txtNomCent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNomCent.Enabled = false;
			this.txtNomCent.Location = new System.Drawing.Point(397, 55);
			this.txtNomCent.MaxLength = 2;
			this.txtNomCent.Name = "txtNomCent";
			this.txtNomCent.Size = new System.Drawing.Size(184, 20);
			this.txtNomCent.TabIndex = 17;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(294, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 23);
			this.label3.TabIndex = 18;
			this.label3.Text = " Nombre del Centro";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(294, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 23);
			this.label1.TabIndex = 16;
			this.label1.Text = "Código del Centro";
			// 
			// txtTarNo
			// 
			this.txtTarNo.Location = new System.Drawing.Point(92, 22);
			this.txtTarNo.Mask = "99999-999";
			this.txtTarNo.Name = "txtTarNo";
			this.txtTarNo.PromptChar = ' ';
			this.txtTarNo.Size = new System.Drawing.Size(87, 20);
			this.txtTarNo.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 20);
			this.label5.TabIndex = 14;
			this.label5.Text = "Tarjeta No.";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Cargo asignado";
			// 
			// btnsalir
			// 
			this.btnsalir.Location = new System.Drawing.Point(563, 177);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(41, 23);
			this.btnsalir.TabIndex = 79;
			this.btnsalir.Text = "Salir";
			this.btnsalir.UseVisualStyleBackColor = true;
			this.btnsalir.Click += new System.EventHandler(this.Button2Click);
			// 
			// btnsiguiente
			// 
			this.btnsiguiente.Location = new System.Drawing.Point(99, 177);
			this.btnsiguiente.Name = "btnsiguiente";
			this.btnsiguiente.Size = new System.Drawing.Size(41, 23);
			this.btnsiguiente.TabIndex = 77;
			this.btnsiguiente.Text = ">";
			this.btnsiguiente.UseVisualStyleBackColor = true;
			this.btnsiguiente.Click += new System.EventHandler(this.BtnsiguienteClick);
			// 
			// btnultimo
			// 
			this.btnultimo.Location = new System.Drawing.Point(142, 177);
			this.btnultimo.Name = "btnultimo";
			this.btnultimo.Size = new System.Drawing.Size(41, 23);
			this.btnultimo.TabIndex = 78;
			this.btnultimo.Text = ">>";
			this.btnultimo.UseVisualStyleBackColor = true;
			this.btnultimo.Click += new System.EventHandler(this.BtnultimoClick);
			// 
			// btnatras
			// 
			this.btnatras.Location = new System.Drawing.Point(55, 176);
			this.btnatras.Name = "btnatras";
			this.btnatras.Size = new System.Drawing.Size(41, 23);
			this.btnatras.TabIndex = 76;
			this.btnatras.Text = "<";
			this.btnatras.UseVisualStyleBackColor = true;
			this.btnatras.Click += new System.EventHandler(this.BtnatrasClick);
			// 
			// btnprimero
			// 
			this.btnprimero.Location = new System.Drawing.Point(13, 176);
			this.btnprimero.Name = "btnprimero";
			this.btnprimero.Size = new System.Drawing.Size(41, 23);
			this.btnprimero.TabIndex = 75;
			this.btnprimero.Text = "<<";
			this.btnprimero.UseVisualStyleBackColor = true;
			this.btnprimero.Click += new System.EventHandler(this.BtnprimeroClick);
			// 
			// btneditar
			// 
			this.btneditar.Location = new System.Drawing.Point(286, 178);
			this.btneditar.Name = "btneditar";
			this.btneditar.Size = new System.Drawing.Size(41, 23);
			this.btneditar.TabIndex = 72;
			this.btneditar.Text = "Editar";
			this.btneditar.UseVisualStyleBackColor = true;
			this.btneditar.Click += new System.EventHandler(this.BtneditarClick);
			// 
			// btnverinforme
			// 
			this.btnverinforme.Location = new System.Drawing.Point(376, 178);
			this.btnverinforme.Name = "btnverinforme";
			this.btnverinforme.Size = new System.Drawing.Size(41, 23);
			this.btnverinforme.TabIndex = 74;
			this.btnverinforme.Text = "Ver Informe";
			this.btnverinforme.UseVisualStyleBackColor = true;
			// 
			// btncancelar
			// 
			this.btncancelar.Location = new System.Drawing.Point(329, 178);
			this.btncancelar.Name = "btncancelar";
			this.btncancelar.Size = new System.Drawing.Size(41, 23);
			this.btncancelar.TabIndex = 73;
			this.btncancelar.Text = "Cancelar";
			this.btncancelar.UseVisualStyleBackColor = true;
			this.btncancelar.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnguardar
			// 
			this.btnguardar.Location = new System.Drawing.Point(242, 177);
			this.btnguardar.Name = "btnguardar";
			this.btnguardar.Size = new System.Drawing.Size(41, 23);
			this.btnguardar.TabIndex = 71;
			this.btnguardar.Text = "Guardar";
			this.btnguardar.UseVisualStyleBackColor = true;
			this.btnguardar.Click += new System.EventHandler(this.BtnguardarClick);
			// 
			// btnnuevo
			// 
			this.btnnuevo.Location = new System.Drawing.Point(199, 177);
			this.btnnuevo.Name = "btnnuevo";
			this.btnnuevo.Size = new System.Drawing.Size(41, 23);
			this.btnnuevo.TabIndex = 70;
			this.btnnuevo.Text = "Nuevo";
			this.btnnuevo.UseVisualStyleBackColor = true;
			this.btnnuevo.Click += new System.EventHandler(this.BtnnuevoClick);
			// 
			// FrmTarjeta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(618, 221);
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
			this.Name = "FrmTarjeta";
			this.Text = "Tarjeta";
			this.Load += new System.EventHandler(this.FrmTarjetaLoad);
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
		private System.Windows.Forms.TextBox txtIngresos;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNomCent;
		private System.Windows.Forms.MaskedTextBox txtTarNo;
		private System.Windows.Forms.ComboBox cmbcargo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MaskedTextBox txtCodCent;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnnuevo;
		private System.Windows.Forms.Button btnguardar;
		private System.Windows.Forms.Button btneditar;
	}
}
