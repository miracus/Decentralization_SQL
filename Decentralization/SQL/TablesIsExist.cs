using Dapper;

namespace Decentralization.SQL
{
    public class TablesIsExist
    {
        public bool Areas()
        {
            using (var database = Context.Connect)
            {
                var tableExistsQuery = "SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Areas'";
                var tableExists = database.QueryFirstOrDefault<int>(tableExistsQuery);

                if (tableExists == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        
        public bool Regions()
        {
            using (var database = Context.Connect)
            {
                var tableExistsQuery = "SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Regions'";
                var tableExists = database.QueryFirstOrDefault<int>(tableExistsQuery);

                if (tableExists == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        
        public bool Communities()
        {
            using (var database = Context.Connect)
            {
                var tableExistsQuery = "SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Communities'";
                var tableExists = database.QueryFirstOrDefault<int>(tableExistsQuery);

                if (tableExists == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
