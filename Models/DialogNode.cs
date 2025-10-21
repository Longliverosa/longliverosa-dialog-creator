namespace DialogCreator.Models
{
    public class DialogNode
    {
        public string Identifier { get; set; } = Utilities.Utilities.GetRandomIdentifier();
        public string Name { get; set; } = string.Empty;
        public List<DialogText> Text { get; set; } = [];
        public List<DialogChoice> Choices { get; set; } = [];

    }
}
