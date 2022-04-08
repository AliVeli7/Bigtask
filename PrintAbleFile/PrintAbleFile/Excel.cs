using System;
using System.Collections.Generic;
using System.Text;

namespace PrintAbleFile
{
    class Excel : IPrintableFil
    {
        public int RowCount { get; set; }
        public int ColumnCount { get; set; }
        public string FileName { get; set ; }

        public void Print()
        {
            Console.WriteLine("asdfg");
        }
    }
}
