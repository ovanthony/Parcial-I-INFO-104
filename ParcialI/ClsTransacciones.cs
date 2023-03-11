using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialI
{
    internal class ClsTransacciones
    {

        public static void Ingresar()
        {

            while (true)
            {

                if (Clsmenu.i == 15)
                {
                    Console.WriteLine("\n**Vectores llenos, por favor limpielos nuevamente**");
                    Console.ReadKey();
                    break;
                }

                Console.Clear();

                Console.Write("¿Desea registrar un nuevo vehículo? S/N\n");
                string opc = Console.ReadLine().ToLower();

                if (opc.Equals("s"))
                {
                    Console.Write("\nIngrese el número de factura: ");
                    Clsmenu.NumFac[Clsmenu.i] = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el número de placa: ");
                    Clsmenu.NumPlac[Clsmenu.i] = Console.ReadLine().ToUpper();
                    Console.Write("Ingrese la fecha: ");
                    Clsmenu.Fecha[Clsmenu.i] = Console.ReadLine();
                    Console.Write("Ingrese la hora: ");
                    Clsmenu.Hora[Clsmenu.i] = Console.ReadLine();

                    do
                    {
                        Console.Clear();
                        Console.Write("Ingrese el tipo de vehículo: ");
                        Console.WriteLine("[1- Moto   2- Vehículo liviano   3- Camión o pesado   4- Autobús]");
                        Clsmenu.Tipo[Clsmenu.i] = int.Parse(Console.ReadLine());

                        if (Clsmenu.Tipo[Clsmenu.i] > 4 || Clsmenu.Tipo[Clsmenu.i] < 1)
                        {
                            Console.WriteLine("\n**Por favor ingrese el tipo de vehículo correcto**");
                            Console.ReadKey();
                        }

                    } while (Clsmenu.Tipo[Clsmenu.i] > 4 || Clsmenu.Tipo[Clsmenu.i] < 1);

                    do
                    {
                        Console.Clear();
                        Console.Write("Ingrese el número de caseta: ");
                        Console.WriteLine("[1- Caseta #1   2- Caseta #2   3- Caseta #3]");
                        Clsmenu.NumCas[Clsmenu.i] = int.Parse(Console.ReadLine());

                        if (Clsmenu.NumCas[Clsmenu.i] > 3 || Clsmenu.NumCas[Clsmenu.i] < 1)
                        {
                            Console.WriteLine("\n**Por favor ingrese el número de caseta correcto**");
                            Console.ReadKey();
                        }

                    } while (Clsmenu.NumCas[Clsmenu.i] > 3 || Clsmenu.NumCas[Clsmenu.i] < 1);

                    switch (Clsmenu.Tipo[Clsmenu.i])
                    {
                        case 1:
                            Clsmenu.MontoPagar[Clsmenu.i] = 700;
                            break;
                        case 2:
                            Clsmenu.MontoPagar[Clsmenu.i] = 2700;
                            break;
                        case 3:
                            Clsmenu.MontoPagar[Clsmenu.i] = 500;
                            break;
                        case 4:
                            Clsmenu.MontoPagar[Clsmenu.i] = 3700;
                            break;
                    }

                    do
                    {
                        Console.Clear();
                        Console.Write("Su monto a pagar es de " + Clsmenu.MontoPagar[Clsmenu.i] + " colones. Ingrese con cuánto paga: ");
                        Clsmenu.MontoPagado[Clsmenu.i] = float.Parse(Console.ReadLine());

                        if (Clsmenu.MontoPagado[Clsmenu.i] < Clsmenu.MontoPagar[Clsmenu.i])
                        {
                            Console.WriteLine("\n**Por favor ingrese un monto válido y mayor al que se necesita pagar**");
                            Console.ReadKey();
                        }

                    } while (Clsmenu.MontoPagado[Clsmenu.i] < Clsmenu.MontoPagar[Clsmenu.i]);

                    Clsmenu.Vuelto[Clsmenu.i] = Clsmenu.MontoPagado[Clsmenu.i] - Clsmenu.MontoPagar[Clsmenu.i];

                    Console.Clear();
                    Console.WriteLine("==== Registro Flujo Vehicular ====");
                    Console.WriteLine("Número de factura: " + Clsmenu.NumFac[Clsmenu.i]);
                    Console.WriteLine("Número de placa: " + Clsmenu.NumPlac[Clsmenu.i]);
                    Console.WriteLine("Fecha: " + Clsmenu.Fecha[Clsmenu.i]);
                    Console.WriteLine("Hora: " + Clsmenu.Hora[Clsmenu.i]);
                    Console.WriteLine("Tipo de vehículo: " + Clsmenu.Tipo[Clsmenu.i]);
                    Console.WriteLine("[1- Moto   2- Vehículo liviano   3- Camión o pesado   4- Autobús]");
                    Console.WriteLine("\nNúmero de caseta: " + Clsmenu.NumCas[Clsmenu.i]);
                    Console.WriteLine("[1- Caseta #1   2- Caseta #2   3- Caseta #3]");
                    Console.WriteLine("\nMonto a pagar: " + Clsmenu.MontoPagar[Clsmenu.i]);
                    Console.WriteLine("Paga con: " + Clsmenu.MontoPagado[Clsmenu.i]);
                    Console.WriteLine("Vuelto: " + Clsmenu.Vuelto[Clsmenu.i]);

                    Console.WriteLine("\n**Presione una tecla para continuar**");
                    Console.ReadKey();

                    Clsmenu.i++;

                }
                else
                {
                    Console.WriteLine("\n**Volviendo al menú principal**");
                    Console.ReadKey();
                    break;
                }

            }
        }

        public static void Consultar()
        {

            while (true)
            {
                Console.Clear();
                Console.Write("¿Desea consultar un vehículo en el registro? S/N\n");
                string opc = Console.ReadLine().ToLower();

                if (opc.Equals("s"))
                {
                    Console.Clear();
                    Console.Write("Ingrese el número de placa: ");
                    String Consult = Console.ReadLine().ToUpper();

                    for (int i = 0; i < Clsmenu.NumPlac.Length; i++)
                    {
                        if (Clsmenu.NumPlac[i] == Consult)
                        {
                            Console.Clear();
                            Console.WriteLine("==== Consulta Flujo Vehicular ====");
                            Console.WriteLine("Número de factura: " + Clsmenu.NumFac[i]);
                            Console.WriteLine("Número de placa: " + Clsmenu.NumPlac[i]);
                            Console.WriteLine("Fecha: " + Clsmenu.Fecha[i]);
                            Console.WriteLine("Hora: " + Clsmenu.Hora[i]);
                            Console.WriteLine("Tipo de vehículo: " + Clsmenu.Tipo[i]);
                            Console.WriteLine("[1- Moto   2- Vehículo liviano   3- Camión o pesado   4- Autobús]");
                            Console.WriteLine("\nNúmero de caseta: " + Clsmenu.NumCas[i]);
                            Console.WriteLine("[1- Caseta #1   2- Caseta #2   3- Caseta #3]");
                            Console.WriteLine("\nMonto a pagar: " + Clsmenu.MontoPagar[i]);
                            Console.WriteLine("Paga con: " + Clsmenu.MontoPagado[i]);
                            Console.WriteLine("Vuelto: " + Clsmenu.Vuelto[i]);

                            Console.WriteLine("\n**Presione una tecla para continuar**");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n**El número de placa consultado no se encuentra registrado**");
                            Console.ReadKey();
                            break;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("\n**Volviendo al menú principal**");
                    Console.ReadKey();
                    break;
                }

            }
        }

        public static void Modificar()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("¿Desea modificar los datos de un vehículo en el registro? S/N\n");
                string opc = Console.ReadLine().ToLower();

                if (opc.Equals("s"))
                {
                    Console.Clear();
                    Console.Write("Ingrese el número de placa: ");
                    String Consult = Console.ReadLine().ToUpper();

                    for (int i = 0; i < Clsmenu.NumPlac.Length; i++)
                    {
                        if (Clsmenu.NumPlac[i] == Consult)
                        {
                            Console.Clear();
                            Console.WriteLine("==== Modificar Flujo Vehicular ====");
                            Console.WriteLine("A- Número de factura: " + Clsmenu.NumFac[i]);
                            Console.WriteLine("B- Número de placa: " + Clsmenu.NumPlac[i]);
                            Console.WriteLine("C- Fecha: " + Clsmenu.Fecha[i]);
                            Console.WriteLine("D- Hora: " + Clsmenu.Hora[i]);
                            Console.WriteLine("E- Tipo de vehículo: " + Clsmenu.Tipo[i]);
                            Console.WriteLine("[1- Moto   2- Vehículo liviano   3- Camión o pesado   4- Autobús]");
                            Console.WriteLine("\nNúmero de caseta: " + Clsmenu.NumCas[i]);
                            Console.WriteLine("[1- Caseta #1   2- Caseta #2   3- Caseta #3]");
                            Console.WriteLine("\nMonto a pagar: " + Clsmenu.MontoPagar[i]);
                            Console.WriteLine("F- Paga con: " + Clsmenu.MontoPagado[i]);
                            Console.WriteLine("Vuelto: " + Clsmenu.Vuelto[i]);

                            Console.Write("\nIngrese el dato a modificar: ");
                            String Mod = Console.ReadLine().ToLower();
                            string opcion = "";

                            do
                            {

                                switch (Mod)
                                {
                                    case "a":
                                        Clsmenu.NumFac[i] = int.Parse(Console.ReadLine());
                                        break;
                                    case "b":
                                        Clsmenu.NumFac[i] = int.Parse(Console.ReadLine());
                                        break;
                                    case "c":
                                        Clsmenu.Fecha[i] = Console.ReadLine();
                                        break;
                                    case "d":
                                        Clsmenu.Hora[i] = Console.ReadLine();
                                        break;
                                    case "e":
                                        break;
                                    case "f":
                                        break;
                                    default:
                                        break;
                                }

                                Console.Write("\n¿Desea modificar otro dato? S/N\n");
                                opcion = Console.ReadLine().ToLower();

                            } while (opcion != "n");

                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n**El número de placa consultado no se encuentra registrado**");
                            Console.ReadKey();
                            break;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("\n**Volviendo al menú principal**");
                    Console.ReadKey();
                    break;
                }
            }

        }

        public static void Reporte()
        {
            Console.Clear();
            bool obs = true;
            int cant = 0;
            float total = 0;

            Console.WriteLine("==== Reporte Flujo Vehicular ====");
            Console.WriteLine("N. Factura  Placa  Tipo de vehículo  Caseta  Monto Pagar  Paga con  Vuelto");
            Console.WriteLine("==========================================================================");

            for (int i = 0; i < Clsmenu.NumPlac.Length; i++)
            {
                if (Clsmenu.MontoPagar[i] > 0)
                {
                    Console.WriteLine(Clsmenu.NumFac[i] + "  " + Clsmenu.NumPlac[i] + "  " + Clsmenu.Tipo[i] + "  " + Clsmenu.NumCas[i] + "  " + Clsmenu.MontoPagar[i] + "  " + Clsmenu.MontoPagado[i] + "  " + Clsmenu.Vuelto[i]);
                    cant++;
                    total += Clsmenu.MontoPagado[i];
                    obs = false;

                }

            }

            if (obs)
            {
                Console.WriteLine("                   **No hay vehículos registrados**");
            }
            Console.WriteLine("==========================================================================");
            Console.WriteLine("Cantidad de vehículos: " + cant + "                                 Total: " + total);
            Console.WriteLine("==========================================================================");

            Console.WriteLine("\n**Presione una tecla para continuar**");
            Console.ReadKey();

        }

    }
}
