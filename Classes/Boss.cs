using System;
using System.Collections.Generic;
using System.Text;
using static System.Console; 
namespace rpg
{
    public class Boss
    { 
        public int X { get; set;}
        public int Y { get; set;}
        public int health {get; set;}
        public int damage {get; set;}
        private string PlayerIcon;
        private ConsoleColor PlayerColor;
        
        public Boss(int initialX, int initialY){
            X = initialX;
            Y = initialY;
            health = 5;
            damage = 1;
            PlayerIcon = "B";
            PlayerColor = ConsoleColor.Red;
        }

        public void Draw(){
            
            ForegroundColor = PlayerColor;
            SetCursorPosition(X, Y);
            Write(PlayerIcon);
            ResetColor();
        }
        
        
    }
}