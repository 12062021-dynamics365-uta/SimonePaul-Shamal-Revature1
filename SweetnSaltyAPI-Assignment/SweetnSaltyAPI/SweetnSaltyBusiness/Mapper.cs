using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SweetnSaltyModels;


namespace SweetnSaltyBusiness
{
    public class Mapper : IMapper
    {
        public Flavor EntityToFlavor(MySqlDataReader rdr)
        {
            return new Flavor()
            {
                //FlavorId = Convert.ToInt32(rdr[0]),
                flavor_Id = rdr.GetInt32(0),

                flavor_Name = rdr[1].ToString(),
            };
        }

        public Person EntityToPerson(MySqlDataReader dr)
        {
            return new Person()
            {
                
                person_Id = dr.GetInt32(0),
                person_FName = dr[1].ToString(),
                person_LName = dr[2].ToString(),
            };
        }


        public Person EntityToPersonFavFlavor(MySqlDataReader r)
        {

            Person person = new Person();
            List<Flavor> flavorList = new List<Flavor>();
            do
            {
                Flavor myflavor = new Flavor()
                {
                    flavor_Id = r.GetInt32(3),
                    flavor_Name = r.GetString(4),
                };
                flavorList.Add(myflavor);
                person = new Person()
                {
                    person_Id = r.GetInt32(0),
                    person_FName = r.GetString(1),
                    person_LName = r.GetString(2),
                    FavFlavor = flavorList
                };
            } while (r.Read());

            return person;


        }
        public List<Flavor> EntityToListFlavor(MySqlDataReader d)
        {
            List<Flavor> myFlavors = new List<Flavor>();
            while (d.Read())
            {
                Flavor flavor = new Flavor()
                {
                    flavor_Id = Convert.ToInt32(d[0]),
                    flavor_Name = d[1].ToString(),
                };

               myFlavors.Add(flavor);

               
            }
            return myFlavors;
        }
        

    }
}

