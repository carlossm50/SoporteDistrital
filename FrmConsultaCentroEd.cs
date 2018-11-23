/*
 * Creado por SharpDevelop.
 * Usuario: admin
 * Fecha: 13/06/2010
 * Hora: 03:08 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;
using System.Diagnostics;
namespace SoporteDistrital
{
	/// <summary>
	/// Description of FrmConsultaCentroEd.
	/// </summary>
	public partial class FrmConsultaCentroEd : Form
	{
		private Font printFont;
		int fila=0;
		public FrmConsultaCentroEd()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
			{
				e.Handled=true;
				SendKeys.Send("");
			}
		}
		
		void BuscarClick(object sender, EventArgs e)
		{
			StringBuilder sel=new StringBuilder();
			sel.Append("select * from tblcentroed where estado='A' ");
			if (txtcodigo.Text.Trim()!=string.Empty)
				{
			    	sel.Append("and codigoCent='"+txtcodigo.Text+"'");
			    }
			else if (txtNom.Text.Trim()!=string.Empty)
			   {
			  	  sel.Append("and nombre like '"+txtNom.Text+"%'");
			   }
			if(chbmat.Checked) sel.Append(" and tanda='MATUTINA'");
			if(chbvesp.Checked) sel.Append(" and tanda='VESPERTINA'");
			if(chbnot.Checked)	sel.Append(" and tanda='NOCTURNA'");
			string conn=System.Configuration.ConfigurationSettings.AppSettings["cono"].ToString();//new MySqlConnection("Database=de0707;Data Source=localhost;User Id=root; Password=12345");
			MySqlDataAdapter adat=new MySqlDataAdapter(sel.ToString(),conn);
			DataTable tb=new DataTable();
			adat.Fill(tb);
			dataGridView1.AutoGenerateColumns=false;
			dataGridView1.DataSource=tb;
			label4.Text=tb.Rows.Count.ToString();
		}
		
		void BtnimprimirClick(object sender, EventArgs e)
		{
			 try

		{

		ArrayList titulos = new ArrayList();

		DataTable datosTabla = new DataTable();

		//Especificar ruta del archivo con extensión de WORD.

		OtrosFormatos OF = new OtrosFormatos(Application.StartupPath

		+ @"\\test.doc");

		//obtenemos los titulos del grid y creamos las columnas de la tabla

		foreach (DataGridViewColumn item in dataGridView1.Columns)

		{

		titulos.Add(item.HeaderText);

		datosTabla.Columns.Add();

		}

		//se crean los renglones de la tabla

		foreach (DataGridViewRow item in dataGridView1.Rows)

		{

		DataRow rowx = datosTabla.NewRow();

		datosTabla.Rows.Add(rowx);

		}

		//se pasan los datos del dataGridView a la tabla

		foreach (DataGridViewColumn item in dataGridView1.Columns)

		{

		foreach (DataGridViewRow itemx in dataGridView1.Rows)

		{

		datosTabla.Rows[itemx.Index][item.Index] =

		dataGridView1[item.Index, itemx.Index].Value;

		}

		}

		OF.Export(titulos, datosTabla);

		Process.Start(OF.xpath);

		MessageBox.Show("Proceso Completo");

		}

		catch(Exception ex)

		{

		MessageBox.Show(ex.Message);

		}
			/*
			if (dataGridView1.RowCount>0)
			{			
           		try 
           		{
           			printFont = new Font("Times New Roman", 10); //establesiendo un formato para letras
              		PrintDocument pd = new PrintDocument();
              		pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);//asignando manejador de evento
              		pd.DefaultPageSettings.Landscape=true; //Poner la pagina en orizontal
              		printPreviewDialog1.Document=pd;
             	 	printPreviewDialog1.WindowState=FormWindowState.Maximized;//maximizando el preview
              		printPreviewDialog1.ShowDialog();
           		}  
           		finally 
           		{
              		
           		}
			}
			else {
				MessageBox.Show("No hay registros que imprimir.");
			}*/
		}
		void pd_PrintPage(object sender, PrintPageEventArgs ev)
		{
			float linesPerPage = 0;
       		float yPos = 0;
	   		int count = 0;
	   		int columna=0;
       		float leftMargin = ev.MarginBounds.Left;
       		float topMargin = ev.MarginBounds.Top;
       		string line = null;
       		Font MinistFont= new Font("Times New Roman",18,FontStyle.Bold);
       		Font distritFont= new Font("Times New Roman",14,FontStyle.Bold);
			Font tablaFont= new Font("Times New Roman",11,FontStyle.Bold);
       	//  Calculate the number of lines per page.
       	  	linesPerPage = ev.MarginBounds.Height / 
          	printFont.GetHeight(ev.Graphics);  
       //imprimir imagen
       System.Drawing.Image i = System.Drawing.Image.FromFile(@"C:\SoporteDistrital\imajenes\escudo.bmp");
        Point p = new Point(500, 10);
        ev.Graphics.DrawImage(i, p);
        count++;
       //print headlines
       yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       ev.Graphics.DrawString("República Dominicana",new Font("Arial",8,FontStyle.Bold),Brushes.Black,487, yPos, new StringFormat());
       count++;
       yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       ev.Graphics.DrawString("Ministerio de Educación ",MinistFont,Brushes.Black,435, yPos, new StringFormat());
       count+=2;
       yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       ev.Graphics.DrawString("Distrito Educativo 07-07 de Villa Tapia",distritFont,Brushes.Black,400, yPos, new StringFormat());
       count+=2;
       yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       ev.Graphics.DrawString("Relación de Centros Educativos",distritFont,Brushes.Black,leftMargin, yPos, new StringFormat());
       count+=2;
       yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       ev.Graphics.DrawString("|Código             |Nombre del centro                               |Tanda  	       Dirección 	                                              Téfono 		              Cant. Aulas       Cant. Secciones ",tablaFont,Brushes.Black,leftMargin, yPos, new StringFormat());
       count+=2;
       // Print each line of the file.
       while(count < linesPerPage && fila<=dataGridView1.Rows.Count-1 /*&& ((line=streamToPrint.ReadLine()) != null) (line="Lo logre") != null)*/)
       { 
       	columna=0;
       	yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
       	while(columna<7){
       		switch(columna)
       		{
       		case 0:{line=dataGridView1.Rows[fila].Cells[0].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());break;}
       		case 1:{line=dataGridView1.Rows[fila].Cells[1].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, 200, yPos, new StringFormat());;break;}
       		case 2:{line=dataGridView1.Rows[fila].Cells[2].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, 450, yPos, new StringFormat());break;}
       		case 3:{line=dataGridView1.Rows[fila].Cells[3].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, 538, yPos, new StringFormat());break;}
       		case 4:{line=dataGridView1.Rows[fila].Cells[4].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, 783, yPos, new StringFormat());break;}
       		case 5:{line=dataGridView1.Rows[fila].Cells[5].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, 900, yPos, new StringFormat());break;}
       		case 6:{line=dataGridView1.Rows[fila].Cells[6].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, 1010, yPos, new StringFormat());break;}
       		//case 7:{line=dataGridView1.Rows[fila].Cells[7].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, 1067, yPos, new StringFormat());break;}
       		}
       		columna++;
       	}
       	fila++;
       	count++;
       	line=null;
       }
       // If more lines exist, print another page.
       if(fila<dataGridView1.Rows.Count-1)
          ev.HasMorePages = true;
       else {
       	count++;
       	yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
       	ev.Graphics.DrawString("TOTAL: "+this.label4.Text, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
       	ev.HasMorePages = false;
       	fila=0;
       }
    }
	}
}
