using Dapper;
using Decentralization;
using System.Text.Json.Serialization;
using System;
using System.Threading.Tasks;

namespace ReportingSystem.Data.SQL
{
    public class CreateTable
    {
        public async Task Areas()
        {
            using (var database = Context.Connect)
            {
                var query = "CREATE TABLE Areas ( " +
                                "Id INT PRIMARY KEY, " +
                                "Title NVARCHAR(MAX), " +
                                "Square FLOAT, " +
                                "Population FLOAT, " +
                                "LocalCommunityCount INT, " +
                                "PercentCommunitiesFromArea FLOAT, " +
                                "SumCommunitiesSquare FLOAT " +
                            ");";

                await database.ExecuteAsync(query);
            }
        }
        public async Task Regions()
        {
            using (var database = Context.Connect)
            {
                var query = "CREATE TABLE Regions ( " +
                                "Id INT PRIMARY KEY, " +
                                "AreaId INT, " +
                                "Title NVARCHAR(MAX), " +
                                "Square FLOAT, " +
                                "Population FLOAT, " +
                                "FOREIGN KEY(AreaId) REFERENCES Areas(Id)" +
                            ");";

                await database.ExecuteAsync(query);
            }
        }
        public async Task Communities()
        {
            using (var database = Context.Connect)
            {
                var query = "CREATE TABLE Communities ( " +
                                "Id INT PRIMARY KEY, " +
                                "AreaId INT, " +
                                "RegionId INT, " +
                                "Title NVARCHAR(MAX), " +
                                "Created DATETIME, " +
                                "Square FLOAT, " +
                                "Population INT, " +
                                "CouncilSize INT, " +
                                "DistrictSize INT, " +
                                "Center NVARCHAR(MAX), " +
                                "Site NVARCHAR(MAX), " +
                                "Koatuu BIGINT, " +
                                "FOREIGN KEY(RegionId) REFERENCES Regions(Id)," +
                                "FOREIGN KEY(AreaId) REFERENCES Areas(Id)" +
                            ");";

                await database.ExecuteAsync(query);
            }
        }
    }
}


