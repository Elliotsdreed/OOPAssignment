using System;
using System.Collections.Generic;

namespace RealTimeBase
{
    public class ItemManagement
    {
           public List<IItem> Items = new List<IItem>();
        
        public void AddItem(IItem item)
        {
            Items.Add(item);
        }

        public void DisplayItems()
        {
            int index = 2;
            foreach(IItem item in Items)
            {
                item.DisplayDetail(index);
                index++;
            }
            
        } 
    }
}