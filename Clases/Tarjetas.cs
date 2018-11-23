/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 11/12/2009
 * Time: 4:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace SoporteDistrital
{
	/// <summary>
	/// Description of Tarjetas.
	/// </summary>
	public class Tarjetas:CentroEducativo
	{
		private string tarjeta =string.Empty;
		private string cargo =string.Empty;
		private double ingresos =0;
		private byte tipo;
		public Tarjetas()
		{
		}
		public string Tarjeta
		{
			get{return tarjeta;}
			set{tarjeta=value;}
		}
		public string Cargo
		{
			get{return cargo;}
			set{cargo=value;}
		}
		public double Ingresos 
		{
			get{return ingresos;}
			set{ingresos=value;}
		}
		public byte Tipo
		{
			get{return tipo;}
			set{tipo=value;}
		}
	}
}
