using System;

namespace Taller_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char Seguir = 'S';
            do
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.SetCursorPosition(10, 1); Console.WriteLine("Promedio de materia");
                Console.SetCursorPosition(0, 3); Console.Write("Ingrese nota 1: "); float a = float.Parse(Console.ReadLine());
                Console.Write("Ingrese nota 2: "); float b = float.Parse(Console.ReadLine());
                Console.Write("Ingrese nota 3: "); float c = float.Parse(Console.ReadLine());
                float total = (a+b+c)/3;
                Console.WriteLine("Promedio : {0}",total);
                if(total>=3)
                {
                    Console.WriteLine("Aprobado");
                }
                else
                {
                    Console.WriteLine("Reprobado");
                }
                Console.Write("Desea seguir ejecutanto [S/N]: "); Seguir = char.ToUpper(char.Parse(Console.ReadLine())); 
            } while (Seguir == 'S');
        }
    }
}
