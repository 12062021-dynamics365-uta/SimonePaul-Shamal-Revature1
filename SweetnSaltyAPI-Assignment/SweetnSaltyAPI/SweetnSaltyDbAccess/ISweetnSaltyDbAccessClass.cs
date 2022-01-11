using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SweetnSaltyDbAccess
{
    public interface ISweetnSaltyDbAccessClass
    {
        Task<MySqlDataReader> PostFlavor(string flavor_Name);
        Task<MySqlDataReader> PostPerson(string person_FName, string person_LName);
        Task<MySqlDataReader> GetPerson(string person_FName, string person_LName);
       // Task<MySqlDataReader> GetPersonFavFlavor(int person_Id);
        Task<MySqlDataReader> GetFlavors();
        
    }
}
