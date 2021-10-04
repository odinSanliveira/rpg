using System;   

namespace rpg
{
    class Program
    {
        static void Main(string[] args)
        {   //Como relacionar objeto com letra na posição do grid?
            //instancia de objeto
            // Hero frodo = new Hero();

            Monster Orc  = new Monster();

            Print2DGrid();
            
            


        }

        // Dictionary<string, int> direction = new Dictionary<string, int>
        // {
        //     ["w"] = new int[] { -1, 0},
        //     ["a"] = new int[] { 0, -1},
        //     ["s"] = new int[] {1, 0},
        //     ["d"] = new int[] {0, 1};
        // }

        public static void Print2DGrid(){
            Hero frodo = new Hero();
            string[,]table = new string[20,20];
            //add inside a method
            for (var i = 0; i < table.GetLength(0); i++)
            {
                for (var j = 0; j < table.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                    {
                        table[i , j] = frodo.icon;
                        
                    }else if(i == 19 && j == 19){
                        
                        table[i , j] = "D";
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

            PlayGame();
            
               
                
              
               
            
                
        }

        public static void PlayGame(){
             //console readkey first test
                Print2DGrid();
                ConsoleKeyInfo comando;                
            do{
                 Console.WriteLine("====================================================");
                Console.WriteLine("[W] To move up   " + "[S] To move down");
                Console.WriteLine("[A] To move left   " + "[D] To move right");
                Console.WriteLine("[SPACE] To move up   " + "[ESC] To move Down");
                Console.WriteLine("====================================================");
                comando = Console.ReadKey();
                Console.Write(" --- You pressed ");
                if((comando.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
                if((comando.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
                if((comando.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");

                
                Console.WriteLine(comando.Key.ToString());
            }while(comando.Key != ConsoleKey.Escape);
        }
    }
}
