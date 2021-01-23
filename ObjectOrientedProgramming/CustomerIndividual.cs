using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    //Entity
    //Inheritance
    public class CustomerIndividual : Customer
    {
        public string IdentificationNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
