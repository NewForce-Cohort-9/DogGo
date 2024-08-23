using DoggoC9.Models;
using Microsoft.Data.SqlClient;

namespace DoggoC9.Repositories
{
    public interface IDogRepository
    {
        SqlConnection Connection { get; }

        List<Dog> GetDogsByOwnerId(int ownerId);
    }
}