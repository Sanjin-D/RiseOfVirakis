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

        private float playerHealth { get; set; }
        private int playerStrength { get; set; }
        private int playerLevel { get; set; }
        private float playerExperience { get; set; }
        private int playerSpeed { get; set; }

        public World worldSize = new World();

        public float bagSize { get; set; }

        private Items _item = new Items();



        private string playerName = "";

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

        public void listItems()
        {
            //gehört gemacht nach item implementierung
            Console.WriteLine(_item);
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
            if(worldSize.X <= currentPositionX)
            {
                currentPositionX += playerSpeed;
            }
            else
            {
                Console.WriteLine("You reached the end of the world! ");
            }
            
        }
        public void playerMoveBackward()
        {
            if (worldSize.X >= currentPositionX)
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
