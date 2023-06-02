using System;

namespace PROYECTO
{
    class Program
    {
        static string [,] Productos = new string[8,3]
        {
            {"001", "Rosas", "0"},
            {"002", "Girasoles", "13"},
            {"003", "Tulipanes", "30"},
            {"004", "Lirios", "100"},
            {"005", "Margaritas", "25"},
            {"006", "Bugambilias", "50"},
            {"007", "Dalias", "10"},
            {"008", "Cerezos", "75"},
        };

        static void ListarProductos()
        {

            Console.Clear();
            Console.WriteLine("");


            Console.WriteLine("Lista de Productos");
            Console.WriteLine("******************");
            Console.WriteLine("");
            Console.WriteLine("Codigo, Descripcion y Existencia");

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(Productos[i, 0] + " | " + Productos[i, 1] + " | " + Productos[i, 2]);
            }

            Console.ReadLine();
        }

        static void MovimientoInventario(string Codigo, int cantidad, string tipoMovimiento)
        {
            for(int i = 0; i < 8; i++)
            {
                if (Productos[i, 0] == Codigo)
                {
                    if(tipoMovimiento == "+")
                    {
                        Productos[i, 2] = (Int32.Parse(Productos[i, 2]) + cantidad).ToString();
                    }
                    else
                    {
                        Productos[i, 2] = (Int32.Parse(Productos[i, 2]) - cantidad).ToString();
                    }
                }
            }
        }

        static void IngresoDeInventario()
        {
            string Codigo = " ";
            string cantidad = " ";

            Console.Clear();
            Console.WriteLine("");

            Console.WriteLine("Ingreso de Productos al Inventario");
            Console.WriteLine("**********************************");

            Console.Write("Ingrese el codigo del producto: ");
            Codigo = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();
            Console.WriteLine("");

            MovimientoInventario(Codigo, Int32.Parse(cantidad), "+");
        }

        static void SalidaDeProductos()
        {
            string Codigo = " ";
            string cantidad = " ";

            Console.Clear();
            Console.WriteLine("");

            Console.WriteLine("Salida de Productos del inventario");
            Console.WriteLine("**********************************");

            Console.Write("Ingrese el codigo del producto: ");
            Codigo = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();
            Console.WriteLine("");

            MovimientoInventario(Codigo, Int32.Parse(cantidad), "-");
        }

        static void AjusteNegativoDeInventario()
        {
            string Codigo = " ";
            string cantidad = " ";

            Console.Clear();
            Console.WriteLine("");

            Console.WriteLine("Ajuste Negativo del inventario");
            Console.WriteLine("******************************");

            Console.Write("Ingrese el codigo del producto: ");
            Codigo = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();
            Console.WriteLine("");

            MovimientoInventario(Codigo, Int32.Parse(cantidad), "-");
        }

        static void AjustePositivoDeInventario()
        {
            string Codigo = " ";
            string cantidad = " ";

            Console.Clear();
            Console.WriteLine("");

            Console.WriteLine("Ajuste Positivo del inventario");
            Console.WriteLine("******************************");

            Console.Write("Ingrese el codigo del producto: ");
            Codigo = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();
            Console.WriteLine("");

            MovimientoInventario(Codigo, Int32.Parse(cantidad), "+");
        }

        static void Main(string[] args)
        {
            string opcion = " ";

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Sistema de Inventario");
                Console.WriteLine("*********************");
                Console.WriteLine("");

                Console.WriteLine("1 - Productos");
                Console.WriteLine("2 - Ingreso de Inventario");
                Console.WriteLine("3 - Salida de Inventario");
                Console.WriteLine("4 - Ajuste Negativo de Inventario");
                Console.WriteLine("5 - Ajuste Positivo de Inventario");

                Console.WriteLine("0 - Salir");
                Console.WriteLine("");

                Console.Write("Ingrese una opcion del menu: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        ListarProductos();
                    break;
                    case "2":
                        IngresoDeInventario();
                    break;
                    case "3":
                        SalidaDeProductos();
                    break;
                    case "4":
                        AjusteNegativoDeInventario();
                    break;
                    case "5":
                        AjustePositivoDeInventario();
                    break;

                    default:
                    break;
                }

                if (opcion == "0")
                {
                    Console.Clear();
                    break;
                }
            }
        }
     }
 }

