/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 4/3/2009
 * Time: 11:13 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace SoporteDistrital
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public Usuario UsuarioActual =new Usuario();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void DocentesToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmTecnicoDocente TecDoc =new FrmTecnicoDocente();
			TecDoc.MdiParent=this;
			TecDoc.StartPosition= FormStartPosition.CenterScreen;
			TecDoc.tipo=1;
			TecDoc.Text="Ingreso de personal docente";
			TecDoc.Show();
		}
		
		void ToolStripMenuItem4Click(object sender, EventArgs e)
		{
			FrmTecnicoDocente TecDoc =new FrmTecnicoDocente();
			TecDoc.MdiParent=this;
			TecDoc.StartPosition= FormStartPosition.CenterScreen;
			TecDoc.tipo=0;
			TecDoc.Text="Ingreso de personal técnico";
			TecDoc.Show();
			
		}
		
		void RegionalToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmRegional NuevaRegional=new FrmRegional();
			NuevaRegional.MdiParent=this;
			NuevaRegional.StartPosition=FormStartPosition.CenterScreen;
			NuevaRegional.Show();
		}
		
		void DistritoEducativoToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmDistrito frmDis = new FrmDistrito();
			frmDis.MdiParent=this;
			frmDis.StartPosition=FormStartPosition.CenterScreen;
			frmDis.Show();
		}
		
		void CentroEducativoToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmCentroEd frmcentro =new FrmCentroEd();
			frmcentro.MdiParent=this;
			frmcentro.StartPosition=FormStartPosition.CenterScreen;
			frmcentro.Show();
		}
		
		void TarjetaToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmTarjeta frmtarjeta=new FrmTarjeta();
			frmtarjeta.MdiParent=this;
			frmtarjeta.StartPosition=FormStartPosition.CenterScreen;
			frmtarjeta.Show();
			
		}
		
		void DeApoyoToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmNuevoEmpleado NuevoEmpleado =new FrmNuevoEmpleado();
			NuevoEmpleado.MdiParent=this;
			NuevoEmpleado.StartPosition=FormStartPosition.CenterScreen;
			NuevoEmpleado.Show();
		}
		
		void ToolStripMenuItem6Click(object sender, EventArgs e)
		{
			FrmAsigTarjApoyo asig = new FrmAsigTarjApoyo();
			asig.MdiParent=this;
			asig.StartPosition=FormStartPosition.CenterScreen;
			asig.Text="Asignar Tarjeta a Personal de Apoyo";
			asig.tipo=2;
			asig.Show();
		}
		
		void ToolStripMenuItem5Click(object sender, EventArgs e)
		{
			FrmAsigTarjApoyo asig = new FrmAsigTarjApoyo();
			asig.MdiParent=this;
			asig.StartPosition=FormStartPosition.CenterScreen;
			asig.Text="Asignar Tarjeta a Docente";
			asig.tipo=1;
			asig.Show();
		}
		
		void EmpleadosToolStripMenuItem1Click(object sender, EventArgs e)
		{
			FrmConsultaPersonal C_CentEd =new FrmConsultaPersonal();
			C_CentEd.MdiParent=this;
			C_CentEd.StartPosition=FormStartPosition.CenterScreen;
			C_CentEd.Show();
		}
		
		void ToolStripMenuItem7Click(object sender, EventArgs e)
		{
			FrmConsultaPersArea frmCParea =new FrmConsultaPersArea();
			frmCParea.MdiParent=this;
			frmCParea.StartPosition=FormStartPosition.CenterScreen;			
			frmCParea.Show();
		}
		
		void ToolStripMenuItem8Click(object sender, EventArgs e)
		{
			FrmcConsultaPorCargo frmConsCarg = new FrmcConsultaPorCargo();
			frmConsCarg.MdiParent=this;
			frmConsCarg.StartPosition=FormStartPosition.CenterScreen;
			frmConsCarg.Show();
		}
		
		void ConectarToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmConectar frmconec =new FrmConectar();
			//frmconec.MdiParent=this;
			frmconec.StartPosition=FormStartPosition.CenterScreen;
			frmconec.miMenu=this.MainMenuStrip;
			frmconec.ShowDialog();
			UsuarioActual=frmconec.UsuarioLog;
			statusStrip1.Items[0].Text="Usuario Actual: "+UsuarioActual.NombreUsuario;
			
		}
		
		void RegistrarUsuarioToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmUsuario FrmUsu = new FrmUsuario();
			FrmUsu.MdiParent=this;
			FrmUsu.StartPosition=FormStartPosition.CenterScreen;
			FrmUsu.Show();
		}
		
		void CambiarContraseñaToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmCambiaContr frmCambCont = new FrmCambiaContr();
			frmCambCont.StartPosition= FormStartPosition.CenterScreen;
			frmCambCont.Usuar=this.UsuarioActual;
			frmCambCont.ShowDialog();
			
		}
		
		void CentrosEducativosToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmConsultaCentroEd frmConsultCent =new FrmConsultaCentroEd();
			frmConsultCent.MdiParent=this;
			frmConsultCent.StartPosition=FormStartPosition.CenterScreen;
			frmConsultCent.Show();
		}
		
		void ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			FrmLiberarTarj1 frmlibre=new FrmLiberarTarj1();
			frmlibre.MdiParent=this;
			frmlibre.StartPosition=FormStartPosition.CenterScreen;
			frmlibre.Show();
		}
		
		void HistorialToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form1 frm1 =new Form1();
			frm1.MdiParent=this;
			frm1.StartPosition=FormStartPosition.CenterScreen;
			frm1.Show();
		}
		
		void DesconectarToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
	}
}
