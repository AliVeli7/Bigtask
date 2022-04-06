using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Book:Product
    {
        public string AuthorName;
        public int  PageCount;

        public override void Sell()
        {
            TotalInCome += Price;
            Count -= 1;

        }

        public override void ShowInfo()
        {
            Console.WriteLine($" Name: {Name} Price:{Price} AoythorName:{AuthorName} PageCount:{PageCount}");
        }


        public Book(string name, double price,string authorName, int pageCount):base()
        {
            Name = name;
            Price = price;
            AuthorName = authorName;
            PageCount = pageCount;
        }
    }
}
