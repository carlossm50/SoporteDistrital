/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 11/13/2009
 * Time: 9:42 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace SoporteDistrital.Clases
{
	/// <summary>
	/// Description of Historial.
	/// </summary>
	public class Historial
	{
		private int idhistorial=0;
		private string cedulaempl=string.Empty;
		private string nomUsuario=string.Empty;
		private string descripcion=string.Empty;
		public Historial()
		{
		}
		public int HistorialID
		{
			get{return idhistorial;}
			set{idhistorial=value;}
		}
		public string CedulaEmpl
		{
			get{return cedulaempl;}
			set{cedulaempl=value;}
		}
		public string NombreUsuario
		{
			get{return nomUsuario;}
			set{nomUsuario=value;}
		}
		public string Descripcion
		{
			get{return descripcion;}
			set{descripcion=value;}
		}
	}
}
