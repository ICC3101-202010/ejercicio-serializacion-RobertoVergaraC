using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ClaseSerialización
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            while (true)//cargar, almacenar, lista personas, crear
            {
                Console.WriteLine("Seleccione la opción que desee: \n(a) Crear Persona\n(b) Cargar\n(c) Almacenar\n(d) Lista Personas creadas\n(e) Salir");
                string option = Console.ReadLine();
                if (option == "a")
                {
                    Console.WriteLine("Seleccione nombre de la Persona");
                    string name = Console.ReadLine();
                    Console.WriteLine("Seleccione el apellido de la Persona");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Seleccione la edad de la Persona");
                    int age = Int32.Parse(Console.ReadLine());
                    Person person = new Person(name, surname, age);
                    persons.Add(person);
                }
                else if (option == "b")
                {

                    IFormatter formatter = new SoapFormatter();

                    stream.Close();
                }
                else if (option == "c")
                {

                }
                else if (option == "d")
                {

                }
                else if (option == "e")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nLa opción que seleccionó no es válida, ponga una que si lo sea\n");
                }
            }
        }
    }
}
