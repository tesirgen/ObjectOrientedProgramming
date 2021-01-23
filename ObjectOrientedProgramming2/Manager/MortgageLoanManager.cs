using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming2
{
    public class MortgageLoanManager : ICreditService
    {
        public void Calculate()
        {
            //
            //
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı..");
        }

        public void Info()
        {
            Console.WriteLine("Konut kredisi ödeme planı bilgilendirme..");
        }
    }
}
