namespace BlazorXivComponents;

public record XivPopupOptions<T>
{
    public XivPopupOptions(ICollection<XivPopupButton<T>>? buttons = null)
    {
        Buttons = buttons ?? [];
    }

    public XivPopupOptions(XivPopupType type)
    {
        Buttons = type.CreatePopupButtons() as ICollection<XivPopupButton<T>> ??
                  throw new InvalidOperationException("Creating buttons failed, is input correct?");
    }

    public required string Label { get; init; }

    public required string Content { get; init; }

    public ICollection<XivPopupButton<T>> Buttons { get; init; }
    public XivCheckboxOptions? Checkbox { get; init; }
    public string? Warning { get; init; }
}

public record XivPopupButton<T>(string Label, T Value);

public class XivCheckboxOptions
{
    public required string Label { get; init; }
    public bool Checked { get; init; }
    public bool Highlighted { get; init; }
}

public enum XivPopupType
{
    TextOnly,
    Ok,
    OkCancel,
    YesNo
}

public static class XivButtonLabels
{
    public static string Ok => "Ok";
    public static string Cancel => "Cancel";
    public static string Yes => "Yes";
    public static string No => "No";
}

public record XivPopupResult<T>(T Value, bool CheckboxChecked);

public static class Extensions
{
    public static ICollection<XivPopupButton<string>> CreatePopupButtons(this XivPopupType type)
    {
        return type switch
        {
            XivPopupType.TextOnly => [],
            XivPopupType.Ok =>
            [
                new XivPopupButton<string>(XivButtonLabels.Ok, XivButtonLabels.Ok)
            ],
            XivPopupType.OkCancel =>
            [
                new XivPopupButton<string>(XivButtonLabels.Ok, XivButtonLabels.Ok),
                new XivPopupButton<string>(XivButtonLabels.Cancel, XivButtonLabels.Cancel)
            ],
            XivPopupType.YesNo =>
            [
                new XivPopupButton<string>(XivButtonLabels.Yes, XivButtonLabels.Yes),
                new XivPopupButton<string>(XivButtonLabels.No, XivButtonLabels.No)
            ],
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };
    }
}