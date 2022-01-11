using System;
using System.Data.Common;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SweetnSaltyDbAccess


{
    public class SweetnSaltyDbAccessClass : ISweetnSaltyDbAccessClass
    {
        //"Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;SSL Mode = Required; CertificateFile=C:\folder\client.pfx;CertificatePassword=pass"


        private readonly string ConnString = "server = localhost; User Id = root; Persist Security Info = True; " +
              "database =SweetnSaltyDB; Password = Luapenomis$1985;";

        private readonly MySqlConnection myConn;
        //constructor

        public SweetnSaltyDbAccessClass()
        {
            this.myConn = new MySqlConnection(ConnString);
            myConn.Open();
        }

        public async Task<MySqlDataReader> PostFlavor(string flavor_Name)
        {
            if (string.IsNullOrEmpty(flavor_Name))
            {
                throw new ArgumentException($"'{nameof(flavor_Name)}' cannot be null or empty.", nameof(flavor_Name));
            }

            using MySqlCommand cmd = myConn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = ($"INSERT INTO Flavor (flavor_Name) VALUES ('{flavor_Name}');");
            cmd.Prepare();

            {
                cmd.Parameters.AddWithValue("@flavor_Name", flavor_Name);
                try

                {

                    await cmd.ExecuteNonQueryAsync();
                    using MySqlCommand cmd1 = myConn.CreateCommand();
                    //query to select most recent flavor
                    cmd1.CommandType = System.Data.CommandType.Text;
                    cmd1.CommandText = "SELECT Top 1 * FROM Flavor ORDER BY flavor_Id DESC ";
                    cmd1.Prepare();
                    //Read the data from user input and sned it to my DB
                    {
                        MySqlDataReader rdr = (MySqlDataReader)await cmd1.ExecuteReaderAsync();

                        return rdr;
                    }
                }

                catch (DbException ex)// TODO do something with this exception

                {
                    Console.WriteLine($" There was an exception in SweetNSaltyBusinessClass.PostFlavor {ex})");
                    return null;
                }
            }
        }

        public async Task<MySqlDataReader> PostPerson(string person_FName, string person_LName)
        {


            using MySqlCommand cmd2 = myConn.CreateCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = $"INSERT INTO Person (person_FName, person_LName)VALUES('{person_FName}','{person_LName});";
            cmd2.Prepare();

            {
                cmd2.Parameters.AddWithValue("@person_FName", person_FName);
                cmd2.Parameters.AddWithValue("@person_LName", person_LName);
                try

                {

                    await cmd2.ExecuteNonQueryAsync();

                    using MySqlCommand cmd3 = myConn.CreateCommand();
                    //query to select most recent flavor
                    cmd3.CommandType = System.Data.CommandType.Text;
                    cmd3.CommandText = "SELECT Top 1 * FROM Person ORDER BY person_Id DESC ";
                    cmd3.Prepare();
                    //Read the data from user input and sned it to my DB
                    {
                        MySqlDataReader rdr = (MySqlDataReader)await cmd3.ExecuteReaderAsync();

                        return rdr;
                    }
                }

                catch (DbException ex)// TODO do something with this exception

                {
                    Console.WriteLine($" There was an exception in SweetNSaltyBusinessClass.PostFlavor {ex})");
                    return null;
                }
            }
        }


        public async Task<MySqlDataReader> GetPerson(string person_FName, string person_LName)
        {

            using MySqlCommand cmd4 = myConn.CreateCommand();
            cmd4.CommandType = System.Data.CommandType.Text;
            cmd4.CommandText = "SELECT FROM Person WHERE person_FName = @person_FName AND person_LNAme = @person_LName";
            cmd4.Prepare();
            {
                cmd4.Parameters.AddWithValue("@person_FName", person_FName);
                cmd4.Parameters.AddWithValue("@person_LName", person_LName);
                try

                {

                    await cmd4.ExecuteNonQueryAsync();

                    using MySqlCommand cmd5 = myConn.CreateCommand();
                    //query to select most recent flavor
                    cmd5.CommandType = System.Data.CommandType.Text;
                    cmd5.CommandText = "SELECT Top 1 * FROM Person ORDER BY person_Id DESC ";
                    cmd5.Prepare();
                    //Read the data from user input and sned it to my DB
                    {
                        MySqlDataReader rdr = (MySqlDataReader)await cmd5.ExecuteReaderAsync();

                        return rdr;
                    }
                }

                catch (DbException ex)// TODO do something with this exception

                {
                    Console.WriteLine($" There was an exception in SweetNSaltyBusinessClass.PostFlavor {ex})");
                    return null;
                }
            }
        }
        //    public async Task<MySqlDataReader> GetPersonFavFlavor(int person_Id)
        //    {

        //        using MySqlCommand cmd2 = myConn.CreateCommand();
        //        cmd2.CommandType = System.Data.CommandType.Text;
        //        cmd2.CommandText = "SELECT person_FName, person_LName FROM Person INNER JOIN ON Flavor.flavor_Id = Person.person_Id;";
        //        cmd2.Prepare();
        //        {
        //            cmd2.Parameters.AddWithValue("@person_Id", person_Id);

        //            try

        //            {

        //                MySqlDataReader rdr = await cmd2.ExecuteNonQueryAsync();



        //                return rdr;
        //            }
        //            }

        //            catch (DbException ex)// TODO do something with this exception

        //        {
        //            Console.WriteLine($" There was an exception in SweetNSaltyBusinessClass.PostFlavor {ex})");
        //            return null;
        //        }
        //    }
        //}
        public async Task<MySqlDataReader> GetFlavors()
        {
            try
            {
                using MySqlCommand cmd8 = myConn.CreateCommand();
                cmd8.CommandType = System.Data.CommandType.Text;
                cmd8.CommandText = "SELECT * From Flavor";
                cmd8.Prepare();

                {

                    MySqlDataReader rdr = (MySqlDataReader)await cmd8.ExecuteReaderAsync();
                 return rdr;
                    
                }


            }

            catch (DbException ex)// TODO do something with this exception

            {
                Console.WriteLine($" There was an exception in SweetNSaltyBusinessClass.PostFlavor {ex})");
                return null;

            }
        

               
        }
    }
}


    




        
    

