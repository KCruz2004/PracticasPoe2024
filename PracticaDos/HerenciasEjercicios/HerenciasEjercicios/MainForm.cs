using LibreriaHerencias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HerenciasEjercicios
{
    public partial class MainForm : Form
    {
        private Perro miPerro;
        public MainForm()
        {
            InitializeComponent();
        }



        private void CreateDogButton_Click(object sender, EventArgs e)
        {
            string Nombre = DogNameTextBox.Text;
            int Edad;

            // Intentar convertir el texto de edad a un entero
            if (int.TryParse(DogAgeTextBox.Text, out Edad))
            {
                // Crear una instancia de Perro usando el nombre y la edad
                miPerro = new Perro(Nombre, Edad);
                labelResultado.Text = $"Perro creado: {miPerro.Nombre}, Edad: {miPerro.Edad}";
            }
            else
            {
                // Mostrar un mensaje de error si la conversión falla
                MessageBox.Show("Por favor, ingresa una edad válida.");
            }
            labelResultado.Text = $"Perro creado: {miPerro.Nombre}, Edad: {miPerro.Edad}";

        }

        private void DogEatingButton_Click(object sender, EventArgs e)
        {
            if (miPerro != null)
            {
                miPerro.Comer();
                MessageBox.Show($"{miPerro.Nombre} está comiendo.");
            }
            else
            {
                MessageBox.Show("No existe un perro, crear uno.");
            }
        }

        private void BarkButton_Click(object sender, EventArgs e)
        {
            if (miPerro != null)
            {
                miPerro.Ladrar();
                MessageBox.Show($"{miPerro.Nombre} está ladrando.");
            }
            else
            {
                MessageBox.Show("No tienes un perro.");
            }
        }
    }
}
