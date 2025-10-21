using System.Text.Json.Serialization;

namespace DialogCreator.Models
{
    public class DialogChoice(string identifier)
    {
        public string Identifier { get; set; } = identifier;
        [JsonIgnore]
        public DialogNode? DialogNode { get; set; } = null;
        public string? DialogNodeId => DialogNode?.Identifier;
        public string Text { get; set; } = string.Empty;
    }
}
