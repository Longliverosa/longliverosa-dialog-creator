namespace DialogCreator.Models
{
    public class DialogChoice(string identifier)
    {
        public string Identifier { get; set; } = identifier;
        public DialogNode? DialogNode { get; set; } = null;
        public string Text { get; set; } = string.Empty;
    }
}
