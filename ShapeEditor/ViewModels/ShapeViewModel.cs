using CommunityToolkit.Mvvm.ComponentModel;
using Avalonia.Media;

namespace ShapeEditor.ViewModels;

public abstract partial class ShapeViewModel : ViewModelBase
{
    [ObservableProperty]
    private Color _shapeColor = Colors.CornflowerBlue;

    [ObservableProperty]
    private string _displayText = "Text";

    [ObservableProperty]
    private Color _textColor = Colors.White;
}