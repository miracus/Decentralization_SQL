using Dapper;
using Decentralization.Models;
using System.Collections.Generic;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Decentralization.SQL
{
    public class InsertData
    {
        public async Task Areas(List<Area> areas)
        {
            using (var database = Context.Connect)
            {

                var query = "INSERT INTO [dbo].[Areas]" +
                                "([Id]" +
                                ",[Title]" +
                                ",[Square]" +
                                ",[Population]" +
                                ",[LocalCommunityCount]" +
                                ",[PercentCommunitiesFromArea]" +
                                ",[SumCommunitiesSquare])" +
                                "VALUES " +
                                "(@Id" +
                                ", @Title" +
                                ", @Square" +
                                ", @Population" +
                                ", @LocalCommunityCount" +
                                ", @PercentCommunitiesFromArea" +
                                ", @SumCommunitiesSquare" +
                            ")";

                foreach (var area in areas)
                {
                    var parameters = new
                    {
                        Id = area.Id,
                        Title = area.Title,
                        Square = area.Square,
                        Population = area.Population,
                        LocalCommunityCount = area.LocalCommunityCount,
                        PercentCommunitiesFromArea = area.PercentCommunitiesFromArea,
                        SumCommunitiesSquare = area.SumCommunitiesSquare
                    };

                    await database.ExecuteAsync(query, parameters);
                }
            }
        }
        public async Task Regions(List<Region> regions)
        {
            using (var database = Context.Connect)
            {

                var query = "INSERT INTO [dbo].[Regions]" +
                                "([Id]" +
                                ",[AreaId]" +
                                ",[Title]" +
                                ",[Square]" +
                                ",[Population])" +
                                "VALUES" +
                                "(@Id" +
                                ", @AreaId" +
                                ", @Title" +
                                ", @Square" +
                                ", @Population" +
                            ")";

                foreach (var region in regions)
                {
                    var parameters = new
                    {
                        Id = region.Id,
                        AreaId = region.AreaId,
                        Title = region.Title,
                        Square = region.Square,
                        Population = region.Population,
                    };

                    await database.ExecuteAsync(query, parameters);
                }
            }
        }
        public async Task Communities(List<Community> communities)
        {
            using (var database = Context.Connect)
            {

                var query = "INSERT INTO [dbo].[Communities]" +
                    "([Id],[AreaId],[RegionId],[Title],[Created],[Square],[Population],[CouncilSize],[DistrictSize],[Center],[Site],[Koatuu])" +
                    "VALUES (@Id, @AreaId, @RegionId, @Title, @Created, @Square, @Population, @CouncilSize, @DistrictSize, @Center, @Site,@Koatuu)";

                foreach (var community in communities)
                {
                    var parameters = new
                    {
                        Id = community.Id,
                        AreaId = community.AreaId,
                        RegionId = community.RegionId,
                        Title = community.Title,
                        Created = community.Created,
                        Square = community.Square,
                        Population = community.Population,
                        CouncilSize = community.CouncilSize,
                        DistrictSize = community.DistrictSize,
                        Center = community.Center,
                        Site = community.Site,
                        Koatuu = community.Koatuu
                    };


                    await database.ExecuteAsync(query, parameters);
                }
            }
        }
    }
}
