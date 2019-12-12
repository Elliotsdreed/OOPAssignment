using System;


namespace RealTimeBase
{
    public class Food : IItem
    {

        public string ItemName {get; set;}
        public int IncreaseFullness {get; set;}
        
        public void DisplayDetail(int position)
        {
            Console.SetCursorPosition( 20, 4);
            Console.WriteLine(ItemName);
        }

        public Food(string name, int increaseFullness)
        {
            this.ItemName = name;
            IncreaseFullness = increaseFullness;
        }
    }
}