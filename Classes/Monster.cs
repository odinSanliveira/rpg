using System;
namespace rpg{
    public class Monster : Warrior{
        // char icon = 'M';
       
        int defeatedPoint = 5;
        public Monster () : base(){
            this.health = 5;
            this.damage = 1;
        }

        //return defeated point to hero score.
        public int Defeated(){
            Console.WriteLine("Monstro Derrotado!");
            return defeatedPoint;
        }
        public override int GetDamage(){
            return this.damage;
        }

        public override void GetHealth(){
            Console.WriteLine("Método GetHealth de Monstro: " + this.health);
        }

        //Math.Random();
    }
}