using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseOfVirakis
{
    public class World
    {
        public static int X = 500;
        public static int Y = 500;
        public string currentArea = "";

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
            
            if(currPosX < 20 && currPosY < 20 )
            {
                currentArea = "Starting Camp";
            }
            else if((currPosX > 20 && currPosX < 50) && (currPosY > 20 && currPosY < 50 ))
            {
                currentArea = "Eltherea";
            }
            return 0;
        }
        

    }


}
