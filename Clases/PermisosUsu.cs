/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 11/13/2009
 * Time: 9:56 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace SoporteDistrital.Clases
{
	/// <summary>
	/// Description of PermisosUsu.
	/// </summary>
	public class PermisosUsu
	{
		private int perID=0;
		private int usuID=0;
		private byte asignado=0;
		public PermisosUsu()
		{
		}
		public int PerID
		{
			get{return perID;}
			set{perID=value;}
		}
		public int UsuID
		{
			get{return usuID;}
			set{usuID=value;}
		}
		public byte Asignado
		{
			get{return asignado;}
			set{asignado=value;}
		}
	}
}
