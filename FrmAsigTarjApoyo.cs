/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 11/12/2009
 * Hora: 08:33 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using SoporteDistrital.Clases;
using System.Data;
namespace SoporteDistrital
{
	/// <summary>
	/// Description of FrmAsigTarjApoyo.
	/// </summary>
	public partial class FrmAsigTarjApoyo : Form
	{
		public byte tipo=0;
		Docente empleado=new Docente();
		Tarjetas tarjeta=new Tarjetas();
		//DataTable adapt =new DataTable();
		Mantenimiento mant=new Mantenimiento();
		//int fila=0;
		//int cantfilas=0;
		public FrmAsigTarjApoyo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MtxtcedulaKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar=='\r')
				{
					empleado.Cedula=mtxtcedula.Text.Trim();
					if (tipo==2){
						empleado=mant.BuscaEmpleado(empleado);
					}
					else if (tipo==1)
					{
						empleado=mant.BuscaDocente(empleado);
					}
					asignavalores(empleado);
					txtTarNo.Enabled=true;
					button4.Enabled=true;
				}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void MtxtcedulaValidating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
			empleado.Cedula=mtxtcedula.Text.Trim();
			if(tipo==2)
			{
				empleado=mant.BuscaEmpleado(empleado);
			}
			else if (tipo==1)
			{
				empleado=mant.BuscaDocente(empleado);
			}			
			asignavalores(empleado);
			txtTarNo.Enabled=true;
			button4.Enabled=true;
		}
		void asignavalores(Empleado empleado)
		{
				mtxtcelular.Text=empleado.Cedula;
				txtnombre.Text=empleado.Nombre;
				txtapellido1.Text=empleado.Apellido1;
				txtapellido2.Text=empleado.Apellido2;
				txtdireccion.Text=empleado.Direccion;
				mtxtelefono.Text=empleado.Telefono;
				mtxtcelular.Text=empleado.Celular;
				mtxtelefono.Text=empleado.Telefono;
				if(empleado.Sexo=="M")
				{
					rdbmasculino.Checked=true;
				}
				else if(empleado.Sexo=="F")
				{
					rdbfemenino.Checked=true;
				}
				cmbfechanacimiento.Text=empleado.Fecha_Nacimiento;//asignando la fecha por la propiedad text
				cmbfechaingreso.Text=empleado.Fecha_Inggreso;
		}
		void asignavalorTar(Tarjetas tarjeta)
		{
			txtTarNo.Text=tarjeta.Tarjeta;
			txtCodCent.Text=tarjeta.CodigoCentro.ToString();
			txtNomCent.Text=tarjeta.Nombre;
			cmbcargo.Text=tarjeta.Cargo;
			txtIngresos.Text=tarjeta.Ingresos.ToString();
			txtTanda.Text=tarjeta.Tanda;
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			FrmBuscaEmpleado frmBusEmp= new FrmBuscaEmpleado();
			frmBusEmp.StartPosition=FormStartPosition.CenterScreen;
			frmBusEmp.tipo=this.tipo;
			if(frmBusEmp.ShowDialog()==DialogResult.OK) 
			{
				mtxtcedula.Text=frmBusEmp.cedula;
				
				empleado.Cedula=mtxtcedula.Text.Trim();
				if(tipo==2)
				{
					empleado=mant.BuscaEmpleado(empleado);
				}
				else if (tipo==1)
				{
					empleado=mant.BuscaDocente(empleado);
				}			
				asignavalores(empleado);
				txtTarNo.Enabled=true;
				button4.Enabled=true;
				
			}			
		}
		
		void TxtTarNoKeyPress(object sender, KeyPressEventArgs e)
		{
			
			if (e.KeyChar=='\r')
			{
				tarjeta.Tarjeta=txtTarNo.Text;
				if(empleado.Tipo==2)
				{
					mant.BuscaTarjetaPApoyo(tarjeta);
					this.asignavalorTar(tarjeta);
				}
				else if(empleado.Tipo==1)
				{
					mant.BuscaTarjetaPDocente(tarjeta);
					this.asignavalorTar(tarjeta);
				}
				else
				{
					mant.AsignaValorTarjetaVacia(tarjeta);
					this.asignavalorTar(tarjeta);
				}
			}
		}
		
		void TxtTarNoValidating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
			tarjeta.Tarjeta=txtTarNo.Text;
			if(empleado.Tipo==2)
			{
				mant.BuscaTarjetaPApoyo(tarjeta);
				this.asignavalorTar(tarjeta);
			}
			else if(empleado.Tipo==1)
			{
				mant.BuscaTarjetaPDocente(tarjeta);
				this.asignavalorTar(tarjeta);
			}
			else
			{
				mant.AsignaValorTarjetaVacia(tarjeta);
				this.asignavalorTar(tarjeta);
			}
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			FrmBuscaTarjeta frmBustar=new FrmBuscaTarjeta();
			frmBustar.StartPosition=FormStartPosition.CenterScreen;
			frmBustar.tipo=this.tipo;
			if (frmBustar.ShowDialog()==DialogResult.OK)
			{
			  txtTarNo.Text=frmBustar.tarjeta;
			  
			  tarjeta.Tarjeta=txtTarNo.Text;
			  if(empleado.Tipo==2)
  			  {
				mant.BuscaTarjetaPApoyo(tarjeta);
				this.asignavalorTar(tarjeta);
			  }
			  else if(empleado.Tipo==1)
			  {
				mant.BuscaTarjetaPDocente(tarjeta);
				this.asignavalorTar(tarjeta);
			  }
			  else
			  {
				mant.AsignaValorTarjetaVacia(tarjeta);
				this.asignavalorTar(tarjeta);
			  }
			}
		}
		
		void BtnguardarClick(object sender, EventArgs e)
		{
			if (mtxtcedula.Text.Trim().Length !=13)
			{
	        	MessageBox.Show("La cédula esta vacia o no esta completa"+'\r'+"Debe especificar 13 caracteres para la cédula","Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Warning);
				mtxtcelular.Focus();
				//MessageBox.Show(mtxtcelular.Text.Trim().Length.ToString());
				return;
			}
			if (txtTarNo.Text.Trim().Length!=9)
			{
				MessageBox.Show("La tarjeta esta vacia o no esta completa"+'\r'+"Debe especificar 9 caracteres para la tarjeta","Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtTarNo.Focus();
				return;
			}
			if (mant.GuardaTarjEmple(empleado.Cedula,tarjeta.Tarjeta))
			{
				MessageBox.Show("Informacion guardada correctamente");
			}
			else 
			{
				MessageBox.Show("Ocurrió un problema al guardar la informacion puede ser que ya exista");
				return;
			}
			this.NActivaTex();
			this.NActivar();
		}
		void NActivar()
		{
			this.btnnuevo.Enabled=true;
			this.btnguardar.Enabled=false;
			this.btneditar.Enabled=false;
			this.btncancelar.Enabled=false;
			this.btnverinforme.Enabled=true;
			this.btnsalir.Enabled=true;
			btnprimero.Enabled=false;
			btnatras.Enabled=false;
			btnsiguiente.Enabled=false;
			btnultimo.Enabled=false;
			button1.Enabled=false;
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
			button1.Enabled=true;
			button4.Enabled=true;
		}
		
		void FrmAsigTarjApoyoLoad(object sender, EventArgs e)
		{
			
			/*cantfilas=adapt.Rows.Count;
			if (cantfilas>0)
			{	
				fila=cantfilas-1;
				//this.CargaRegistro();
			}*/
			this.NActivaTex();
			this.NActivar();
		}
		
		void BtnnuevoClick(object sender, EventArgs e)
		{
			
			this.GActivaTex();
			this.GActivar();
			foreach(Control x in groupBox1.Controls)
			{
				if (x.GetType().ToString()=="System.Windows.Forms.TextBox" || x.GetType().ToString()=="System.Windows.Forms.MaskedTextBox")
					x.Text="";
			}
			foreach(Control x in groupBox2.Controls)
			{
				if (x.GetType().ToString()=="System.Windows.Forms.TextBox" || x.GetType().ToString()=="System.Windows.Forms.MaskedTextBox")
					x.Text="";
			}
		}
		
		void BtneditarClick(object sender, EventArgs e)
		{
			this.GActivaTex();
			this.GActivar();
		}
		
		void BtncancelarClick(object sender, EventArgs e)
		{
			/*if(cantfilas>0)
			{
				//this.CargaRegistro();
			}*/
			foreach(Control x in groupBox1.Controls)
			{
				if (x.GetType().ToString()=="System.Windows.Forms.TextBox" || x.GetType().ToString()=="System.Windows.Forms.MaskedTextBox")
					x.Text="";
			}
			foreach(Control x in groupBox2.Controls)
			{
				if (x.GetType().ToString()=="System.Windows.Forms.TextBox" || x.GetType().ToString()=="System.Windows.Forms.MaskedTextBox")
					x.Text="";
			}
			this.NActivaTex();
			this.NActivar();
		}
		void GActivaTex()
		{
			this.mtxtcedula.Enabled=true;
			this.txtnombre.Enabled=true;
			this.txtapellido1.Enabled=true;
			this.txtapellido2.Enabled=true;
			this.txtdireccion.Enabled=true;
			this.mtxtelefono.Enabled=true;
			this.mtxtcelular.Enabled=true;
			this.txtTarNo.Enabled=true;
			this.cmbfechaingreso.Enabled=true;
			this.cmbfechanacimiento.Enabled=true;
			this.rdbmasculino.Enabled=true;
			this.rdbfemenino.Enabled=true;
		}
		void NActivaTex()
		{
			this.mtxtcedula.Enabled=false;
			this.txtnombre.Enabled=false;
			this.txtapellido1.Enabled=false;
			this.txtapellido2.Enabled=false;
			this.txtdireccion.Enabled=false;
			this.mtxtelefono.Enabled=false;
			this.mtxtcelular.Enabled=false;
			this.txtTarNo.Enabled=false;
			this.cmbfechaingreso.Enabled=false;
			this.cmbfechanacimiento.Enabled=false;
			this.rdbmasculino.Enabled=false;
			this.rdbfemenino.Enabled=false;
		}
		
		void BtnprimeroClick(object sender, EventArgs e)
		{
			/*if (cantfilas>0)
			{
				this.fila=0;
				//this.CargaRegistro();
			}*/
		}
		
		void BtnatrasClick(object sender, EventArgs e)
		{
			/*if (cantfilas>0)
			{	
				if (this.fila!=0)
				{
					this.fila-=1;
					//this.CargaRegistro();
				}
			}*/
		}
		
		void BtnsiguienteClick(object sender, EventArgs e)
		{
			/*if (cantfilas>0)
			{
				if (this.fila!=cantfilas-1)
				{
					this.fila+=1;
					//this.CargaRegistro();
				}
			}*/
		}
		
		void BtnultimoClick(object sender, EventArgs e)
		{
			/*if(cantfilas>0)
			{
				this.fila=cantfilas-1;
				//this.CargaRegistro();
			}*/
		}
	}
}
