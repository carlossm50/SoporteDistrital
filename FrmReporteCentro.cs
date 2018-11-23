/*
 * Creado por SharpDevelop.
 * Usuario: admin
 * Fecha: 14/06/2010
 * Hora: 09:14 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.IO;

namespace SoporteDistrital
{
	/// <summary>
	/// Description of FrmReporteCentro.
	/// </summary>
	public partial class FrmReporteCentro : Form
	{
		public FrmReporteCentro()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnimprimirClick(object sender, EventArgs e)
		{
			//StringReader re=new StringReader();
			PrintDocument documento = new PrintDocument();
			
			//Graphics grafico;
			//documento=grafico.DrawString("hola",new Font("Arial", 80, FontStyle.Bold), Brushes.Black, 150, 125);
			try
			{
				if(printDialog1.ShowDialog()== DialogResult.OK)
			
				{
					
					documento.PrinterSettings.PrinterName=printDialog1.PrinterSettings.PrinterName;
					documento.Print();
					label1.Text=printDialog1.PrinterSettings.PrinterName;
					label2.Text=printDialog1.PrinterSettings.Copies.ToString();
					label3.Text=printDialog1.PrinterSettings.MaximumCopies.ToString();
					label4.Text=printDialog1.PrinterSettings.MaximumPage.ToString();
					label5.Text=printDialog1.PrinterSettings.MinimumPage.ToString();
					
				}
			}
			catch(Exception ex)
			{MessageBox.Show(ex.Message);}
			finally
			{
				//this.Close();
			}
			
		}
	}
}
