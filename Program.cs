using System;   

namespace rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,]table = new string[20,20];

            for (var i = 0; i < table.GetLength(0); i++)
            {
                // table[i] = "o";
                for (var j = 0; j < table.GetLength(1); j++)
                {
                    table[i , j] = "o";
                }
                // Console.WriteLine();
            }


             for (var i = 0; i < table.GetLength(0); i++)
            {
                // Console.WriteLine(table[i]);
                for (var j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write("{0} ", table[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
