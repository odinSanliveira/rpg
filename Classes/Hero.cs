using System;

namespace rpg{
    public class Hero : Warrior{
        public string icon = 'H';

        public int[] position = new int[0, 0];
        public Hero() : base(){
            this.alive = true;
            this.health = 25;
            this.damage = 1;

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
        

        // public int[] toDirection(string move){

        //     switch (move)
        //     {
        //         case 'w':
        //             return new int[] {-1, 0};
        //         case 'a':
        //             return new int[] {0, -1};
        //         case 's':
        //             return new int[] {1, 0};
        //         case 'd':
        //             return new int[] {0, 1};
        //         default:

        //             return new int[] {0, 0};
        //     }
            
        }
    }
}