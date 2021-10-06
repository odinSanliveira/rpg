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
        private string MonsterIcon;
        private ConsoleColor MonsterColor;

        public Monster(int initialX, int initialY){
            X = initialX;
            Y = initialY;
            health = 3;
            damage = 1;
            MonsterIcon = "M";
            MonsterColor = ConsoleColor.Green;
        }
        public void Draw(){
            
            ForegroundColor = MonsterColor;
            SetCursorPosition(X, Y);
            Write(MonsterIcon);
            ResetColor();
        }
        public (int, int) GetPosition(){

            return GetCursorPosition();
        }
        public string GetElementAt(int x, int y, World grid){
            string element = grid.GetElementAt(x,y);
            return element;
        }

    
    }
}