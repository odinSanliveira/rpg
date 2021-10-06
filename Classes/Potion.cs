using System;
using System.Collections.Generic;
using System.Text;
using static System.Console; 

namespace rpg{
    
    

    public class Potion{
        public int X { get; set;}
        public int Y { get; set;}
        public string PotionIcon;
        private ConsoleColor PotionColor;
        int healthRestore  = 6;  //health point
        
        public Potion(int initialX, int initialY){
            X = initialX;
            Y = initialY;
            PotionIcon = "P";
            PotionColor = ConsoleColor.Green;
        }
        public void Draw(){
            
            ForegroundColor = PotionColor;
            SetCursorPosition(X, Y);
            Write(PotionIcon);
            ResetColor();
        }
        
        //restore hero health function
        public int restoreHealth(){
            Console.WriteLine("Restaurando {0} de vida do Herói", healthRestore);
            return healthRestore;
        }
        public (int, int) GetPosition(){

            return GetCursorPosition();
        }
        public (int, int) GetPositionAt(int x, int y){
            
            return GetCursorPosition();
        }

        

    }
}