using System;   

namespace rpg
{
    class Program
    {
        static void Main(string[] args)
        {   //Como relacionar objeto com letra na posição do grid?
            //instancia de objeto
            Hero frodo = new Hero();
            Monster Orc  = new Monster();

            Print2DGrid();
            
            


        }

        public static void Print2DGrid(){
            string[,]table = new string[20,20];
            //add inside a method
            for (var i = 0; i < table.GetLength(0); i++)
            {
                for (var j = 0; j < table.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                    {
                        table[i , j] = "H";
                        
                    }else{
                        table[i , j] = "O";

                    }
                }
            }

            //print the grid table
             for (var i = 0; i < table.GetLength(0); i++)
            {
                for (var j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write("{0} ", table[i, j]);
                }
                Console.WriteLine();
            }
            
                Console.WriteLine("====================================================");
                Console.WriteLine("[W] To move up   " + "[S] To move down");
                Console.WriteLine("[A] To move left   " + "[D] To move right");
                Console.WriteLine("[SPACE] To move up   " + "[ESC] To move Down");
                Console.WriteLine("====================================================");
                
                ConsoleKeyInfo comando;
                comando = Console.ReadKey();
        }
    }
}
