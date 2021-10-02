using System;
namespace rpg{
    public class Hero : Warrior{
        
        public Hero() : base(){
            this.alive = true;
            this.health = 25;
            this.damage = 1;
            GetHealth();

        }
         public override void GetHealth(){
            Console.WriteLine("Método GetHealth (Hero): " + health);
        }

        public int GetHealthValue(){
            return this.health;
        }
        // public int GetDamage(){
        //     return this.damage;
        // }
        public bool GetAlive(){

            return this.alive;
        }

        // void IActions.Move(){
        //     Console.WriteLine("Movendo Herói...");
        // }
        
        // //attack in interface action
        // void IActions.Attack(Monster monster){
            
        //     monster.health--;
        //     Console.WriteLine("Atacando Monstro...");
        //     monster.Defeated();
            
        // }

        public void Attack(Monster monster){
            Console.WriteLine("Vida atual do monstro é {0}", monster.health);
            Console.WriteLine("Atacando Monstro...");
            monster.health--;
            Console.WriteLine("Vida atual do monstro é {0}", monster.health);

        }
        public void Attack(Boss boss){}
        
    }
}