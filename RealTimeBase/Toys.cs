using System;

namespace RealTimeBase
{
    public class Toys : IItem
    {

        public string ItemName {get; set;}
        public int IncreaseMood {get; set;}
        
        public void DisplayDetail(int position)
        {
            Console.SetCursorPosition( 20, 3);
            Console.WriteLine(ItemName);
        }

        public Toys(string name, int increaseMood)
        {
            this.ItemName = name;
            IncreaseMood = increaseMood;
        }
    
        
    }
}