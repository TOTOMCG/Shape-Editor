using CommunityToolkit.Mvvm.ComponentModel;

namespace ShapeEditor.Models;

public partial class RectangleModel : ShapeModel
{
    [ObservableProperty]
    private double _width = 200;

    [ObservableProperty]
    private double _height = 150;

    [ObservableProperty]
    private double _rotation = 0;
}