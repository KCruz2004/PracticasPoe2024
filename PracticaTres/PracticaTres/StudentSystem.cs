using StudentSystemData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3POE
{
	public partial class StudentSystem : Form
	{

		public StudentSystem()
		{
			InitializeComponent();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			Career career = new Career();
			Student student = new Student();

			career.Name = CarreraAlumnoTextBox.Text;
			student.FirstName = NombreAlumnoTextBox.Text;
			student.LastName = ApellidoAlumnoTextBox.Text;
			student.PhoneNumber = NumeroTelefonoTextBox.Text;
			student.Career = career;

			RegistroAlumnoListBox.Items.Add(student);
			MessageBox.Show("Estudiante Registrado con Exito");
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (RegistroAlumnoListBox.SelectedItem is Student selectedStudent)
			{
				RegistroAlumnoListBox.Items.Remove(selectedStudent);
				MessageBox.Show("Estudiante Eliminado con Exito");
			}
			else
			{
				MessageBox.Show("No ha seleccionado estudiante");
			}
		}
	}
}
