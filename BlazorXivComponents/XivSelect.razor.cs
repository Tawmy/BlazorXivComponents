namespace BlazorXivComponents;

public record XivSelectOption<T>(T Value, string Label);

public record XivSelectCategory<T>(string Name, IEnumerable<XivSelectOption<T>> Options);