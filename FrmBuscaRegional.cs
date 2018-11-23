/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 11/17/2009
 * Time: 11:37 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using SoporteDistrital.Clases;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Data;
using System.Text;

namespace SoporteDistrital
{
	/// <summary>
	/// Description of FrmBuscaRegional.
	/// </summary>
	public partial class FrmBuscaRegional : Form
	{
		public Regional reg=new Regional();			    
		public FrmBuscaRegional()
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
			string codigo=string.Empty;
			if (dataGridView1.RowCount>0)
			{
				foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            	{
                	reg.Codregional= row.Cells[0].Value.ToString();
                	reg.Nombre=row.Cells[1].Value.ToString();
            	}				
				this.DialogResult=DialogResult.OK;
			}
			else 
			{
				MessageBox.Show("No hay registros disponibles para seleccionar","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
			
			
		}
		
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
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
			sql.Append("select cod_regional,nombre from tblregional ");
			if (!(txtCodReg.Text.Trim()==string.Empty))
			{
				sql.Append("where cod_regional="+txtCodReg.Text);
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
