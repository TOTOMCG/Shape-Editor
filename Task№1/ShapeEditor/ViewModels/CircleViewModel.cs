using ShapeEditor.Models;
using Avalonia.Media;

namespace ShapeEditor.ViewModels;

public class CircleViewModel : ShapeViewModel
{
    private readonly CircleModel _model;

    public CircleViewModel(CircleModel model)
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
    
    public double Diameter
    {
        get => _model.Diameter;
        set => SetProperty(_model.Diameter, value, _model, (m, v) => m.Diameter = v);
    }
    
    public double ScaleX
    {
        get => _model.ScaleX;
        set => SetProperty(_model.ScaleX, value, _model, (m, v) => m.ScaleX = v);
    }

    public double ScaleY
    {
        get => _model.ScaleY;
        set => SetProperty(_model.ScaleY, value, _model, (m, v) => m.ScaleY = v);
    }
}