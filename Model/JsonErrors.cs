using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class JsonErrors
    {
        [JsonProperty("invalidFilters")]
        public string[] InvalidFilters { get; set; }
        [JsonProperty("invalidLanguage")]
        public string InvalidLanguage { get; set; }
        [JsonProperty("invalidQueryParams")]
        public string[] InvalidQueryParams { get; set; }
    }
}
