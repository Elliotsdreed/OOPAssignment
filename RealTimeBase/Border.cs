using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeBase
{
    public class Border : RealTimeComponent
    {
         string sprite;
        public void Display()
        {
           Console.SetCursorPosition(1,1);
           Console.Write(sprite);
        }

        public void Initialise()
        {
           sprite ="██████████████████████████████████████████████████████████████████████████\n █                                   █                                    █\n █                                   █                                    █\n █                                   █                                    █\n █                                   █                                    █\n █                                   █                                    █\n █                                   █                                    █\n █                                   █                                    █\n █                                   █                                    █\n █                                   █                                    █\n █                                   █                                    █\n █                                   █                                    █\n █                                   █                                    █\n █                                   █                                    █\n ██████████████████████████████████████████████████████████████████████████";
           
           {

           }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}