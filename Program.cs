using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System;
//Nombre del proyecto...
namespace Edusex
{
    // clase antes del Void Main
    class Encuesta
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string NecesitaCita { get; set; }
        public string Ciudad { get; set; }
        public string Distrito { get; set; }
    }
// Aca inicia la clase program y el Main...
    class Program
    {
        static void Main()
        {
            List<Encuesta> listaEncuestas = new List<Encuesta>();

            int opcion = 0;
            string nombre = "";
            int edad = 0;
            string necesitaCita = "";
            bool edadValida;

            string ciudad;
            string Distrito = "";


            Console.WriteLine("==========================");
            Console.WriteLine("Hola, Bienvenido a EDUSEX");
            Console.WriteLine("==========================");
            Console.WriteLine("Create by Josue Mena");
            Console.WriteLine("Presione enter para continuar");
            Console.ReadKey();

            Console.WriteLine("Iniciando sistema...");
            do
            {
                Console.Clear();
                Console.WriteLine("=== Sistema EDUSEX ===");
                Console.WriteLine();
                Console.WriteLine("1. Realizar registro");
                Console.WriteLine("2. Ver registros");
                Console.WriteLine("3. Salir de la App");
                Console.WriteLine("4. Ver conceptos Educativos");
                Console.Write("Seleccione una opción: ");

                bool opcOk = int.TryParse(Console.ReadLine(), out opcion);

                if (!opcOk)
                {
                    Console.WriteLine("Por favor ingrese un número válido.");
                    Console.ReadKey();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("\nIngrese su nombre: ");
                        nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese la ciudad donde se encuentra: ");
                        ciudad = Console.ReadLine();
                        //ingresar condicional en caso de que la cuidad sea managua
                        // ingresar Distrito ...
                        if (ciudad.ToLower() == "managua")
                        {
                            Console.WriteLine("Digite numero del Distrito de su localidad");
                            Distrito = Console.ReadLine();

                        }



                        Console.Write("Ingrese su edad: ");
                        edadValida = int.TryParse(Console.ReadLine(), out edad);
                        if (!edadValida)
                        {
                            Console.WriteLine("Edad inválida. Intente de nuevo.");
                            Console.ReadKey();
                            break;
                        }

                        if (edad >= 12)
                        {
                            Console.Write("¿Requiere cita médica? (si/no): ");
                            necesitaCita = Console.ReadLine().ToLower();

                            if (necesitaCita == "si")
                            {
                                Console.WriteLine();
                                Console.WriteLine("Se le asignará una cita médica, en el Puesto Medico u hospital más cercano.");

                            }
                            else
                            {
                                Console.WriteLine("No se agendó ninguna cita.");
                            }

                            listaEncuestas.Add(new Encuesta
                            {
                                Nombre = nombre,
                                Edad = edad,
                                NecesitaCita = necesitaCita,
                                Ciudad = ciudad,
                                Distrito = Distrito

                            });
                        }
                        else
                        {
                            Console.WriteLine("No se permite el Registro a menores de 12 años.");
                        }

                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n=== Registros guardados ===");

                        if (listaEncuestas.Count == 0)
                        {
                            Console.WriteLine("No hay encuestas registradas aún.");
                        }
                        else
                        {
                            foreach (Encuesta encuesta in listaEncuestas)
                            {

                                Console.WriteLine($"Nombre: {encuesta.Nombre} | Edad: {encuesta.Edad} | Cita médica: {encuesta.NecesitaCita} | Ciudad: {encuesta.Ciudad} | Distrito: {encuesta.Distrito}");
                                Console.WriteLine();
                            }

                        }

                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Gracias por usar EDUSEX. ¡Hasta pronto!");
                        break;

                    case 4:
                        bool volverMenu = false;
                        while (!volverMenu)
                        {
                            Console.Clear();
                            Console.WriteLine("=== Información educativa ===");
                            Console.WriteLine("1. Enfermedades de transmisión sexual");
                            Console.WriteLine("2. Métodos anticonceptivos");
                            Console.WriteLine("3. Cambios en la adolescencia");
                            Console.WriteLine("4. Volver al menú principal");
                            Console.Write("Seleccione una opción: ");

                            string opcionInfo = Console.ReadLine();

                            Console.Clear();
                            switch (opcionInfo)
                            {
                                case "1":
                                    Console.WriteLine("=== Enfermedades de Transmisión Sexual (ETS) ===");
                                    Console.WriteLine("- Son infecciones que se transmiten por contacto sexual sin protección.");
                                    Console.WriteLine("- Ejemplos: VIH/SIDA, clamidia, gonorrea, sífilis.");
                                    Console.WriteLine("- Usar preservativos ayuda a prevenirlas.");
                                    break;

                                case "2":
                                    Console.WriteLine("=== Métodos Anticonceptivos ===");
                                    Console.WriteLine("- Condón (masculino y femenino)");
                                    Console.WriteLine("- Pastillas anticonceptivas");
                                    Console.WriteLine("- Inyecciones y parches");
                                    Console.WriteLine("- Implantes subdérmicos");
                                    Console.WriteLine("- DIU (Dispositivo Intrauterino)");
                                    Console.WriteLine("- Siempre consultar con un profesional médico para elegir el mejor método.");
                                    break;

                                case "3":
                                    Console.WriteLine("=== Cambios en la Adolescencia ===");
                                    Console.WriteLine("- Cambios físicos: crecimiento, vello corporal, cambios en la voz.");
                                    Console.WriteLine("- Cambios emocionales: atracción, dudas, autoestima.");
                                    Console.WriteLine("- Es importante hablar con adultos de confianza y buscar información segura.");
                                    break;

                                case "4":
                                    volverMenu = true;
                                    continue;

                                default:
                                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                                    break;
                            }

                            Console.WriteLine("\nPresione una tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;

                    default:
                        Console.WriteLine("Opción no Invalida.");
                        Console.ReadKey();
                        break;
                }

            } while (opcion != 3);
            //fin y uso del do-while
        }//fin del main
    }//Fin del programa
}// fin del namespace Edusex
