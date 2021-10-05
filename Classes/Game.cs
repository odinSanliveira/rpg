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
        // Monster monsters;
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

            int xAxis = Random.Next(2,5);
            int yAxis =  Random.Next(2,5);
            WriteLine(xAxis);
            WriteLine(yAxis);
            worldMap = new World(map);
            worldMap.Draw();
            boss = new Boss(xAxis, yAxis);
            hero = new Hero(0, 0);
            hero.Draw();
            
            RunGame();



        }

        private void DrawMap(){
            Clear();
            worldMap.Draw();
            hero.Draw();
            boss.Draw();
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
                            // hero.health--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if(worldMap.isPositionWalkable(hero.X, hero.Y+1)){
                            hero.Y += 1;
                            // hero.health--;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                    if(worldMap.isPositionWalkable(hero.X-1, hero.Y)){
                            hero.X -= 1;
                            // hero.health--;
                    }
                        break;
                    case ConsoleKey.RightArrow:
                        if(worldMap.isPositionWalkable(hero.X+1, hero.Y)){
                            hero.X += 1;
                            // hero.health--;
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

                //check if player has reached the goal.
                string elementPosition = worldMap.GetElementAt(hero.X, hero.Y);
                if(elementPosition == "D"){
                    break;
                }else if(elementPosition == "P"){
                    hero.health += 6;
                }
                //give the console a change to render.
                System.Threading.Thread.Sleep(20);
            }
            DisplayComplete();
        }

        private void BossMovement(){
            
            int randomY = Random.Next(-1,2);
            int randomX = Random.Next(-1,2);
            // string elementPosition = worldMap.GetElementAt(boss.X, boss.Y);
            // int randomY = -1;
            // int randomX = 0;
            //below code check if there is a "hero" arround
            
            //up
            if(randomY == -1 && worldMap.GetElementAt(boss.X, boss.Y-1) != "H"){
                if(worldMap.isPositionWalkable(boss.X, boss.Y-1)){
                    boss.Y -= 1;
                }
            }
            //down
            if(randomY == 1 && worldMap.GetElementAt(boss.X, boss.Y+1) != "H"){
                if(worldMap.isPositionWalkable(boss.X, boss.Y+1)){
                    boss.Y += 1;
                }
            }
            //left
            if(randomX == -1 && worldMap.GetElementAt(boss.X-1, boss.Y) != "H"){
                if(worldMap.isPositionWalkable(boss.X-1, boss.Y)){
                    boss.X -= 1;
                }
            }
            //right
            if(randomX == 1 && worldMap.GetElementAt(boss.X+1, boss.Y) != "H"){
                if(worldMap.isPositionWalkable(boss.X+1, boss.Y)){
                    boss.X += 1;
                }
            }
        }
        //display completed journey
        public void DisplayComplete(){
            Clear();
            WriteLine("You've completed the journey!");
        }
    }
}