/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 11/13/2009
 * Time: 9:38 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace SoporteDistrital.Clases
{
	/// <summary>
	/// Description of Regional.
	/// </summary>
	public class Regional
	{
		private string codregional=string.Empty;
		private string nombre=string.Empty;
		private string direccion=string.Empty;
		private string telefono=string.Empty;
		private string estado=string.Empty;
		public Regional()
		{
		}
		public string Codregional
		{
			get{return codregional;}
			set{codregional=value;}
		}
		public string Nombre
		{
			get{return nombre;}
			set{nombre=value;}
		}
		public string Direccion
		{
			get{return direccion;}
			set{direccion=value;}
		}
		public string Telefono
		{
			get{return telefono;}
			set{telefono=value;}
		}
		public string Estado
		{
			get{return estado;}
			set{estado=value;}
		}
	}
}
