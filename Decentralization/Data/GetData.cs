using Decentralization.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Decentralization.Data
{
    public class GetData
    {
        public async Task<List<Area>> Areas()
        {
            List<Area> areas = new List<Area>();

            string url = "https://decentralization.gov.ua/graphql";
            string graphqlQuery = "{areas{title,id,square,population,local_community_count,percent_communities_from_area,sum_communities_square}}";

            var client = new RestClient(url);

            var request = new RestRequest();
            request.Method = Method.Post;
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            request.AddParameter("application/json", $"{{\"query\":\"{graphqlQuery}\"}}", ParameterType.RequestBody);

            var response = await client.ExecuteAsync<AreaResponse>(request);

            if (response.IsSuccessful)
            {
                areas = response.Data.data.areas;
                Console.WriteLine(JsonConvert.SerializeObject(areas, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("Помилка при виконанні запиту: " + response.StatusCode);
            }

            return areas;
        }
        public async Task<List<Region>> Regions()
        {
            List<Region> regions = new List<Region>();

            string url = "https://decentralization.gov.ua/graphql";
            string graphqlQuery = "{regions{title, area_id,id,population,square}}";

            var client = new RestClient(url);

            var request = new RestRequest();
            request.Method = Method.Post;
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            request.AddParameter("application/json", $"{{\"query\":\"{graphqlQuery}\"}}", ParameterType.RequestBody);

            var response = await client.ExecuteAsync<RegionResponse>(request);

            if (response.IsSuccessful)
            {
                regions = response.Data.data.regions;
                Console.WriteLine(JsonConvert.SerializeObject(regions, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("Помилка при виконанні запиту: " + response.StatusCode);
            }

            return regions;
        }
        public async Task<List<Community>> Communities()
        {
            List<Community> communities = new List<Community>();

            string url = "https://decentralization.gov.ua/graphql";
            string graphqlQuery = "{communities{title,id,area_id, region_id, created,population,square,council_size,district_size,center,koatuu, site}}";

            var client = new RestClient(url);

            var request = new RestRequest();
            request.Method = Method.Post;
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            request.AddParameter("application/json", $"{{\"query\":\"{graphqlQuery}\"}}", ParameterType.RequestBody);

            var response = await client.ExecuteAsync<CommunityResponse>(request);


            if (response.IsSuccessful)
            {
                communities = response.Data.data.communities;
                Console.WriteLine(JsonConvert.SerializeObject(communities, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("Помилка при виконанні запиту: " + response.StatusCode);
            }

            return communities;
        }
    }
}
