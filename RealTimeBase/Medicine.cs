using System;

namespace RealTimeBase
{
    public class Medicine : IItem
    {

        public string ItemName {get; set;}
        public int IncreaseHealth {get; set;}
        
        public void DisplayDetail(int position)
        {
            Console.SetCursorPosition( 20, 5);
            Console.WriteLine(ItemName);
        }

        public Medicine(string name, int increaseHealth)
        {
            this.ItemName = name;
            IncreaseHealth = increaseHealth;
        }
    
        
    }
}