using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciocioPrueba
{
    internal class Persona
    {
        public class Humano
        {
            // Campos de la clase
            public string Nombre;
            public int Edad;

            // Constructor de la clase
            public Humano(string nombre, int edad)
            {
                Nombre = nombre;
                Edad = edad;
            }

            // Métodos de la clase
            public void Saludo()
            {
                Console.WriteLine("Hola, mi nombre es " + Nombre + " y tengo " + Edad + " años.");
            }
        }
    }
}
