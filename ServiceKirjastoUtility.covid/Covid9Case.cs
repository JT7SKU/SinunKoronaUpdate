using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ServiceKirjastoUtility.covid
{

    public partial class Covid9Case
    {
        [JsonPropertyName("link")]
        public Link Link { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("class")]
        public string Class { get; set; }

        [JsonPropertyName("updated")]
        public DateTimeOffset Updated { get; set; }
    }

    public partial class Link
    {
        [JsonPropertyName("item")]
        public List<Item> Item { get; set; }
    }

    public partial class Item
    {
        [JsonPropertyName("href")]
        public Uri Href { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("class")]
        public string Class { get; set; }
    }
}