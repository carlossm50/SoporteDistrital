/*
 * Creado por SharpDevelop.
 * Usuario: admin
 * Fecha: 09/06/2011
 * Hora: 06:34 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace SoporteDistrital
{
	/// <summary>
	/// Description of OtrosFormatos.
	/// </summary>
	public class OtrosFormatos

{

StreamWriter w;

string ruta;
public string nombre;
public string cedula;
public string cargo;
public string centro;
public string sueldo;
public string tarjeta;
	

public string xpath { get { return ruta; } set { value = ruta; }}
/// <summary>

/// Constructor que establece el path del archivo

/// </summary>

/// <param name="path"></param>

public OtrosFormatos(string path)

{

ruta = @path;

}

 /// <summary>
 /// Exportar certificacion 
 /// </summary>
 /// <param name="titulos"></param>
 /// <param name="datos"></param>
 public void exportarcertificacion()
 {
 	
 	try{
 		FileStream ct=new FileStream(ruta,FileMode.Create,FileAccess.ReadWrite);
 		StreamWriter Cert_virt=new StreamWriter(ct);
 		StringBuilder certic=new StringBuilder();
 		string comillas = char.ConvertFromUtf32(34);
 		certic.Append(@"<!DOCTYPE html PUBLIC" + comillas +

"-//W3C//DTD XHTML 1.0 Transitional//EN" + comillas +

" " + comillas

+ "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"

+ comillas + ">");

certic.Append(@"<html xmlns=" + comillas + "http://www.w3.org/1999/xhtml"

+ comillas + ">");

certic.Append(@"<head>");

certic.Append(@"<meta http-equiv=" + comillas +"Content-Type"

+ comillas + "content=" + comillas

+ "text/html; charset=utf-8" + comillas+"/>");

certic.Append(@"<title>Untitled Document</title>");

certic.Append(@"</head>");
certic.Append(@"<body>");
certic.Append(@"<div style='text-align:center'><img src="+comillas+@"C:\SoporteDistrital\imajenes\escudo.bmp"+comillas+@"</img></div>");
certic.Append(@"<div style='text-align:center;line-height:150%;font-size:14.0pt'><b>MINISTERIO DE EDUCACION DE LA REPUBLICA DOMINICANA</b></div>");
certic.Append(@"<div style='text-align:center;line-height:150%;font-size:14.0pt'><b>(MINERD)</b></div>");
certic.Append(@"<div style='text-align:center;line-height:150%;font-size:14.0pt'><b>DISTRITO EDUCATIVO 07-07 DE VILLA TAPIA</b></div>");
certic.Append(@"<br><br>");
certic.Append(@"<div style='text-align:center;line-height:150%;font-size:14.0pt'>C E R T I F I C A C I O N</div>");
certic.Append(@"<br><br>");
 		certic.Append(@"<div align="+comillas+@"center"+comillas+@"><h3>"+nombre+"</h3>");
 		certic.Append(@"</div>");
 		certic.Append(@"<br>"); 		
 		certic.Append(@"<p  style='text-align:justify;line-height:150%;font-size:14.0pt'>DOMINICANO(A), MAYOR DE EDAD, CEDULA DE IDENTIDAD Y ELECTORAL NO. "+cedula
 		             +", LABORA BAJO NUESTRA DEPENDENCIA DESENPEÑANDO LA(S) FUNCION(ES) DE "+cargo
 		            +" EN EL CENTRO EDUCATIVO "+centro+".</p>");
 		certic.Append(@"<p style='text-align:left;line-height:100%;font-size:14.0pt'>");
 		certic.Append("TARJETA NO.:"+tarjeta);
 		certic.Append(@"<br>");
 		certic.Append("SUELDO:RD$:"+sueldo); 		
 		certic.Append(@"<p style='text-align:justify;line-height:150%;font-size:14.0pt'>SE EXPIDE LA PRESENTE CERTIFICACION A SOLICITUD DE LA PARTE INTERESADA "+
 		              "EN  EL MUNICIPIO DE VILLA TAPIA, PROVINCIA  HERMANAS  MIRABAL, "+
 		              "REPUBLICA DOMINICANA, A LOS ");
 		certic.Append(DateTime.Now.Day.ToString());
 		certic.Append(" DIAS DEL  MES DE ");
 		switch(DateTime.Now.Month){
 				case 1:{certic.Append("ENERO");break; }
 				case 2:{certic.Append("FEBRERO");break;}
 				case 3:{certic.Append("MARZO");break;}
 				case 4:{certic.Append("ABRIL");break;}
 				case 5:{certic.Append("MAYO");break;}
 				case 6:{certic.Append("JUNIO");break;}
 				case 7:{certic.Append("JULIO");break;}
 				case 8:{certic.Append("AGOSTO");break;}
 				case 9:{certic.Append("SEPTIEMBRE");break;}
 				case 10:{certic.Append("OCTUBRE");break;}
 				case 11:{certic.Append("NOVIEMBRE");break;}
 				case 12:{certic.Append("DICIEMBRE");break;}
				default:{break;};
			}
 		certic.Append(" DEL AÑO "+DateTime.Now.Year.ToString()+".</p>");
 		certic.Append(@"<br><br>");
 		certic.Append(@"<div style='text-align:center;line-height:100%;font-size:14.0pt'><b>LIC. JUANA MIGDALIA VASQUEZ</b></div>");
 	    certic.Append(@"<div style='text-align:center;line-height:100%;font-size:14.0pt'><b>DIRECTORA DISTRITO EDUCATIVO 07-07</b></div>");
 		certic.Append(@"</body>");
		certic.Append(@"</html>");
 		Cert_virt.Write(certic.ToString());
 		Cert_virt.Close();
 	}
 	catch (Exception ex)

	{

		throw ex;

	}
 	
 }
/// <summary>

/// Exporta datos a un archivo

/// </summary>

/// <param name="titulos"></param>

/// <param name="datos"></param>

public void Export(ArrayList titulos, DataTable datos)

{

try

{
//Creando en archivo
FileStream fs = new FileStream(ruta, FileMode.Create,

FileAccess.ReadWrite);

//Carga el archivo y lo representa de manera virtual
w = new StreamWriter(fs);

string comillas = char.ConvertFromUtf32(34);

StringBuilder html = new StringBuilder();

html.Append(@"<!DOCTYPE html PUBLIC" + comillas +

"-//W3C//DTD XHTML 1.0 Transitional//EN" + comillas +

" " + comillas

+ "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"

+ comillas + ">");

html.Append(@"<html xmlns=" + comillas + "http://www.w3.org/1999/xhtml"

+ comillas + ">");

html.Append(@"<head>");

html.Append(@"<meta http-equiv=" + comillas +"Content-Type"

+ comillas + "content=" + comillas

+ "text/html; charset=utf-8" + comillas+"/>");

html.Append(@"<title>Untitled Document</title>");

html.Append(@"</head>");

html.Append(@"<body>");

 

//Generando encabezados del archivo
html.Append(@"<div style='text-align:center'><img src="+comillas+@"C:\SoporteDistrital\imajenes\escudo.bmp"+comillas+@"</img></div>");
html.Append(@"<div style='text-align:center;line-height:150%;font-size:14.0pt'><b>MINISTERIO DE EDUCACION DE LA REPUBLICA DOMINICANA</b></div>");
html.Append(@"<div style='text-align:center;line-height:150%;font-size:14.0pt'><b>(MINERD)</b></div>");
html.Append(@"<div style='text-align:center;line-height:150%;font-size:14.0pt'><b>DISTRITO EDUCATIVO 07-07 DE VILLA TAPIA</b></div>");
html.Append(@"<br><br>");

//(aquí podemos dar el formato como a una tabla de HTML)

html.Append(@"<table WIDTH=730 CELLSPACING=0 CELLPADDING=10

border=0.5 BORDERCOLOR=" + comillas + "#333366"

+ comillas + " bgcolor=" + comillas + "#FFFFFF"

+ comillas + ">");

html.Append(@"<tr> <b>");

foreach (object item in titulos)

{

html.Append(@"<th>" + item.ToString() + "</th>");

}

html.Append(@"</b> </tr>");


//Generando datos del archivo

for (int i = 0; i < datos.Rows.Count; i++)

{

html.Append(@"<tr>");

for (int j = 0; j < datos.Columns.Count; j++)

{

html.Append(@"<td>" +

datos.Rows[i][j].ToString() + "</td>");

}

html.Append(@"</tr>");

}

html.Append(@"</body>");

html.Append(@"</html>");

w.Write(html.ToString());

w.Close();

}

catch (Exception ex)

{

throw ex;

}

} //Fin de la Función Export



/// <summary>

/// Genera un archivo CSV

/// </summary>

/// <param name="titulos"></param>

/// <param name="datos"></param>

public void ExportCSV(ArrayList titulos, DataTable datos)

{

try

{

FileStream fs = new FileStream(ruta, FileMode.Create,

FileAccess.ReadWrite);

w = new StreamWriter(fs);

string comillas = char.ConvertFromUtf32(34);

StringBuilder CSV = new StringBuilder();


//Encabezados

for (int i = 0; i < titulos.Count; i++)

{

if (i != (titulos.Count - 1))

CSV.Append(comillas + titulos[i].ToString() + comillas + ",");

else

CSV.Append(comillas + titulos[i].ToString() + comillas

+ Environment.NewLine);

}



   // se generan datos

for (int i = 0; i < datos.Rows.Count; i++)

{

for (int j = 0; j < datos.Columns.Count; j++)

{

if (j != (titulos.Count - 1))

CSV.Append(comillas + datos.Rows[i][j].ToString()

+ comillas + ",");

else

CSV.Append(comillas + datos.Rows[i][j].ToString()

+ comillas + Environment.NewLine);

}

}

w.Write(CSV.ToString()); //se escribe la cadena en el archivo

w.Close();

}

catch (Exception ex)

{

throw ex;

}

} //Fin de ExportCSV

} // Fin de Clase OtrosFormatos
}
