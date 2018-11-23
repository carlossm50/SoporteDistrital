/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 25/03/2010
 * Hora: 10:36 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using SoporteDistrital.Clases;
namespace SoporteDistrital
{
	/// <summary>
	/// Description of FrmConectar.
	/// </summary>
	public partial class FrmConectar : Form
	{
		public MenuStrip miMenu=new MenuStrip();
		private int cont=0;
		public Usuario UsuarioLog = new Usuario();
		public FrmConectar()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BTNACEPTARClick(object sender, EventArgs e)
		{
			Mantenimiento mat=new Mantenimiento();
			if(txtUsuario.Text.Trim()==string.Empty)
			{
				MessageBox.Show("El Usuario no debe estar vacío.","abvertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtUsuario.Focus();
				return;
			}
			else if(txtcontrasena.Text.Trim()==string.Empty)
			{
				MessageBox.Show("La Contraceña no debe estar vacía.","abvertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtcontrasena.Focus();
				return;
			}
			if(!(mat.Chekapermisos(txtUsuario.Text,txtcontrasena.Text)==string.Empty))
			{
				mat.ActivaMenu(miMenu,mat.Chekapermisos(txtUsuario.Text,txtcontrasena.Text));
				UsuarioLog.NombreUsuario=txtUsuario.Text;
				mat.BuscaUsuario(UsuarioLog);
				this.Close();
			}
			else 
			{
				cont++;
				LBmensaje.Text="Intento(s): "+cont.ToString()+"/3";
				LBmensaje.Visible=true;
				if (cont==3)
					Application.Exit();
			}
			
			
		}
	}
}
public class Usuario
{
	private string id =string.Empty;
	private string Nom_usu=string.Empty;
	private string contrac=string.Empty;
	private string cedula=string.Empty;
	private string permisos=string.Empty;
	public Usuario()
	{
	}
	public string Id
	{
		get{return id;}
		set{id=value;}
	}
	public string NombreUsuario
	{
		get{return Nom_usu;}
		set{Nom_usu=value;}
	}
	public string Contraceña
	{
		get{return contrac;}
		set{contrac=value;}
	}
	public string Cedula
	{
		get{return cedula;}
		set{cedula=value;}
	}
	public string Permisos 
	{
		get{return permisos;}
		set{permisos=value;}
	}
	
	
}
