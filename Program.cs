using System;   

namespace rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero mf = new Hero();
            Monster odin  = new Monster();
            Console.WriteLine(mf.damage);

            Console.WriteLine("Dano do Heróis");
            Console.WriteLine(mf.GetDamage());
            Console.WriteLine("Vida do Heróis");
            Console.WriteLine(mf.GetHealthValue());
            Console.WriteLine("Herói vivo?");
            Console.WriteLine(mf.GetAlive());

            Console.WriteLine("Dano do Monstro");
            Console.WriteLine(odin.GetDamage());
            Console.WriteLine("Vida do Monstro");
            odin.GetHealth();

            mf.Attack(odin);
            odin.GetHealth();
            
            


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
                        table[i , j] = "h";
                        
                    }else{
                        table[i , j] = "o";

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
        }
    }
}
