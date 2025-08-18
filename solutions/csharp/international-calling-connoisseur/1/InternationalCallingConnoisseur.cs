public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary() => new Dictionary<int, string>();
    
    public static Dictionary<int, string> GetExistingDictionary()
    {
        return new Dictionary<int, string>()
        {
            {1, "United States of America"},
            {55, "Brazil"},
            {91, "India"}
        };
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        return new Dictionary<int, string>()
        {
            { countryCode, countryName }
        };
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.TryAdd(countryCode, countryName);
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.TryGetValue(countryCode, out string? value)
            ? value : string.Empty;
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.ContainsKey(countryCode);
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (existingDictionary.ContainsKey(countryCode))
        {
            existingDictionary[countryCode] = countryName;
        }

        return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        existingDictionary.Remove(countryCode);
        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        string longestCountryName = string.Empty;
        foreach (KeyValuePair<int,string> item in existingDictionary)
        {
            if (item.Value.Length > longestCountryName.Length)
            {
                longestCountryName = item.Value;
            }
        }

        return longestCountryName;
    }
}