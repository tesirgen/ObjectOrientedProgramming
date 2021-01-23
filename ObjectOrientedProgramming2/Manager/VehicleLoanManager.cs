using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming2
{
    public class VehicleLoanManager : ICreditService
    {
        public void Calculate()
        {
            //
            //
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı..");
        }

        public void Info()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı bilgilendirme..");
        }
    }
}
