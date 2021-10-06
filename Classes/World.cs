using System;
using System.Collections.Generic;
using System.Text;
using static System.Console; 


namespace rpg
{
    public class World
    {
        private string[,] wideMap;
        private int Rows;
        private int Cols;


        public World(string[,] grid){
            wideMap = grid;
            Rows = wideMap.GetLength(0);
            Cols = wideMap.GetLength(1);
        }

        //print the map
        public void Draw(){
            for (int y = 0; y < Rows; y++){
                for(int x = 0; x < Cols; x++){
                    //check null positions to print elements, hero, boss, potion, etc.
                    string element = wideMap[y, x];
                    SetCursorPosition(x, y);
                    Write(element);
                }
            }
            WriteLine("");
        }

        public bool isPositionWalkable(int x, int y){

            //checking bounds 
            if(x < 0 || y < 0 || x >= Cols || y >= Rows || wideMap[y, x] == "B" || wideMap[y, x] == "M"){
                return false;
            }
            //checking if is walkable position
            /*wideMap[y, x] == "P" || wideMap[y, x] == "W" ||*/
            return wideMap[y, x] == "0" ||  wideMap[y, x] == "D" || wideMap[y, x] == "P";
        }

        public bool isHeroThere(int x, int y){
            if (wideMap[y, x] == "H")
            {
                return true;
            }

                return false;
        
        }

        //check if there is a potion in position
        public bool thereIsPotion(int x, int y){
            
            if (wideMap[y,x] != "P")
            {
                return false;
            }
            return wideMap[y, x] == "P";
        }

        public string GetElementAt(int x, int y){
            //check string in position
            //position of potions and monsters?
            return wideMap[y, x];
        }
    }
}