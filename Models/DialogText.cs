namespace DialogCreator.Models
{
    public class DialogText
    {
        public string Identifier { get; set; } = Utilities.Utilities.GetRandomIdentifier();
        public string Text { get; set; } = string.Empty;
        public required DialogSpeaker Speaker { get; set; } 
    }
}
