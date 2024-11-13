﻿using System.Threading.Channels;

namespace ConversionesDeMoneda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                MostrarMenu();

                string respuestaUsuario=Console.ReadLine();

                switch (respuestaUsuario)
                {
                    case "1":
                        ConvertirPesosADolares();
                        break;
                    case "2":
                        Console.WriteLine("Dolares a pesos");
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                    }
                Console.ReadKey();
                }
                //decimal conversion = PesosADolares(20.43m, 50000m);
                //Console.WriteLine(conversion.ToString("N2"));
            }

            static void MostrarMenu()
            {
                Console.Clear();
                Console.WriteLine("Conversiones");
                Console.WriteLine("1) Pesos a dolares");
                Console.WriteLine("2) Dolares a pesos");
                Console.WriteLine("");
            }
            static void ConvertirPesosADolares() 
            {
            Console.WriteLine("pesos a dolares");
            Console.WriteLine("Introducir tipo de cambio");

            string respuestaUsuario= Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoDeCambio);


            Console.WriteLine("Introducir la cantidad de pesos");
            respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal pesos);

            decimal dolares =PesosADolares(tipoDeCambio, pesos);
            Console.WriteLine($"Cantidad en dolares: {dolares}");
        }
            static decimal PesosADolares(decimal tipoCambio, decimal pesos)
            {
                decimal dolares = 0.00m;
                dolares = pesos / tipoCambio;
                return dolares;
            }
        }
    }
