namespace DialogCreator.Models
{
    public class DialogText(string identifier)
    {
        public string Identifier { get; set; } = identifier;
        public string Text { get; set; } = string.Empty;
        public required DialogSpeaker Speaker { get; set; } 
    }
}
