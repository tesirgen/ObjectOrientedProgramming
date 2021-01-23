using ObjectOrientedProgramming2.Interface;
using ObjectOrientedProgramming2.Manager;
using System;
using System.Collections.Generic;

namespace ObjectOrientedProgramming2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("************************Kredi Hesaplama************************");
            PersonalFinanceLoanManager personalFinanceLoanManager = new PersonalFinanceLoanManager();
            personalFinanceLoanManager.Calculate();

            VehicleLoanManager vehicleLoanManager = new VehicleLoanManager();
            vehicleLoanManager.Calculate();

            MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();
            mortgageLoanManager.Calculate();

            //YADA
            Console.WriteLine();
            Console.WriteLine("************************YADA************************");
            ICreditService personalFinanceLoanManager2 = new PersonalFinanceLoanManager();
            personalFinanceLoanManager2.Calculate();

            ICreditService vehicleLoanManager2 = new VehicleLoanManager();
            vehicleLoanManager2.Calculate();

            ICreditService mortgageLoanManager2 = new MortgageLoanManager();
            mortgageLoanManager2.Calculate();

            //Başvuru Kısmı
            Console.WriteLine();
            Console.WriteLine("************************Başvuru Kısmı************************");
            ICreditService personalFinanceLoanManager3 = new PersonalFinanceLoanManager();

            ICreditService vehicleLoanManager3 = new VehicleLoanManager();

            ICreditService mortgageLoanManager3 = new MortgageLoanManager();

            ApplyCredit applyCredit = new ApplyCredit();
            applyCredit.Apply(personalFinanceLoanManager3);
            applyCredit.Apply(vehicleLoanManager3);
            applyCredit.Apply(mortgageLoanManager3);

            //Başvuru Bilgilendirme
            Console.WriteLine();
            Console.WriteLine("************************Başvuru Bilgilendirme************************");

            List<ICreditService> creditList = new List<ICreditService>()
            { personalFinanceLoanManager3,vehicleLoanManager3,mortgageLoanManager3};
            applyCredit.ApplyInfo(creditList);


            Console.WriteLine();
            Console.WriteLine("************************Başvuru Kısmı,Loglama Dahil************************");
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            applyCredit.Apply(vehicleLoanManager3, databaseLoggerService);
            applyCredit.Apply(mortgageLoanManager3, fileLoggerService);



        }
    }
}
