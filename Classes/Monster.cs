using System;
using System.Collections.Generic;
using System.Text;
using static System.Console; 
namespace rpg{
    public class Monster{

        public int X { get; set;}
        public int Y { get; set;}
        public int health {get; set;}
        public int damage {get; set;}
        private string PlayerIcon;
        private ConsoleColor PlayerColor;

        public Monster(int initialX, int initialY){
            X = initialX;
            Y = initialY;
            health = 3;
            damage = 1;
            PlayerIcon = "B";
            PlayerColor = ConsoleColor.Green;
        }
        public void Draw(){
            
            ForegroundColor = PlayerColor;
            SetCursorPosition(X, Y);
            Write(PlayerIcon);
            ResetColor();
        }
    }
}