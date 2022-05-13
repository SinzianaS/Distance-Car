using System;

namespace distanceCar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var cons = int.Parse(Console.ReadLine());
            var cap = int.Parse(Console.ReadLine());
            int dist;
            dist = cap * 100 / cons;
            
            Console.Write(dist);
        }
    }
}

