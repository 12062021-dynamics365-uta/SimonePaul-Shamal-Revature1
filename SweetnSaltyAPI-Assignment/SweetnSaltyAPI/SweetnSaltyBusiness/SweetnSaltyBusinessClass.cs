using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SweetnSaltyDbAccess;
using SweetnSaltyModels;


namespace SweetnSaltyBusiness
{
    public class SweetnSaltyBusinessClass : ISweetnSaltyBusinessClass
    {
        private readonly ISweetnSaltyDbAccessClass _dbAccess;
        private readonly IMapper _mapper;

        public SweetnSaltyBusinessClass(ISweetnSaltyDbAccessClass Dbaccess, IMapper mapper)//you need a reference to the DbAccess Layer 
        {
            _mapper = mapper;
            _dbAccess =Dbaccess;
        }

        public async Task<Flavor> PostFlavor(string flavor_Name)
        {
            MySqlDataReader rdr = await _dbAccess.PostFlavor(flavor_Name);
            if (rdr.Read())
            {
                Flavor postFlavor = _mapper.EntityToFlavor(rdr);

                return postFlavor;
            }
            else
            {
                return null;
            }
        }

        public async Task<Person> PostPerson(string person_FName, string person_LName)
        {
            MySqlDataReader dr = await _dbAccess.PostPerson(person_FName, person_LName);
            if (dr.Read())
            {
                Person postPerson = _mapper.EntityToPerson(dr);

                return postPerson;
            }
            else
            {
                return null;
            }
        }



        public async Task<Person> GetPerson(string person_FName, string person_LName)
        {
            MySqlDataReader r = await _dbAccess.GetPerson(person_FName, person_LName);
            if (r.Read())
            {
                Person getPerson = _mapper.EntityToPerson(r);

                return getPerson;
            }
            else
            {
                return null;
            }
        }

        //public async Task<Person> GetPersonFavFlavor(int person_Id)
        //{
        //    MySqlDataReader dr = await _dbAccess.GetPersonFavFlavor(person_Id);
        //    if (dr.Read())
        //    {
        //        Person getFavflav = _mapper.EntityToPerson(dr);

        //        return getFavFlav;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

      

        public async Task<List<Flavor>> GetFlavors()
        {
            MySqlDataReader d = await _dbAccess.GetFlavors();

            List<Flavor> getFlavor = _mapper.EntityToListFlavor(d);
                return getFlavor;
        }
            
    }




    
}
