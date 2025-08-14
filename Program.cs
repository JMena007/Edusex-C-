using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EDUSEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            int edad = 0;
            string edadTexto, nombre, respuestPsico, opcion;


            Console.WriteLine("======================================");
            Console.WriteLine("      BIENVENIDO A EDUSEX APP");
            Console.WriteLine("   Educación Sexual para Jóvenes");
            Console.WriteLine("======================================");

            Console.Write("Por favor, ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            edadTexto = Console.ReadLine();
            edad = int.Parse(edadTexto);

            if (edad < 10)
            {
                Console.WriteLine("Lo sentimos, esta aplicación es para personas mayores de 10 años.");
               // Return;
            }


            Console.Clear();
            Console.WriteLine($"¡Hola, {nombre}!Bienvenido a EDUSEX.") ;
            Console.WriteLine($"Edad registrada: { edad} años\n");

            // Menú principal
            while (!salir)
            {
                Console.WriteLine("\n ===============");
                Console.WriteLine("MENÚ PRINCIPAL");
                Console.WriteLine("===============n");
                Console.WriteLine("1.Información sobre anticonceptivos");
                Console.WriteLine("2.Evaluar riesgo de embarazo");
                Console.WriteLine("3.Ver si necesita atención médica");
                Console.WriteLine("4.Recomendación Psicologica");
                Console.WriteLine("5. ¿Qué es la educación sexual ?");
                Console.WriteLine("6.Salir");
                Console.Write("Opción: ");
                opcion = Console.ReadLine();
                Console.Clear();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("\nMétodos anticonceptivos:");
                        Console.WriteLine("-Preservativo(masculino / femenino): evita embarazos y enfermedades.");
                        Console.WriteLine("-Pastillas anticonceptivas: deben tomarse diariamente.");
                        Console.WriteLine("-DIU: colocado por un médico, dura años.");
                        Console.WriteLine("-Inyecciones: mensuales o trimestrales.");
                        Console.WriteLine("-Implante subdérmico: debajo de la piel, dura años.");
                        Console.WriteLine("-Métodos naturales: menos seguros.");
                        break;

                    case "2":
                        Console.Write("\n¿Tuviste relaciones sexuales sin protección ? (s / n) : ");
                        string respuesta = Console.ReadLine().ToLower();
                        if (respuesta == "s")
                        {
                            if (edad > 0 && edad < 18)
                            {
                                Console.WriteLine("Hay riesgo de embarazo y sos menor de edad.Es importante buscar orientación médica.");
                            }
                            else
                            {
                                Console.WriteLine("Hay riesgo de embarazo.Se recomienda hacer una prueba.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("El riesgo es bajo si usaste protección correctamente.");
                        }
                        break;

                    case "3":
                        Console.Write("\n¿Tenés dolor fuerte, sangrado, dolor o síntomas extraños en tu zona vaginal ? (s / n) : ");
    
                        string respuestaMedica = Console.ReadLine().ToLower();
                        if (respuestaMedica == "s")
                        {
                            Console.WriteLine("Es recomendable ir a un centro de salud.");
                        }
                        else
                        {
                            Console.WriteLine("Parece que no es urgente.Igualmente, los chequeos son importantes.");
                        }
                        break;

                    case "4":
                        Console.Write("\n¿Has hablado con tu familiar, pareja sobre los síntomas que sientes ? (s / n) : ");
                        respuestPsico = Console.ReadLine().ToLower();
                        if (respuestPsico == "s")
                        {
                            Console.WriteLine("Si por ahora no tienes problemas con tus seres queridos.Recomendamos que sigas obtenieneo conocimientos acerca de como llevar estas etapas de la mejor manera");
                            Console.WriteLine("una vida sexual responsable y segura");
                        }
                        else
                        {
                            Console.WriteLine("Te recomendamos acudir a una cita médica con un profesional.Tu vida y salud es algo primordial.");

                        }
                        break;

                    case "5":
                        Console.WriteLine("\nEducación sexual:");
                        Console.WriteLine("Es el proceso de aprender sobre el cuerpo, partes íntimas, emociones, respeto, relaciones y prevención.");
                        Console.WriteLine("Ayuda a tomar decisiones informadas, evitar embarazos no deseados y proteger la salud sexual.");
                        break;

                    case "6":
                        Console.WriteLine($"Gracias por usar la aplicación EDUSEX, {nombre}. ¡Hasta pronto!");
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida.Intente otra vez.");
                    break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresione Enter para continuar…");
                    Console.ReadLine();
                    Console.Clear();
                }

            }
                    
        }//Fin del main
    }
}
