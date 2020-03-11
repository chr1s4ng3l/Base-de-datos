/*
 * Creado por SharpDevelop.
 * Usuario: Christopher
 * Fecha: 13/11/2019
 * Hora: 09:21 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Base_De_Datos
{
	partial class Materias
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
			this.buttonS = new System.Windows.Forms.Button();
			this.buttonAM = new System.Windows.Forms.Button();
			this.textBoxNrc = new System.Windows.Forms.TextBox();
			this.textBoxMateria = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxClave = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonS
			// 
			this.buttonS.AutoSize = true;
			this.buttonS.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonS.Location = new System.Drawing.Point(169, 171);
			this.buttonS.Name = "buttonS";
			this.buttonS.Size = new System.Drawing.Size(86, 32);
			this.buttonS.TabIndex = 11;
			this.buttonS.Text = "Salir";
			this.buttonS.UseVisualStyleBackColor = true;
			// 
			// buttonAM
			// 
			this.buttonAM.AutoSize = true;
			this.buttonAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAM.Location = new System.Drawing.Point(36, 171);
			this.buttonAM.Name = "buttonAM";
			this.buttonAM.Size = new System.Drawing.Size(90, 32);
			this.buttonAM.TabIndex = 10;
			this.buttonAM.Text = "Agregar";
			this.buttonAM.UseVisualStyleBackColor = true;
			this.buttonAM.Click += new System.EventHandler(this.ButtonAMClick);
			// 
			// textBoxNrc
			// 
			this.textBoxNrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNrc.Location = new System.Drawing.Point(111, 109);
			this.textBoxNrc.Name = "textBoxNrc";
			this.textBoxNrc.Size = new System.Drawing.Size(144, 26);
			this.textBoxNrc.TabIndex = 9;
			// 
			// textBoxMateria
			// 
			this.textBoxMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxMateria.Location = new System.Drawing.Point(111, 22);
			this.textBoxMateria.Name = "textBoxMateria";
			this.textBoxMateria.Size = new System.Drawing.Size(144, 26);
			this.textBoxMateria.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(59, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "NRC:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Materia:";
			// 
			// textBoxClave
			// 
			this.textBoxClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxClave.Location = new System.Drawing.Point(111, 63);
			this.textBoxClave.Name = "textBoxClave";
			this.textBoxClave.Size = new System.Drawing.Size(144, 26);
			this.textBoxClave.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(38, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 20);
			this.label3.TabIndex = 12;
			this.label3.Text = "CLAVE:";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// Materias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(288, 230);
			this.Controls.Add(this.textBoxClave);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonS);
			this.Controls.Add(this.buttonAM);
			this.Controls.Add(this.textBoxNrc);
			this.Controls.Add(this.textBoxMateria);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Materias";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Materias";
			this.Load += new System.EventHandler(this.MateriasLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox textBoxClave;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox textBoxMateria;
		public System.Windows.Forms.TextBox textBoxNrc;
		public System.Windows.Forms.Button buttonAM;
		public System.Windows.Forms.Button buttonS;
		private System.Windows.Forms.Label label1;
	}
}
