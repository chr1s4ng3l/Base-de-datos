/*
 * Creado por SharpDevelop.
 * Usuario: Christopher
 * Fecha: 13/11/2019
 * Hora: 09:21 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Base_De_Datos
{
	/// <summary>
	/// Description of Materias.
	/// </summary>
	public partial class Materias : Form
	{
		public Materias()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void MateriasLoad(object sender, EventArgs e)
		{
			
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void ButtonAMClick(object sender, EventArgs e)
		{
			if(!textBoxMateria.Text.Equals("") && !textBoxClave.Text.Equals("") && !textBoxNrc.Text.Equals("")){
				this.DialogResult = DialogResult.OK;
			}else{
				MessageBox.Show("Debe llenar todos los campos");
			}
		}
	}
}
