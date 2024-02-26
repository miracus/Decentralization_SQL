using Decentralization.Data;
using Decentralization.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Decentralization
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            try
            {
                await new CreateTables().Areas();
                var areas = await new GetData().Areas();
                await new InsertData().Areas(areas);


                await new CreateTables().Regions();
                var regions = await new GetData().Regions();
                await new InsertData().Regions(regions);


                await new CreateTables().Communities();
                var communities = await new GetData().Communities();
                await new InsertData().Communities(communities);

                Console.Write("Програма завершена. База заповнена");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Виникла помилка: " + ex.Message);
            }
        }
    }
}
