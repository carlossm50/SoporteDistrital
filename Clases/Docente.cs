/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 07/12/2009
 * Hora: 10:29 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;

namespace SoporteDistrital.Clases
{
	/// <summary>
	/// Description of Docente.
	/// </summary>
	public class Docente:Empleado
	{
		private string nivelAcademico=string.Empty;
		private string titulo=string.Empty;
		private string areaEstudio=string.Empty;
		private byte tipo;
		
		public Docente()
		{
		}
		public string NivelAcademico
		{
			get{return nivelAcademico;}
			set{nivelAcademico=value;}
		}
		public string Titulo
		{
			get{return titulo;}
			set{titulo=value;}
		}
		public string AreaEstudio
		{
			get{return areaEstudio;}
			set{areaEstudio=value;}
		}
		public byte Tipo
		{
			get{return tipo;}
			set{tipo=value;}
		}
	}
}
