/*
 * Creado por SharpDevelop.
 * Usuario: dell
 * Fecha: 13/07/2011
 * Hora: 03:43 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using SoporteDistrital.Clases;

namespace SoporteDistrital
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnimportarClick(object sender, EventArgs e)
		{
			OleDbConnection conn=new OleDbConnection();
			//conn.ConnectionString=@"provider=Microsoft.ACE.OleDB.12.0;Data Source=C:\Users\dell\Desktop\FORMULARIO INAFOCAM.xls"+@";Extended Properties=""
			conn.ConnectionString=@"Provider=Microsoft.Jet.OLEDB.4.0;" +  @"Data Source=C:\Users\dell\Desktop\FORMULARIO INAFOCAM.xls"+
               @";Extended Properties=""Excel 8.0;HDR=Yes"""; 
			OleDbCommand com=new OleDbCommand(@"select CED,NOMAP,APELL1,APELL2,FORMACAD FROM [Hoja1$]",conn);
			DataSet datgrid=new DataSet();
			OleDbDataAdapter adat =new OleDbDataAdapter(com);
			adat.Fill(datgrid);
			dataGridView1.DataSource=datgrid.Tables[0];
		}
		
		void BtnexportarClick(object sender, EventArgs e)
		{
			if(dataGridView1.RowCount>=1)
			{
			foreach(DataGridViewRow r in dataGridView1.SelectedRows)
       		{
			       			
			Docente  empleado=new Docente();
			Mantenimiento mant=new Mantenimiento();
			empleado.Cedula=r.Cells[0].Value.ToString();
			empleado.Nombre=r.Cells[1].Value.ToString();
			empleado.Apellido1=r.Cells[2].Value.ToString();
			empleado.Apellido2=r.Cells[3].Value.ToString();
			empleado.Direccion="VILLA TAPIA";
			empleado.Telefono="(809)574-3305";
			empleado.Celular=String.Empty;
			empleado.Fecha_Inggreso="2005/05/25";//DateTime.Today.ToString();//Now.ToString();
			empleado.Fecha_Nacimiento="2005/05/25";//DateTime.Today.ToString();
			empleado.Estatus=1;
			empleado.NivelAcademico="UNIVERSITARIO";
			empleado.AreaEstudio="EDUCACION";
			empleado.Titulo="LICENCIADO";
			empleado.Tipo=1;
			empleado.Control=1;
			empleado.Sexo="M";
			
			if (mant.GuardaDocente(empleado))
			{
				DataTable adapt =new DataTable();
		        Mantenimiento mantenimiemt=new Mantenimiento();
				adapt=mantenimiemt.BuscaDocente();
				//cantfilas=adapt.Rows.Count;
				MessageBox.Show("Informacion guardada correctamente");
			}
			else 
			{
				MessageBox.Show("Ocurrió un problema al guardar la informacion puede ser que ya exista el empleado");
				return;
			}
			}
			}
			
		}
		
		void DataGridView1CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
		
			if(dataGridView1.RowCount>=1)
			{
			foreach(DataGridViewRow r in dataGridView1.SelectedRows)
       		{
			       			
			Docente  empleado=new Docente();
			Mantenimiento mant=new Mantenimiento();
			empleado.Cedula=r.Cells[0].Value.ToString();
			empleado.Nombre=r.Cells[1].Value.ToString();
			empleado.Apellido1=r.Cells[2].Value.ToString();
			empleado.Apellido2=r.Cells[3].Value.ToString();
			empleado.Direccion="VILLA TAPIA";
			empleado.Telefono="(809)574-3305";
			empleado.Celular=String.Empty;
			empleado.Fecha_Inggreso="2005/05/25";//DateTime.Today.ToString();//Now.ToString();
			empleado.Fecha_Nacimiento="2005/05/25";//DateTime.Today.ToString();
			empleado.Estatus=1;
			empleado.NivelAcademico="UNIVERSITARIO";
			empleado.AreaEstudio="EDUCACION";
			empleado.Titulo="LICENCIADO";
			empleado.Tipo=1;
			empleado.Control=1;
			empleado.Sexo="M";
			
			if (mant.GuardaDocente(empleado))
			{
				DataTable adapt =new DataTable();
		        Mantenimiento mantenimiemt=new Mantenimiento();
				adapt=mantenimiemt.BuscaDocente();
				//cantfilas=adapt.Rows.Count;
				MessageBox.Show("Informacion guardada correctamente");
			}
			else 
			{
				MessageBox.Show("Ocurrió un problema al guardar la informacion puede ser que ya exista el empleado");
				return;
			}
			}
			}	
		}
	}
}
