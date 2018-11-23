/*
 * Creado por SharpDevelop.
 * Usuario: admin
 * Fecha: 07/07/2010
 * Hora: 04:22 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
namespace SoporteDistrital
{
	/// <summary>
	/// Description of FrmCertificacion.
	/// </summary>
	public partial class FrmCertificacion : Form
	{
		public string tarjata=string.Empty;
		public string cedula=string.Empty;
		public string nombre=string.Empty;
		public string sueldo=string.Empty;
		public string centroEd=string.Empty;
		public string cargo=string.Empty;
		public string[] linea=new string[18];
		public FrmCertificacion()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BuscarClick(object sender, EventArgs e)
		{

			int start=0;
			int ends=0;
			int longitud=0;
			linea[0]=label1.Text;
			
			if(radioButton1.Checked)
			{
				lbcedula.Text+=" "+radioButton1.Text;
			}
			else 
			{
				lbcedula.Text+=" "+radioButton2.Text;
			}
			if(!(lbcedula.Width>405))
			{
					lbcedula.Text+=" "+label6.Text.Substring(0,13);
			}
			label6.Text=label6.Text.Substring(13,14);
			if(!(label6.Width>405))
			{
				if(radioButton3.Checked)
				{label6.Text+=" "+radioButton3.Text+" ";}
				else if(radioButton4.Checked)
				{label6.Text+=" "+radioButton4.Text+" ";}
				else
				{label6.Text+=" "+radioButton7.Text+" COMO ";}
			}
			ends=lbcentroEd.Text.IndexOf(" ");
			longitud=ends-start+1;
			if(!(radioButton7.Checked))
			while(!(label6.Width>370))
			{
				if (ends<0)
				{
					break;
				}
				else {
					label6.Text+=lbcentroEd.Text.Substring(start,longitud);
 					start=ends+1;
 					ends=lbcentroEd.Text.IndexOf(" ",start);
 					longitud=ends-start+1;
				}
				
			}
			if(!(radioButton7.Checked))
			{
				label8.Text=lbcentroEd.Text.Substring(start,lbcentroEd.Text.Length-start);
			}
			else 
				label8.Text=cargo;
			
			if(radioButton2.Checked)
			{
				if(checkBox1.Checked)
					label8.Text+=checkBox1.Text;
				else
					if (checkBox2.Checked)
					label8.Text+=checkBox2.Text;
			}
			linea[1]=lbcedula.Text;
			linea[2]=label6.Text;
			linea[3]=label8.Text;
			linea[5]=lbtarjeta.Text;
			linea[6]=lbsueldo.Text;
			linea[7]=label11.Text;
			linea[8]=label4.Text;
			linea[9]=label12.Text;
			linea[10]="A LOS "+label18.Text+" DIAS DEL MES DE "+label19.Text+" DEL AÑO "+label14.Text;
			linea[12]=textBox1.Text;
			linea[13]=label15.Text;
			linea[14]=lbnombre.Text;
			linea[15]=label5.Text;
			
		}
		
		void FrmCertificacionLoad(object sender, EventArgs e)
		{
			lbnombre.Text=nombre;
			lbcedula.Text+=cedula; 
			lbcentroEd.Text=centroEd+" COMO "+cargo;
			lbtarjeta.Text+=tarjata;
			lbsueldo.Text+=sueldo;
			switch(DateTime.Now.Month){
				case 1:{label19.Text="ENERO";break; }
				case 2:{label19.Text="FEBRERO";break;}
				case 3:{label19.Text="MARZO";break;}
				case 4:{label19.Text="ABRIL";break;}
				case 5:{label19.Text="MAYO";break;}
				case 6:{label19.Text="JUNIO";break;}
				case 7:{label19.Text="JULIO";break;}
				case 8:{label19.Text="AGOSTO";break;}
				case 9:{label19.Text="SEPTIEMBRE";break;}
				case 10:{label19.Text="OCTUBRE";break;}
				case 11:{label19.Text="NOVIEMBRE";break;}
				case 12:{label19.Text="DICIEMBRE";break;}
				default:{break;};
			}
			
			label18.Text=DateTime.Now.Day.ToString();
			//label19.Text=DateTime.Now.Month.ToString();
			label14.Text=DateTime.Now.Year.ToString();
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				checkBox2.Checked=false;
			}
		}
		
		void CheckBox2CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked)
			{
				checkBox1.Checked=false;
			}
		}
		
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			if(radioButton2.Checked)
			{
				checkBox1.Enabled=true;
				checkBox2.Enabled=true;
			}
			else 
			{
				checkBox1.Enabled=false;
				checkBox2.Enabled=false;
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string ruta=Application.StartupPath	+ @"\\test.doc";
			OtrosFormatos OF = new OtrosFormatos(ruta); //+ @"\\test.doc");
			OF.exportarcertificacion();
			Process.Start(ruta);
		}
	}
}
