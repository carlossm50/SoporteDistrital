/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 11/13/2009
 * Time: 3:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using SoporteDistrital.Clases;
using System.Data;
using System.Collections;
namespace SoporteDistrital
{
	/// <summary>
	/// Description of FrmRegional.
	/// </summary>
	public partial class FrmRegional : Form
	{
		DataTable adapt =new DataTable();
		Mantenimiento mant=new Mantenimiento();
		int fila=0;
		int cantfilas=0;
		int control=0;
		public FrmRegional()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnnuevoClick(object sender, EventArgs e)
		{
			control=1;
			this.txtRegNo.Enabled=true;
			this.txtnombre.Enabled=true;
			this.txtdireccion.Enabled=true;
			this.mtxtelefono.Enabled=true;
			this.txtRegNo.Clear();
			this.txtnombre.Clear();
			this.txtdireccion.Clear();
			this.mtxtelefono.Clear();
			this.GActivaTex();
			this.GActivar();
		}
		
		void BtnguardarClick(object sender, EventArgs e)
		{
			if (txtRegNo.Text.Trim()==string.Empty)
			{
				MessageBox.Show("El número de la regional está vacio.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtRegNo.Focus();
				return;
			}
			if (txtnombre.Text.Trim()==string.Empty)
			{
				MessageBox.Show("El nombre de la regional está vacio.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtnombre.Focus();
				return;
			}
			if (txtdireccion.Text.Trim()==string.Empty)
			{
				MessageBox.Show("La dirección de la regional está vacia.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtdireccion.Focus();
				return;
			}
			if (this.mtxtelefono.Text.Trim().Length<14)
			{
				
				MessageBox.Show(" El telefono esta vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				mtxtelefono.Focus();
				return;
			}
			Regional reg = new Regional();
			Mantenimiento mat = new Mantenimiento();
			reg.Codregional=txtRegNo.Text;
			reg.Nombre = txtnombre.Text;
			reg.Direccion = txtdireccion.Text;
			reg.Telefono = mtxtelefono.Text;
			reg.Estado = "A";
			if (mat.GuardaRegional(reg,control))
			{
				adapt=mant.BuscaRegional();
				cantfilas=adapt.Rows.Count;
				MessageBox.Show("Informacion guardada correctamente");
			}
			else 
			{
				MessageBox.Show("Ocurrió un problema al guardar la informacion puede ser que ya exista la regional");
			}
			this.txtRegNo.Enabled=false;
			this.txtnombre.Enabled=false;
			this.txtdireccion.Enabled=false;
			this.mtxtelefono.Enabled=false;	
			this.NActivaTex();
			this.NActivar();
		}
		
		void TxtRegNoKeyPress(object sender, KeyPressEventArgs e)
		{
			
			
			if (!(e.KeyChar>='0'&&e.KeyChar<='9' || Char.IsControl(e.KeyChar)))
			{
				
				e.Handled=true;
				SendKeys.Send("");
			}
		}
		
		void FrmRegionalLoad(object sender, EventArgs e)
		{
			adapt=mant.BuscaRegional();
			cantfilas=adapt.Rows.Count;
			if (cantfilas>0)
			{	
				fila=cantfilas-1;
				this.CargaRegistro();
			}
			this.NActivaTex();
			this.NActivar();
		}
		void NActivar()
		{
			this.btnnuevo.Enabled=true;
			this.btnguardar.Enabled=false;
			this.btneditar.Enabled=true;
			this.btncancelar.Enabled=false;
			this.btnverinforme.Enabled=true;
			this.btnsalir.Enabled=true;
			btnprimero.Enabled=true;
			btnatras.Enabled=true;
			btnsiguiente.Enabled=true;
			btnultimo.Enabled=true;
		}
		void GActivar()
		{
			this.btnnuevo.Enabled=false;
			this.btnguardar.Enabled=true;
			this.btneditar.Enabled=false;
			this.btncancelar.Enabled=true;
			this.btnverinforme.Enabled=false;
			this.btnsalir.Enabled=false;
			btnprimero.Enabled=false;
			btnatras.Enabled=false;
			btnsiguiente.Enabled=false;
			btnultimo.Enabled=false;
		}
		void GActivaTex()
		{
			this.txtRegNo.Enabled=true;
			this.txtnombre.Enabled=true;
			this.txtdireccion.Enabled=true;
			this.mtxtelefono.Enabled=true;
			
		}
		void NActivaTex()
		{
			this.txtRegNo.Enabled=false;
			this.txtnombre.Enabled=false;
			this.txtdireccion.Enabled=false;
			this.mtxtelefono.Enabled=false;
		}
		void CargaRegistro()
		{
			txtRegNo.Text=adapt.Rows[fila][0].ToString();
			txtnombre.Text=adapt.Rows[fila][1].ToString();			
			txtdireccion.Text=adapt.Rows[fila][2].ToString();
			mtxtelefono.Text=adapt.Rows[fila][3].ToString();
		}
		
		void BtneditarClick(object sender, EventArgs e)
		{
			control=0;
			this.GActivaTex();
			this.GActivar();
		}
		
		void BtncancelarClick(object sender, EventArgs e)
		{
			if(cantfilas>0)
			{
				this.CargaRegistro();
			}
			this.NActivaTex();
			this.NActivar();
			
		}
		
		void BtnprimeroClick(object sender, EventArgs e)
		{
			if (cantfilas>0)
			{
				this.fila=0;
				this.CargaRegistro();
			}
		}
		
		void BtnatrasClick(object sender, EventArgs e)
		{
			if (cantfilas>0)
			{	
				if (this.fila!=0)
				{
					this.fila-=1;
					this.CargaRegistro();
				}
			}
		}
		
		void BtnsiguienteClick(object sender, EventArgs e)
		{
			if (cantfilas>0)
			{
				if (this.fila!=cantfilas-1)
				{
					this.fila+=1;
					this.CargaRegistro();
				}
			}
		}
		
		void BtnultimoClick(object sender, EventArgs e)
		{
			if(cantfilas>0)
			{
				this.fila=cantfilas-1;
				this.CargaRegistro();
			}
		}
		
		void TxtRegNoValidating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
			

		}
	}
}
