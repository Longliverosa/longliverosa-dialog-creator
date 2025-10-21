using System.Text.Json.Serialization;

namespace DialogCreator.Models
{
    public class DialogChoice(string identifier)
    {
        public string Identifier { get; set; } = identifier;
        [JsonIgnore]
        public DialogNode? DialogNode { get; set; } = null;

        private string? dialogNodeId;
        public string? DialogNodeId
        {
            get => DialogNode?.Identifier ?? dialogNodeId;
            set => dialogNodeId = value;
        }
        public string Text { get; set; } = string.Empty;
    }
}
