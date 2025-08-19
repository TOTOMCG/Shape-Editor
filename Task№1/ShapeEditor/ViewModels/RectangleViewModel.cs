using ShapeEditor.Models;
using Avalonia.Media;

namespace ShapeEditor.ViewModels;

public class RectangleViewModel : ShapeViewModel
{
    private readonly RectangleModel _model;

    public RectangleViewModel(RectangleModel model)
    {
        _model = model;
    }
    
    public override Color ShapeColor
    {
        get => _model.ShapeColor;
        set => SetProperty(_model.ShapeColor, value, _model, (m, v) => m.ShapeColor = v);
    }

    public override string DisplayText
    {
        get => _model.DisplayText;
        set => SetProperty(_model.DisplayText, value, _model, (m, v) => m.DisplayText = v);
    }
    
    public override Color TextColor
    {
        get => _model.TextColor;
        set => SetProperty(_model.TextColor, value, _model, (m, v) => m.TextColor = v);
    }

    public double Width
    {
        get => _model.Width;
        set => SetProperty(_model.Width, value, _model, (m, v) => m.Width = v);
    }

    public double Height
    {
        get => _model.Height;
        set => SetProperty(_model.Height, value, _model, (m, v) => m.Height = v);
    }

    public double Rotation
    {
        get => _model.Rotation;
        set => SetProperty(_model.Rotation, value, _model, (m, v) => m.Rotation = v);
    }
}