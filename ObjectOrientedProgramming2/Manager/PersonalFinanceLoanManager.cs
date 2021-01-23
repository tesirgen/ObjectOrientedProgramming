using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming2
{
    public class PersonalFinanceLoanManager : ICreditService
    {
        public void Calculate()
        {
            //
            //
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı..");
        }

        public void Info()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı bilgilendirme..");
        }
    }
}
