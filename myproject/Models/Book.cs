using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace myproject.Models
{
    public class Book
    {
        [JsonPropertyName("id")]
        public int Book_id { get; set; }
        [JsonPropertyName("name")]
        public string Book_name { get; set; }
        [JsonPropertyName("image")]
        public string Book_image { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize<Book>(this);
        }
    }
}
