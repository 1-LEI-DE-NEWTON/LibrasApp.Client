using System.Text.Json.Serialization;

namespace LibrasApp.Shared.Models
{
    public class ReactionStep
    {
        public int Step { get; set; }
        [JsonPropertyName("libra")]
        public string? Libra { get; set; }
        [JsonPropertyName("portuguese")]
        public string? Portuguese { get; set; }
    }

    public class Reaction
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        [JsonPropertyName("steps")]
        public List<ReactionStep>? Steps { get; set; }
    }
}