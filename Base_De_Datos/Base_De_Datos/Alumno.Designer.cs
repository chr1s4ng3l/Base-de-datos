/*
 * Creado por SharpDevelop.
 * Usuario: Christopher
 * Fecha: 11/11/2019
 * Hora: 03:28 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Base_De_Datos
{
	partial class Alumno
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.textBoxCodigo = new System.Windows.Forms.TextBox();
			this.comboBoxCarrera = new System.Windows.Forms.ComboBox();
			this.buttonAceptar = new System.Windows.Forms.Button();
			this.buttonCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(11, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Codigo:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(11, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Carrera:";
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNombre.Location = new System.Drawing.Point(86, 12);
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(202, 24);
			this.textBoxNombre.TabIndex = 3;
			// 
			// textBoxCodigo
			// 
			this.textBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCodigo.Location = new System.Drawing.Point(86, 56);
			this.textBoxCodigo.Name = "textBoxCodigo";
			this.textBoxCodigo.Size = new System.Drawing.Size(202, 24);
			this.textBoxCodigo.TabIndex = 4;
			// 
			// comboBoxCarrera
			// 
			this.comboBoxCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxCarrera.FormattingEnabled = true;
			this.comboBoxCarrera.Items.AddRange(new object[] {
									"Informatica",
									"Computacion",
									"Matematicas",
									"Ciencias"});
			this.comboBoxCarrera.Location = new System.Drawing.Point(86, 114);
			this.comboBoxCarrera.Name = "comboBoxCarrera";
			this.comboBoxCarrera.Size = new System.Drawing.Size(202, 26);
			this.comboBoxCarrera.TabIndex = 5;
			// 
			// buttonAceptar
			// 
			this.buttonAceptar.AutoSize = true;
			this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAceptar.Location = new System.Drawing.Point(86, 178);
			this.buttonAceptar.Name = "buttonAceptar";
			this.buttonAceptar.Size = new System.Drawing.Size(84, 32);
			this.buttonAceptar.TabIndex = 6;
			this.buttonAceptar.Text = "Aceptar";
			this.buttonAceptar.UseVisualStyleBackColor = true;
			this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
			// 
			// buttonCancelar
			// 
			this.buttonCancelar.AutoSize = true;
			this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCancelar.Location = new System.Drawing.Point(196, 178);
			this.buttonCancelar.Name = "buttonCancelar";
			this.buttonCancelar.Size = new System.Drawing.Size(92, 32);
			this.buttonCancelar.TabIndex = 7;
			this.buttonCancelar.Text = "Cancelar";
			this.buttonCancelar.UseVisualStyleBackColor = true;
			// 
			// Alumno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(307, 226);
			this.ControlBox = false;
			this.Controls.Add(this.buttonCancelar);
			this.Controls.Add(this.buttonAceptar);
			this.Controls.Add(this.comboBoxCarrera);
			this.Controls.Add(this.textBoxCodigo);
			this.Controls.Add(this.textBoxNombre);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Alumno";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Alumno";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.Button buttonCancelar;
		public System.Windows.Forms.Button buttonAceptar;
		public System.Windows.Forms.ComboBox comboBoxCarrera;
		public System.Windows.Forms.TextBox textBoxCodigo;
		public System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
