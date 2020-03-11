/*
 * Creado por SharpDevelop.
 * Usuario: Christopher
 * Fecha: 06/11/2019
 * Hora: 09:35 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace Base_De_Datos
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		static String CadenaConexion = "Provider = Microsoft.Jet.OleDB.4.0; Data source = BD.mdb";
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		bool VerificarNrc(String nrc, String id_materia){
			Boolean existe  = false;
			
			for(int i=0; i<dataGridViewMaterias.RowCount; i ++){
				String COD = dataGridViewMaterias.Rows[i].Cells[3].Value.ToString();
				String ID = dataGridViewMaterias.Rows[i].Cells[0].Value.ToString();
				if(nrc.Equals(COD) == true && !ID.Equals(id_materia)){
					existe = true;
					break;
				}
				
			}
			
			return existe;
			
		}
		bool VerificarCodigo(String codigo, String id_Alumno){
			Boolean existe  = false;
			
			for(int i=0; i<dataGridViewAlumnos.RowCount; i ++){
				String COD = dataGridViewAlumnos.Rows[i].Cells[1].Value.ToString();
				String ID = dataGridViewAlumnos.Rows[i].Cells[0].Value.ToString();
				if(codigo.Equals(COD) == true && !ID.Equals(id_Alumno)){
					existe = true;
					break;
				}
				
			}
			
			return existe;
			
		}
		
		public static void Eliminar(String SQL){
			
			
			DataTable tabla = new DataTable();
			
			OleDbConnection ConexionBD = new OleDbConnection(CadenaConexion);
			ConexionBD.Open();
			OleDbDataAdapter adaptador = new OleDbDataAdapter();
			
			adaptador.DeleteCommand = ConexionBD.CreateCommand();
			adaptador.DeleteCommand.CommandText = SQL;
			adaptador.DeleteCommand.ExecuteNonQuery();
			
			ConexionBD.Close();
		}
		
		public static void Insertar(String SQL){
			
			
			DataTable tabla = new DataTable();
			
			OleDbConnection ConexionBD = new OleDbConnection(CadenaConexion);
			ConexionBD.Open();
			OleDbDataAdapter adaptador = new OleDbDataAdapter();
			
			adaptador.InsertCommand = ConexionBD.CreateCommand();
			adaptador.InsertCommand.CommandText = SQL;
			adaptador.InsertCommand.ExecuteNonQuery();
			
			ConexionBD.Close();
		}
		
		public static void Actualizar(String SQL){
			
			
			DataTable tabla = new DataTable();
			
			OleDbConnection ConexionBD = new OleDbConnection(CadenaConexion);
			ConexionBD.Open();
			OleDbDataAdapter adaptador = new OleDbDataAdapter();
			
			adaptador.UpdateCommand = ConexionBD.CreateCommand();
			adaptador.UpdateCommand.CommandText = SQL;
			adaptador.UpdateCommand.ExecuteNonQuery();
			
			ConexionBD.Close();
		}
		
		public static void Consulta(String SQL, DataGridView Vista){
			
			
			DataTable tabla = new DataTable();
			
			OleDbConnection ConexionBD = new OleDbConnection(CadenaConexion);
			ConexionBD.Open();
			OleDbDataAdapter adaptador = new OleDbDataAdapter();
			
			adaptador.SelectCommand = ConexionBD.CreateCommand();
			adaptador.SelectCommand.CommandText = SQL;
			adaptador.SelectCommand.ExecuteNonQuery();
			adaptador.Fill(tabla);
			Vista.DataSource=tabla;
			ConexionBD.Close();
		}
		void ButtonConsultaAlumnosClick(object sender, EventArgs e)
		{
			
			String SQL = "Select id_alumno as ID, codigo as CODIGO, nombre as NOMBRE, carrera as CARRERA from alumnos";
			Consulta(SQL,dataGridViewAlumnos);

		}
		
		void ButtonConsultaMateriasClick(object sender, EventArgs e)
		{
			
			String SQL = "Select id_materia as ID, nombre as NOMBRE, clave as CLAVE, nrc as NRC from materias";
			Consulta(SQL, dataGridViewMaterias);
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			comboBoxCiclo.SelectedIndex = 0;
			ButtonConsultaAlumnosClick(null, null);
			ButtonConsultaMateriasClick(null, null);
			ButtonConsultaInscripcionesClick(null, null);
		}
		
		void ButtonConsultaInscripcionesClick(object sender, EventArgs e)
		{
			String SQL = "Select c.id_cursa as ID, a.codigo as CODIGO, a.nombre as ALUMNO , a.carrera AS CARRERA, m.nombre as MATERIA, m.nrc as NRC,  c.ciclo as CICLO" +
				"				from cursa as c, alumnos as a, materias as m where a.id_alumno = c.id_alumno and c.id_materia = m.id_materia";
			Consulta(SQL, dataGridViewCursa);
			
		}
		
		
		void ButtonAltaClick(object sender, EventArgs e)
		{
			Alumno ventana = new Alumno();
			if(ventana.ShowDialog() == DialogResult.OK){
				String nombre, codigo, carrera;
				nombre = ventana.textBoxNombre.Text;
				codigo = ventana.textBoxCodigo.Text;
				carrera =ventana.comboBoxCarrera.Text;
				if(VerificarCodigo(codigo, "")== false){
					String SQL = "insert into alumnos (nombre, codigo, carrera) values ('"+nombre+"', '"+codigo+"', '"+carrera+"')";
					Insertar(SQL);
					ButtonConsultaAlumnosClick(null, null);
				}else{
					MessageBox.Show("El codigo ya existe");
				}
			}
		}
		
		void ButtonModificarClick(object sender, EventArgs e)
		{
			String nombre, codigo, carrera, id_Alumno, SQL;
			id_Alumno = dataGridViewAlumnos.CurrentRow.Cells[0].Value.ToString();
			codigo = dataGridViewAlumnos.CurrentRow.Cells[1].Value.ToString();
			nombre = dataGridViewAlumnos.CurrentRow.Cells[2].Value.ToString();
			carrera = dataGridViewAlumnos.CurrentRow.Cells[3].Value.ToString();
			
			Alumno ventana = new Alumno();
			ventana.textBoxNombre.Text = nombre;
			ventana.textBoxCodigo.Text = codigo;
			ventana.comboBoxCarrera.Text = carrera;
			
			
			if(ventana.ShowDialog() == DialogResult.OK){
				
				nombre = ventana.textBoxNombre.Text;
				codigo = ventana.textBoxCodigo.Text;
				carrera =ventana.comboBoxCarrera.Text;
				if(VerificarCodigo(codigo, id_Alumno)== false){
					SQL = "Update alumnos set codigo = '"+codigo+"', nombre = '"+nombre+"', carrera = '"+carrera+"' where id_alumno = "+id_Alumno;
					Actualizar(SQL);
					ButtonConsultaAlumnosClick(null, null);
				}else{
					MessageBox.Show("El codigo ya existe");
				}
				
			}
		}
		
		void ButtonBajaClick(object sender, EventArgs e)
		{
			if(dataGridViewAlumnos.SelectedRows.Count > 0){
				
				if(MessageBox.Show("Desea eliminar el alumno", "Confirmar", MessageBoxButtons.OKCancel,MessageBoxIcon.Question)== DialogResult.OK){
					String id_Alumno = dataGridViewAlumnos.CurrentRow.Cells[0].Value.ToString();
					String SQL = "delete from alumnos where id_alumno ="+id_Alumno;
					Eliminar(SQL);
					ButtonConsultaAlumnosClick(null, null);
					
				}
				
			}else{
				MessageBox.Show("No hay alumnos que eliminar");
			}
		}
		
		//inscribir
		void Button4Click(object sender, EventArgs e)
		{
			String id_alumno, id_materia, ciclo, SQL;
			String Materia = dataGridViewMaterias.CurrentRow.Cells[1].Value.ToString();
			String codigo = dataGridViewAlumnos.CurrentRow.Cells[1].Value.ToString();
			bool encontrado  = false;
			ciclo = comboBoxCiclo.Text;
			
			for (int i = 0; i < dataGridViewCursa.RowCount; i++) {
				
				String MateriaCursa = dataGridViewCursa.Rows[i].Cells[4].Value.ToString();
				String cicloCursa = dataGridViewCursa.Rows[i].Cells[6].Value.ToString();
				String codigoAlumnoCursa = dataGridViewCursa.Rows[i].Cells[1].Value.ToString();
				
				if(MateriaCursa.Equals(Materia) && ciclo.Equals(cicloCursa) && codigoAlumnoCursa.Equals(codigo)){
					encontrado = true;
				}
			}
			
			if(encontrado == true){
				MessageBox.Show("El alumnos con esa materia ya existe");
			}else{
				
				id_alumno = dataGridViewAlumnos.CurrentRow.Cells[0].Value.ToString();
				id_materia = dataGridViewMaterias.CurrentRow.Cells[0].Value.ToString();
				
				SQL = "insert into Cursa (id_alumno, id_materia, ciclo) values ("+id_alumno+", "+id_materia+", '"+ciclo+"')";
				Insertar(SQL);
				ButtonConsultaInscripcionesClick(null, null);
				
			}
			
			

		}
		
		void ButtonEliminarIncritoClick(object sender, EventArgs e)
		{
			if(dataGridViewAlumnos.SelectedRows.Count > 0){
				String id_cursa, SQL;
				id_cursa = dataGridViewCursa.CurrentRow.Cells[0].Value.ToString();
				
				SQL= "delete from cursa where id_cursa = "+id_cursa;
				Eliminar(SQL);
				ButtonConsultaInscripcionesClick(null, null);
			}else{
				MessageBox.Show("No hay datos que eliminar");
			}
		}
		
		
		//alta materia
		void Button1Click(object sender, EventArgs e)
		{
			try{
				Materias ventana = new Materias();
				if(ventana.ShowDialog() == DialogResult.OK){
					String nombre, clave, nrc;
					nombre = ventana.textBoxMateria.Text;
					clave = ventana.textBoxClave.Text;
					nrc =ventana.textBoxNrc.Text;
					if(VerificarNrc(nrc, "")== false){
						String SQL = "insert into materias (nombre, clave, nrc) values ('"+nombre+"', '"+clave+"', '"+nrc+"')";
						Insertar(SQL);
						ButtonConsultaMateriasClick(null, null);
					}else{
						MessageBox.Show("El Nrc ya existe");
					}
				}
			}catch(Exception){
				
			}
			
		}
		
		void ButtonModificarMateriaClick(object sender, EventArgs e)
		{
			String nombre, clave, nrc, id_Materia, SQL;
			id_Materia = dataGridViewMaterias.CurrentRow.Cells[0].Value.ToString();
			nombre = dataGridViewMaterias.CurrentRow.Cells[1].Value.ToString();
			clave = dataGridViewMaterias.CurrentRow.Cells[2].Value.ToString();
			nrc = dataGridViewMaterias.CurrentRow.Cells[3].Value.ToString();
			
			Materias ventana = new Materias();
			ventana.textBoxMateria.Text = nombre;
			ventana.textBoxClave.Text = clave;
			ventana.textBoxNrc.Text = nrc;
			
			try{
				
				if(ventana.ShowDialog() == DialogResult.OK){
					
					nombre = ventana.textBoxMateria.Text;
					clave = ventana.textBoxClave.Text;
					nrc = ventana.textBoxNrc.Text;
					if(VerificarNrc(nrc, id_Materia)== false){
						SQL = "Update materias set nrc = '"+nrc+"', nombre = '"+nombre+"', clave = '"+clave+"' where id_materia = "+id_Materia;
						Actualizar(SQL);
						ButtonConsultaMateriasClick(null, null);
					}else{
						MessageBox.Show("El nrc ya existe");
					}
					
				}
			}catch(Exception){
				
			}
		}
		
		void ButtonBajaMateriaClick(object sender, EventArgs e)
		{
			if(dataGridViewMaterias.SelectedRows.Count > 0){
				
				if(MessageBox.Show("Desea eliminar La materia", "Confirmar", MessageBoxButtons.OKCancel,MessageBoxIcon.Question)== DialogResult.OK){
					String id_Materia = dataGridViewMaterias.CurrentRow.Cells[0].Value.ToString();
					String SQL = "delete from materias where id_materia ="+id_Materia;
					Eliminar(SQL);
					ButtonConsultaMateriasClick(null, null);
					
				}
				
			}else{
				MessageBox.Show("No hay Materia que eliminar");
			}
		}
		
		void ButtonSalirClick(object sender, EventArgs e)
		{
			
			if(MessageBox.Show("Desea cerrar la ventana? ", "Confirmar", MessageBoxButtons.OKCancel,MessageBoxIcon.Question)== DialogResult.OK){
				this.Close();
			}
					
			
		}
	}
}
