/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 4/3/2009
 * Time: 11:13 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SoporteDistrital
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.docentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deApoyoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tarjetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.centroEducativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.distritoEducativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.regionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
			this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
			this.centrosEducativosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.estadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.archivoToolStripMenuItem,
									this.toolStripMenuItem2,
									this.mantenimientosToolStripMenuItem,
									this.consultasToolStripMenuItem,
									this.herramientasToolStripMenuItem,
									this.ayudaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(544, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.conectarToolStripMenuItem,
									this.desconectarToolStripMenuItem,
									this.toolStripSeparator1,
									this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Tag = "0";
			this.archivoToolStripMenuItem.Text = "&Archivo";
			// 
			// conectarToolStripMenuItem
			// 
			this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
			this.conectarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.conectarToolStripMenuItem.Tag = "0";
			this.conectarToolStripMenuItem.Text = "Conectar";
			this.conectarToolStripMenuItem.Click += new System.EventHandler(this.ConectarToolStripMenuItemClick);
			// 
			// desconectarToolStripMenuItem
			// 
			this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
			this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.desconectarToolStripMenuItem.Tag = "0";
			this.desconectarToolStripMenuItem.Text = "Desconectar";
			this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.DesconectarToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.salirToolStripMenuItem.Tag = "0";
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.copiarToolStripMenuItem,
									this.cortarToolStripMenuItem,
									this.pegarToolStripMenuItem});
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(58, 20);
			this.toolStripMenuItem2.Tag = "0";
			this.toolStripMenuItem2.Text = "Edición";
			// 
			// copiarToolStripMenuItem
			// 
			this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
			this.copiarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.copiarToolStripMenuItem.Tag = "0";
			this.copiarToolStripMenuItem.Text = "Copiar";
			// 
			// cortarToolStripMenuItem
			// 
			this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
			this.cortarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.cortarToolStripMenuItem.Tag = "0";
			this.cortarToolStripMenuItem.Text = "Cortar";
			// 
			// pegarToolStripMenuItem
			// 
			this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
			this.pegarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.pegarToolStripMenuItem.Tag = "0";
			this.pegarToolStripMenuItem.Text = "Pegar";
			// 
			// mantenimientosToolStripMenuItem
			// 
			this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.empleadosToolStripMenuItem,
									this.tarjetaToolStripMenuItem,
									this.toolStripMenuItem5,
									this.toolStripMenuItem6,
									this.centroEducativoToolStripMenuItem,
									this.distritoEducativoToolStripMenuItem,
									this.regionalToolStripMenuItem});
			this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
			this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
			this.mantenimientosToolStripMenuItem.Tag = "300";
			this.mantenimientosToolStripMenuItem.Text = "&Mantenimientos";
			// 
			// empleadosToolStripMenuItem
			// 
			this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripMenuItem4,
									this.docentesToolStripMenuItem,
									this.deApoyoToolStripMenuItem});
			this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
			this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
			this.empleadosToolStripMenuItem.Tag = "301";
			this.empleadosToolStripMenuItem.Text = "Personal";
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(124, 22);
			this.toolStripMenuItem4.Tag = "308";
			this.toolStripMenuItem4.Text = "Técnico";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.ToolStripMenuItem4Click);
			// 
			// docentesToolStripMenuItem
			// 
			this.docentesToolStripMenuItem.Name = "docentesToolStripMenuItem";
			this.docentesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.docentesToolStripMenuItem.Tag = "309";
			this.docentesToolStripMenuItem.Text = "Docente";
			this.docentesToolStripMenuItem.Click += new System.EventHandler(this.DocentesToolStripMenuItemClick);
			// 
			// deApoyoToolStripMenuItem
			// 
			this.deApoyoToolStripMenuItem.Name = "deApoyoToolStripMenuItem";
			this.deApoyoToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.deApoyoToolStripMenuItem.Tag = "310";
			this.deApoyoToolStripMenuItem.Text = "De apoyo";
			this.deApoyoToolStripMenuItem.Click += new System.EventHandler(this.DeApoyoToolStripMenuItemClick);
			// 
			// tarjetaToolStripMenuItem
			// 
			this.tarjetaToolStripMenuItem.Name = "tarjetaToolStripMenuItem";
			this.tarjetaToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
			this.tarjetaToolStripMenuItem.Tag = "302";
			this.tarjetaToolStripMenuItem.Text = "Tarjeta";
			this.tarjetaToolStripMenuItem.Click += new System.EventHandler(this.TarjetaToolStripMenuItemClick);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(255, 22);
			this.toolStripMenuItem5.Tag = "303";
			this.toolStripMenuItem5.Text = "Asignar Tarjeta Técnico/Docente";
			this.toolStripMenuItem5.Click += new System.EventHandler(this.ToolStripMenuItem5Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(255, 22);
			this.toolStripMenuItem6.Tag = "304";
			this.toolStripMenuItem6.Text = "Asignar Tarjeta Personal de Apoyo";
			this.toolStripMenuItem6.Click += new System.EventHandler(this.ToolStripMenuItem6Click);
			// 
			// centroEducativoToolStripMenuItem
			// 
			this.centroEducativoToolStripMenuItem.Name = "centroEducativoToolStripMenuItem";
			this.centroEducativoToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
			this.centroEducativoToolStripMenuItem.Tag = "305";
			this.centroEducativoToolStripMenuItem.Text = "Centro Educativo";
			this.centroEducativoToolStripMenuItem.Click += new System.EventHandler(this.CentroEducativoToolStripMenuItemClick);
			// 
			// distritoEducativoToolStripMenuItem
			// 
			this.distritoEducativoToolStripMenuItem.Name = "distritoEducativoToolStripMenuItem";
			this.distritoEducativoToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
			this.distritoEducativoToolStripMenuItem.Tag = "306";
			this.distritoEducativoToolStripMenuItem.Text = "Distrito Educativo";
			this.distritoEducativoToolStripMenuItem.Click += new System.EventHandler(this.DistritoEducativoToolStripMenuItemClick);
			// 
			// regionalToolStripMenuItem
			// 
			this.regionalToolStripMenuItem.Name = "regionalToolStripMenuItem";
			this.regionalToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
			this.regionalToolStripMenuItem.Tag = "307";
			this.regionalToolStripMenuItem.Text = "Regional";
			this.regionalToolStripMenuItem.Click += new System.EventHandler(this.RegionalToolStripMenuItemClick);
			// 
			// consultasToolStripMenuItem
			// 
			this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripMenuItem9,
									this.empleadosToolStripMenuItem1,
									this.toolStripMenuItem7,
									this.toolStripMenuItem8,
									this.centrosEducativosToolStripMenuItem,
									this.toolStripMenuItem3,
									this.estadísticasToolStripMenuItem});
			this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
			this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.consultasToolStripMenuItem.Tag = "400";
			this.consultasToolStripMenuItem.Text = "Consultas";
			// 
			// toolStripMenuItem9
			// 
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			this.toolStripMenuItem9.Size = new System.Drawing.Size(182, 22);
			this.toolStripMenuItem9.Text = "Expedir Certificación";
			this.toolStripMenuItem9.Click += new System.EventHandler(this.ToolStripMenuItem1Click);
			// 
			// empleadosToolStripMenuItem1
			// 
			this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
			this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
			this.empleadosToolStripMenuItem1.Tag = "401";
			this.empleadosToolStripMenuItem1.Text = "Personal en general";
			this.empleadosToolStripMenuItem1.Click += new System.EventHandler(this.EmpleadosToolStripMenuItem1Click);
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(182, 22);
			this.toolStripMenuItem7.Tag = "402";
			this.toolStripMenuItem7.Text = "Personal por área";
			this.toolStripMenuItem7.Click += new System.EventHandler(this.ToolStripMenuItem7Click);
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(182, 22);
			this.toolStripMenuItem8.Tag = "403";
			this.toolStripMenuItem8.Text = "Personal por cargo";
			this.toolStripMenuItem8.Click += new System.EventHandler(this.ToolStripMenuItem8Click);
			// 
			// centrosEducativosToolStripMenuItem
			// 
			this.centrosEducativosToolStripMenuItem.Name = "centrosEducativosToolStripMenuItem";
			this.centrosEducativosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.centrosEducativosToolStripMenuItem.Tag = "404";
			this.centrosEducativosToolStripMenuItem.Text = "Centros Educativos";
			this.centrosEducativosToolStripMenuItem.Click += new System.EventHandler(this.CentrosEducativosToolStripMenuItemClick);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(179, 6);
			// 
			// estadísticasToolStripMenuItem
			// 
			this.estadísticasToolStripMenuItem.Name = "estadísticasToolStripMenuItem";
			this.estadísticasToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.estadísticasToolStripMenuItem.Text = "Estadísticas";
			// 
			// herramientasToolStripMenuItem
			// 
			this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.registrarUsuarioToolStripMenuItem,
									this.cambiarContraseñaToolStripMenuItem,
									this.toolStripSeparator2,
									this.historialToolStripMenuItem});
			this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
			this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.herramientasToolStripMenuItem.Tag = "500";
			this.herramientasToolStripMenuItem.Text = "Seguridad";
			// 
			// registrarUsuarioToolStripMenuItem
			// 
			this.registrarUsuarioToolStripMenuItem.Name = "registrarUsuarioToolStripMenuItem";
			this.registrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.registrarUsuarioToolStripMenuItem.Tag = "501";
			this.registrarUsuarioToolStripMenuItem.Text = "Registrar Usuario";
			this.registrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.RegistrarUsuarioToolStripMenuItemClick);
			// 
			// cambiarContraseñaToolStripMenuItem
			// 
			this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
			this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.cambiarContraseñaToolStripMenuItem.Tag = "502";
			this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
			this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.CambiarContraseñaToolStripMenuItemClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// historialToolStripMenuItem
			// 
			this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
			this.historialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.historialToolStripMenuItem.Tag = "503";
			this.historialToolStripMenuItem.Text = "Historial";
			this.historialToolStripMenuItem.Click += new System.EventHandler(this.HistorialToolStripMenuItemClick);
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.ayudaToolStripMenuItem.Tag = "0";
			this.ayudaToolStripMenuItem.Text = "Ayuda";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 321);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(544, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(90, 17);
			this.toolStripStatusLabel1.Text = "Usuario Actual: ";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(544, 343);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Sistema de Soporte Distrital";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
		private System.Windows.Forms.ToolStripMenuItem estadísticasToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem centrosEducativosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem deApoyoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem docentesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registrarUsuarioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem regionalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem distritoEducativoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem centroEducativoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tarjetaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
