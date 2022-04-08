using System;
using System.Collections.Generic;
using System.Text;

namespace PrintAbleFile
{
    class PrintFileGen<T> where T : IPrintableFil
    {
        public string FileName { get; set; }

        public void Print(T obj)
        {
            Console.WriteLine(obj);
        }
    }
    
}
