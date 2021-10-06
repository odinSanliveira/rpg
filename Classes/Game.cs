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
        Monster monster1;
        Random Random = new Random();
        public void Start(){
            
           

            string[,] map = {
                {"0", "0", "0", "0", "0", "0", "0"},
                {"0", "0", "0", "0", "0", "0", "0"},
                {"0", "0", "0", "0", "0", "0", "0"},
                {"0", "0", "0", "0", "0", "0", "0"},
                {"0", "0", "0", "0", "0", "0", "0"},
                {"0", "0", "0", "0", "0", "0", "D"},
            };

            //random position to monsters and boss
            int xAxis = Random.Next(2,5);
            int yAxis =  Random.Next(2,5);
            
            worldMap = new World(map);
            worldMap.Draw();
            //random position for boss
            boss = new Boss(xAxis, yAxis);
            
            
            //new random value
            //maybe a for loop?
            xAxis = Random.Next(2,5);
            yAxis =  Random.Next(2,5);
            monster1 = new Monster(xAxis, yAxis);


            //hero on extreme top left position
            hero = new Hero(0, 0);
            // hero.Draw();
            
            RunGame();



        }

        private void DrawMap(){
            Clear();
            worldMap.Draw();
            hero.Draw();
            boss.Draw();
            monster1.Draw();
            WriteLine("\n\n\n\n\n===Hero:{0}", hero.health);
            // WriteLine("==== health: {0}", hero.health);
        }
        //player movement
        private void PlayerInput(){
            
            ConsoleKeyInfo command = ReadKey(true);
            ConsoleKey key = command.Key;
            
                //user heath point decreasing
            
                
                switch (key)
                {
                    
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
                //check if is a hero around of monster
                monster1.HeroIsAround(monster1, worldMap, hero);
                //check for player input from keyboard.
                PlayerInput();
                //check the boss movement.
                BossMovement();

                //check if player has reached the goal.
                string elementPosition = worldMap.GetElementAt(hero.X, hero.Y);
                if(elementPosition == "D"){
                    break;
                }else if(elementPosition == "P"){
                    hero.health += 6;
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
            
            int randomY = Random.Next(-1,2);
            int randomX = Random.Next(-1,2);
            // string elementPosition = worldMap.GetElementAt(boss.X, boss.Y);
            // int randomY = -1;
            // int randomX = 0;
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


        public void HeroIsAround(){
            
        }
    }
}