public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as FacialFeatures);
    }

    private bool Equals(FacialFeatures other)
    {
        return other.EyeColor == EyeColor && other.PhiltrumWidth == PhiltrumWidth;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(EyeColor, PhiltrumWidth);
    }
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Identity);
    }

    private bool Equals(Identity? facialFeatures)
    {
        return Email == facialFeatures.Email && 
               FacialFeatures.Equals(facialFeatures.FacialFeatures);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Email, FacialFeatures.EyeColor, FacialFeatures.PhiltrumWidth);
    }
}

public class Authenticator
{
    private const string adminEmail = "admin@exerc.ism";
    private const string adminEyeColor = "green";
    private const decimal adminPhiltrumWidth = 0.9m;
    private HashSet<Identity> identities = [];
    
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return faceA.Equals(faceB);
    }

    public bool IsAdmin(Identity identity)
    {
        var admin = new Identity(adminEmail, new FacialFeatures(adminEyeColor, adminPhiltrumWidth));
        return admin.Equals(identity);
    }

    public bool Register(Identity identity)
    {
         return identities.Add(identity);
    }

    public bool IsRegistered(Identity identity)
    {
        return identities.Contains(identity);
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return identityA == identityB;
    }
}