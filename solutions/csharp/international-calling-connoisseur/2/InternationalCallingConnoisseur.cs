public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary() => new();
    
    public static Dictionary<int, string> GetExistingDictionary() => new()
    {
        [1] = "United States of America",
        [55] = "Brazil",
        [91] = "India"
    };

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName) => new()
    {
        [countryCode] = countryName
    };

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary[countryCode] = countryName;
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode) =>
        existingDictionary.GetValueOrDefault(countryCode, string.Empty);

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode) =>
        existingDictionary.ContainsKey(countryCode);

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
        _ = existingDictionary.Remove(countryCode);
        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary) =>
        existingDictionary.Count == 0 
            ? string.Empty 
            : existingDictionary.Values.MaxBy(x => x.Length) ?? string.Empty;
}