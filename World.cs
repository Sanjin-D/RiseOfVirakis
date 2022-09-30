using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseOfVirakis
{
    internal class World
    {
        public int X;
        public int Y;


        public int setWorldSize(int x, int y)
        {
            X = x;
            Y = y;
            return 0;
        }
        public void getWorldSize()
        {
            Console.WriteLine("X: " + X + " Y: " + Y);
        }

        public int getArea(int currPosX, int currPosY)
        {
            string currentArea = "";
            if(currPosX < 20 && currPosY < 20 )
            {
                currentArea = "Starting Camp";
            }
            Console.WriteLine(currentArea);
            return 0;
        }
        

    }


}
