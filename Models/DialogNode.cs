namespace DialogCreator.Models
{
    public class DialogNode(string identifier)
    {
        public string Identifier { get; set; } = identifier;
        public string Name { get; set; } = string.Empty;
        public List<DialogText> Text { get; set; } = [];
        public List<DialogChoice> Choices { get; set; } = [];

    }
}
