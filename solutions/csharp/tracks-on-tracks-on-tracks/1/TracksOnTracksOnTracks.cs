public static class Languages
{
    public static List<string> NewList() => [];

    public static List<string> GetExistingLanguages() => ["C#", "Clojure", "Elm"];

    public static List<string> AddLanguage(List<string> languages, string language)
        => languages.Append(language).ToList();

    public static int CountLanguages(List<string> languages) => languages.Count;

    public static bool HasLanguage(List<string> languages, string language)
        => languages.Contains(language);

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
       var index = languages.FindIndex(l => l.Equals("C#", StringComparison.OrdinalIgnoreCase));
        return index == 0
            || (languages.Count is > 1 and < 4 && index == 1);
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.RemoveAll(l => l == language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        var distinct = languages.Distinct().ToList();
        return distinct.Count == languages.Count;
    }
}