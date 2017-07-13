using System;
using System.Data;
using System.Data.SqlClient;

namespace DataManagement.Repository
{
    public class BaseRepository: IDisposable
    {
       protected IDbConnection con;
        public BaseRepository()
        {
            string connectionString = "Data Source=DESKTOP-VH4JD4O\\SQLEXPRESS;Initial Catalog=DataManagement;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;";
            con = new SqlConnection(connectionString);
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
