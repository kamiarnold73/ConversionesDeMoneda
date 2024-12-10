using System.Threading.Channels;

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
                        ConvertirDolaresAPesos();
                        break;
                    case "3":
                        ConvertirPesosAEuros();
                        break;
                    case "4":
                        ConvertirEurosAPesos();
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
                Console.WriteLine("3) Pesos a euros");
                Console.WriteLine("4) Euros a pesos");
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

            static void ConvertirDolaresAPesos()
            {
            Console.WriteLine("dolares a pesos");
            Console.WriteLine("Introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoDeCambio);


            Console.WriteLine("Introducir la cantidad de dolares");
            respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal dolares);

            decimal pesos = DolaresAPesos(tipoDeCambio, dolares);
            Console.WriteLine($"Cantidad en pesos: {pesos}");
        }
            static decimal DolaresAPesos(decimal tipoCambio, decimal dolares)
            {
               decimal pesos = 0.00m;
               pesos = dolares / tipoCambio;
               return pesos;
            }

        static void ConvertirPesosAEuros()
        {
            Console.WriteLine("pesos a euros");
            Console.WriteLine("Introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoDeCambio);


            Console.WriteLine("Introducir la cantidad de pesos");
            respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal pesos);

            decimal euros = PesosAEuros(tipoDeCambio, pesos);
            Console.WriteLine($"Cantidad en euros: {euros}");
        }
        static decimal PesosAEuros(decimal tipoCambio, decimal pesos)
        {
            decimal euros = 0.00m;
            euros = pesos / tipoCambio;
            return euros;
        }

        static void ConvertirEurosAPesos()
        {
            Console.WriteLine("euros a pesos");
            Console.WriteLine("Introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoDeCambio);


            Console.WriteLine("Introducir la cantidad de euros");
            respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal euros);

            decimal pesos = EurosAPesos(tipoDeCambio, euros);
            Console.WriteLine($"Cantidad en pesos: {pesos}");
        }
        static decimal EurosAPesos(decimal tipoCambio, decimal euros)
        {
            decimal pesos = 0.00m;
            pesos = euros / tipoCambio;
            return pesos;
        }
    }
    }
