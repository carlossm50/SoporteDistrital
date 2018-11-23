/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 4/3/2009
 * Time: 3:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace SoporteDistrital
{
	/// <summary>
	/// Description of Empleado.
	/// </summary>
	public class Empleado
	{
		private string cedula= string.Empty;
		private string nombre= string.Empty;
		private string apellido1= string.Empty;
		private string apellido2= string.Empty;
		private string direccion= string.Empty;
		private string telefono= string.Empty;
		private string celular= string.Empty;
		private int estatus=0;
		private string fech_ingreso= string.Empty;
		private string fech_nacimiento= string.Empty;
		private string sexo= string.Empty;
		private int control;
		
		public Empleado()
		{
		}
		public string Cedula 
		{
			get {return cedula;}
			set{cedula=value;}
		}
		public string Nombre
		{
			get {return nombre;}
			set{nombre=value;}
		}
		public string Apellido1
		{
			get {return apellido1;}
			set{apellido1=value;}
		}
		public string Apellido2
		{
			get {return apellido2;}
			set{apellido2=value;}
		}
		public string Direccion
		{
			get {return direccion;}
			set{direccion=value;}
		}
		public string Telefono 
		{
			get {return telefono;}
			set{telefono=value;}
		}
		public string Celular
		{
			get {return celular;}
			set{celular=value;}
		}
		public int Estatus
		{
			get {return estatus;}
			set{estatus=value;}
		}
		public string Fecha_Inggreso
		{
			get {return fech_ingreso;}
			set{fech_ingreso=value;}
		}
		public string Fecha_Nacimiento
		{
			get {return fech_nacimiento;}
			set{fech_nacimiento=value;}
		}
		public string Sexo
		{
			get {return sexo;}
			set{sexo=value;}
		}
		public int Control
		{
			get {return control;}
			set {control=value;}
		}
	}
}
