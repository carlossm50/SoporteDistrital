/*
 * Creado por SharpDevelop.
 * Usuario: admin
 * Fecha: 02/06/2010
 * Hora: 12:59 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificaci�n | Editar Encabezados Est�ndar
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace SoporteDistrital
{
	/// <summary>
	/// Description of FrmCambiaContr.
	/// </summary>
	public partial class FrmCambiaContr : Form
	{
		public Usuario Usuar=new Usuario();
		public FrmCambiaContr()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtncancelarClick(object sender, EventArgs e)
		{
			this.DialogResult=DialogResult.Cancel;
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			if(txtContrActual.Text.Trim()==string.Empty)
			{
				MessageBox.Show("Escriba su contrase�a","Soporte Distrital", MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtContrActual.Focus();
				return;
			}
			if(txtNContras.Text.Trim()==string.Empty)
			{
				MessageBox.Show("Escriba la nueva contrase�a","Soporte Distrital", MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtNContras.Focus();
				return;
			}
			if(txtConfContr.Text.Trim()==string.Empty)
			{
				MessageBox.Show("Confirme la nueva contrase�a","Soporte Distrital", MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtConfContr.Focus();
				return;
			}
			if(txtNContras.Text!=txtConfContr.Text)
			{
				MessageBox.Show("Las contrese�as que ha escrito no coinciden.","Soporte Distrital", MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtNContras.Clear();
				txtConfContr.Clear();
				txtNContras.Focus();
				return;
			}
			if (txtContrActual.Text!=Usuar.Contrace�a)
			{
				MessageBox.Show("La contrase�a no es valida.","Soporte Distrital", MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtContrActual.Focus();
				return;
			}
			if (txtContrActual.Text==txtNContras.Text)
			{
				MessageBox.Show("La nueva contrase�a debe ser diferente de la contrase�a actual.","Soporte Distrital", MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtNContras.Clear();
				txtConfContr.Clear();
				txtNContras.Focus();
				return;
			}
			Mantenimiento mant=new Mantenimiento();
			if(mant.Cambiacontrasena(Usuar.NombreUsuario,txtNContras.Text))
			{
				MessageBox.Show("La informaci�n ha sido guardada exitosamente","SoporteDistrital",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			this.DialogResult=DialogResult.OK;
		}
	}
}
