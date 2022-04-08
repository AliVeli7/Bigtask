using System;

namespace PrintAbleFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Pdf pdf = new Pdf();
            PrintFileGen<Pdf> fileGen = new PrintFileGen<Pdf>();
            fileGen.Print(pdf);
           




        }
    }
}
