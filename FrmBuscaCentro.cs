/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 11/23/2009
 * Time: 11:00 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using SoporteDistrital.Clases;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Text;
namespace SoporteDistrital
{
	/// <summary>
	/// Description of FrmBuscaCentro.
	/// </summary>
	public partial class FrmBuscaCentro : Form
	{
		public CentroEducativo centro=new CentroEducativo();
		public FrmBuscaCentro()
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
			StringBuilder sql=new StringBuilder();
			if ((txtCodCent.Text.Trim().Length<1) && (txtNom.Text.Trim()==string.Empty))
			{
			   sql.Append("select codigoCent,nombre,tanda from tblcentroed union select Codistrito as codigoCent,d_nombre,null from  tbldistrito ");
			}
			else 
			if (!(txtCodCent.Text.Trim().Length<=1))
			{
				sql.Append("select codigoCent,nombre,tanda from tblcentroed where codigoCent="+txtCodCent.Text+" union select Codistrito as codigoCent,d_nombre,null from  tbldistrito where Codistrito="+txtCodCent.Text);
				//sql.Append("where codigoCent='"+txtCodCent.Text+"'");
			}
			else if (!(txtNom.Text.Trim()==string.Empty))
			{
				sql.Append("select codigoCent,nombre,tanda from tblcentroed where nombre like '"+txtNom.Text+"%' union select Codistrito as codigoCent,d_nombre,null from  tbldistrito where d_nombre like '"+txtNom.Text+"%'");
				//sql.Append("where nombre like '"+txtNom.Text+"%'");
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
					centro.CodigoCentro=System.Convert.ToInt32(row.Cells[0].Value);
                	centro.Nombre=row.Cells[1].Value.ToString();
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
