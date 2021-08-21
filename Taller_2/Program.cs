using System;

namespace Taller_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char Seguir = 'S';
            int pulsaciones;
            do
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("Numero de pulsaciones");
                Console.Write("Ingrese la edad: "); int edad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese M <- Masculino o F <- Femenino: "); char op = char.ToUpper(char.Parse(Console.ReadLine()));
                
                if(op == 'M')
                {
                    pulsaciones = (210 - edad) / 10;
                }
                else
                {
                    pulsaciones = (220 - edad) / 10;
                }
                Console.WriteLine("Numero de pulsaciones: {0}", pulsaciones);
                Console.WriteLine("Desea seguir ejecutando [S/N]: "); Seguir = char.ToUpper(char.Parse(Console.ReadLine()));

            } while (Seguir == 'S');
            
        }
    }
}
