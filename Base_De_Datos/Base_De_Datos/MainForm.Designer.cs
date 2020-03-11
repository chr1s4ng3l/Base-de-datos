/*
 * Creado por SharpDevelop.
 * Usuario: Christopher
 * Fecha: 06/11/2019
 * Hora: 09:35 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Base_De_Datos
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonConsultaAlumnos = new System.Windows.Forms.Button();
			this.dataGridViewAlumnos = new System.Windows.Forms.DataGridView();
			this.buttonConsultaMaterias = new System.Windows.Forms.Button();
			this.dataGridViewMaterias = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridViewCursa = new System.Windows.Forms.DataGridView();
			this.buttonConsultaInscripciones = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonAlta = new System.Windows.Forms.Button();
			this.buttonModificar = new System.Windows.Forms.Button();
			this.buttonBaja = new System.Windows.Forms.Button();
			this.buttonAltaMateria = new System.Windows.Forms.Button();
			this.buttonModificarMateria = new System.Windows.Forms.Button();
			this.buttonBajaMateria = new System.Windows.Forms.Button();
			this.comboBoxCiclo = new System.Windows.Forms.ComboBox();
			this.buttonInscribir = new System.Windows.Forms.Button();
			this.buttonEliminarIncrito = new System.Windows.Forms.Button();
			this.buttonSalir = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterias)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursa)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonConsultaAlumnos
			// 
			this.buttonConsultaAlumnos.AutoSize = true;
			this.buttonConsultaAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.buttonConsultaAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonConsultaAlumnos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonConsultaAlumnos.Location = new System.Drawing.Point(12, 206);
			this.buttonConsultaAlumnos.Name = "buttonConsultaAlumnos";
			this.buttonConsultaAlumnos.Size = new System.Drawing.Size(117, 31);
			this.buttonConsultaAlumnos.TabIndex = 0;
			this.buttonConsultaAlumnos.Text = "Consulta Alumnos";
			this.buttonConsultaAlumnos.UseVisualStyleBackColor = false;
			this.buttonConsultaAlumnos.Click += new System.EventHandler(this.ButtonConsultaAlumnosClick);
			// 
			// dataGridViewAlumnos
			// 
			this.dataGridViewAlumnos.AllowUserToAddRows = false;
			this.dataGridViewAlumnos.AllowUserToDeleteRows = false;
			this.dataGridViewAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewAlumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewAlumnos.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAlumnos.GridColor = System.Drawing.Color.Lime;
			this.dataGridViewAlumnos.Location = new System.Drawing.Point(12, 27);
			this.dataGridViewAlumnos.MultiSelect = false;
			this.dataGridViewAlumnos.Name = "dataGridViewAlumnos";
			this.dataGridViewAlumnos.ReadOnly = true;
			this.dataGridViewAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewAlumnos.Size = new System.Drawing.Size(463, 173);
			this.dataGridViewAlumnos.TabIndex = 1;
			// 
			// buttonConsultaMaterias
			// 
			this.buttonConsultaMaterias.AutoSize = true;
			this.buttonConsultaMaterias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.buttonConsultaMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonConsultaMaterias.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonConsultaMaterias.Location = new System.Drawing.Point(500, 206);
			this.buttonConsultaMaterias.Name = "buttonConsultaMaterias";
			this.buttonConsultaMaterias.Size = new System.Drawing.Size(117, 31);
			this.buttonConsultaMaterias.TabIndex = 2;
			this.buttonConsultaMaterias.Text = "Consulta Materias";
			this.buttonConsultaMaterias.UseVisualStyleBackColor = false;
			this.buttonConsultaMaterias.Click += new System.EventHandler(this.ButtonConsultaMateriasClick);
			// 
			// dataGridViewMaterias
			// 
			this.dataGridViewMaterias.AllowUserToAddRows = false;
			this.dataGridViewMaterias.AllowUserToDeleteRows = false;
			this.dataGridViewMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewMaterias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewMaterias.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewMaterias.GridColor = System.Drawing.Color.Lime;
			this.dataGridViewMaterias.Location = new System.Drawing.Point(500, 27);
			this.dataGridViewMaterias.MultiSelect = false;
			this.dataGridViewMaterias.Name = "dataGridViewMaterias";
			this.dataGridViewMaterias.ReadOnly = true;
			this.dataGridViewMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewMaterias.Size = new System.Drawing.Size(442, 173);
			this.dataGridViewMaterias.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Alumnos";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(500, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Materias";
			// 
			// dataGridViewCursa
			// 
			this.dataGridViewCursa.AllowUserToAddRows = false;
			this.dataGridViewCursa.AllowUserToDeleteRows = false;
			this.dataGridViewCursa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridViewCursa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewCursa.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewCursa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCursa.GridColor = System.Drawing.Color.Lime;
			this.dataGridViewCursa.Location = new System.Drawing.Point(12, 269);
			this.dataGridViewCursa.MultiSelect = false;
			this.dataGridViewCursa.Name = "dataGridViewCursa";
			this.dataGridViewCursa.ReadOnly = true;
			this.dataGridViewCursa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewCursa.Size = new System.Drawing.Size(549, 173);
			this.dataGridViewCursa.TabIndex = 6;
			// 
			// buttonConsultaInscripciones
			// 
			this.buttonConsultaInscripciones.AutoSize = true;
			this.buttonConsultaInscripciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.buttonConsultaInscripciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonConsultaInscripciones.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonConsultaInscripciones.Location = new System.Drawing.Point(587, 269);
			this.buttonConsultaInscripciones.Name = "buttonConsultaInscripciones";
			this.buttonConsultaInscripciones.Size = new System.Drawing.Size(121, 31);
			this.buttonConsultaInscripciones.TabIndex = 7;
			this.buttonConsultaInscripciones.Text = "Consulta Cursa";
			this.buttonConsultaInscripciones.UseVisualStyleBackColor = false;
			this.buttonConsultaInscripciones.Click += new System.EventHandler(this.ButtonConsultaInscripcionesClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 253);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Cursa";
			// 
			// buttonAlta
			// 
			this.buttonAlta.AutoSize = true;
			this.buttonAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.buttonAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAlta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAlta.Location = new System.Drawing.Point(147, 206);
			this.buttonAlta.Name = "buttonAlta";
			this.buttonAlta.Size = new System.Drawing.Size(85, 31);
			this.buttonAlta.TabIndex = 9;
			this.buttonAlta.Text = "Alta alumno";
			this.buttonAlta.UseVisualStyleBackColor = false;
			this.buttonAlta.Click += new System.EventHandler(this.ButtonAltaClick);
			// 
			// buttonModificar
			// 
			this.buttonModificar.AutoSize = true;
			this.buttonModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonModificar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModificar.Location = new System.Drawing.Point(256, 206);
			this.buttonModificar.Name = "buttonModificar";
			this.buttonModificar.Size = new System.Drawing.Size(114, 31);
			this.buttonModificar.TabIndex = 10;
			this.buttonModificar.Text = "Modificar alumno";
			this.buttonModificar.UseVisualStyleBackColor = false;
			this.buttonModificar.Click += new System.EventHandler(this.ButtonModificarClick);
			// 
			// buttonBaja
			// 
			this.buttonBaja.AutoSize = true;
			this.buttonBaja.BackColor = System.Drawing.Color.Red;
			this.buttonBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBaja.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBaja.Location = new System.Drawing.Point(383, 206);
			this.buttonBaja.Name = "buttonBaja";
			this.buttonBaja.Size = new System.Drawing.Size(92, 31);
			this.buttonBaja.TabIndex = 11;
			this.buttonBaja.Text = "Baja alumnos";
			this.buttonBaja.UseVisualStyleBackColor = false;
			this.buttonBaja.Click += new System.EventHandler(this.ButtonBajaClick);
			// 
			// buttonAltaMateria
			// 
			this.buttonAltaMateria.AutoSize = true;
			this.buttonAltaMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.buttonAltaMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAltaMateria.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAltaMateria.Location = new System.Drawing.Point(640, 206);
			this.buttonAltaMateria.Name = "buttonAltaMateria";
			this.buttonAltaMateria.Size = new System.Drawing.Size(87, 31);
			this.buttonAltaMateria.TabIndex = 12;
			this.buttonAltaMateria.Text = "Alta materia";
			this.buttonAltaMateria.UseVisualStyleBackColor = false;
			this.buttonAltaMateria.Click += new System.EventHandler(this.Button1Click);
			// 
			// buttonModificarMateria
			// 
			this.buttonModificarMateria.AutoSize = true;
			this.buttonModificarMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.buttonModificarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonModificarMateria.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonModificarMateria.Location = new System.Drawing.Point(733, 206);
			this.buttonModificarMateria.Name = "buttonModificarMateria";
			this.buttonModificarMateria.Size = new System.Drawing.Size(116, 31);
			this.buttonModificarMateria.TabIndex = 13;
			this.buttonModificarMateria.Text = "Modificar materia";
			this.buttonModificarMateria.UseVisualStyleBackColor = false;
			this.buttonModificarMateria.Click += new System.EventHandler(this.ButtonModificarMateriaClick);
			// 
			// buttonBajaMateria
			// 
			this.buttonBajaMateria.AutoSize = true;
			this.buttonBajaMateria.BackColor = System.Drawing.Color.Red;
			this.buttonBajaMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBajaMateria.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBajaMateria.Location = new System.Drawing.Point(855, 206);
			this.buttonBajaMateria.Name = "buttonBajaMateria";
			this.buttonBajaMateria.Size = new System.Drawing.Size(87, 31);
			this.buttonBajaMateria.TabIndex = 14;
			this.buttonBajaMateria.Text = "Baja materia";
			this.buttonBajaMateria.UseVisualStyleBackColor = false;
			this.buttonBajaMateria.Click += new System.EventHandler(this.ButtonBajaMateriaClick);
			// 
			// comboBoxCiclo
			// 
			this.comboBoxCiclo.BackColor = System.Drawing.Color.White;
			this.comboBoxCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCiclo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxCiclo.FormattingEnabled = true;
			this.comboBoxCiclo.Items.AddRange(new object[] {
									"2020A",
									"2020B",
									"2021A",
									"2021B"});
			this.comboBoxCiclo.Location = new System.Drawing.Point(587, 316);
			this.comboBoxCiclo.Name = "comboBoxCiclo";
			this.comboBoxCiclo.Size = new System.Drawing.Size(121, 21);
			this.comboBoxCiclo.TabIndex = 15;
			// 
			// buttonInscribir
			// 
			this.buttonInscribir.AutoSize = true;
			this.buttonInscribir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.buttonInscribir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonInscribir.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonInscribir.Location = new System.Drawing.Point(587, 355);
			this.buttonInscribir.Name = "buttonInscribir";
			this.buttonInscribir.Size = new System.Drawing.Size(121, 31);
			this.buttonInscribir.TabIndex = 16;
			this.buttonInscribir.Text = "Inscribir\r\n";
			this.buttonInscribir.UseVisualStyleBackColor = false;
			this.buttonInscribir.Click += new System.EventHandler(this.Button4Click);
			// 
			// buttonEliminarIncrito
			// 
			this.buttonEliminarIncrito.AutoSize = true;
			this.buttonEliminarIncrito.BackColor = System.Drawing.Color.Red;
			this.buttonEliminarIncrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEliminarIncrito.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonEliminarIncrito.Location = new System.Drawing.Point(587, 411);
			this.buttonEliminarIncrito.Name = "buttonEliminarIncrito";
			this.buttonEliminarIncrito.Size = new System.Drawing.Size(121, 31);
			this.buttonEliminarIncrito.TabIndex = 17;
			this.buttonEliminarIncrito.Text = "Eliminar";
			this.buttonEliminarIncrito.UseVisualStyleBackColor = false;
			this.buttonEliminarIncrito.Click += new System.EventHandler(this.ButtonEliminarIncritoClick);
			// 
			// buttonSalir
			// 
			this.buttonSalir.AutoSize = true;
			this.buttonSalir.BackColor = System.Drawing.Color.Blue;
			this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSalir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSalir.ForeColor = System.Drawing.Color.White;
			this.buttonSalir.Location = new System.Drawing.Point(821, 411);
			this.buttonSalir.Name = "buttonSalir";
			this.buttonSalir.Size = new System.Drawing.Size(121, 31);
			this.buttonSalir.TabIndex = 18;
			this.buttonSalir.Text = "Salir";
			this.buttonSalir.UseVisualStyleBackColor = false;
			this.buttonSalir.Click += new System.EventHandler(this.ButtonSalirClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(954, 453);
			this.Controls.Add(this.buttonSalir);
			this.Controls.Add(this.buttonEliminarIncrito);
			this.Controls.Add(this.buttonInscribir);
			this.Controls.Add(this.comboBoxCiclo);
			this.Controls.Add(this.buttonBajaMateria);
			this.Controls.Add(this.buttonModificarMateria);
			this.Controls.Add(this.buttonAltaMateria);
			this.Controls.Add(this.buttonBaja);
			this.Controls.Add(this.buttonModificar);
			this.Controls.Add(this.buttonAlta);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonConsultaInscripciones);
			this.Controls.Add(this.dataGridViewCursa);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridViewMaterias);
			this.Controls.Add(this.buttonConsultaMaterias);
			this.Controls.Add(this.dataGridViewAlumnos);
			this.Controls.Add(this.buttonConsultaAlumnos);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Base_De_Datos";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterias)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursa)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button buttonSalir;
		private System.Windows.Forms.Button buttonEliminarIncrito;
		private System.Windows.Forms.Button buttonInscribir;
		private System.Windows.Forms.ComboBox comboBoxCiclo;
		private System.Windows.Forms.Button buttonBajaMateria;
		private System.Windows.Forms.Button buttonModificarMateria;
		private System.Windows.Forms.Button buttonAltaMateria;
		private System.Windows.Forms.Button buttonBaja;
		private System.Windows.Forms.Button buttonModificar;
		private System.Windows.Forms.Button buttonAlta;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonConsultaInscripciones;
		private System.Windows.Forms.DataGridView dataGridViewCursa;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridViewMaterias;
		private System.Windows.Forms.Button buttonConsultaMaterias;
		private System.Windows.Forms.DataGridView dataGridViewAlumnos;
		private System.Windows.Forms.Button buttonConsultaAlumnos;
	}
}
