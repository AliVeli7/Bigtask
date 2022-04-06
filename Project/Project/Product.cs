using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    abstract class Product
    {
        private static int _id;
        readonly int Id;
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public double TotalInCome;


        public abstract void  Sell();
        public abstract void ShowInfo();

        public Product()
        {
            Id = _id++;
        }
    }
}
