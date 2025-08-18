using System.Collections.ObjectModel;
public class Authenticator
{
    private readonly Identity admin;
    private IDictionary<string, Identity> developers
        = new Dictionary<string,Identity>
        {
            ["Bertrand"] = new Identity("bert@ex.ism", "blue"),

            ["Anders"] = new Identity("anders@ex.ism", "brown"),
        };
    
    private class EyeColor
    {
        public const string Blue = "blue";
        public const string Green = "green";
        public const string Brown = "brown";
        public const string Hazel = "hazel";
        public const string Grey = "grey";
    }

    public Authenticator(Identity admin)
    {
        this.admin = admin;
        
    }

    public Identity Admin
    {
        get { return admin; }
    }

    public IDictionary<string, Identity> GetDevelopers()
    {
        return new ReadOnlyDictionary<string, Identity>(developers);
    }
}

public struct Identity
{    
    public string Email { get; set; }

    public string EyeColor { get; set; }

    public Identity(string email, string eyeColor)
    {
        Email = email;
        EyeColor = eyeColor;
    }
}
