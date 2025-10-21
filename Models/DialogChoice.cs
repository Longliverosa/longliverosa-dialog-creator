namespace DialogCreator.Models
{
    public class DialogChoice
    {
        public string Identifier { get; set; } = Utilities.Utilities.GetRandomIdentifier();
        public DialogNode? DialogNode { get; set; } = null;
        public string Text { get; set; } = string.Empty;
    }
}
