namespace BlazorXivComponents;

public record XivMenuOptions<T>(string Label, IEnumerable<XivMenuOption<T>> Options);

public record XivMenuOption<T>
{
    public XivMenuOption(string label, T value)
    {
        Label = label;
        Value = value;
    }

    public XivMenuOption(string label, Uri url)
    {
        Label = label;
        Url = url.ToString();
    }

    public string Label { get; }
    public T? Value { get; }
    public string? Url { get; }
}