using System;
using System.Collections.Generic;
using System.Text;
using static System.Console; 

namespace rpg
{
    public class Game{

        World worldMap;
        Hero hero;
        Boss boss;
        Monster monster;
        Weapon weapon;
        Potion[] potion;
        Random Random = new Random();

        public void Start(){
            
           

            string[,] map = {
                {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "D"},
            };

            //random position to monsters and boss
            int xAxis = Random.Next(2,8);
            int yAxis =  Random.Next(2,8);
            
            worldMap = new World(map);
            // worldMap.Draw(hero);
            potion = new Potion[8];
            //hero on extreme top left position
            hero = new Hero(0, 0);
            //random position for boss
            boss = new Boss(xAxis, yAxis);
            
            
            //new random value
            //maybe a for loop?
            xAxis = Random.Next(2,8);
            yAxis =  Random.Next(2,8);
            monster = new Monster(xAxis, yAxis);
            
            
            xAxis = Random.Next(2,8);
            yAxis =  Random.Next(2,8);
            weapon = new Weapon(xAxis, yAxis);
            
            //random position axis for potions
            for (var i = 0; i < 8; i++)
            {   
                xAxis = Random.Next(2,8);
                yAxis =  Random.Next(2,8);
                potion[i] = new Potion(xAxis, yAxis);
                // potion.Draw();
                
            }


            // hero.Draw();
            
            RunGame();



        }

        private void DrawMap(){
            Clear();
            //draw map
            worldMap.Draw();
            //draw boss on map
            boss.Draw();            
            
            //get the potions positions
            for (var i = 0; i < 8; i++)
            {   
                potion[i].Draw();
            
                
            }
            //draw monster on map            
            monster.Draw();

            //draw weapon on map            
            weapon.Draw();
            //draw hero on map
            hero.Draw();

           
            
        }
        //player movement
        private void PlayerInput(){
            
            ConsoleKeyInfo command = ReadKey(true);
            ConsoleKey key = command.Key;
            
                //user heath point decreasing
            
                
                switch (key)
                {
                    //hero's health decreases with each step
                    case ConsoleKey.UpArrow:
                        if(worldMap.isPositionWalkable(hero.X, hero.Y-1)){
                            
                            hero.Y -= 1;
                            hero.health--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if(worldMap.isPositionWalkable(hero.X, hero.Y+1)){
                            
                            hero.Y += 1;
                            hero.health--;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                    if(worldMap.isPositionWalkable(hero.X-1, hero.Y)){
                        
                            hero.X -= 1;
                            hero.health--;
                    }
                        break;
                    case ConsoleKey.RightArrow:
                        if(worldMap.isPositionWalkable(hero.X+1, hero.Y)){
                            
                            hero.X += 1;
                            hero.health--;
                        }
                        break;
                   
                    default:
                        break;
                
            }    
            
        }

        private void RunGame(){


            while (true)
            {   
                //draw all set.
                DrawMap();
                //check for player input from keyboard.
                PlayerInput();
                //check the boss movement.
                BossMovement();
                //check if is a hero around of monster
                // IsHeroAroundOfMonster();

                //random potion position
                

                //check if player has reached the goal.
                string elementPosition = worldMap.GetElementAt(hero.X, hero.Y);
                if(elementPosition == "D"){
                    
                    break;

                }else if(elementPosition == "P"){
                    //here is the potion restore statement(test)
                    //will break if there is a "P"
                    break;
                }else if(hero.health == 0){

                    break;
                }
                //give the console a change to render.
                System.Threading.Thread.Sleep(20);
            }
            if(hero.health > 0){
                DisplayComplete();
            }else{
                DisplayFailed();
            }
        }

        private void BossMovement(){
            
            //random values to boss axis
            int randomY = Random.Next(-1,2);
            int randomX = Random.Next(-1,2);

            //below code check if there is a "hero" arround
            
            //up
            if( worldMap.isPositionWalkable(boss.X, boss.Y-1) && randomY == -1 ){
                if( worldMap.GetElementAt(boss.X, boss.Y-1) != "H"){
                    boss.Y -= 1;
                    
                }
            }
            //down
            if(worldMap.isPositionWalkable(boss.X, boss.Y+1)  && randomY == 1 ){
                if(worldMap.GetElementAt(boss.X, boss.Y+1) != "H"){
                    boss.Y += 1;
                    
                }
            }
            //left
            if(worldMap.isPositionWalkable(boss.X-1, boss.Y) && randomX == -1 ){
                if(worldMap.GetElementAt(boss.X-1, boss.Y) != "H" ){
                    boss.X -= 1;
                    
                }
            }
            //right
            if(worldMap.isPositionWalkable(boss.X+1, boss.Y) && randomX == 1 ){
                if(worldMap.GetElementAt(boss.X+1, boss.Y) != "H"){
                    boss.X += 1;
                    
                }
            }
        }
        //display completed journey
        public void DisplayComplete(){
            Clear();
            WriteLine("You've completed the journey!");
        }
        public void DisplayFailed(){
            Clear();
            WriteLine("You've not completed the journey!");
        }

        // public void IsHeroAroundOfMonster(){

        //     if (monster.GetElementAt(monster.X, monster.Y-1, worldMap) == "H")
        //     {
        //         hero.health--;
        //     }
        //     if (worldMap.isHeroThere(monster.X, monster.Y+1))
        //     {
        //         hero.health--;
                
        //     }
        //     if (worldMap.isHeroThere(monster.X-1, monster.Y))
        //     {
        //         hero.health--;
                
        //     }
        //     if (worldMap.isHeroThere(monster.X+1, monster.Y))
        //     {
        //         hero.health--;
                
        //     }
        // }
    }
}