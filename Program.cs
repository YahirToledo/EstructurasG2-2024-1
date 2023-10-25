using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace EstructurasG2_2024_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ejempo con estructura --> Asignacion Directa
             */ 
            Cliente cliente = new Cliente();
            cliente.Nombre = "Yahir";
            cliente.Edad = 20;

            Cliente cliente2 = cliente;
            cliente2.Nombre = "Sergio";

            Console.WriteLine("Nombre: {0}", cliente.Nombre);

            List<Cliente> clientes = new List<Cliente>();

            clientes.Add(cliente);
            clientes.Add(cliente2);

            foreach (Cliente miCliente in clientes)
            {
                Console.WriteLine(miCliente.Nombre);
            }

            Console.ReadLine();
            
            /*
            // Ejemplo con clase --> Asignacion por referencia

            Persona persona = new Persona();
            persona.Nombre = "Yahir";
            persona.Edad = 20;

            Persona persona2 = persona;
            persona2.Nombre = "Sergio";

            Console.WriteLine("Nombre: {0}", persona.Nombre);


            Console.WriteLine("Hoy es: {0}", Semana.Lunes + 2);

            Console.WriteLine(Keys.Enter);

            Console.ReadLine();
            */

        }
    }
}
