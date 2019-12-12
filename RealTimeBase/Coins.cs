using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeBase
{
    class Coins : RealTimeComponent
    {
        int startCount;
        int count;
        bool active = true;
        public int TickSpeed { get; set; }

        public Coins(int startValue)
        {
            startCount = startValue;
        }

        public void Display()
        {
            if (active)
            {
               
                Console.SetCursorPosition(4, 4);
                Console.Write("Coins");
                Console.SetCursorPosition(5, 5);
                Console.Write(count);
            }
        }

        public void Initialise()
        {
            TickSpeed = -1;
            count = startCount;
        }

        public void Update()
        {
            if (count > 0)
            {
                count -= TickSpeed;
            }
            else
            {
                active = false;
            }
        }
    }
}
