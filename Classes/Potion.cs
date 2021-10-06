using System;
using System.Collections.Generic;
using System.Text;
using static System.Console; 

namespace rpg{
    
    

    public class Potion{
        public int X { get; set;}
        public int Y { get; set;}
        public string PotionIcon;
        private ConsoleColor PlayerColor;
        int healthRestore  = 6;  //health point
        
        public Potion(int initialX, int initialY){
            X = initialX;
            Y = initialY;
            PotionIcon = "P";
            PlayerColor = ConsoleColor.Green;
        }
        public void Draw(){
            
            ForegroundColor = PlayerColor;
            SetCursorPosition(X, Y);
            Write(PotionIcon);
            ResetColor();
        }
        

        public int restoreHealth(){
            Console.WriteLine("Restaurando {0} de vida do Herói", healthRestore);
            return healthRestore;
        }
        public (int, int) GetPosition(){

            return GetCursorPosition();
        }

        

    }
}