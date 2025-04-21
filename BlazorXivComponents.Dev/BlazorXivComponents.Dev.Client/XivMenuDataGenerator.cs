namespace BlazorXivComponents.Dev.Client;

public static class XivMenuDataGenerator
{
    public static XivMenuOptions<string> CreateSamplePopupMenu()
    {
        var options = new List<XivMenuOption<string>>
        {
            new("Option 1 (string)", "string value 1"),
            new("Option 2 (url)", new Uri("https://tawmy.dev"))
        };

        return new XivMenuOptions<string>("Sample popup menu", options);
    }
}