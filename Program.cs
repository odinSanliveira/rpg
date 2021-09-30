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
                for (var j = 0; j < table.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                    {
                        table[i , j] = "H";
                        
                    }else{
                        table[i , j] = "o";

                    }
                }
            }


             for (var i = 0; i < table.GetLength(0); i++)
            {
                for (var j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write("{0} ", table[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
