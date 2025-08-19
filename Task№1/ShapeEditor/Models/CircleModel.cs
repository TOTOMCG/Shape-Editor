using CommunityToolkit.Mvvm.ComponentModel;

namespace ShapeEditor.Models;

public partial class CircleModel : ShapeModel
{
    [ObservableProperty]
    private double _diameter = 150;

    [ObservableProperty]
    private double _scaleX = 1.0;

    [ObservableProperty]
    private double _scaleY = 1.0;
}