using System;
using System.Collections.Generic;
using System.Text;
using static System.Console; 

namespace rpg{
    public class Hero{
        
        public int X { get; set;}
        public int Y { get; set;}
        public int health {get; set;}
        public int damage {get; set;}
        public string HeroIcon;
        private ConsoleColor PlayerColor;

        
        public Hero(int initialX, int initialY){
            X = initialX;
            Y = initialY;
            health = 25;
            damage = 1;
            HeroIcon = "H";
            PlayerColor = ConsoleColor.Blue;
        }

        public void Draw(){
            
            ForegroundColor = PlayerColor;
            SetCursorPosition(X, Y);
            Write(HeroIcon);
            ResetColor();
        }

        public void Attack(){
            
        }
        //attack monster test
        // public void Attack(Monster monster){
        //     Console.WriteLine("Vida atual do monstro é {0}", monster.health);
        //     Console.WriteLine("Atacando Monstro...");
        //     monster.health--;
        //     Console.WriteLine("Vida atual do monstro é {0}", monster.health);

        // }
        public void Attack(Boss boss){}
        

    
            
        }
}