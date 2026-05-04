namespace BlazorXivComponents;

public enum Theme
{
    Dark,
    Light,
    Classic,
    ClearBlue,
    ClearWhite,
    ClearGreen
}

internal static class ThemeExtensions
{
    extension(Theme theme)
    {
        public string CssClass => theme switch
        {
            Theme.Dark => "dark",
            Theme.Light => "light",
            Theme.Classic => "classic",
            Theme.ClearBlue => "clear blue",
            Theme.ClearWhite => "clear white",
            Theme.ClearGreen => "clear green",
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}