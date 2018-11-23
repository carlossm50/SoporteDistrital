/*
 * Creado por SharpDevelop.
 * Usuario: admin
 * Fecha: 29/06/2010
 * Hora: 11:58 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Diagnostics;
namespace SoporteDistrital
{
	/// <summary>
	/// Description of FrmLiberarTarj1.
	/// </summary>
	public partial class FrmLiberarTarj1 : Form
	{
		MySqlDataReader adapt;
		Mantenimiento mantenimiemt=new Mantenimiento();
		private Font printFont;
		int fila=0;
		int cantfilas=0;
		int control=0;
		string[] linea=new string[18];
		string tarjetas=string.Empty;
		public FrmLiberarTarj1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void CargaRegistro()
		{
			
		}
		void buscaDatos()
		{
			MySqlConnection con=new MySqlConnection(System.Configuration.ConfigurationSettings.AppSettings["cono"].ToString());
			MySqlCommand coman= new MySqlCommand("select * from empleados where estado=1 and cedula='"+mtxtcedula.Text+"'",con);
			try {
				con.Open();
				adapt=coman.ExecuteReader();
			    if(adapt.HasRows)
			    {
			    	while (adapt.Read())
			    	{
			    		mtxtcedula.Text=adapt.GetString(0);
						txtnombre.Text=adapt.GetString(1);
						txtapellido1.Text=adapt.GetString(2);
						txtapellido2.Text=adapt.GetString(3);
						txtdireccion.Text=adapt.GetString(4);
						mtxtelefono.Text=adapt.GetString(5);
						mtxtcelular.Text=adapt.GetString(6);
						cmbfechaingreso.Text=adapt.GetString(10);
						cmbfechanacimiento.Text=adapt.GetString(7);
						if(adapt.GetString(8)=="M")
						{
							rdbmasculino.Checked=true;
						}
						else rdbfemenino.Checked=true;
						if(adapt.GetString(9)=="True")
						{
							cmbestatus.SelectedIndex=1;
				
						}
						else
						{
							cmbestatus.SelectedIndex=0;
						}
			    	}
			    }
			    else 
			    {
			    	foreach(Control x in groupBox1.Controls)
			{
				if (x.GetType().ToString()=="System.Windows.Forms.TextBox" || x.GetType().ToString()=="System.Windows.Forms.MaskedTextBox")
					x.Text="";
			}
			    }
			}
			catch(Exception ex)
			{MessageBox.Show(ex.Message);}
			finally 
			{}
		}
		
		void BtnsalirClick(object sender, EventArgs e)
		{
			this.Close();
			
		}
		
		void MtxtcedulaKeyPress(object sender, KeyPressEventArgs e)
		{
			double suel=0;
			tarjetas=string.Empty;
			if(e.KeyChar=='\r')
			{
				buscaDatos();
				buscatarjeta();
				for(int x=0;x<dataGridView1.Rows.Count;x++)
				{
					suel=suel+System.Convert.ToDouble(dataGridView1.Rows[x].Cells[4].Value);
					tarjetas=tarjetas+dataGridView1.Rows[x].Cells[0].Value + "  ";
				}
				lbsueldo.Text=suel.ToString();
			}
		}
		
		void MtxtcedulaValidating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			buscaDatos();
			buscatarjeta();
		}
		void buscatarjeta()
		{
			string sel="select tbltarjeta.tarjeta,tblcentroed.nombre,tblcentroed.tanda,tbltarjeta.cargo,tbltarjeta.ingresos"+
						" from tblcentroed,tbltarjeta,empleados,tbltarj_empl "+
					    " where empleados.cedula='"+mtxtcedula.Text+"' and tblcentroed.codigoCent=tbltarjeta.CodigoCent and empleados.cedula=tbltarj_empl.cedula_empl and tbltarjeta.tarjeta=tbltarj_empl.tarjeta"+
					   " union select tbltarjeta.tarjeta,tbldistrito.d_nombre,'COMPLETA' AS tanda,tbltarjeta.cargo,tbltarjeta.ingresos" +
					   " from tbldistrito,tbltarjeta,empleados,tbltarj_empl"+
					   " where empleados.cedula='"+mtxtcedula.Text+"' and tbldistrito.Codistrito=tbltarjeta.CodigoCent and empleados.cedula=tbltarj_empl.cedula_empl and tbltarjeta.tarjeta=tbltarj_empl.tarjeta";
			MySqlDataAdapter adaptador =new MySqlDataAdapter(sel,System.Configuration.ConfigurationSettings.AppSettings["cono"].ToString());
			DataTable table =new DataTable();
			adaptador.Fill(table);
			dataGridView1.AutoGenerateColumns=false;
			dataGridView1.DataSource=table;
		}
		
		void SalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void PrintButtonClick(object sender, EventArgs e)
		{
			//OtrosFormatos frmcert = new OtrosFormatos();
			string ruta=Application.StartupPath	+ @"\\certif.doc";
			OtrosFormatos frmcert = new OtrosFormatos(ruta); //+ @"\\test.doc");
			foreach(DataGridViewRow r in dataGridView1.SelectedRows)
       		{
				frmcert.cedula=mtxtcedula.Text;
       			frmcert.nombre=txtnombre.Text+' '+txtapellido1.Text+' '+txtapellido2.Text;
       			frmcert.centro=r.Cells[1].Value.ToString();
       			frmcert.tarjeta=tarjetas; //r.Cells[0].Value.ToString();
       			frmcert.cargo=r.Cells[3].Value.ToString();
       			frmcert.sueldo=lbsueldo.Text;       			
       		}
			//frmcert.ShowDialog();
			//if(frmcert.DialogResult==DialogResult.OK)
			//{
			//	linea=frmcert.linea;
				try 
           		{
					/*printFont = new Font("Times New Roman", 14,FontStyle.Italic); //establesiendo un formato para letras
              		PrintDocument pd = new PrintDocument();
              		pd.PrintPage += new PrintPageEventHandler(this.PrintCert);//asignando manejador de evento
              		pd.DefaultPageSettings.Landscape=false; //Poner la pagina en orizontal
              		printPreviewDialog1.Document=pd;
             	 	printPreviewDialog1.WindowState=FormWindowState.Maximized;//maximizando el preview
             	 	printPreviewDialog1.Document.PrinterSettings=printDialog1.PrinterSettings;
              		printPreviewDialog1.ShowDialog();*/
					
					frmcert.exportarcertificacion();
					Process.Start(ruta);
           		}  
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
           		{
              		
           		}
			//}
			
		
		}
		private void PrintCert(object sender, PrintPageEventArgs ev) 
        {
       		float linesPerPage = 0;
       		float yPos = 0;
	   		int count = 0;	   		
	   		int columna=0;
       		float leftMargin = ev.MarginBounds.Left;
       		float topMargin = ev.MarginBounds.Top;
       		string line = null;
       		string  nombre=null;
       		Font MinistFont= new Font("Times New Roman",18,FontStyle.Bold);
       		Font distritFont= new Font("Times New Roman",13,FontStyle.Bold);
			Font tablaFont= new Font("Times New Roman",11,FontStyle.Bold);
			SizeF tamano;
       	
			//  Calculate the number of lines per page.
       	  	linesPerPage = ev.MarginBounds.Height / 
          	printFont.GetHeight(ev.Graphics);  	
       	  	
       	  	//imprimir imagen
       		System.Drawing.Image i = System.Drawing.Image.FromFile(@"C:\SoporteDistrital\imajenes\escudo.bmp");
        	Point p = new Point(360, 86);
        	ev.Graphics.DrawImage(i, p);
        
        	count+=5;
        	//print headlines
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		tamano=ev.Graphics.MeasureString("República Dominicana",new Font("Arial",8,FontStyle.Bold));
       		                                 ev.Graphics.DrawString("República Dominicana",new Font("Arial",8,FontStyle.Bold),Brushes.Black,(ev.PageBounds.Width-tamano.Width)/2, yPos, new StringFormat());
       		count++;
       	  	yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       	  	tamano=ev.Graphics.MeasureString("Ministerio de Educación ",MinistFont);
       		ev.Graphics.DrawString("Ministerio de Educación ",MinistFont,Brushes.Black,(ev.PageBounds.Width-tamano.Width)/2, yPos, new StringFormat());
       		count+=1;
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		tamano=ev.Graphics.MeasureString("Distrito Educativo 07-07 de Villa Tapia",distritFont);
       		ev.Graphics.DrawString("Distrito Educativo 07-07 de Villa Tapia",distritFont,Brushes.Black,(ev.PageBounds.Width-tamano.Width)/2, yPos, new StringFormat());
       		count+=3;
            yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
            tamano=ev.Graphics.MeasureString("C E R T I F I C A C I O N",distritFont);
       		ev.Graphics.DrawString("C E R T I F I C A C I O N",distritFont,Brushes.Black,(ev.PageBounds.Width-tamano.Width)/2, yPos, new StringFormat());
       		count+=3;
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		/*foreach(DataGridViewRow r in dataGridView1.SelectedRows)
       		{
       			nombre=r.Cells[1].Value.ToString();
       		}*/
       		tamano = ev.Graphics.MeasureString(linea[14],distritFont);
       		ev.Graphics.DrawString(linea[14],distritFont,Brushes.Black,(ev.PageBounds.Width-tamano.Width)/2, yPos, new StringFormat());
       		count+=2;
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		ev.Graphics.DrawString(linea[15],distritFont,Brushes.Black,leftMargin, yPos, new StringFormat());
       		count+=1;
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		ev.Graphics.DrawString(linea[1],distritFont,Brushes.Black,leftMargin, yPos, new StringFormat());
       		count+=1;
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		/*foreach(DataGridViewRow r in dataGridView1.SelectedRows)
       		{
       			nombre=r.Cells[3].Value.ToString();
       		}*/
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		ev.Graphics.DrawString(linea[2],distritFont,Brushes.Black,leftMargin, yPos, new StringFormat());
       		count+=1;
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		ev.Graphics.DrawString(linea[3],distritFont,Brushes.Black,leftMargin, yPos, new StringFormat());
       		count+=1;
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		ev.Graphics.DrawString(linea[4],distritFont,Brushes.Black,leftMargin, yPos, new StringFormat());
       		count+=1;
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		ev.Graphics.DrawString(linea[5],distritFont,Brushes.Black,leftMargin, yPos, new StringFormat());
       		count+=1;
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		ev.Graphics.DrawString(linea[6],distritFont,Brushes.Black,leftMargin, yPos, new StringFormat());
       		count+=2;
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		ev.Graphics.DrawString(linea[7],distritFont,Brushes.Black,leftMargin, yPos, new StringFormat());
       		count+=1;
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		ev.Graphics.DrawString(linea[8],distritFont,Brushes.Black,leftMargin, yPos, new StringFormat());
       		count+=1;
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		ev.Graphics.DrawString(linea[9],distritFont,Brushes.Black,leftMargin, yPos, new StringFormat());
       		count+=1;
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		ev.Graphics.DrawString(linea[10],distritFont,Brushes.Black,leftMargin, yPos, new StringFormat());
       		count+=3;
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		tamano=ev.Graphics.MeasureString(linea[12],distritFont);
       		ev.Graphics.DrawString(linea[12],distritFont,Brushes.Black,(ev.PageBounds.Width-tamano.Width)/2, yPos, new StringFormat());
       		count+=1;
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		tamano=ev.Graphics.MeasureString(linea[13],distritFont);
       		ev.Graphics.DrawString(linea[13],distritFont,Brushes.Black,(ev.PageBounds.Width-tamano.Width)/2, yPos, new StringFormat());
       		count+=1;
       // Print each line of the file.
       
       
       // If more lines exist, print another page.
       /*if(fila<dataGridView1.Rows.Count-1)
          ev.HasMorePages = true;
       else {
       	count++;
       	yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
       	ev.Graphics.DrawString("TOTAL: "+this.label4.Text, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
       	    ev.HasMorePages = false;
       	    fila=0;
       }*/
    }
		
		void PrintPreviewDialog1Load(object sender, EventArgs e)
		{
			printDialog1.ShowDialog();
		}
	}
}
