using DoggoC9.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;


namespace DoggoC9.Repositories
{
    public interface IWalkerRepository
    {
        List<Walker> GetAllWalkers();
        Walker GetWalkerById(int id);
    }
}
