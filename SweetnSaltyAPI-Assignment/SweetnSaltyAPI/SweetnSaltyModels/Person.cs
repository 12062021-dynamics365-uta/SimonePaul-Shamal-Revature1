using System;
using System.Collections.Generic;

namespace SweetnSaltyModels
{
    public class Person
    {
        public int person_Id { get; set; }
        public string person_FName { get; set; }
        public string person_LName { get; set; }
        public List<Flavor> FavFlavor { get; set; }


        public Person(string person_Fname, string person_Lname)
        {
           
            this.person_FName = person_Fname;
            this.person_LName = person_Lname;

        }
        public Person() { }


    }
}
