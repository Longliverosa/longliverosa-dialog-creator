namespace DialogCreator.Utilities
{
    public static class Utilities
    {
        public static List<string> ExistingIdentifiers { get; set; } = [];
        public static string GetRandomIdentifier()
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
