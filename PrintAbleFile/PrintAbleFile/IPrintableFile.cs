using System;
using System.Collections.Generic;
using System.Text;

namespace PrintAbleFile
{
    interface IPrintableFil
    {
        public string FileName { get; set; }
        public void Print();
    }
}
