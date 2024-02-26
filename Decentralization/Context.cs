using System.Data;
using System.Data.SqlClient;

namespace Decentralization
{
    public static class Context
    {
        public static IDbConnection Connect 
        {
            get
            {
                return new SqlConnection("Server=localhost\\SQLEXPRESS;Database=Decentralization;Trusted_Connection=True;");
            }
        }
    }
}
