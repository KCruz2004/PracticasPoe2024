using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHerencias
{
        public class Animal
        {
            // Atributos de la clase base
            public string Nombre { get; set; }
            public int Edad { get; set; }

            // Constructor
            public Animal(string nombre, int edad)
            {
                Nombre = nombre;
                Edad = edad;
            }

            // Método de la clase base
            public virtual void Comer()
            {
                // Para demostración en consola, en la aplicación de Windows Forms se mostrará en un MessageBox
                System.Diagnostics.Debug.WriteLine($"{Nombre} está comiendo.");
            }
        }
    }
