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
            PlayerIcon = "M";
            PlayerColor = ConsoleColor.Green;
        }
        public void Draw(){
            
            ForegroundColor = PlayerColor;
            SetCursorPosition(X, Y);
            Write(PlayerIcon);
            ResetColor();
        }
        //need to 
        // public int CheckIfPositionIsNull(int x, int y){
            
        //     if(SetCursorPosition(x, y) != "0"){
        //         SetCursorPosition()
        //     }
        // }

        public void HeroIsAround(Monster m, World grid, Hero h){
            
            if( grid.GetElementAt(m.X, m.Y-1) == "H"){
                // WriteLine("Herói a Esquerda");
                h.health--;
            }
            if( grid.GetElementAt(m.X, m.Y+1) == "H"){
                // WriteLine("Herói a Direita");
                
                h.health--;
                    
            }
            if( grid.GetElementAt(m.X-1, m.Y) == "H"){
                // WriteLine("Herói Acima");
                h.health--;
                    
            }
            if( grid.GetElementAt(m.X+1, m.Y) == "H"){
                // WriteLine("Herói Abaixo");                    
                h.health--;
            }
        }
    }
}