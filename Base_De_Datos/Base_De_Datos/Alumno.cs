/*
 * Creado por SharpDevelop.
 * Usuario: Christopher
 * Fecha: 11/11/2019
 * Hora: 03:28 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Base_De_Datos
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public partial class Alumno : Form
	{
		public Alumno()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ButtonAceptarClick(object sender, EventArgs e)
		{
			if(!textBoxNombre.Text.Equals("") && !textBoxCodigo.Text.Equals("") && !comboBoxCarrera.Text.Equals("")){
				this.DialogResult = DialogResult.OK;
			}else{
				MessageBox.Show("Debe llenar todos los campos");
			}
		}
	}
}
