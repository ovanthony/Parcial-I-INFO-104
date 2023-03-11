using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialI
{
    internal class Clsmenu
    {
        public static int[] NumFac = new int[15];
        public static string[] NumPlac = new string[15];
        public static string[] Fecha = new string[15];
        public static string[] Hora = new string[15];
        public static int[] Tipo = new int[15];
        public static int[] NumCas = new int[15];
        public static float[] MontoPagar = new float[15];
        public static float[] MontoPagado = new float[15];
        public static float[] Vuelto = new float[15];
        public static int i;

        public static void Menu()
        {
            int input;

            do
            {
                Console.Clear();

                Console.WriteLine("==== Menú ====");
                Console.WriteLine("1. Inicializar vectores.");
                Console.WriteLine("2. Ingresar paso vehicular.");
                Console.WriteLine("3. Consulta de vehiculos por número de placa.");
                Console.WriteLine("4. Modificar datos vehiculares por número de placa.");
                Console.WriteLine("5. Reporte todos los datos.");
                Console.WriteLine("6. Salir.");

                Console.Write("Seleccione una opción: ");
                string opc = Console.ReadLine();
                
                if (!int.TryParse(opc, out input))
                {
                    Console.WriteLine("\nOpción inválida. Ingrese un número del 1 al 6.");
                    Console.ReadKey();
                    continue;
                }

                switch (input)
                {
                    case 1:

                        for (int i = 0; i < NumPlac.Length; i++)
                        {
                            NumFac[i] = 0;
                            NumPlac[i] = "";
                            Fecha[i] = "";
                            Hora[i] = "";
                            Tipo[i] = 0;
                            NumCas[i] = 0;
                            MontoPagar[i] = 0;
                            MontoPagado[i] = 0;
                            Vuelto[i] = 0;
                        }
                        i = 0;

                        Console.WriteLine("\n**Vectores inicializados correctamente.**");
                        Console.ReadKey();
                        break;

                    case 2:
                        ClsTransacciones.Ingresar();
                        break;
                    case 3:
                        ClsTransacciones.Consultar();
                        break;
                    case 4:
                        ClsTransacciones.Modificar();
                        break;
                    case 5:
                        ClsTransacciones.Reporte();
                        break;
                    default:
                        Console.WriteLine("\n**Gracias por utilizar el programa**");
                        Console.ReadKey();
                        break;
                }

            } while (input != 6);

        }

    }
}
