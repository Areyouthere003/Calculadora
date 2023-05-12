using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Menu
    {
        private string palabra1;
        string palabra2;
        long numero1;
        long numero2;

        public void Menucito()
        {
            Logica_Operacional llamados = new Logica_Operacional();

            Console.WriteLine("************************************************");
            Console.WriteLine("*╔══╗╔══╗╔╗──╔══╗╔╗╔╗╔╗──╔══╗╔══╗─╔══╗╔═══╗╔══╗*");
            Console.WriteLine("*║╔═╝║╔╗║║║──║╔═╝║║║║║║──║╔╗║║╔╗╚╗║╔╗║║╔═╗║║╔╗║*");
            Console.WriteLine("*║║──║╚╝║║║──║║──║║║║║║──║╚╝║║║╚╗║║║║║║╚═╝║║╚╝║*");
            Console.WriteLine("*║║──║╔╗║║║──║║──║║║║║║──║╔╗║║║─║║║║║║║╔╗╔╝║╔╗║*");
            Console.WriteLine("*║╚═╗║║║║║╚═╗║╚═╗║╚╝║║╚═╗║║║║║╚═╝║║╚╝║║║║║─║║║║*");
            Console.WriteLine("*╚══╝╚╝╚╝╚══╝╚══╝╚══╝╚══╝╚╝╚╝╚═══╝╚══╝╚╝╚╝─╚╝╚╝*");
            Console.WriteLine("************************************************");
            Console.WriteLine("");
            Console.WriteLine("Escoga su operación matemática");
            Console.WriteLine("");
            Console.WriteLine("1) Suma");
            Console.WriteLine("2) Resta");
            Console.WriteLine("3) Multiplicación");
            Console.WriteLine("4) División");
            Console.WriteLine("5) Salir");
            palabra1 = Console.ReadLine();
            numero1 = long.Parse(palabra1);
            switch (numero1)
            {
                case 1:
                    Console.WriteLine("SUMAS");
                    Console.Write("Ingrese el primer número: ");
                    palabra1 = Console.ReadLine();
                    Console.Write("Ingrese el segundo número: ");
                    palabra2 = Console.ReadLine();
                    numero1 = long.Parse(palabra1);
                    numero2 = long.Parse(palabra2);
                    llamados.Sumas(numero1, numero2);
                    Console.ReadKey(); Console.Clear(); Menucito();
                    break;
                case 2:
                    Console.WriteLine("RESTAS");
                    Console.Write("Ingrese el primer número: ");
                    palabra1 = Console.ReadLine();
                    Console.Write("Ingrese el segundo número: ");
                    palabra2 = Console.ReadLine();
                    numero1 = long.Parse(palabra1);
                    numero2 = long.Parse(palabra2);
                    llamados.Restas(numero1, numero2);
                    Console.ReadKey(); Console.Clear(); Menucito();
                    break;
                case 3:
                    Console.WriteLine("MULTIPLICACIÓN");
                    Console.Write("Ingrese el primer número: ");
                    palabra1 = Console.ReadLine();
                    Console.Write("Ingrese el segundo número: ");
                    palabra2 = Console.ReadLine();
                    numero1 = long.Parse(palabra1);
                    numero2 = long.Parse(palabra2);
                    llamados.Multiplicacion(numero1, numero2);
                    Console.ReadKey(); Console.Clear(); Menucito();
                    break;
                case 4:
                    Console.WriteLine("DIVISIÓN");
                    Console.Write("Ingrese el primer número: ");
                    palabra1 = Console.ReadLine();
                    Console.Write("Ingrese el segundo número: ");
                    palabra2 = Console.ReadLine();
                    numero1 = long.Parse(palabra1);
                    numero2 = long.Parse(palabra2);
                    llamados.Division(numero1, numero2);
                    Console.ReadKey(); Console.Clear(); Menucito();
                    break;
                default:
                    Console.WriteLine("Gracias por usar el aplicativo");
                    Console.ReadKey(); Console.Clear();
                    break;
            }
        }
    }
}