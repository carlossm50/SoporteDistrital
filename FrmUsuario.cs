/*
 * Creado por SharpDevelop.
 * Usuario: admin
 * Fecha: 30/05/2010
 * Hora: 11:08 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace SoporteDistrital
{
	/// <summary>
	/// Description of FrmUsuario.
	/// </summary>
	public partial class FrmUsuario : Form
	{
		public FrmUsuario()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnguardarClick(object sender, EventArgs e)
		{
			if(mTxtCedula.Text.Trim().Length<13)
			{
				MessageBox.Show("La cédula no es correcta","Soporte Distrital", MessageBoxButtons.OK,MessageBoxIcon.Warning);
				mTxtCedula.Focus();
				return;
			}
			if(txtnombre.Text.Trim()==string.Empty || txtnombre.Text=="NO ENCONTRADO")
			{
				MessageBox.Show("No se ha espesificado el empleado","Soporte Distrital", MessageBoxButtons.OK,MessageBoxIcon.Warning);
				mTxtCedula.Focus();
				return;
			}
			
			if(txtUsuario.Text.Trim()==string.Empty)
			{
				MessageBox.Show("El nombre de Usuarion está vacío","Soporte Distrital", MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtUsuario.Focus();
				return;
			}
			if(txtContrasena.Text.Trim()==string.Empty)
			{
				MessageBox.Show("La Contraseña está vacía","Soporte Distrital", MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtContrasena.Focus();
				return;
			}
			if(txtConfContr.Text.Trim()==string.Empty)
			{
				MessageBox.Show("Debe confirmar su contraseña","Soporte Distrital", MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtConfContr.Focus();
				return;
			}
			if(txtConfContr.Text!=txtContrasena.Text)
			{
				MessageBox.Show("Las contreseñas que ha escrito no coinciden.","Soporte Distrital", MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtContrasena.Clear();
				txtConfContr.Clear();
				txtContrasena.Focus();
				return;
			}
			Mantenimiento mant =new Mantenimiento();
			Usuario usu=new Usuario();
			usu.Cedula=mTxtCedula.Text;
			usu.NombreUsuario=txtUsuario.Text;
			usu.Contraceña=txtContrasena.Text;
			if(mant.GuardaUsuario(usu))
			{
				usu.Id=mant.Buscaentabla("select UsuarioID from tblusuarios where NomUsu='"+txtUsuario.Text+"'");
				if(mant.GuardaPermisos(lVPermisos,System.Convert.ToInt32(usu.Id)))
				MessageBox.Show("La información ha sido guardada exitosamente","SoporteDistrital",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		}
		
		void MTxtCedulaKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar=='\r')
			{
				Mantenimiento mant =new Mantenimiento();
				txtnombre.Text=mant.Buscaentabla("select concat(nombre,' ',apellido1,' ',apellido2) as Nombre,cedula from empleados where cedula='"+mTxtCedula.Text.Trim()+"'");
			}
		}
		
		void MTxtCedulaValidating(object sender, System.ComponentModel.CancelEventArgs e)
		{
 			Mantenimiento mant =new Mantenimiento();
  			txtnombre.Text=mant.Buscaentabla("select concat(nombre,' ',apellido1,' ',apellido2) as Nombre,cedula from empleados where cedula='"+mTxtCedula.Text.Trim()+"'");
		}
		
		void FrmUsuarioLoad(object sender, EventArgs e)
		{
			Mantenimiento mant=new Mantenimiento();
			mant.llenalista(this.lVPermisos,MdiParent.MainMenuStrip);
		}
		
		void LVPermisosClick(object sender, EventArgs e)
		{
			//MessageBox.Show(lVPermisos.Items[System.Convert.ToInt32(txtUsuario.Text)].ImageIndex.ToString());
		}
		
		void BuscarClick(object sender, EventArgs e)
		{
			FrmBuscaEmpleado frmBusCaEm=new FrmBuscaEmpleado();
			frmBusCaEm.StartPosition= FormStartPosition.CenterScreen;
			frmBusCaEm.tipo=1;
			if(frmBusCaEm.ShowDialog()== DialogResult.OK)
			{
				mTxtCedula.Text=frmBusCaEm.cedula;
				Mantenimiento mant =new Mantenimiento();
  			    txtnombre.Text=mant.Buscaentabla("select concat(nombre,' ',apellido1,' ',apellido2) as Nombre,cedula from empleados where cedula='"+mTxtCedula.Text.Trim()+"'");
			}
		}
		void GActivaTex()
		{
			lVPermisos.Enabled=true;
		}
		void NActivaTex()
		{
			lVPermisos.Enabled=false;
		}
	}
}
