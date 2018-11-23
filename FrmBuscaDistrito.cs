/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 11/20/2009
 * Time: 10:01 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using SoporteDistrital.Clases;
namespace SoporteDistrital
{
	/// <summary>
	/// Description of FrmBuscaDistrito.
	/// </summary>
	public partial class FrmBuscaDistrito : Form
	{
		public Distrito distrito=new Distrito();
		public FrmBuscaDistrito()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TxtCodRegKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(Char.IsDigit(e.KeyChar)||Char.IsControl(e.KeyChar)))
			{
				e.Handled=true;
				SendKeys.Send("");
			}
		}
		
		void BuscarClick(object sender, EventArgs e)
		{
			StringBuilder sql=new StringBuilder();
			sql.Append("select Codistrito,d_nombre from tbldistrito ");
			if (!(txtCodDist.Text.Trim().Length<=1))
			{
				sql.Append("where Codistrito='"+txtCodDist.Text+"'");
			}
			else if (!(txtNom.Text.Trim()==string.Empty))
			{
				sql.Append("where d_nombre like '"+txtNom.Text+"%'");
			}
			string conn=System.Configuration.ConfigurationSettings.AppSettings["cono"].ToString();//new MySqlConnection("Database=de0707;Data Source=localhost;User Id=root; Password=12345");
			MySqlDataAdapter adat=new MySqlDataAdapter(sql.ToString(),conn);
			DataTable tb=new DataTable();
			adat.Fill(tb);
			dataGridView1.AutoGenerateColumns=false;
			dataGridView1.DataSource=tb;
		}
		
		void AceptarClick(object sender, EventArgs e)
		{
			if (dataGridView1.RowCount>0)
			{
				foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            	{
					distrito.Coddistrito= System.Convert.ToInt32(row.Cells[0].Value);
                	distrito.Nombre=row.Cells[1].Value.ToString();
            	}				
				this.DialogResult=DialogResult.OK;
			}
			else 
			{
				MessageBox.Show("No hay registros disponibles para seleccionar","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
		}
	}
}
