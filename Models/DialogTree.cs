namespace DialogCreator.Models
{
    public class DialogTree
    {
        public string Title { get; set; } = string.Empty;
        public string Identifier { get; set; } = Utilities.Utilities.GetRandomIdentifier();
        public List<DialogNode> Nodes { get; set; } = [];

    }
}
