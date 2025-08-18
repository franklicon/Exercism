using System.Collections.ObjectModel;
public class Authenticator(Identity admin)
{
    private class EyeColor
    {
        public const string Blue = "blue";
        public const string Green = "green";
        public const string Brown = "brown";
        public const string Hazel = "hazel";
        public const string Grey = "grey";
    }

   private readonly IDictionary<string, Identity> _developers 
        = new Dictionary<string, Identity>
    {
        ["Bertrand"] = new Identity("bert@ex.ism", "blue"),

        ["Anders"] = new Identity("anders@ex.ism", "brown"),
    };

    public Identity Admin { get; } = admin;

    public IDictionary<string, Identity> GetDevelopers()
    {
        return new ReadOnlyDictionary<string, Identity>(_developers);
    }
}

public struct Identity(string email, string eyeColor)
{
    public string Email { get; set; } = email;

    public string EyeColor { get; set; } = eyeColor;
}
