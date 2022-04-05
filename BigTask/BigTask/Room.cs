using System;
using System.Collections.Generic;
using System.Text;

namespace BigTask
{
    class Room
    {
        private static int _id=0;
        readonly int Id;
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable = true;


        public override string ToString()
        {
            return ShowInfo();
        }



        public string ShowInfo()
        {

            return $"iD:{Id} Name:{Name} Price:{Price} PersonCapacity:{PersonCapacity} IsAvailable{IsAvailable}";
        }



        public Room()
        {
            Id = _id++;

        }

    }
}
