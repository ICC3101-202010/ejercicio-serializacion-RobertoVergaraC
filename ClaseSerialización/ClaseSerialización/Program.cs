using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
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
                Console.WriteLine("\nSeleccione la opción que desee: \n(a) Crear Persona\n(b) Cargar\n(c) Almacenar\n(d) Lista Personas creadas\n(e) Salir");
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
                    Stream stream = new FileStream("Personas.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                    int line = (int) formatter.Deserialize(stream);
                    for (int i = 0; i < line; i++)
                    {
                        Person person = (Person)formatter.Deserialize(stream);
                        persons.Add(person);
                    }
                    stream.Close(); 
         
                }
                else if (option == "c")
                {
                    IFormatter formatter = new SoapFormatter();
                    Stream stream = new FileStream("Personas.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                    formatter.Serialize(stream, persons);
                    for (int i = 0; i < persons.Count; i++)
                    {
                        formatter.Serialize(stream, persons[i]);
                    }
                                            stream.Close();
                }
                else if (option == "d")
                {
                    Console.WriteLine("\nLa lista de Personas creadas es:");
                    for (int i = 0; i < persons.Count; i++)
                    {
                        Console.WriteLine("\nPersona"+(i+1)+":\nNombre ="+persons[i].Name+"\nApellido ="+persons[i].Surname+"\nEdad ="+persons[i].Age);
                    }
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
