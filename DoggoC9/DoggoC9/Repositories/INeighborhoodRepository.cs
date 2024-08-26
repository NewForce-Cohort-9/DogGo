using DoggoC9.Models;
using Microsoft.Data.SqlClient;

namespace DoggoC9.Repositories
{
    public interface INeighborhoodRepository
    {
        SqlConnection Connection { get; }

        List<Neighborhood> GetAll();
    }
}