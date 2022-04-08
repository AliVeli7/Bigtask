using System;
using System.Collections.Generic;
using System.Text;

namespace PrintAbleFile
{
    class Pdf : IPrintableFil
    {
        public int PageCount { get; set; }
        public string FileName { get ; set; }

        public void Print()
        {
            Console.WriteLine("asdfg");
        }
    }
}
