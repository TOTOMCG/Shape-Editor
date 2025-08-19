using CommunityToolkit.Mvvm.ComponentModel;
using Avalonia.Media;

namespace ShapeEditor.Models;

public abstract partial class ShapeModel : ObservableObject
{
    [ObservableProperty]
    private Color _shapeColor = Color.FromRgb(100, 149, 237);

    [ObservableProperty]
    private string _displayText = "Text";

    [ObservableProperty]
    private Color _textColor = Color.FromRgb(255, 255, 255);
}
