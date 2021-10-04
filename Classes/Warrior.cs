using System;
namespace rpg
{
    public class Warrior
    {   
        public bool alive = false;
        public int health {set; get;}
        public int damage {set; get;}
        public int score {set; get;}

        public Warrior(){
            this.health = 0;
            this.damage = 0;
            this.score = 0;

        }


        public virtual void GetHealth(){
            Console.WriteLine("Método GetHealth (z): " + health);
        }
        public virtual int GetDamage(){
            return damage;
        }

    
    }
}