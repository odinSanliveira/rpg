using System;

namespace rpg{

    public class Potion{
        int healthPoint  = 6;  //health point

        public int restoreHealth(){
            Console.WriteLine("Restaurando {0} de vida do Herói", healthPoint);
            return healthPoint;
        }


    }
}