using System;

namespace RealTimeBase
{
    public interface IItem
    {
        string ItemName {get; set;}
        void DisplayDetail(int position);
    }
}