/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 02/12/2009
 * Hora: 03:24 a.m.
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
	/// Description of FrmTecnicoDocente.
	/// </summary>
	public partial class FrmTecnicoDocente : Form
	{
		public byte tipo;
		DataTable adapt =new DataTable();
		Mantenimiento mantenimiemt=new Mantenimiento();
		int fila=0;
		int cantfilas=0;
		bool edit=false;
		public FrmTecnicoDocente()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnnuevoClick(object sender, EventArgs e)
		{
			edit=false;
			this.mtxtcedula.Enabled=true;
			this.txtnombre.Enabled=true;
			this.txtapellido1.Enabled=true;
			this.txtapellido2.Enabled=true;
			this.txtdireccion.Enabled=true;
			this.mtxtelefono.Enabled=true;
			this.mtxtcelular.Enabled=true;
			this.cmbNivel.Enabled=true;
			this.txtareaestudio.Enabled=true;
			this.cmbTitulo.Enabled=true;
			this.cmbestatus.Enabled=true;
			this.rdbmasculino.Enabled=true;
			this.rdbfemenino.Enabled=true;
			this.cmbfechanacimiento.Enabled=true;
			this.cmbfechaingreso.Enabled=true;
			
			/*this.mtxtcedula.Clear();
			this.txtnombre.Clear();
			this.txtapellido1.Clear();
			this.txtapellido2.Clear();
			this.txtdireccion.Clear();
			this.mtxtelefono.Clear();
			this.mtxtcelular.Clear();*/
			/*this.cmbareatrabajo.SelectedIndex=-1;
			this.txtcarreraestudio.Clear();
			this.cmbtitulo.SelectedIndex=0;*/
			
			foreach(Control x in groupBox1.Controls)
			{
				if (x.GetType().ToString()=="System.Windows.Forms.TextBox" || x.GetType().ToString()=="System.Windows.Forms.MaskedTextBox")
					x.Text="";
			}
			this.cmbestatus.SelectedIndex=1;
			this.rdbmasculino.Checked=true;
			this.GActivaTex();
			this.GActivar();
			txtdireccion.Text="VILLA TAPIA";
			mtxtelefono.Text="(809)574-3305";
		}
		
		void BtnguardarClick(object sender, EventArgs e)
		{
			if (this.mtxtcedula.Text.Trim().Length<13)
			{
				
				MessageBox.Show(" La Cedula esta vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				mtxtcedula.Focus();
				return;
			}

			if (this.txtnombre.Text.Trim()==string.Empty)
			{
				MessageBox.Show(" El nombre esta vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtnombre.Focus();
				return;
			}
			if (this.txtapellido1.Text.Trim()==string.Empty)
			{
				MessageBox.Show(" El 1er apellido esta vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtapellido1.Focus();
				return;
			}
			/*if (this.txtapellido2.Text.Trim()==string.Empty)
			{
				MessageBox.Show(" El 2do apellido esta vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtapellido2.Focus();
				return;
			}*/
			if (this.txtdireccion.Text.Trim()==string.Empty)
			{
				MessageBox.Show(" La dirección esta vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtdireccion.Focus();
				return;
			}
			if (this.mtxtelefono.Text.Trim().Length<14)
			{
				
				MessageBox.Show(" El telefono esta vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				mtxtelefono.Focus();
				return;
			}

			if (this.cmbNivel.Text.Trim()==string.Empty)
			{
				MessageBox.Show(" El nivel academico esta vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmbNivel.Focus();
				return;
			}
			if (this.cmbTitulo.Text.Trim()==string.Empty)
			{
				MessageBox.Show(" El titulo esta vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmbTitulo.Focus();
				return;
			}
			if (this.txtareaestudio.Text.Trim()==string.Empty)
			{
				MessageBox.Show("El area de estudio esta vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtareaestudio.Focus();
				return;
			}			
			
			if (this.cmbestatus.Text.Trim()==string.Empty)
			{
				MessageBox.Show(" El estatus esta vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmbestatus.Focus();
				return;
			}
			
			Docente  empleado=new Docente();
			Mantenimiento mant=new Mantenimiento();
			empleado.Cedula=this.mtxtcedula.Text;
			empleado.Nombre=this.txtnombre.Text;
			empleado.Apellido1=this.txtapellido1.Text;
			empleado.Apellido2=this.txtapellido2.Text;
			empleado.Direccion=this.txtdireccion.Text;
			empleado.Telefono=this.mtxtelefono.Text;
			empleado.Celular=this.mtxtcelular.Text;
			empleado.Fecha_Inggreso=this.cmbfechaingreso.Text.Trim();
			empleado.Fecha_Nacimiento=this.cmbfechanacimiento.Text.Trim();
			empleado.Estatus=cmbestatus.SelectedIndex;
			empleado.NivelAcademico=this.cmbNivel.Text;
			empleado.AreaEstudio=this.txtareaestudio.Text;
			empleado.Titulo=this.cmbTitulo.Text;
			empleado.Tipo=this.tipo;
			if(edit==false)
			empleado.Control=1;
			else empleado.Control=0;
			if (rdbmasculino.Checked)
				empleado.Sexo="M";
			else
			    empleado.Sexo="F";
			if (mant.GuardaDocente(empleado))
			{
				adapt=mantenimiemt.BuscaDocente();
				cantfilas=adapt.Rows.Count;
				MessageBox.Show("Informacion guardada correctamente");
			}
			else 
			{
				MessageBox.Show("Ocurrió un problema al guardar la informacion puede ser que ya exista el empleado");
				return;
			}
			this.mtxtcedula.Enabled=false;
			this.txtnombre.Enabled=false;
			this.txtapellido1.Enabled=false;
			this.txtapellido2.Enabled=false;
			this.txtdireccion.Enabled=false;
			this.mtxtelefono.Enabled=false;
			this.mtxtcelular.Enabled=false;
			this.cmbNivel.Enabled=false;
			this.cmbTitulo.Enabled=false;
			this.txtareaestudio.Enabled=false;
			this.cmbestatus.Enabled=false;
			this.rdbmasculino.Enabled=false;
			this.rdbfemenino.Enabled=false;
			this.cmbfechanacimiento.Enabled=false;
			this.cmbfechaingreso.Enabled=false;
			this.NActivaTex();
			this.NActivar();
		}
		
		void FrmTecnicoDocenteLoad(object sender, EventArgs e)
		{
			cmbfechaingreso.MaxDate=DateTime.Today;
			//cmbfechanacimiento.MaxDate= DateTime.Today.AddYears(-18);
			adapt=mantenimiemt.BuscaDocente();
			cantfilas=adapt.Rows.Count;
			if(cantfilas>0)
			{
				fila=cantfilas-1;
				this.CargaRegistro();
			}
			this.NActivaTex();
			this.NActivar();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
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
			this.mtxtcedula.Enabled=true;
			this.txtnombre.Enabled=true;
			this.txtapellido1.Enabled=true;
			this.txtapellido2.Enabled=true;
			this.txtdireccion.Enabled=true;
			this.mtxtelefono.Enabled=true;
			this.mtxtcelular.Enabled=true;
			this.cmbNivel.Enabled=true;
			this.cmbTitulo.Enabled=true;
			this.rdbmasculino.Enabled=true;
			this.rdbfemenino.Enabled=true;
			this.txtareaestudio.Enabled=true;
			this.cmbfechanacimiento.Enabled=true;
			this.cmbfechaingreso.Enabled=true;
			this.cmbestatus.Enabled=true;
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
			this.cmbNivel.Enabled=false;
			this.cmbTitulo.Enabled=false;
			this.rdbmasculino.Enabled=false;
			this.rdbfemenino.Enabled=false;
			this.txtareaestudio.Enabled=false;
			this.cmbfechanacimiento.Enabled=false;
			this.cmbfechaingreso.Enabled=false;
			this.cmbestatus.Enabled=false;
		}
		
		void BtneditarClick(object sender, EventArgs e)
		{
			edit=true;
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
		void CargaRegistro()
		{
			mtxtcedula.Text=adapt.Rows[fila][0].ToString();
			txtnombre.Text=adapt.Rows[fila][1].ToString();
			txtapellido1.Text=adapt.Rows[fila][2].ToString();
			txtapellido2.Text=adapt.Rows[fila][3].ToString();
			txtdireccion.Text=adapt.Rows[fila][4].ToString();
			mtxtelefono.Text=adapt.Rows[fila][5].ToString();
			mtxtcelular.Text=adapt.Rows[fila][6].ToString();
			cmbfechanacimiento.Text=adapt.Rows[fila][7].ToString();
			cmbfechaingreso.Text=adapt.Rows[fila][9].ToString();
			
			if(adapt.Rows[fila][8].ToString()=="M")
			{
				rdbmasculino.Checked=true;
			}
			else rdbfemenino.Checked=true;
			if(adapt.Rows[fila][10].ToString()=="True")
			{
				cmbestatus.SelectedIndex=1;
				
			}
			else
			{
				cmbestatus.SelectedIndex=0;
			}
			cmbNivel.Text=adapt.Rows[fila][13].ToString();
			cmbTitulo.Text=adapt.Rows[fila][14].ToString();
			txtareaestudio.Text=adapt.Rows[fila][15].ToString();
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
