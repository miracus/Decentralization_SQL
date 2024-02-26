using Dapper;
using ReportingSystem.Data.SQL;
using System.Threading.Tasks;

namespace Decentralization.SQL
{
    public class CreateTables
    {
        public async Task Areas()
        {
            if (!new TablesIsExist().Areas())
            {
                await new CreateTable().Areas();
            }
        }
        public async Task Regions()
        {
            if (!new TablesIsExist().Regions())
            {
                await new CreateTable().Regions();
            }
        }
        public async Task Communities()
        {
            if (!new TablesIsExist().Communities())
            {
                await new CreateTable().Communities();
            }
        }
    }
}
