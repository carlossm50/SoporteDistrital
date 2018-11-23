/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 14/02/2010
 * Hora: 03:18 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Data;
using MySql.Data;
using System.Collections;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace SoporteDistrital
{
	/// <summary>
	/// Description of FrmConsultaPersonal.
	/// </summary>
	public partial class FrmConsultaPersonal : Form
	{
     	private Font printFont;
     	int fila=0;
     	string[] linea=new string[18];
		public FrmConsultaPersonal()
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
		
		void BuscarClick(object sender, EventArgs e)
		{
			StringBuilder sel=new StringBuilder();
			sel.Append("select empleados.cedula,concat(nombre,' ',apellido1,' ',apellido2) as nombre,fecha_ingreso,(YEAR(CURRENT_DATE) - YEAR(fecha_ingreso))  - (RIGHT(CURRENT_DATE,5) < RIGHT(fecha_ingreso,5)) AS anoserv,tbltarjeta.tarjeta,cargo,ingresos,d_nombre,tanda ");
			sel.Append("from tbltarj_empl,tbltarjeta,empleados,(select nombre as d_nombre,tanda,codigoCent as Codistrito ");
			sel.Append("from tblcentroed union select d_nombre,'COMPLETA' as tanda,Codistrito from  tbldistrito)as tbldistrito ");
			sel.Append("where ((tbltarjeta.CodigoCent=tbldistrito.Codistrito and tbltarj_empl.tarjeta=tbltarjeta.tarjeta) and empleados.cedula=tbltarj_empl.cedula_empl) AND tbltarj_empl.estado='A' and tbltarjeta.estado='A'");
			if (mtxtcedula.Text.Trim().Length==13 || mtxtcedula.Text.Trim().Length!=9)
			{
				sel.Append("and empleados.cedula='"+mtxtcedula.Text+"'");
			}
			else if (!(txtNom.Text.Trim()==string.Empty))
			{
				sel.Append("and nombre like '"+txtNom.Text+"%'");
			}
			sel.Append(" order by d_nombre,tanda,cargo");
			string conn= System.Configuration.ConfigurationSettings.AppSettings["cono"].ToString();//n("Database=de0707;Data Source=localhost;User Id=root; Password=12345");
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
		private void pd_PrintPage(object sender, PrintPageEventArgs ev) 
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
       ev.Graphics.DrawString("Relación de Personal",distritFont,Brushes.Black,leftMargin, yPos, new StringFormat());
       count+=2;
       yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       ev.Graphics.DrawString("|Cedula             |Nombre                                               |Años servicio  Centro Educativo                                 |Tarjeta  |Tanda          |Cargo                      |Sueldo|",tablaFont,Brushes.Black,leftMargin, yPos, new StringFormat());
       count+=2;
       
       // Print each line of the file.
       while(count < linesPerPage && fila<=dataGridView1.Rows.Count-1 /*&& ((line=streamToPrint.ReadLine()) != null) (line="Lo logre") != null)*/)
       { 
       	columna=0;
       	yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
       	while(columna<8){
       		switch(columna)
       		{
       		case 0:{line=dataGridView1.Rows[fila].Cells[0].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());break;}
       		case 1:{line=dataGridView1.Rows[fila].Cells[1].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, 200, yPos, new StringFormat());;break;}
       		case 2:{line=dataGridView1.Rows[fila].Cells[2].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, 450, yPos, new StringFormat());break;}
       		case 3:{line=dataGridView1.Rows[fila].Cells[3].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, 538, yPos, new StringFormat());break;}
       		case 4:{line=dataGridView1.Rows[fila].Cells[4].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, 783, yPos, new StringFormat());break;}
       		case 5:{line=dataGridView1.Rows[fila].Cells[5].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, 850, yPos, new StringFormat());break;}
       		case 6:{line=dataGridView1.Rows[fila].Cells[6].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, 940, yPos, new StringFormat());break;}
       		case 7:{line=dataGridView1.Rows[fila].Cells[7].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, 1067, yPos, new StringFormat());break;}
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
		
		void CTMcertificacionOpening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (dataGridView1.RowCount<=0)
			{
				imprimirCertificaciónToolStripMenuItem.Enabled=false;
			}
			else {imprimirCertificaciónToolStripMenuItem.Enabled=true;}
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
       	
			//  Calculate the number of lines per page.
       	  	linesPerPage = ev.MarginBounds.Height / 
          	printFont.GetHeight(ev.Graphics);  	
       	  	
       	  	//imprimir imagen
       		System.Drawing.Image i = System.Drawing.Image.FromFile("C:\\Documents and Settings\\admin\\Mis documentos\\Mis imágenes\\escudo.bmp");
        	Point p = new Point(308, 86);
        	ev.Graphics.DrawImage(i, p);
        	count+=5;
        	//print headlines
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		ev.Graphics.DrawString("República Dominicana",new Font("Arial",8,FontStyle.Bold),Brushes.Black,300, yPos, new StringFormat());
       		count++;
       	  	yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		ev.Graphics.DrawString("Ministerio de Educación ",MinistFont,Brushes.Black,240, yPos, new StringFormat());
       		count+=1;
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		ev.Graphics.DrawString("Distrito Educativo 07-07 de Villa Tapia",distritFont,Brushes.Black,205, yPos, new StringFormat());
       		count+=3;
            yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		ev.Graphics.DrawString("C E R T I F I C A C I O N",distritFont,Brushes.Black,255, yPos, new StringFormat());
       		count+=3;
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		/*foreach(DataGridViewRow r in dataGridView1.SelectedRows)
       		{
       			nombre=r.Cells[1].Value.ToString();
       		}*/
       		SizeF tamano = ev.Graphics.MeasureString(linea[14],distritFont);
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
       		ev.Graphics.DrawString(linea[12],distritFont,Brushes.Black,leftMargin, yPos, new StringFormat());
       		count+=1;
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		ev.Graphics.DrawString(linea[13],distritFont,Brushes.Black,leftMargin, yPos, new StringFormat());
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
		
		void ImprimirCertificaciónToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmCertificacion frmcert = new FrmCertificacion();
			foreach(DataGridViewRow r in dataGridView1.SelectedRows)
       		{
       			frmcert.cedula=r.Cells[0].Value.ToString();
       			frmcert.nombre=r.Cells[1].Value.ToString();
       			frmcert.centroEd=r.Cells[3].Value.ToString();
       			frmcert.tarjata=r.Cells[4].Value.ToString();
       			frmcert.cargo=r.Cells[6].Value.ToString();
       			frmcert.sueldo=r.Cells[7].Value.ToString();
       		}
			frmcert.ShowDialog();
			if(frmcert.DialogResult==DialogResult.OK)
			{
				linea=frmcert.linea;
				try 
           		{
           			printFont = new Font("Times New Roman", 14,FontStyle.Italic); //establesiendo un formato para letras
              		PrintDocument pd = new PrintDocument();
              		pd.PrintPage += new PrintPageEventHandler(this.PrintCert);//asignando manejador de evento
              		pd.DefaultPageSettings.Landscape=false; //Poner la pagina en orizontal
              		printPreviewDialog1.Document=pd;
             	 	printPreviewDialog1.WindowState=FormWindowState.Maximized;//maximizando el preview
              		printPreviewDialog1.ShowDialog();
           		}  
           		finally 
           		{
              		
           		}
			}
			
		}
	}
}
