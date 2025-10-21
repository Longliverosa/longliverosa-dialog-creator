namespace DialogCreator.Models
{
    public class DialogNode
    {
        public string Identifier { get; set; } = Utilities.Utilities.GetRandomIdentifier();
        public List<DialogText> Text { get; set; } = [];
        public List<DialogChoice> Choices { get; set; } = [];

    }
}
