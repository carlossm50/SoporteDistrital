/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 11/19/2009
 * Time: 8:12 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
namespace SoporteDistrital
{
	/// <summary>
	/// Description of FrmCentroEd.
	/// </summary>
	public partial class FrmCentroEd : Form
	{
		Mantenimiento mant=new Mantenimiento();
		DataTable adapt =new DataTable();
		int fila=0;
		int cantfilas=0;
		int control=0;
		public FrmCentroEd()
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
			this.txtCodCent.Enabled=true;
			this.txtDistNo.Enabled=true;
			this.txtnombre.Enabled=true;
			this.txtdireccion.Enabled=true;
			this.mtxtelefono.Enabled=true;
			this.txtCodCent.Clear();
			this.txtDistNo.Clear();
			this.txtNomDist.Clear();
			this.txtnombre.Clear();
			this.txtdireccion.Clear();
			this.mtxtelefono.Clear();
			txtcantAulas.Clear();
			txtcantSecc.Clear();
			RBMat.Checked=true;
			this.txtCodCent.Focus();
			this.GActivaTex();
			this.GActivar();
		}
		
		void BtnguardarClick(object sender, EventArgs e)
		{
			if (txtCodCent.Text.Trim()==string.Empty)
			{
				MessageBox.Show("El código del centro está vacio.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtCodCent.Focus();
				return;
			}
			if (this.txtDistNo.Text.Trim().Length!=1)
			{
				MessageBox.Show("El número del distrito está vacio.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtDistNo.Focus();
				return;
			}
			
			if (txtnombre.Text.Trim()==string.Empty)
			{
				MessageBox.Show("El nombre del centro está vacio.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtnombre.Focus();
				return;
			}
			if (txtdireccion.Text.Trim()==string.Empty)
			{
				MessageBox.Show("La direccion del centro está vacia.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtdireccion.Focus();
				return;
			}
			if (this.mtxtelefono.Text.Trim().Length<14)
			{
				MessageBox.Show("El telefono del centro está vacio.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				mtxtelefono.Focus();
				return;
			}
			if (txtNomDist.Text=="NO ENCONTRADO")
			{
				MessageBox.Show("Este distrito no ha sido registrado.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtNomDist.Focus();
				return;
			}
			if(!(RBMat.Checked) && !(RBVesp.Checked)&&!(RBNot.Checked))
			{
				MessageBox.Show("No se ha especificado la tanda.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}
			CentroEducativo centroed=new CentroEducativo();
			Mantenimiento mant= new Mantenimiento();
			centroed.CodigoCentro=Convert.ToInt32(txtCodCent.Text);
			centroed.CodigoDistrito=txtDistNo.Text;
			centroed.Nombre=txtnombre.Text;
			centroed.Direccion=txtdireccion.Text;
			centroed.Telefono=mtxtelefono.Text;
			centroed.Estado="A";
			centroed.CantidadAulas=txtcantAulas.Text;
			centroed.CantidadSecciones=txtcantSecc.Text;
			if(RBMat.Checked)
			{
				centroed.Tanda="MATUTINA";
			}
			else 
				if(RBVesp.Checked)
				{
					centroed.Tanda="VESPERTINA";
				}
				else 
				{
					centroed.Tanda="NOCTURNA";
				}
			if (mant.Guardacentro(centroed,control))
			{
				adapt=mant.BuscaCentro();
				cantfilas=adapt.Rows.Count;
				MessageBox.Show("Informacion guardada correctamente");
			}
			else 
			{
				MessageBox.Show("Ocurrió un problema al guardar la informacion puede ser que ya exista el centro");
				return;
			}
				
			this.txtCodCent.Enabled=false;
			this.txtDistNo.Enabled=false;
			this.txtnombre.Enabled=false;
			this.txtdireccion.Enabled=false;
			this.mtxtelefono.Enabled=false;
			this.NActivaTex();
			this.NActivar();
		}
		
		void TxtCodCentKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
			{
				e.Handled=true;
				SendKeys.Send("");
			}
		}
		
		void TxtDistNoKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(Char.IsDigit(e.KeyChar)||Char.IsControl(e.KeyChar)))
			{
				e.Handled=true;
				SendKeys.Send("");
			}
			else 
			if(e.KeyChar=='\r')
				{				
					txtNomDist.Text=mant.Buscaentabla("select d_nombre from tbldistrito where Codistrito='"+txtDistNo.Text.Trim()+"'");
				    
				}
			    
		}
		
		void TxtDistNoValidating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
			txtNomDist.Text=mant.Buscaentabla("select d_nombre from tbldistrito where Codistrito='"+txtDistNo.Text.Trim()+"'");
	
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			FrmBuscaDistrito frmBuscDist=new FrmBuscaDistrito();
			frmBuscDist.StartPosition=FormStartPosition.CenterScreen;
			if (frmBuscDist.ShowDialog()==DialogResult.OK)
			{
				txtDistNo.Text=frmBuscDist.distrito.Coddistrito.ToString();
				txtNomDist.Text=frmBuscDist.distrito.Nombre;
			}
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
		
		void FrmCentroEdLoad(object sender, EventArgs e)
		{
			adapt=mant.BuscaCentro();
			cantfilas=adapt.Rows.Count;
			if (cantfilas>0)
			{	
				fila=cantfilas-1;
				this.CargaRegistro();
			}
			this.NActivaTex();
			this.NActivar();
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
		void GActivaTex()
		{
			this.txtCodCent.Enabled=true;
			this.txtnombre.Enabled=true;
			this.txtdireccion.Enabled=true;
			this.mtxtelefono.Enabled=true;
			this.txtDistNo.Enabled=true;
			txtcantAulas.Enabled=true;
			txtcantSecc.Enabled=true;
		}
		void NActivaTex()
		{
			this.txtCodCent.Enabled=false;
			this.txtnombre.Enabled=false;
			this.txtdireccion.Enabled=false;
			this.mtxtelefono.Enabled=false;
			this.txtDistNo.Enabled=false;
			txtcantAulas.Enabled=false;
			txtcantSecc.Enabled=false;
		}
		void CargaRegistro()
		{
			txtCodCent.Text=adapt.Rows[fila][0].ToString();
			txtDistNo.Text=adapt.Rows[fila][1].ToString();			
			txtnombre.Text=adapt.Rows[fila][2].ToString();
			txtdireccion.Text=adapt.Rows[fila][3].ToString();
			this.mtxtelefono.Text=adapt.Rows[fila][4].ToString();
			txtNomDist.Text=mant.Buscaentabla("select d_nombre from tbldistrito where Codistrito='"+txtDistNo.Text.Trim()+"'");
			if(adapt.Rows[fila][5].ToString()=="MATUTINA")
			{
				RBMat.Checked=true;
			}else if(adapt.Rows[fila][5].ToString()=="VESPERTINA")
			{
				RBVesp.Checked=true;
			}else if(adapt.Rows[fila][5].ToString()=="NOCTURNA")
			{
				RBNot.Checked=true;
			}
			txtcantAulas.Text=adapt.Rows[fila][8].ToString();
			txtcantSecc.Text=adapt.Rows[fila][9].ToString();
			
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
		
		void TxtcantAulasKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
			{
				e.Handled=true;
				SendKeys.Send("");
			}
		}
		
		void TxtcantSeccKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
			{
				e.Handled=true;
				SendKeys.Send("");
			}
		}
	}
}
