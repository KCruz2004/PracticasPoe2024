using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencias
{
    public class Perro : Animal
    {
        // Constructor que llama al constructor base
        public Perro(string nombre, int edad) : base(nombre, edad)
        {
        }

        // Método adicional en la clase derivada
        public void Ladrar()
        {
            // Para demostración en consola, en la aplicación de Windows Forms se mostrará en un MessageBox
            System.Diagnostics.Debug.WriteLine($"{Nombre} está ladrando.");
        }
    }
}
