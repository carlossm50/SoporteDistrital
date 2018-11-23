/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 11/16/2009
 * Time: 8:03 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using SoporteDistrital.Clases;
using System.Data;
namespace SoporteDistrital
{
	/// <summary>
	/// Description of FrmDistrito.
	/// </summary>
	public partial class FrmDistrito : Form
	{
        Mantenimiento mant=new Mantenimiento();
        DataTable adapt =new DataTable();
		int fila=0;
		int cantfilas=0;
		int control=0;
		public FrmDistrito()
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
			this.txtDistNo.Enabled=true;
			this.txtRegNo.Enabled=true;
			this.txtnombre.Enabled=true;
			this.txtdireccion.Enabled=true;
			this.mtxtelefono.Enabled=true;
			this.txtDistNo.Clear();
			this.txtRegNo.Clear();
			this.txtNomReg.Clear();
			this.txtnombre.Clear();
			this.txtdireccion.Clear();
			this.mtxtelefono.Clear();
			this.GActivaTex();
			this.GActivar();
		}
		
		void BtnguardarClick(object sender, EventArgs e)
		{
			if (this.txtDistNo.Text.Trim().Length<1)
			{
				MessageBox.Show("El número del distrito está vacio.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtDistNo.Focus();
				return;
			}
			if (txtRegNo.Text.Trim()==string.Empty)
			{
				MessageBox.Show("El número de la regional está vacio.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtRegNo.Focus();
				return;
			}
			if (txtnombre.Text.Trim()==string.Empty)
			{
				MessageBox.Show("El nombre del distrito está vacio.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtnombre.Focus();
				return;
			}
			if (txtdireccion.Text.Trim()==string.Empty)
			{
				MessageBox.Show("La direccion del distrito está vacia.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtdireccion.Focus();
				return;
			}
			if (this.mtxtelefono.Text.Trim().Length<14)
			{
				MessageBox.Show("El telefono del distrito está vacio.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				mtxtelefono.Focus();
				return;
			}
			if (txtNomReg.Text=="NO ENCONTRADO")
			{
				MessageBox.Show("Esta regional no ha sido registrada.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtRegNo.Focus();
				return;
			}
			Distrito dist=new Distrito();
			Mantenimiento mant= new Mantenimiento();
			dist.Coddistrito=System.Convert.ToInt32(txtDistNo.Text);
			dist.Codregional=txtRegNo.Text;
			dist.Nombre=txtnombre.Text;
			dist.Direccion=txtdireccion.Text;
			dist.Telefono=mtxtelefono.Text;
			dist.Estado="A";
			if (mant.GuardaDistrito(dist,control))
			{
				adapt=mant.BuscaDistrito();
				cantfilas=adapt.Rows.Count;
				MessageBox.Show("Informacion guardada correctamente");
			}
			else 
			{
				MessageBox.Show("Ocurrió un problema al guardar la informacion puede ser que ya exista el distrito");
				return;
			}
				
			this.txtDistNo.Enabled=false;
			this.txtRegNo.Enabled=false;
			this.txtnombre.Enabled=false;
			this.txtdireccion.Enabled=false;
			this.mtxtelefono.Enabled=false;
			this.NActivaTex();
			this.NActivar();
		}
		
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			
			if (!(Char.IsDigit(e.KeyChar)||Char.IsControl(e.KeyChar)))
			{
				e.Handled=true;
				SendKeys.Send("");
			}
			else 
				if(!(txtRegNo.Text.Trim()==string.Empty)){
					if(e.KeyChar=='\r')
					{				
						txtNomReg.Text=mant.Buscaentabla("select nombre from tblregional where cod_regional="+txtRegNo.Text.Trim());		    
					}
				}
		}
		
		
		void Button4Click(object sender, EventArgs e)
		{
			FrmBuscaRegional frmBusReg= new FrmBuscaRegional();
			frmBusReg.StartPosition=FormStartPosition.CenterScreen;
			
			if(frmBusReg.ShowDialog()==DialogResult.OK) 
			{
				this.txtRegNo.Text=frmBusReg.reg.Codregional;
				this.txtNomReg.Text=frmBusReg.reg.Nombre;
			}
			
		}
		
		void TxtRegNoValidating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(!(txtRegNo.Text.Trim()==string.Empty))
			{
				txtNomReg.Text=mant.Buscaentabla("select nombre from tblregional where cod_regional="+txtRegNo.Text.Trim());
			}
			else 
			{
				txtNomReg.Text="NO ENCONTRADO";
			}
		}
		
		void FrmDistritoLoad(object sender, EventArgs e)
		{
			adapt=mant.BuscaDistrito();
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
			button4.Enabled=false;
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
			button4.Enabled=true;
		}
		void GActivaTex()
		{
			this.txtDistNo.Enabled=true;
			this.txtnombre.Enabled=true;
			this.txtdireccion.Enabled=true;
			this.mtxtelefono.Enabled=true;
			this.txtRegNo.Enabled=true;
		}
		void NActivaTex()
		{
			this.txtDistNo.Enabled=false;
			this.txtnombre.Enabled=false;
			this.txtdireccion.Enabled=false;
			this.mtxtelefono.Enabled=false;
			this.txtRegNo.Enabled=false;
		}
		void CargaRegistro()
		{
			txtDistNo.Text=adapt.Rows[fila][0].ToString();
			txtRegNo.Text=adapt.Rows[fila][1].ToString();			
			txtnombre.Text=adapt.Rows[fila][2].ToString();
			txtdireccion.Text=adapt.Rows[fila][3].ToString();
			this.mtxtelefono.Text=adapt.Rows[fila][4].ToString();
			txtNomReg.Text=mant.Buscaentabla("select nombre from tblregional where cod_regional="+txtRegNo.Text.Trim());			
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
	}
}
