/*
 * Creado por SharpDevelop.
 * Usuario: admin
 * Fecha: 30/05/2010
 * Hora: 11:08 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace SoporteDistrital
{
	partial class FrmUsuario
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
			this.Buscar = new System.Windows.Forms.Button();
			this.mTxtCedula = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtConfContr = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtContrasena = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lVPermisos = new System.Windows.Forms.ListView();
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
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Buscar);
			this.groupBox1.Controls.Add(this.mTxtCedula);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtnombre);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(606, 85);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			// 
			// Buscar
			// 
			this.Buscar.Location = new System.Drawing.Point(243, 21);
			this.Buscar.Name = "Buscar";
			this.Buscar.Size = new System.Drawing.Size(75, 23);
			this.Buscar.TabIndex = 31;
			this.Buscar.Text = "Buscar";
			this.Buscar.UseVisualStyleBackColor = true;
			this.Buscar.Click += new System.EventHandler(this.BuscarClick);
			// 
			// mTxtCedula
			// 
			this.mTxtCedula.Location = new System.Drawing.Point(92, 22);
			this.mTxtCedula.Mask = "999-0000000-0";
			this.mTxtCedula.Name = "mTxtCedula";
			this.mTxtCedula.PromptChar = ' ';
			this.mTxtCedula.Size = new System.Drawing.Size(136, 20);
			this.mTxtCedula.TabIndex = 2;
			this.mTxtCedula.Validating += new System.ComponentModel.CancelEventHandler(this.MTxtCedulaValidating);
			this.mTxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MTxtCedulaKeyPress);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(9, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 14;
			this.label5.Text = "Cedula ";
			// 
			// txtnombre
			// 
			this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtnombre.Enabled = false;
			this.txtnombre.ForeColor = System.Drawing.SystemColors.Info;
			this.txtnombre.Location = new System.Drawing.Point(92, 50);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(226, 20);
			this.txtnombre.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(9, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombre";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtConfContr);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtContrasena);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txtUsuario);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(12, 114);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(300, 247);
			this.groupBox2.TabIndex = 32;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Autenticación";
			// 
			// txtConfContr
			// 
			this.txtConfContr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtConfContr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConfContr.Location = new System.Drawing.Point(92, 79);
			this.txtConfContr.Name = "txtConfContr";
			this.txtConfContr.PasswordChar = '*';
			this.txtConfContr.Size = new System.Drawing.Size(179, 22);
			this.txtConfContr.TabIndex = 18;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(9, 79);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 33);
			this.label6.TabIndex = 17;
			this.label6.Text = "Confirmar Contraseña";
			// 
			// txtContrasena
			// 
			this.txtContrasena.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContrasena.Location = new System.Drawing.Point(92, 52);
			this.txtContrasena.Name = "txtContrasena";
			this.txtContrasena.PasswordChar = '*';
			this.txtContrasena.Size = new System.Drawing.Size(179, 22);
			this.txtContrasena.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(9, 55);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 23);
			this.label4.TabIndex = 15;
			this.label4.Text = "Contraseña";
			// 
			// txtUsuario
			// 
			this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUsuario.Location = new System.Drawing.Point(92, 27);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(179, 20);
			this.txtUsuario.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(9, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Usuario";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lVPermisos);
			this.groupBox3.Location = new System.Drawing.Point(318, 114);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(300, 247);
			this.groupBox3.TabIndex = 33;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Autorisación";
			// 
			// lVPermisos
			// 
			this.lVPermisos.CheckBoxes = true;
			this.lVPermisos.Location = new System.Drawing.Point(5, 19);
			this.lVPermisos.Name = "lVPermisos";
			this.lVPermisos.Size = new System.Drawing.Size(289, 221);
			this.lVPermisos.TabIndex = 0;
			this.lVPermisos.UseCompatibleStateImageBehavior = false;
			this.lVPermisos.View = System.Windows.Forms.View.List;
			this.lVPermisos.Click += new System.EventHandler(this.LVPermisosClick);
			// 
			// btnsalir
			// 
			this.btnsalir.Location = new System.Drawing.Point(563, 382);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(41, 23);
			this.btnsalir.TabIndex = 79;
			this.btnsalir.Text = "Salir";
			this.btnsalir.UseVisualStyleBackColor = true;
			this.btnsalir.Click += new System.EventHandler(this.Button2Click);
			// 
			// btnsiguiente
			// 
			this.btnsiguiente.Enabled = false;
			this.btnsiguiente.Location = new System.Drawing.Point(99, 382);
			this.btnsiguiente.Name = "btnsiguiente";
			this.btnsiguiente.Size = new System.Drawing.Size(41, 23);
			this.btnsiguiente.TabIndex = 77;
			this.btnsiguiente.Text = ">";
			this.btnsiguiente.UseVisualStyleBackColor = true;
			// 
			// btnultimo
			// 
			this.btnultimo.Enabled = false;
			this.btnultimo.Location = new System.Drawing.Point(142, 382);
			this.btnultimo.Name = "btnultimo";
			this.btnultimo.Size = new System.Drawing.Size(41, 23);
			this.btnultimo.TabIndex = 78;
			this.btnultimo.Text = ">>";
			this.btnultimo.UseVisualStyleBackColor = true;
			// 
			// btnatras
			// 
			this.btnatras.Enabled = false;
			this.btnatras.Location = new System.Drawing.Point(55, 381);
			this.btnatras.Name = "btnatras";
			this.btnatras.Size = new System.Drawing.Size(41, 23);
			this.btnatras.TabIndex = 76;
			this.btnatras.Text = "<";
			this.btnatras.UseVisualStyleBackColor = true;
			// 
			// btnprimero
			// 
			this.btnprimero.Enabled = false;
			this.btnprimero.Location = new System.Drawing.Point(13, 381);
			this.btnprimero.Name = "btnprimero";
			this.btnprimero.Size = new System.Drawing.Size(41, 23);
			this.btnprimero.TabIndex = 75;
			this.btnprimero.Text = "<<";
			this.btnprimero.UseVisualStyleBackColor = true;
			// 
			// btneditar
			// 
			this.btneditar.Location = new System.Drawing.Point(286, 383);
			this.btneditar.Name = "btneditar";
			this.btneditar.Size = new System.Drawing.Size(41, 23);
			this.btneditar.TabIndex = 72;
			this.btneditar.Text = "Editar";
			this.btneditar.UseVisualStyleBackColor = true;
			// 
			// btnverinforme
			// 
			this.btnverinforme.Location = new System.Drawing.Point(376, 383);
			this.btnverinforme.Name = "btnverinforme";
			this.btnverinforme.Size = new System.Drawing.Size(41, 23);
			this.btnverinforme.TabIndex = 74;
			this.btnverinforme.Text = "Ver Informe";
			this.btnverinforme.UseVisualStyleBackColor = true;
			// 
			// btncancelar
			// 
			this.btncancelar.Location = new System.Drawing.Point(329, 383);
			this.btncancelar.Name = "btncancelar";
			this.btncancelar.Size = new System.Drawing.Size(41, 23);
			this.btncancelar.TabIndex = 73;
			this.btncancelar.Text = "Cancelar";
			this.btncancelar.UseVisualStyleBackColor = true;
			// 
			// btnguardar
			// 
			this.btnguardar.Location = new System.Drawing.Point(242, 382);
			this.btnguardar.Name = "btnguardar";
			this.btnguardar.Size = new System.Drawing.Size(41, 23);
			this.btnguardar.TabIndex = 71;
			this.btnguardar.Text = "Guardar";
			this.btnguardar.UseVisualStyleBackColor = true;
			this.btnguardar.Click += new System.EventHandler(this.BtnguardarClick);
			// 
			// btnnuevo
			// 
			this.btnnuevo.Location = new System.Drawing.Point(199, 382);
			this.btnnuevo.Name = "btnnuevo";
			this.btnnuevo.Size = new System.Drawing.Size(41, 23);
			this.btnnuevo.TabIndex = 70;
			this.btnnuevo.Text = "Nuevo";
			this.btnnuevo.UseVisualStyleBackColor = true;
			// 
			// FrmUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(647, 430);
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
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FrmUsuario";
			this.ShowInTaskbar = false;
			this.Text = "Registro de Usuario";
			this.Load += new System.EventHandler(this.FrmUsuarioLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btncancelar;
		private System.Windows.Forms.Button btnverinforme;
		private System.Windows.Forms.Button btnprimero;
		private System.Windows.Forms.Button btnatras;
		private System.Windows.Forms.Button btnultimo;
		private System.Windows.Forms.Button btnsiguiente;
		private System.Windows.Forms.Button btnsalir;
		private System.Windows.Forms.ListView lVPermisos;
		private System.Windows.Forms.MaskedTextBox mTxtCedula;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtContrasena;
		private System.Windows.Forms.TextBox txtConfContr;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnnuevo;
		private System.Windows.Forms.Button btnguardar;
		private System.Windows.Forms.Button btneditar;
		private System.Windows.Forms.Button Buscar;
	}
}
