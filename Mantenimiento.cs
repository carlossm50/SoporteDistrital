/*
 * Created by SharpDevelop.
 * User: USUARIO
 * Date: 4/3/2009
 * Time: 4:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using SoporteDistrital;
using SoporteDistrital.Clases;
using System.Configuration;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SoporteDistrital
{
	/// <summary>
	/// Description of Mantenimiento.
	/// </summary>
	public class Mantenimiento
	{   
		private string connString =string.Empty;
		private MySqlConnection conn;
		private MySqlCommand cmd;
		private int cont=0;
		public Mantenimiento()
		{
		  //connString ="Database=de0707;Data Source=localhost;User Id=root; Password=12345";
		  connString= ConfigurationSettings.AppSettings["cono"].ToString();
		  string con=ConfigurationSettings.AppSettings["fune"].ToString();
		  
		  conn=new MySqlConnection(connString);
		}
		public bool GuardaEmpleados(Empleado empleado,int control)
		{
		   bool r = false;
			cmd = new MySqlCommand("de0707.guardaEmpleado", conn);
			cmd.CommandTimeout = 10;
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("control",control);
			cmd.Parameters.AddWithValue("ecedula",empleado.Cedula);
			cmd.Parameters.AddWithValue("enombre",empleado.Nombre);
			cmd.Parameters.AddWithValue("eapellido1",empleado.Apellido1);
			cmd.Parameters.AddWithValue("eapellido2",empleado.Apellido2);
			cmd.Parameters.AddWithValue("edireccion",empleado.Direccion);
			cmd.Parameters.AddWithValue("ecelular",empleado.Celular);
			cmd.Parameters.AddWithValue("etelefono",empleado.Telefono);
			cmd.Parameters.AddWithValue("efecha_nacimiento",empleado.Fecha_Nacimiento);
			cmd.Parameters.AddWithValue("efecha_ingreso",empleado.Fecha_Inggreso);
			cmd.Parameters.AddWithValue("esexo",empleado.Sexo);
			cmd.Parameters.AddWithValue("eestado",empleado.Estatus);
			try
			{
				conn.Open();
				if(cmd.ExecuteNonQuery()>0)
					r = true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}
			return r;
		}
		public bool GuardaDocente(Docente empleado)
		{
		   bool r = false;
			cmd = new MySqlCommand("de0707.guardadocente", conn);
			cmd.CommandTimeout = 10;
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("control",empleado.Control);
			cmd.Parameters.AddWithValue("ecedula",empleado.Cedula);
			cmd.Parameters.AddWithValue("enombre",empleado.Nombre);
			cmd.Parameters.AddWithValue("eapellido1",empleado.Apellido1);
			cmd.Parameters.AddWithValue("eapellido2",empleado.Apellido2);
			cmd.Parameters.AddWithValue("edireccion",empleado.Direccion);
			cmd.Parameters.AddWithValue("ecelular",empleado.Celular);
			cmd.Parameters.AddWithValue("etelefono",empleado.Telefono);
			cmd.Parameters.AddWithValue("efecha_nacimiento",empleado.Fecha_Nacimiento);
			cmd.Parameters.AddWithValue("efecha_ingreso",empleado.Fecha_Inggreso);
			cmd.Parameters.AddWithValue("esexo",empleado.Sexo);
			cmd.Parameters.AddWithValue("eestado",empleado.Estatus);
			cmd.Parameters.AddWithValue("dnivelacad",empleado.NivelAcademico);
			cmd.Parameters.AddWithValue("dtitulo",empleado.Titulo);
			cmd.Parameters.AddWithValue("dareaestudio",empleado.AreaEstudio);
			cmd.Parameters.AddWithValue("dtipo",empleado.Tipo);
			
			try
			{
				conn.Open();
				if(cmd.ExecuteNonQuery()>0)
					r = true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}
			return r;
		}
		public bool GuardaRegional(Regional regional,int control)
		{
			bool r=false;
			MySqlCommand com = new MySqlCommand("de0707.guardaReg",conn);
			com.CommandTimeout=10;
			com.CommandType=CommandType.StoredProcedure;
			com.Parameters.AddWithValue("control",control);
			com.Parameters.AddWithValue("rcod_regional",regional.Codregional);
			com.Parameters.AddWithValue("rnombre",regional.Nombre);
			com.Parameters.AddWithValue("rdireccion",regional.Direccion);
			com.Parameters.AddWithValue("rtelefono",regional.Telefono);
			com.Parameters.AddWithValue("restado",regional.Estado);
			try
			{
				conn.Open();
				if (com.ExecuteNonQuery()>0)
				{
					 r=true;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally 
			{
				conn.Close();
			}
			return r;
		}
		public bool GuardaDistrito(Distrito distrito,int control)
		{
			bool r=false;
			MySqlCommand com=new MySqlCommand();
			com.CommandText="de0707.guardadist";
			com.Connection=conn;
			com.CommandTimeout=10;
			com.CommandType=CommandType.StoredProcedure;
			com.Parameters.AddWithValue("control",control);
			com.Parameters.AddWithValue("dCodistrito",distrito.Coddistrito);
			com.Parameters.AddWithValue("dcod_regional",distrito.Codregional);
			com.Parameters.AddWithValue("dd_nombre",distrito.Nombre);
			com.Parameters.AddWithValue("dd_direccion",distrito.Direccion);
			com.Parameters.AddWithValue("dd_telefono",distrito.Telefono);
			com.Parameters.AddWithValue("destado",distrito.Estado);
			
			try 
			{
				conn.Open();
				if (com.ExecuteNonQuery()>0)
					r=true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}
			return r;
			
		}
		public bool Guardacentro(CentroEducativo centro,int control)
		{
			bool r=false;
			MySqlCommand cmd=new MySqlCommand("de0707.guardacentro",conn);
			cmd.CommandTimeout=10;
			cmd.CommandType=CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("control",control);
			cmd.Parameters.AddWithValue("ccodigoCent",centro.CodigoCentro);
			cmd.Parameters.AddWithValue("cCodistrito",centro.CodigoDistrito);
			cmd.Parameters.AddWithValue("cnombre",centro.Nombre);
			cmd.Parameters.AddWithValue("cdireccion",centro.Direccion);
			cmd.Parameters.AddWithValue("ctelefono",centro.Telefono);
			cmd.Parameters.AddWithValue("ctanda",centro.Tanda);
			cmd.Parameters.AddWithValue("cestado","A");
			cmd.Parameters.AddWithValue("cantaulas",centro.CantidadAulas); 
			cmd.Parameters.AddWithValue("cantsecc",centro.CantidadSecciones);
			try
			{
				conn.Open();
				if(cmd.ExecuteNonQuery()>0)
				{
					r=true;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}
			
			
			return r;
		}
		public bool GuardaTarjeta(Tarjetas tarjeta,int control)
		{
			bool r=false;
			MySqlCommand cmd =new MySqlCommand("de0707.guardaTarj",conn);
			cmd.CommandTimeout=10;
			cmd.CommandType=CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("control",control);
			cmd.Parameters.AddWithValue("ttarjeta",tarjeta.Tarjeta);
			cmd.Parameters.AddWithValue("tcodigoCent",tarjeta.CodigoCentro);
			cmd.Parameters.AddWithValue("tcargo",tarjeta.Cargo);
			cmd.Parameters.AddWithValue("testado",tarjeta.Estado);			
			cmd.Parameters.AddWithValue("tingresos",tarjeta.Ingresos);
			try
			{
				conn.Open();
				if(cmd.ExecuteNonQuery()>0)
				{	
					r=true;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}
			return r;
		}
		public bool GuardaTarjEmple(string cedula, string tarjeta)
		{
			bool r=false;
			MySqlCommand cmd=new MySqlCommand("de0707.guardaTarjEmpl",conn);
			cmd.CommandTimeout=10;			
			cmd.CommandType= CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("ttarjeta",tarjeta);
			cmd.Parameters.AddWithValue("tcedula",cedula);
			try
			{
				conn.Open();
				if(cmd.ExecuteNonQuery()>0)
				{
					r=true;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}
			return r;
		}
		public bool GuardaUsuario(Usuario usu)
		{
			bool r = false;
			MySqlCommand cmd=new MySqlCommand("de0707.guardaUsuario");
			cmd.CommandTimeout=10;
			cmd.CommandType=CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("uNomUsu",usu.NombreUsuario);
			cmd.Parameters.AddWithValue("ucontrac",usu.Contraceña);
			cmd.Parameters.AddWithValue("ucedulaEmpl",usu.Cedula);
			//uNomUsu varchar(50),ucontrac varchar(50),ucedulaEmpl char(13)
			cmd.Connection=conn;
			try
			{
				conn.Open();
				if(cmd.ExecuteNonQuery()>0)
				{
					r=true;
				}
			}
			catch(Exception ex)
			{MessageBox.Show(ex.Message);}
			finally
			{
				conn.Close();
			}
			return r;
		}
		public bool GuardaPermisos(ListView lista,int codigo)
		{
			bool r=false;
			int x=0;
			MySqlCommand cmd=new MySqlCommand("de0707.guardapermisos");
			cmd.Connection=conn;
			cmd.CommandType=CommandType.StoredProcedure;
			cmd.CommandTimeout=10;//control tinyint,PerID int,UsuID int,Asignado
			
			foreach(ListViewItem item in lista.Items)
			{
				if(lista.Items[x].ImageIndex!=0)
				{
			   		cmd.Parameters.Clear();
			   		cmd.Parameters.AddWithValue("control",0);
			   		cmd.Parameters.AddWithValue("PerID",lista.Items[x].ImageIndex);
			  		cmd.Parameters.AddWithValue("UsuID",codigo);
			   		if(lista.Items[x].Checked)
			   		cmd.Parameters.AddWithValue("Asignado",1);
			   		else 
			   		cmd.Parameters.AddWithValue("Asignado",0);
			   		try
			   		{
			   			conn.Open();
			   			if(cmd.ExecuteNonQuery()>0)
			   	   			r=true;
			   			else
			   			{
			   				r=false;
			   				break;
			   			}
			   		}
			   		catch(Exception ex)
			   		{
			   			MessageBox.Show(ex.Message);
			   			break;
			   		}
			   		finally
			   		{
			   			conn.Close();
			   		}
				}
				x++;
			}
			return r;
		}	
		public string Buscaentabla(string select)
		{
			MySqlCommand cm = new MySqlCommand(select,conn);
			MySqlDataReader r;
			try
			{
				conn.Open();
				r=cm.ExecuteReader();
				if (r.HasRows)
				{
					while(r.Read())
					{
						return r.GetString(0);
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally 
			{
				conn.Close();
			}
			return "NO ENCONTRADO";
		}
		public Docente BuscaEmpleado(Docente empl)
		{
			//int numero=0;
			MySqlCommand com = new MySqlCommand("select * from v_apoyotarjeta where v_apoyotarjeta.cedula='"+empl.Cedula+"'",conn);
		    MySqlDataReader r;
		    try
		    {
		    	conn.Open();
		    	r=com.ExecuteReader();
		    	if(r.HasRows)
		    	{
		    		while(r.Read())
		    		{
		    			empl.Cedula=r.GetString(0);
		    			empl.Nombre=r.GetString(1);
		    			empl.Apellido1=r.GetString(2);
		    			empl.Apellido2=r.GetString(3);
		    			empl.Direccion=r.GetString(4);
		    			empl.Telefono=r.GetString(5);
		    			empl.Celular=r.GetString(6);
		    			empl.Fecha_Nacimiento=r.GetString(7);
		    			empl.Sexo=r.GetString(8);
		    			empl.Fecha_Inggreso	=r.GetString(9);
		    			empl.Tipo=2;
		    		}
		    	}
		    	else
		    	{
		    		this.AsignaValoresVacio(empl);
		    	}
		    }
		    catch(Exception ex)
		    {MessageBox.Show(ex.Message);}
		    finally
		    {
		    	conn.Close();
		    }
			return empl;
		}
		public DataTable BuscaEmpleado()
		{
			MySqlDataAdapter adapt=new MySqlDataAdapter("Select * from v_apoyotarjeta",conn);
			DataTable tab=new DataTable();
			try
			{
				adapt.Fill(tab);
			}
			catch(Exception ex)
			{MessageBox.Show(ex.Message);}
			finally 
			{}
			return tab;
		}
		public Docente BuscaDocente(Docente empl)
		{
			//int numero=0;
			MySqlCommand com = new MySqlCommand("select * from v_docentestarje where v_docentestarje.cedula='"+empl.Cedula+"'",conn);
		    MySqlDataReader r;
		    try
		    {
		    	conn.Open();
		    	r=com.ExecuteReader();
		    	if(r.HasRows)
		    	{
		    		while(r.Read())
		    		{
		    			empl.Cedula=r.GetString(0);
		    			empl.Nombre=r.GetString(1);
		    			empl.Apellido1=r.GetString(2);
		    			empl.Apellido2=r.GetString(3);
		    			empl.Direccion=r.GetString(4);
		    			empl.Telefono=r.GetString(5);
		    			empl.Celular=r.GetString(6);
		    			empl.Fecha_Nacimiento=r.GetString(7);
		    			empl.Sexo=r.GetString(8);
		    			empl.Fecha_Inggreso	=r.GetString(9);
		    			empl.Tipo=r.GetByte(10);
		    		}
		    	}
		    	else
		    	{
		    		this.AsignaValoresVacio(empl);
		    	}
		    }
		    catch(Exception ex)
		    {MessageBox.Show(ex.Message);}
		    finally
		    {
		    	conn.Close();
		    }
			return empl;
		}
		public DataTable BuscaDocente()
		{
		    MySqlDataAdapter adapt = new MySqlDataAdapter("Select * from v_docentestarje",conn);
			DataTable tab = new DataTable();
			try
			{
				adapt.Fill(tab);
			}
			catch(Exception ex)
			{MessageBox.Show(ex.Message);}
			finally 
			{}
			return tab;
		}
		public DataTable BuscaTarjeta()
		{
		    MySqlDataAdapter adapt = new MySqlDataAdapter("Select * from tbltarjeta",conn);
			DataTable tab = new DataTable();
			try
			{
				adapt.Fill(tab);
			}
			catch(Exception ex)
			{MessageBox.Show(ex.Message);}
			finally 
			{}
			return tab;
		}
		public DataTable BuscaCentro()
		{
		    MySqlDataAdapter adapt = new MySqlDataAdapter("select * from tblcentroed",conn);
			DataTable tab = new DataTable();
			try
			{
				adapt.Fill(tab);
			}
			catch(Exception ex)
			{MessageBox.Show(ex.Message);}
			finally 
			{}
			return tab;
		}
		public DataTable BuscaDistrito()
		{
		    MySqlDataAdapter adapt = new MySqlDataAdapter("select * from tbldistrito",conn);
			DataTable tab = new DataTable();
			try
			{
				adapt.Fill(tab);
			}
			catch(Exception ex)
			{MessageBox.Show(ex.Message);}
			finally 
			{}
			return tab;
		}
		public DataTable BuscaRegional()
		{
		    MySqlDataAdapter adapt = new MySqlDataAdapter("select * from tblregional",conn);
			DataTable tab = new DataTable();
			try
			{
				adapt.Fill(tab);
			}
			catch(Exception ex)
			{MessageBox.Show(ex.Message);}
			finally 
			{}
			return tab;
		}
		public void AsignaValoresVacio(Docente empl)
		{
			empl.Cedula=string.Empty;
		    empl.Nombre=string.Empty;
		    empl.Apellido1=string.Empty;
   			empl.Apellido2=string.Empty;
		    empl.Direccion=string.Empty;
		    empl.Telefono=string.Empty;
		    empl.Celular=string.Empty;
		    empl.Fecha_Nacimiento=string.Empty;
		    empl.Sexo=string.Empty;
		    empl.Fecha_Inggreso	=string.Empty;
		    empl.Tipo=10;
		}
		public void AsignaValorTarjetaVacia(Tarjetas tarjeta)
		{
			tarjeta.Tarjeta=string.Empty;
			tarjeta.CodigoCentro=0;
			tarjeta.Nombre=string.Empty;
			tarjeta.Cargo=string.Empty;
			tarjeta.Ingresos=0;
			tarjeta.Tipo=10;
			tarjeta.Tanda=string.Empty;
		}
		public void BuscaTarjetaPApoyo(Tarjetas tarjeta)
		{
			StringBuilder sel=new StringBuilder();
			sel.Append("select * from v_tarjetapoyo0 where tarjeta='"+tarjeta.Tarjeta+"' union select * from v_tarjetapoyo1 where tarjeta='"+tarjeta.Tarjeta+"' union select * from v_tarjetapoyodistrito where tarjeta='"+tarjeta.Tarjeta+"' union select * from v_tarjetapoyodistrito1 where tarjeta='"+tarjeta.Tarjeta+"'");
			/*sel.Append(" union select `tbltarjeta`.`tarjeta` AS `tarjeta`,`tbltarjeta`.`CodigoCent` AS `CodigoCent`,`tbldistrito`.`d_nombre` AS `nombre`,`tbltarjeta`.`cargo` AS `cargo`,`tbltarjeta`.`ingresos` AS `ingresos`,`tbltarjeta`.`fecha_reg` AS `fecha_reg`,`tbltarjeta`.`estado` AS `estado`,`tblcargos`.`tipo` AS `tipo`,'' AS tanda ");
			sel.Append("from ((`tbltarjeta` join `tblcargos`) join `tbldistrito`) where ((`tbltarjeta`.`cargo` = `tblcargos`.`nombreCarg`) and (`tblcargos`.`tipo` = 2) and (`tbltarjeta`.`CodigoCent` = `tbldistrito`.`Codistrito`) and (tarjeta ='"+tarjeta.Tarjeta+"'))");*/
			MySqlCommand cmd=new MySqlCommand(sel.ToString(),conn);
			MySqlDataReader r;
			try
			{
				conn.Open();
				r=cmd.ExecuteReader();
				if (r.HasRows)
				{
					while(r.Read())
					{
						tarjeta.Tarjeta=r.GetString(0);
						tarjeta.CodigoCentro=r.GetInt32(1);
						tarjeta.Nombre=r.GetString(2);
						tarjeta.Cargo=r.GetString(3);
						tarjeta.Ingresos=r.GetDouble(4);
						tarjeta.Tipo=r.GetByte(7);
						tarjeta.Tanda=r.GetString(8);
						
					}
				}
				else
				{
					this.AsignaValorTarjetaVacia(tarjeta);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally 
			{
				conn.Close();
			}
		}
		public void BuscaTarjetaPDocente(Tarjetas tarjeta)
		{
			StringBuilder sel=new StringBuilder();
			sel.Append("select * from v_tarjetadocente0 where tarjeta='"+tarjeta.Tarjeta+"' union select * from v_tarjetadocente1 where tarjeta='"+tarjeta.Tarjeta+"' union select * from v_tarjetadocentedistrito where tarjeta='"+tarjeta.Tarjeta+"' union select * from v_tarjetadocentedistrito1 where tarjeta='"+tarjeta.Tarjeta+"'");
			/*sel.Append(" union select `tbltarjeta`.`tarjeta` AS `tarjeta`,`tbltarjeta`.`CodigoCent` AS `CodigoCent`,`tbldistrito`.`d_nombre` AS `nombre`,`tbltarjeta`.`cargo` AS `cargo`,`tbltarjeta`.`ingresos` AS `ingresos`,`tbltarjeta`.`fecha_reg` AS `fecha_reg`,`tbltarjeta`.`estado` AS `estado`,`tblcargos`.`tipo` AS `tipo`,'' AS `tanda` ");
			sel.Append("from ((`tbltarjeta` join `tblcargos`) join `tbldistrito`) where ((`tbltarjeta`.`cargo` = `tblcargos`.`nombreCarg`) and (`tblcargos`.`tipo` <> 2) and (`tbltarjeta`.`CodigoCent` = `tbldistrito`.`Codistrito`)and (tarjeta ='"+tarjeta.Tarjeta+"'))");*/
			MySqlCommand cmd=new MySqlCommand(sel.ToString(),conn);
			MySqlDataReader r;
			try
			{
				conn.Open();
				r=cmd.ExecuteReader();
				if (r.HasRows)
				{
					while(r.Read())
					{
						tarjeta.Tarjeta=r.GetString(0);
						tarjeta.CodigoCentro=r.GetInt32(1);
						tarjeta.Nombre=r.GetString(2);
						tarjeta.Cargo=r.GetString(3);
						tarjeta.Ingresos=r.GetDouble(4);
						tarjeta.Tipo=r.GetByte(7);
						tarjeta.Tanda=r.GetString(8);
						
					}
				}
				else
				{
					this.AsignaValorTarjetaVacia(tarjeta);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally 
			{
				conn.Close();
			}
		}
		public bool BuscaUsuario(string usu, string contrac)
		{
			bool esta=false;
			MySqlCommand cmd =new MySqlCommand("select UsuarioID,NomUsu,contrac,cedulaEmpl from tblusuarios where NomUsu='"+usu+"'"+ " and contrac='"+contrac +"' and estado='A'",conn);
			MySqlDataReader red;
			try
			{
				conn.Open();
				red=cmd.ExecuteReader();
				if(red.HasRows)
				{
					esta=true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}
			
			return esta;
		}
		public bool BuscaUsuario(string usu)
		{
			bool esta=false;
			MySqlCommand cmd =new MySqlCommand("select UsuarioID,NomUsu,contrac,cedulaEmpl from tblusuarios where NomUsu='"+usu+"'"+"' and estado='A'",conn);
			MySqlDataReader red;
			try
			{
				conn.Open();
				red=cmd.ExecuteReader();
				if(red.HasRows)
				{
					esta=true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}
			
			return esta;
		}
		public void BuscaUsuario(Usuario usu)
		{
			
			MySqlCommand cmd =new MySqlCommand("select UsuarioID,NomUsu,contrac,cedulaEmpl from tblusuarios where NomUsu='"+usu.NombreUsuario+"'"+" and estado='A'",conn);
			MySqlDataReader red;
			try
			{
				conn.Open();
				red=cmd.ExecuteReader();
				if(red.HasRows)
				{
					while(red.Read())
					{
						usu.Id=red.GetInt32(0).ToString();
						usu.NombreUsuario=red.GetString(1);
						usu.Contraceña=red.GetString(2);
						usu.Cedula=red.GetString(3);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}
		}
		public string Chekapermisos(string usu, string contrac)
		{
			StringBuilder permisos=new StringBuilder();
			string sel="select tblusuarios.UsuarioID,NomUsu,contrac,tblusuarios.cedulaEmpl,fPerID,fUsuID,fAsignado from tblusuarios,tblpermisosusuarios where tblusuarios.NomUsu='"+usu+"' and tblusuarios.UsuarioID=tblpermisosusuarios.fUsuID and fasignado=1";
			MySqlDataReader red;
			MySqlCommand cmd =new MySqlCommand(sel,conn);
			if(BuscaUsuario(usu,contrac))
			{
				try
				{
					conn.Open();
					red=cmd.ExecuteReader();
					if(red.HasRows)
					{
						while(red.Read())
						{
							permisos.Append(red.GetInt32(4).ToString()+";");
						}
					}
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
				{
					conn.Close();
				}
				return permisos.ToString();
			}
			else
			{
				MessageBox.Show("No se ha encontrado en usuario.","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return string.Empty;
			}
		}
		public bool Cambiacontrasena(string usu,string contr)
		{
			bool r =false;
			MySqlCommand cmd=new MySqlCommand("de0707.UpUsuario");
			cmd.Connection=conn;
			cmd.CommandType=CommandType.StoredProcedure;
			cmd.CommandTimeout=10;
			cmd.Parameters.AddWithValue("usuario",usu);
			cmd.Parameters.AddWithValue("contrasena",contr);
			try
			{
				conn.Open();
				if (cmd.ExecuteNonQuery()>0)
				{
					r=true;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally 
			{
				conn.Close();
			}
			return r;
		}
		public void ActivaMenu(MenuStrip MainMenu, string permisos)
		{
			foreach(ToolStripMenuItem item in MainMenu.Items)
			{				
				if(item.Tag != null)
				{
					string key=item.Tag.ToString()+";";
					if ((permisos.IndexOf(key)<0))
					{
						item.Enabled=false;						
					}
					else
					{
						item.Enabled=true;
						//MessageBox.Show(item.Tag.ToString()+item.Text);
					}
			    }
				if (item.Enabled)
				{
					if (item.HasDropDownItems)
					{						
						ActivaDropDown(item.DropDownItems,permisos);
					}
				}
			}
		}
		public void ActivaDropDown(ToolStripItemCollection Items,string permisos)
		{
			foreach(ToolStripItem item in Items)
			{
				if(item.Tag != null)
				{
					string key=item.Tag.ToString()+";";
					if(permisos.IndexOf(key)<0)
					{
						item.Enabled=false;
					}
					else
					{
						item.Enabled=true;
					}
				}
				if (item.Enabled==true)
				{
					ToolStripMenuItem Menuitems =new ToolStripMenuItem();
					if(item.Tag!=null)
					try
					{
						Menuitems=(ToolStripMenuItem)item;
					}
					catch(Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
					finally 
					{
						if(Menuitems.HasDropDownItems)
						{
							ActivaDropDown(Menuitems.DropDownItems,permisos);
						}			
					}
					
				}
			}
		}
		public void llenalista(ListView lista,MenuStrip Mimenu)
		{
			
			foreach(ToolStripMenuItem item in Mimenu.Items)
			{
				if(item.Tag !=null)
				if (item.Tag.ToString().Trim()!="0")
				{
					lista.Items.Add(item.Text);
					lista.Items[cont].ImageIndex=System.Convert.ToInt32(item.Tag);
					cont++;
					if(item.HasDropDownItems)
					{
						recorredropdown(lista,item.DropDownItems);
					}
				}
			}
		}
		public void recorredropdown(ListView lista,ToolStripItemCollection items)
		{
			foreach(ToolStripItem item in items)
			{
				
				if(item.Tag !=null )
					{
						lista.Items.Add(item.Text);
						lista.Items[cont].ImageIndex=System.Convert.ToInt32(item.Tag);
					    cont++;
						ToolStripMenuItem MisItems=new ToolStripMenuItem();
						try
						{
							MisItems=(ToolStripMenuItem)item;
						}
						catch
						{}
						finally
						{
							if(MisItems.HasDropDownItems)
								{
									recorredropdown(lista,MisItems.DropDownItems);
								}
						}
					}
			}
			
		}
		
	}
}
