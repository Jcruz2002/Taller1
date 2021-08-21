using System;

namespace Taller_3
{
    class Program
    {
        public static class Global
        {
            public static String nombr;
            public static long numCuenta;
            public static long saldo;
        }
        

        static void Main(string[] args)
        {
       
            char Seguir = 'S';
            do
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("Cuenta Bancaria");
                Console.WriteLine(" ");
                Console.WriteLine("1. Capturar informacion");
                Console.WriteLine("2. Consignar a la cuenta");
                Console.WriteLine("3. Retirar de cuenta");
                Console.WriteLine("4. Consultar saldo");
                Console.WriteLine("5. Salir");
                Console.WriteLine();
                Console.Write("Eliga una opcion: "); int x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1: Info(); break;                
                    case 2: Consignacion(); break;
                    case 3: Retirar(); break;
                    case 4: Consultar(); break;
                    default: Seguir = 'N'; break;
                }

            } while (Seguir == 'S');
        }

        public static void Info()
        {
            Console.Clear();
            Console.WriteLine("1. Captura de informacion");
            Console.WriteLine();
            Console.Write("Nombre           : ");  Global.nombr = Console.ReadLine();
            Console.Write("Numero de Cuenta : ");  Global.numCuenta = long.Parse(Console.ReadLine());
            Console.Write("Saldo de apertura: ");  Global.saldo = long.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Pulse Enter para continuar..."); Console.ReadKey();

        }

        public static void Consignacion()
        {
            Console.Clear();
            Console.WriteLine("2. Consignar a la cuenta");
            Console.WriteLine();
            Console.Write("Valor a consignar: "); long consig = long.Parse(Console.ReadLine());
            Global.saldo += consig;
            Console.WriteLine("Consignacion Exitosa");
            Console.WriteLine();
            Console.Write("Pulse Enter para continuar..."); Console.ReadKey();

        }

        public static void Retirar()
        {
            Console.Clear();
            Console.WriteLine("3. Retirar de cuenta");
            Console.WriteLine();
            Console.Write("Valor a retirar: "); long retirar = long.Parse(Console.ReadLine());
            Global.saldo -= retirar;
            Console.WriteLine("Retiro Exitoso");
            Console.WriteLine();
            Console.Write("Pulse Enter para continuar..."); Console.ReadKey();

        }

        public static void Consultar()
        {
            Console.Clear();
            Console.WriteLine("4. Consultar Saldo");
            Console.WriteLine();
            Console.WriteLine("Nombre          : {0}", Global.nombr);
            Console.WriteLine("Numero de cuenta: {0}", Global.numCuenta);
            Console.WriteLine("Total de saldo  : {0}", Global.saldo);
            Console.WriteLine();
            Console.Write("Pulse Enter para continuar..."); Console.ReadKey();
        }

    }
}
