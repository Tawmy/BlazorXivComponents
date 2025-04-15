namespace BlazorXivComponents.Dev.Client;

internal static class XivPopupDataGenerator
{
    public static XivPopupOptions<string> CreateTextOnly()
    {
        return new XivPopupOptions<string>(XivPopupType.TextOnly)
        {
            Label = $"{nameof(XivPopupType.TextOnly)}",
            Content = "This is a basic popup without buttons. Refresh page to close."
        };
    }

    public static XivPopupOptions<string> CreateOk()
    {
        return new XivPopupOptions<string>(XivPopupType.Ok)
        {
            Label = $"{nameof(XivPopupType.Ok)}",
            Content = "This is a basic popup with one button."
        };
    }

    public static XivPopupOptions<string> CreateOkCancel()
    {
        return new XivPopupOptions<string>(XivPopupType.OkCancel)
        {
            Label = $"{nameof(XivPopupType.OkCancel)}",
            Content = "This is a basic popup with two buttons."
        };
    }

    public static XivPopupOptions<string> CreateOkCancelWithCheckbox(bool isChecked, bool highlighted)
    {
        return new XivPopupOptions<string>(XivPopupType.OkCancel)
        {
            Label = $"{nameof(XivPopupType.OkCancel)}",
            Content = "This is a popup with a checkbox and two buttons.",
            Checkbox = new XivCheckboxOptions
            {
                Label = "Optional checkbox",
                Checked = isChecked,
                Highlighted = highlighted
            }
        };
    }

    public static XivPopupOptions<string> CreateOkCancelWithWarning()
    {
        return new XivPopupOptions<string>(XivPopupType.OkCancel)
        {
            Label = $"{nameof(XivPopupType.OkCancel)}",
            Content = "This is a popup with a warning and two buttons.",
            Warning = "This is a warning! It's yellow!"
        };
    }

    public static XivPopupOptions<string> CreateOkCancelWithWarningAndCheckbox()
    {
        return new XivPopupOptions<string>(XivPopupType.OkCancel)
        {
            Label = $"{nameof(XivPopupType.OkCancel)}",
            Content = "This is a popup with a warning and two buttons.",
            Warning = "This is a warning! It's yellow!",
            Checkbox = new XivCheckboxOptions
            {
                Label = "Optional checkbox",
                Highlighted = true
            }
        };
    }

    public static XivPopupOptions<string> CreateYesNo()
    {
        return new XivPopupOptions<string>(XivPopupType.YesNo)
        {
            Label = $"{nameof(XivPopupType.YesNo)}",
            Content = "This is a basic popup with two buttons."
        };
    }
}