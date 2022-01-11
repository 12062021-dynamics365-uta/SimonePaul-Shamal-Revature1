using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SweetnSaltyModels;

namespace SweetnSaltyBusiness
{
    public interface ISweetnSaltyBusinessClass
    {
        Task<Flavor> PostFlavor(string flavor_Name);
        Task<Person> PostPerson(string person_FName, string person_LName);
        Task<Person> GetPerson(string person_FName, string person_LName);
        //Task<Person> GetPersonFavFlavor(int person_Id);
        Task<List<Flavor>> GetFlavors();
    }
}
