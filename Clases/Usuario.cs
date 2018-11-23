/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 11/13/2009
 * Time: 9:50 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace SoporteDistrital.Clases
{
	/// <summary>
	/// Description of Usuario.
	/// </summary>
	public class Usuario
	{
		private int usuarioid=0;
		private string nomUsuario=string.Empty;
		private string contrac=string.Empty;
		private string cedulaempl=string.Empty;
		private string estado=string.Empty;
		public Usuario()
		{
		}
		public int UsuarioID
		{
			get{return usuarioid;}
			set{usuarioid=value;}
		}
		public string Contracena
		{
			get{return contrac;}
			set{contrac=value;}
		}
		public string NombreUsuario
		{
			get{return nomUsuario;}
			set{nomUsuario=value;}
		}
		public string Cedulaempleado
		{
			get{return cedulaempl;}
			set{cedulaempl=value;}
		}
		public string Estado
		{
			get{return estado;}
			set{estado=value;}
		}
	}
}
