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


        //    public Person EntityToPersonFavFlavor(MySqlDataReader rdr)
        //    {

        //        List<Flavor> flavors = new List<Flavor>();
        //        Person person = new Person();

        //                //flavor_Id = Convert.ToInt32(rdr[0]),
        //            person_Id = rdr.GetInt32(0),

        //            person_FName = rdr[1].ToString(),
        //            person_LName = rdr[2].ToString(),
        //            FavFlavor = rdr[3].ToString(),

        //}
        public List<Flavor> EntityToListFlavor(MySqlDataReader rdr)
        {
            List<Flavor> myFlavors = new List<Flavor>();
            while (rdr.Read())
            {
                Flavor flavor = new Flavor()
                {
                    flavor_Id = Convert.ToInt32(rdr[0]),
                    flavor_Name = rdr[1].ToString(),
                };

               
            }
            return myFlavors;
        }
        

    }
}

