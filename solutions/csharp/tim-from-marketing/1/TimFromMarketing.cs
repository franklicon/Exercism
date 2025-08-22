static class Badge
{
    private const string Owner = "owner";
    public static string Print(int? id, string name, string? department)
    {
        var badge = id is null ? "" : $"[{id}] - ";
        badge += $"{name} - ";
        badge += (department ?? Owner).ToUpper();
        return badge;
    }
}
