/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 13/12/2009
 * Hora: 09:30 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using SoporteDistrital.Clases;
namespace SoporteDistrital
{
	/// <summary>
	/// Description of FrmBuscaEmpleado.
	/// </summary>
	public partial class FrmBuscaEmpleado : Form
	{
		public string cedula=string.Empty;
		public byte tipo=0;
		public FrmBuscaEmpleado()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void AceptarClick(object sender, EventArgs e)
		{
			if (dataGridView1.RowCount>0)
			{
				foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            	{
                	cedula=row.Cells[0].Value.ToString();
            	}				
				this.DialogResult=DialogResult.OK;
			}
			else 
			{
				MessageBox.Show("No hay registros disponibles para seleccionar","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
		}
		
		void BuscarClick(object sender, EventArgs e)
		{
			StringBuilder sql=new StringBuilder();
			if(tipo==2)
			{
				sql.Append("select cedula,concat(nombre,' ',apellido1,' ',apellido2)as nombre,fecha_nacimiento from v_apoyotarjeta ");
			}
			else if(tipo==1)
			{
				sql.Append("select cedula,concat(nombre,' ',apellido1,' ',apellido2)as nombre,fecha_nacimiento from v_docentestarje ");
			}
			if (mtxtcedula.Text.Trim().Length==13 || mtxtcedula.Text.Trim().Length!=9)
			{
				sql.Append("where cedula='"+mtxtcedula.Text+"'");
			}
			else if (!(txtNom.Text.Trim()==string.Empty))
			{
				sql.Append("where nombre like '"+txtNom.Text+"%'");
			}
			
			string conn=System.Configuration.ConfigurationSettings.AppSettings["cono"].ToString();//new MySqlConnection("Database=de0707;Data Source=localhost;User Id=root; Password=12345");
			MySqlDataAdapter adat=new MySqlDataAdapter(sql.ToString(),conn);
			DataTable tb=new DataTable();
			adat.Fill(tb);
			dataGridView1.AutoGenerateColumns=false;
			dataGridView1.DataSource=tb;
		}
	}
}
