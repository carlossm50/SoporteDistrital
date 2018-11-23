/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 11/12/2009
 * Time: 4:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace SoporteDistrital
{
	/// <summary>
	/// Description of CentroEducativo.
	/// </summary>
	public class CentroEducativo
	{
		private int codigocentro=0;
		private string codigodistrito=string.Empty;
		private string nombre=string.Empty;
		private string direccion =string.Empty;
		private string telefono=string.Empty;
		private string tanda=string.Empty;
		private string estado=string.Empty;
		private string cantAulas=string.Empty;
		private string cantSecc=string.Empty;
		
		public CentroEducativo()
		{
		}
		public int CodigoCentro
		{
			get{return codigocentro;}
			set{codigocentro=value;}
		}
		public string CodigoDistrito
		{
			get{return codigodistrito;}
			set{codigodistrito=value;}
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
		public string Tanda
		{
			get{return tanda;}
			set{tanda=value;}
		}
		public string Estado
		{
			get{return estado;}
			set{estado=value;}
		}
		public string CantidadAulas
		{
			get{return cantAulas;}
			set{cantAulas=value;}
		}
		public string CantidadSecciones
		{
			get{return cantSecc;}
			set{cantSecc=value;}
		}
	}
}
