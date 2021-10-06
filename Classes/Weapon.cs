using System;
using System.Collections.Generic;
using System.Text;
using static System.Console; 
namespace rpg{
    public class Weapon{
        public int X { get; set;}
        public int Y { get; set;}
        public int damage {get; set;}
        private string WeaponIcon;
        private ConsoleColor WeaponColor;

        public Weapon(int initialX, int initialY){
            X = initialX;
            Y = initialY;
            damage = 1;
            WeaponIcon = "W";
            WeaponColor = ConsoleColor.Yellow;
        }
        public void Draw(){
            
            ForegroundColor = WeaponColor;
            SetCursorPosition(X, Y);
            Write(WeaponIcon);
            ResetColor();
        }
        
    }
}