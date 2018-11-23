/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 26/12/2009
 * Hora: 11:33 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace SoporteDistrital
{
	/// <summary>
	/// Description of FrmBuscaTarjeta.
	/// </summary>
	public partial class FrmBuscaTarjeta : Form
	{
		public byte tipo=0;
		public string tarjeta=string.Empty;
		public FrmBuscaTarjeta()
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
			
			if (txtTarNo.Text.Trim().Length!=9 && (txtNom.Text.Trim()==string.Empty))
			{
				if(tipo==2)
			{
				sql.Append("select * from v_tarjetapoyo0 union select * from v_tarjetapoyo1 union select * from v_tarjetapoyodistrito union select * from v_tarjetapoyodistrito1 ");
				/*Uselect.Append(" union select `tbltarjeta`.`tarjeta` AS `tarjeta`,`tbltarjeta`.`CodigoCent` AS `CodigoCent`,`tbldistrito`.`d_nombre` AS `nombre`,`tbltarjeta`.`cargo` AS `cargo`,`tbltarjeta`.`ingresos` AS `ingresos`,`tbltarjeta`.`fecha_reg` AS `fecha_reg`,`tbltarjeta`.`estado` AS `estado`,`tblcargos`.`tipo` AS `tipo`,null AS tanda  ");
			    Uselect.Append("from ((`tbltarjeta` join `tblcargos`) join `tbldistrito`) where ((`tbltarjeta`.`cargo` = `tblcargos`.`nombreCarg`) and (`tblcargos`.`tipo` = 2) and (`tbltarjeta`.`CodigoCent` = `tbldistrito`.`Codistrito`) AND tbltarjeta.estado='A')");*/
			}
			else if(tipo==1)
			{
				sql.Append("select * from v_tarjetadocente0 union select * from v_tarjetadocente1 union select * from v_tarjetadocentedistrito union select * from v_tarjetadocentedistrito1 ");
				/*Uselect.Append(" union select `tbltarjeta`.`tarjeta` AS `tarjeta`,`tbltarjeta`.`CodigoCent` AS `CodigoCent`,`tbldistrito`.`d_nombre` AS `nombre`,`tbltarjeta`.`cargo` AS `cargo`,`tbltarjeta`.`ingresos` AS `ingresos`,`tbltarjeta`.`fecha_reg` AS `fecha_reg`,`tbltarjeta`.`estado` AS `estado`,`tblcargos`.`tipo` AS `tipo`,null AS `tanda` ");
			    Uselect.Append("from ((`tbltarjeta` join `tblcargos`) join `tbldistrito`) where ((`tbltarjeta`.`cargo` = `tblcargos`.`nombreCarg`) and (`tblcargos`.`tipo` <> 2) and (`tbltarjeta`.`CodigoCent` = `tbldistrito`.`Codistrito`) AND tbltarjeta.estado='A')");*/
			}
			}
			else if (txtTarNo.Text.Trim().Length==9)
			{
				if (tipo==2){
					sql.Append("select * from v_tarjetapoyo0 where tarjeta='"+txtTarNo.Text+"'  union select * from v_tarjetapoyo1 where tarjeta='"+txtTarNo.Text+"' union select * from v_tarjetapoyodistrito where tarjeta='"+txtTarNo.Text+"' union select * from v_tarjetapoyodistrito1 where tarjeta='"+txtTarNo.Text+"'");
				}
				else 
					if (tipo==1)
					{
					   sql.Append("select * from v_tarjetadocente0 where tarjeta='"+txtTarNo.Text+"'  union select * from v_tarjetadocente1 where tarjeta='"+txtTarNo.Text+"' union select * from v_tarjetadocentedistrito where tarjeta='"+txtTarNo.Text+"' union select * from v_tarjetadocentedistrito where tarjeta='"+txtTarNo.Text+"'");
					}
					
			}
			else if (!(txtNom.Text.Trim()==string.Empty))
			{
				if (tipo==2){
				sql.Append("select * from v_tarjetapoyo0 where nombre like '"+txtNom.Text+"%' union select * from v_tarjetapoyo1 where nombre like '"+txtNom.Text+"%' union select * from v_tarjetapoyodistrito where nombre like '"+txtNom.Text+"%' union select * from v_tarjetapoyodistrito1 where nombre like '"+txtNom.Text+"%'");	
				}
				else 
					if (tipo==1)
					{
					  sql.Append("select * from v_tarjetadocente0 where nombre like '"+txtNom.Text+"%' union select * from v_tarjetadocente1 where nombre like '"+txtNom.Text+"%' union select * from v_tarjetadocentedistrito where nombre like '"+txtNom.Text+"%' union select * from v_tarjetadocentedistrito where nombre like '"+txtNom.Text);
					}
			}
			MySqlConnection conn=new MySqlConnection("Database=de0707;Data Source=localhost;User Id=root; Password=foltran");
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
                	tarjeta=row.Cells[0].Value.ToString();
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
