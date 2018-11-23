/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 11/20/2009
 * Time: 10:41 AM
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
	/// Description of FrmTarjeta.
	/// </summary>
	public partial class FrmTarjeta : Form
	{
		DataTable adapt =new DataTable();
		Mantenimiento mant=new Mantenimiento();
		int fila=0;
		int cantfilas=0;
		int control=0;
		public FrmTarjeta()
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
			this.txtTarNo.Enabled=true;
			this.txtCodCent.Enabled=true;
			this.cmbcargo.Enabled=true;
			this.txtIngresos.Enabled=true;
			foreach(Control x in groupBox1.Controls)
			{
				if (x.GetType().ToString()=="System.Windows.Forms.TextBox" || x.GetType().ToString()=="System.Windows.Forms.MaskedTextBox")
					x.Text="";
			}
			this.GActivaTex();
			this.GActivar();
		}
		
		void BtnguardarClick(object sender, EventArgs e)
		{
			if(txtTarNo.Text.Trim().Length<9)
			{
				MessageBox.Show("El número de la tarjeta está vacio.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtTarNo.Focus();
				return;
			}
			if((txtCodCent.Text.Trim().Length==0) || (txtCodCent.Text.Trim()==string.Empty))
			{
				MessageBox.Show("El código del centro está vacio.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtCodCent.Focus();
				return;
			}
			if (txtNomCent.Text=="NO ENCONTRADO")
			{
				MessageBox.Show("El código del centro no es válido.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtCodCent.Focus();
				return;
			}
			if(cmbcargo.Text.Trim()==string.Empty)
			{
				MessageBox.Show("El cargo está vacio.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				cmbcargo.Focus();
				return;
			}
			if(txtIngresos.Text.Trim().Length<=1)
			{
				MessageBox.Show("Ingresos está vacio.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtIngresos.Focus();
				return;
			}
			Mantenimiento mant =new Mantenimiento();
			Tarjetas tarjeta=new Tarjetas();
			
			tarjeta.Tarjeta=txtTarNo.Text;
			tarjeta.CodigoCentro=System.Convert.ToInt32(txtCodCent.Text);
			tarjeta.Cargo=cmbcargo.Text;
			tarjeta.Estado="A";
			tarjeta.Ingresos=System.Convert.ToDouble(txtIngresos.Text.Trim());
			if (mant.GuardaTarjeta(tarjeta,control))
			{
				adapt=mant.BuscaTarjeta();
				cantfilas=adapt.Rows.Count;
				MessageBox.Show("Informacion guardada correctamente");
			}
			else 
			{
				MessageBox.Show("Ocurrió un problema al guardar la informacion puede ser que ya exista el centro");
				return;
			}
			this.txtTarNo.Enabled=false;
			this.txtCodCent.Enabled=false;
			this.cmbcargo.Enabled=false;
			this.txtIngresos.Enabled=false;
			this.NActivaTex();
			this.NActivar();
		}
		
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar== '.'))
			{
				if (!(txtIngresos.Text.IndexOf(".")<0))
					
				{
					e.Handled=true;
					SendKeys.Send("");
				}
			}
			else
			if (!(Char.IsDigit(e.KeyChar)||Char.IsControl(e.KeyChar)))
			{
				e.Handled=true;
				SendKeys.Send("");
			}
		}
		
		void TxtCodCentKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(Char.IsDigit(e.KeyChar)||Char.IsControl(e.KeyChar)))
			{
				e.Handled=true;
				SendKeys.Send("");
			}
			else 
			if(e.KeyChar=='\r')
				{				
					txtNomCent.Text=mant.Buscaentabla("select nombre from (select codigoCent,nombre,tanda from tblcentroed union select Codistrito as codigoCent,d_nombre,null from  tbldistrito) as tblcentroed where codigoCent='"+txtCodCent.Text.Trim()+"'");
				    
				}
		}
		
		void TxtCodCentValidating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			txtNomCent.Text=mant.Buscaentabla("select nombre from (select codigoCent,nombre,tanda from tblcentroed union select Codistrito as codigoCent,d_nombre,null from  tbldistrito) as tblcentroed where codigoCent='"+txtCodCent.Text.Trim()+"'");
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			FrmBuscaCentro frmBusCent=new FrmBuscaCentro();
			frmBusCent.StartPosition=FormStartPosition.CenterScreen;
			if (frmBusCent.ShowDialog()==DialogResult.OK)
			{
				this.txtCodCent.Text=frmBusCent.centro.CodigoCentro.ToString();
				this.txtNomCent.Text=frmBusCent.centro.Nombre;
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
		
		void Button1Click(object sender, EventArgs e)
		{
			if(cantfilas>0)
			{
				this.CargaRegistro();
				txtNomCent.Text=mant.Buscaentabla("select nombre from (select codigoCent,nombre,tanda from tblcentroed union select Codistrito as codigoCent,d_nombre,null from  tbldistrito) as tblcentroed where codigoCent='"+txtCodCent.Text.Trim()+"'");
			}
			this.NActivaTex();
			this.NActivar();
		}
		
		void FrmTarjetaLoad(object sender, EventArgs e)
		{
			adapt=mant.BuscaTarjeta();
			
			cantfilas=adapt.Rows.Count;
			if (cantfilas>0)
			{	
				fila=cantfilas-1;
				this.CargaRegistro();
				txtNomCent.Text=mant.Buscaentabla("select nombre from (select codigoCent,nombre,tanda from tblcentroed union select Codistrito as codigoCent,d_nombre,null from  tbldistrito) as tblcentroed where codigoCent='"+txtCodCent.Text.Trim()+"'");
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
		void GActivaTex()
		{
			this.txtTarNo.Enabled=true;
			this.txtCodCent.Enabled=true;
			this.txtIngresos.Enabled=true;
			this.cmbcargo.Enabled=true;
		}
		void NActivaTex()
		{
			this.txtTarNo.Enabled=false;
			this.txtCodCent.Enabled=false;
			this.txtIngresos.Enabled=false;
			this.cmbcargo.Enabled=false;
		}
		void CargaRegistro()
		{
			txtTarNo.Text=adapt.Rows[fila][0].ToString();
			txtCodCent.Text=adapt.Rows[fila][1].ToString();			
			cmbcargo.Text=adapt.Rows[fila][2].ToString();
			txtIngresos.Text=adapt.Rows[fila][3].ToString();
			

		}
		
		void BtnprimeroClick(object sender, EventArgs e)
		{
			if (cantfilas>0)
			{
				this.fila=0;
				this.CargaRegistro();
				txtNomCent.Text=mant.Buscaentabla("select nombre from (select codigoCent,nombre,tanda from tblcentroed union select Codistrito as codigoCent,d_nombre,null from  tbldistrito) as tblcentroed where codigoCent='"+txtCodCent.Text.Trim()+"'");
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
					txtNomCent.Text=mant.Buscaentabla("select nombre from (select codigoCent,nombre,tanda from tblcentroed union select Codistrito as codigoCent,d_nombre,null from  tbldistrito) as tblcentroed where codigoCent='"+txtCodCent.Text.Trim()+"'");
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
					txtNomCent.Text=mant.Buscaentabla("select nombre from (select codigoCent,nombre,tanda from tblcentroed union select Codistrito as codigoCent,d_nombre,null from  tbldistrito) as tblcentroed where codigoCent='"+txtCodCent.Text.Trim()+"'");
				}
			}
		}
		
		void BtnultimoClick(object sender, EventArgs e)
		{
			if(cantfilas>0)
			{
				this.fila=cantfilas-1;
				this.CargaRegistro();
				txtNomCent.Text=mant.Buscaentabla("select nombre from (select codigoCent,nombre,tanda from tblcentroed union select Codistrito as codigoCent,d_nombre,null from  tbldistrito) as tblcentroed where codigoCent='"+txtCodCent.Text.Trim()+"'");
			}
		}
	}
}
