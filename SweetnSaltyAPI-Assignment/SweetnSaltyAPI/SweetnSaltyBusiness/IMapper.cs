using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SweetnSaltyModels;

namespace SweetnSaltyBusiness
{
    public interface IMapper
    {
        Flavor EntityToFlavor(MySqlDataReader rdr);
        Person EntityToPerson(MySqlDataReader dr);
        Person EntityToPersonFavFlavor(MySqlDataReader rdr);
        Flavor EntityToListFlavor(MySqlDataReader rdr);


    }
}