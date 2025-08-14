using CommunityToolkit.Mvvm.ComponentModel;

namespace ShapeEditor.ViewModels;

public partial class RectangleViewModel : ShapeViewModel
{
    [ObservableProperty]
    private double _width = 200;

    [ObservableProperty]
    private double _height = 150;

    [ObservableProperty]
    private double _rotation = 0;
}