using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Decentralization.Models
{
    public class Region
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("area_id")]
        public int? AreaId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("square")]
        public double? Square { get; set; }

        [JsonPropertyName("population")]
        public double? Population { get; set; }
    }

    public class RegionResponse
    {
        public DataRegion data { get; set; }
    }

    public class DataRegion
    {
        public List<Region> regions { get; set; }
    }
}
