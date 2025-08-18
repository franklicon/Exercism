public static class Identifier
{
    public static string Clean(string identifier)
    {
        string result = string.Empty;
        int n = identifier.Length;
        for(var i = 0; i < n; i++)
        {
            if(identifier[i] == ' ')
            {
                result += '_';
            }
            else if(Char.IsControl(identifier[i]))
            {
                result += "CTRL";
            }
            else if(identifier[i] == '-' && i < n)
            {
                result += Char.ToUpper(identifier[++i]); 
            }
            else if(!Char.IsLetter(identifier[i])
                   || (945 <= (int)identifier[i] && identifier[i] <= 969))
            {
                continue;
            }
            else
            {
                result += identifier[i];
            }  
        }
        
        return result;
    }
}
