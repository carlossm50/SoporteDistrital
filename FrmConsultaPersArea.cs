/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 26/02/2010
 * Hora: 06:24 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Text;
using System.Data;
using System.Collections;
using System.Diagnostics;

namespace SoporteDistrital
{
	/// <summary>
	/// Description of FrmConsultaPersArea.
	/// </summary>
	public partial class FrmConsultaPersArea : Form
	{
		private Font printFont;
		int fila=0;
		public FrmConsultaPersArea()
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
			int b=0;int l=0;int p=0; int m=0;int d=0;
			string con=System.Configuration.ConfigurationSettings.AppSettings["cono"].ToString();
			StringBuilder comando=new StringBuilder();
			comando.Append("select empleados.cedula,concat(nombre,' ',apellido1,' ',apellido2) as Nombre,nivelacad,titulo,areaestudio from empleados join tbldocente where empleados.cedula=tbldocente.cedula AND estado=1");
			if (!(CBarea.Text.Trim()==string.Empty))
			{
				comando.Append(" and areaestudio ='"+CBarea.Text+"'");
			}
			if (!(cmbNivel.Text.Trim()==string.Empty))
			{
				comando.Append(" and titulo='"+cmbNivel.Text+"'");
			}
			MySqlDataAdapter adap =new MySqlDataAdapter(comando.ToString(),con);
			DataTable tbl=new DataTable();
			adap.Fill(tbl);
			dataGridView1.AutoGenerateColumns=false;
			dataGridView1.DataSource=tbl;
			label1.Text=tbl.Rows.Count.ToString();
			foreach(DataRow t in tbl.Rows )
			{
				if(t[3].ToString()=="BACHILLER")
				{
					b+=1;
				}
				else if(t[3].ToString()=="LICENCIADO")
				{
					l+=1;
				}					
				else if(t[3].ToString()=="POST-GRADO")
				{
					p+=1;
				}
				else if(t[3].ToString()=="MAESTRIA")
				{
					m+=1;
				}
				else if(t[3].ToString()=="DOCTORADO")
				{
					d+=1;
				}
			}
			label13.Text=b.ToString();
			label5.Text=l.ToString();
			label7.Text=p.ToString();
			label11.Text=m.ToString();
			label9.Text=d.ToString();
			
			
		}
		
		
		void PrintButtonClick(object sender, EventArgs e)
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
			if(dataGridView1.RowCount>0){
			try
			{
				printFont=new Font("Times New Roman",10);
				PrintDocument pd = new PrintDocument();
				pd.PrintPage += new PrintPageEventHandler(this.Print_preview);
				printPreviewDialog1.Document=pd;
				printPreviewDialog1.WindowState= FormWindowState.Maximized;
				printPreviewDialog1.ShowDialog();
				
			}
			finally
			{
				
			}
			}
			else { MessageBox.Show("No hay registros que imprimir");}*/
		}
		void Print_preview(object sender, PrintPageEventArgs ev)
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
        	Point p = new Point(308, 10);
        	ev.Graphics.DrawImage(i, p);
        	count++;
       		
        	//print headlines
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		ev.Graphics.DrawString("República Dominicana",new Font("Arial",8,FontStyle.Bold),Brushes.Black,295, yPos, new StringFormat());
       		count++;
       	  	yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		ev.Graphics.DrawString("Ministerio de Educación ",MinistFont,Brushes.Black,235, yPos, new StringFormat());
       		count+=2;
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		ev.Graphics.DrawString("Distrito Educativo 07-07 de Villa Tapia",distritFont,Brushes.Black,200, yPos, new StringFormat());
       		count+=2;
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		ev.Graphics.DrawString("Relación de Personal por Área",distritFont,Brushes.Black,leftMargin, yPos, new StringFormat());
       		count+=2;
       		yPos = topMargin + (count *  printFont.GetHeight(ev.Graphics));
       		ev.Graphics.DrawString("|Cedula             |Nombre                                                  |Nivel Academico         Título                |Áre|",tablaFont,Brushes.Black,leftMargin, yPos, new StringFormat());
       		count+=2;
			while(count < linesPerPage && fila<=dataGridView1.Rows.Count-1 /*&& ((line=streamToPrint.ReadLine()) != null) (line="Lo logre") != null)*/)
       		{ 
       		columna=0;
       		yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
      	 	while(columna<5){
       		switch(columna)
       		{
       		case 0:{line=dataGridView1.Rows[fila].Cells[0].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());break;}
       		case 1:{line=dataGridView1.Rows[fila].Cells[1].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, 200, yPos, new StringFormat());;break;}
       		case 2:{line=dataGridView1.Rows[fila].Cells[2].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, 450, yPos, new StringFormat());break;}
       		case 3:{line=dataGridView1.Rows[fila].Cells[3].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, 610, yPos, new StringFormat());break;}
       		case 4:{line=dataGridView1.Rows[fila].Cells[4].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, 715, yPos, new StringFormat());break;}
       		/*case 5:{line=dataGridView1.Rows[fila].Cells[5].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, 850, yPos, new StringFormat());break;}
       		case 6:{line=dataGridView1.Rows[fila].Cells[6].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, 940, yPos, new StringFormat());break;}
       		case 7:{line=dataGridView1.Rows[fila].Cells[7].Value.ToString();ev.Graphics.DrawString(line, printFont, Brushes.Black, 1067, yPos, new StringFormat());break;}*/
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
       	ev.Graphics.DrawString("TOTAL: "+this.label1.Text, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
       	    ev.HasMorePages = false;
       	    fila=0;
       }
		}
	}
}
