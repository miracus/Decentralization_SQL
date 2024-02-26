using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Decentralization.Models
{
    public class Community
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("area_id")]
        public int? AreaId { get; set; }

        [JsonPropertyName("region_id")]
        public int? RegionId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("created")]
        public DateTime Created { get; set; }

        [JsonPropertyName("population")]
        public int? Population { get; set; }

        [JsonPropertyName("square")]
        public double? Square { get; set; }

        [JsonPropertyName("council_size")]
        public int? CouncilSize { get; set; }

        [JsonPropertyName("district_size")]
        public int? DistrictSize { get; set; }

        [JsonPropertyName("center")]
        public string Center { get; set; }

        [JsonPropertyName("koatuu")]
        public string Koatuu { get; set; }

        [JsonPropertyName("site")]
        public string Site { get; set; }

        

    }

    public class CommunityResponse
    {
        public DataCommunity data { get; set; }
    }

    public class DataCommunity
    {
        public List<Community> communities { get; set; }
    }
    
}
