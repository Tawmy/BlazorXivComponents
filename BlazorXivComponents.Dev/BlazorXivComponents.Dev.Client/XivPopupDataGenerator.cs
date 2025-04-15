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

    /*
    public static async Task OpenPopupFromPreset()
    {
        return new XivPopupOptions<string>(XivPopupType.OkCancel)
        {
            Label = "This is a popup",
            Content = "This will explain to the user what is being asked of them",
            Warning = "This is a warning! Please read!",
            Checkbox = new XivCheckboxOptions { Label = "If this is set, checkbox is shown"}
        };

        var result = await _popup.OpenAsync(options);
        if (assign)
        {
            _popupResult = result;
        }
    }

    private static async Task OpenPopupWithCustomButtons(bool assign)
    {
        List<XivPopupButton<string>> buttons =
        [
            new("Button 1", "button1"),
            new("Button 2", "button2"),
            new("Button 3", "button3"),
            new("Button 4", "button4"),
            new("Button 5 with more text", "button5")
        ];

        var options = new XivPopupOptions<string>(buttons)
        {
            Label = "This is a popup",
            Content = "This will explain to the user what is being asked of them",
            Warning = "This is a warning! Please read!",
            Checkbox = new XivCheckboxOptions { Label = "If this is set, checkbox is shown"}
        };

        var result = await _popup.OpenAsync(options);
        if (assign)
        {
            _popupResult = result;
        }
    }
    */
}