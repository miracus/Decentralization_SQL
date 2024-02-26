using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Decentralization.Models
{
    public class Area
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("square")]
        public double? Square { get; set; }

        [JsonPropertyName("population")]
        public int? Population { get; set; }

        [JsonPropertyName("local_community_count")]
        public int? LocalCommunityCount { get; set; }

        [JsonPropertyName("percent_communities_from_area")]
        public double? PercentCommunitiesFromArea { get; set; }

        [JsonPropertyName("sum_communities_square")]
        public double? SumCommunitiesSquare { get; set; }
    }

    public class AreaResponse
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public List<Area> areas { get; set; }
    }
}
