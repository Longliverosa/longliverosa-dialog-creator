namespace DialogCreator.Utilities
{
    public class Utilities
    {
        public List<string> ExistingIdentifiers { get; set; } = [];
        public string GetRandomIdentifier()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();

            var id = string.Empty;
            while (string.IsNullOrEmpty(id) || ExistingIdentifiers.Contains(id))
            {
                id = new string([.. Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)])]);
            }
            ExistingIdentifiers.Add(id);
            return id;
        }
    }
}
