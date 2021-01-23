using ObjectOrientedProgramming2.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming2.Manager
{
    class ApplyCredit
    {
        public void Apply(ICreditService creditManager,ILoggerService loggerService = null) 
        {
            //Başcuru bilgileri değerlendirme
            //...

            //Yanlış Kullanım
            //MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();
            //mortgageLoanManager.Calculate();

            creditManager.Calculate();
            if (loggerService != null)
            {
                loggerService.Log();
            }
           
        }

        public void ApplyInfo(List<ICreditService> credits) 
        {
            foreach (var credit in credits)
            {
                credit.Info();
            }
        }
    }
}
