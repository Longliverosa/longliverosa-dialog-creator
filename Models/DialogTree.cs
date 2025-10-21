namespace DialogCreator.Models
{
    public class DialogTree(string identifier)
    {
        public string Title { get; set; } = string.Empty;
        public string Identifier { get; set; } = identifier;
        public List<DialogNode> Nodes { get; set; } = [];

    }
}
