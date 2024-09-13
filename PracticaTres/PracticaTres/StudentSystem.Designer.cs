namespace Practica_3POE
{
	partial class StudentSystem
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            NombreAlumnoTextBox = new TextBox();
            ApellidoAlumnoTextBox = new TextBox();
            NumeroTelefonoTextBox = new TextBox();
            CarreraAlumnoTextBox = new TextBox();
            RegistroAlumnoListBox = new ListBox();
            AgregarButton = new Button();
            EliminarButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(322, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 27);
            label1.TabIndex = 0;
            label1.Text = "Registro de Alumnos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 103);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(194, 27);
            label2.TabIndex = 1;
            label2.Text = "Nombres del Alumno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 182);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(199, 27);
            label3.TabIndex = 2;
            label3.Text = "Apellidos del Alumno:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 269);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(287, 27);
            label4.TabIndex = 3;
            label4.Text = "Numero de Telefono del Alumno:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 347);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(187, 27);
            label5.TabIndex = 4;
            label5.Text = "Carrera del Alumno:";
            // 
            // NombreAlumnoTextBox
            // 
            NombreAlumnoTextBox.BackColor = SystemColors.Window;
            NombreAlumnoTextBox.Location = new Point(554, 110);
            NombreAlumnoTextBox.Margin = new Padding(4, 6, 4, 6);
            NombreAlumnoTextBox.Name = "NombreAlumnoTextBox";
            NombreAlumnoTextBox.Size = new Size(346, 33);
            NombreAlumnoTextBox.TabIndex = 5;
            // 
            // ApellidoAlumnoTextBox
            // 
            ApellidoAlumnoTextBox.Location = new Point(554, 189);
            ApellidoAlumnoTextBox.Margin = new Padding(4, 6, 4, 6);
            ApellidoAlumnoTextBox.Name = "ApellidoAlumnoTextBox";
            ApellidoAlumnoTextBox.Size = new Size(346, 33);
            ApellidoAlumnoTextBox.TabIndex = 6;
            // 
            // NumeroTelefonoTextBox
            // 
            NumeroTelefonoTextBox.Location = new Point(554, 276);
            NumeroTelefonoTextBox.Margin = new Padding(4, 6, 4, 6);
            NumeroTelefonoTextBox.Name = "NumeroTelefonoTextBox";
            NumeroTelefonoTextBox.Size = new Size(346, 33);
            NumeroTelefonoTextBox.TabIndex = 7;
            // 
            // CarreraAlumnoTextBox
            // 
            CarreraAlumnoTextBox.Location = new Point(554, 353);
            CarreraAlumnoTextBox.Margin = new Padding(4, 6, 4, 6);
            CarreraAlumnoTextBox.Name = "CarreraAlumnoTextBox";
            CarreraAlumnoTextBox.Size = new Size(346, 33);
            CarreraAlumnoTextBox.TabIndex = 8;
            // 
            // RegistroAlumnoListBox
            // 
            RegistroAlumnoListBox.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegistroAlumnoListBox.FormattingEnabled = true;
            RegistroAlumnoListBox.ItemHeight = 20;
            RegistroAlumnoListBox.Location = new Point(19, 495);
            RegistroAlumnoListBox.Margin = new Padding(4, 6, 4, 6);
            RegistroAlumnoListBox.Name = "RegistroAlumnoListBox";
            RegistroAlumnoListBox.Size = new Size(780, 224);
            RegistroAlumnoListBox.TabIndex = 9;
            // 
            // AgregarButton
            // 
            AgregarButton.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AgregarButton.Location = new Point(151, 424);
            AgregarButton.Margin = new Padding(4, 6, 4, 6);
            AgregarButton.Name = "AgregarButton";
            AgregarButton.Size = new Size(199, 58);
            AgregarButton.TabIndex = 10;
            AgregarButton.Text = "Agregar";
            AgregarButton.UseVisualStyleBackColor = true;
            AgregarButton.Click += btnAgregar_Click;
            // 
            // EliminarButton
            // 
            EliminarButton.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EliminarButton.Location = new Point(502, 425);
            EliminarButton.Margin = new Padding(4, 6, 4, 6);
            EliminarButton.Name = "EliminarButton";
            EliminarButton.Size = new Size(199, 58);
            EliminarButton.TabIndex = 11;
            EliminarButton.Text = "Eliminar";
            EliminarButton.UseVisualStyleBackColor = true;
            EliminarButton.Click += btnEliminar_Click;
            // 
            // StudentSystem
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(923, 749);
            Controls.Add(EliminarButton);
            Controls.Add(AgregarButton);
            Controls.Add(RegistroAlumnoListBox);
            Controls.Add(CarreraAlumnoTextBox);
            Controls.Add(NumeroTelefonoTextBox);
            Controls.Add(ApellidoAlumnoTextBox);
            Controls.Add(NombreAlumnoTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe Script", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 6, 4, 6);
            Name = "StudentSystem";
            Text = "StudentSystem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox NombreAlumnoTextBox;
		private TextBox ApellidoAlumnoTextBox;
		private TextBox NumeroTelefonoTextBox;
		private TextBox CarreraAlumnoTextBox;
		private ListBox RegistroAlumnoListBox;
		private Button AgregarButton;
		private Button EliminarButton;
	}
}