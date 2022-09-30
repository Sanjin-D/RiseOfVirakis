using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace RiseOfVirakis
{
    internal class Player : Position
    {
        //TODO -> finish all player attributes and start making methods for everything
        public float playerHealth { get; private set; }
        public int playerStrength { get; private set; }
        public int playerLevel { get; private set; }
        public float playerExperience { get; private set; }
        public int playerSpeed { get; private set; }

        public float bagSize { get; private set; }

        private Items.Food item_food = new Items.Food();
        private Items item = new Items();
        private string playerName = "";

        /*
        public Player(int pX, int pY, string pName, float pHealth, int pStrength, int pLevel, float pExperience, int pSpeed)
        {
            currentPositionX = pX;
            currentPositionY = pY;
            playerName = pName;
            playerStrength = pStrength;
            playerExperience = pExperience;
            playerHealth = pHealth;
            playerLevel = pLevel;
            playerSpeed = pSpeed;

        }
        */

        public void increaseHealth()
        {
            playerHealth += item_food.foodBonus;
        }
        public void listItems()
        {
            //gehört gemacht nach item implementierung
            Console.WriteLine(item);
        }
        public void get_Player_Name()
        {
            Console.WriteLine(playerName);
        }
        public string set_Player_Name(string newPlayerName)
        {
            return playerName = newPlayerName;
        }

        public void get_Player_Position()
        {
            Console.WriteLine("X: " + currentPositionX + " Y: " + currentPositionY);

        }
        public void set_Player_Position(int setPlayerPositionX, int setPlayerPositionY)
        {
            currentPositionX = setPlayerPositionX;
            currentPositionY = setPlayerPositionY;

        }

        public void playerMoveForward()
        {
            if(World.Y <= currentPositionY)
            {
                currentPositionY += playerSpeed;
            }
            else
            {
                Console.WriteLine("You reached the end of the world! ");
            }
            
        }
        public void playerMoveBackward()
        {
            if (currentPositionY >= 1)
            {
                currentPositionY -= playerSpeed;
            }
            else
            {
                Console.WriteLine("You reached the end of the world! ");
            }
        }

        public void playerMoveRight()
        {
            if (World.X >= currentPositionX)
            {
                currentPositionX += playerSpeed;
            }
            else
            {
                Console.WriteLine("You reached the end of the world! ");
            }
        }

        public void playerMoveLeft()
        {
            if (currentPositionX >= 1)
            {
                currentPositionX -= playerSpeed;
            }
            else
            {
                Console.WriteLine("You reached the end of the world! ");
            }

        }



    }
}
