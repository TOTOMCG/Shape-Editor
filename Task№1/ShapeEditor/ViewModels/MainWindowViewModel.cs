using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using ShapeEditor.Models;

namespace ShapeEditor.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly RectangleModel _rectangleModel = new();
    private readonly CircleModel _circleModel = new();
    
    public RectangleViewModel RectangleState { get; }
    public CircleViewModel CircleState { get; }

    [ObservableProperty]
    private ShapeViewModel? _currentShape;

    [ObservableProperty]
    private bool _isRectangleSelected = true;

    public MainWindowViewModel()
    {
        RectangleState = new RectangleViewModel(_rectangleModel);
        CircleState = new CircleViewModel(_circleModel);
        
        _currentShape = RectangleState;
    }

    partial void OnIsRectangleSelectedChanged(bool value)
    {
        CurrentShape = value ? RectangleState : CircleState;
    }
    
    [ObservableProperty]
    private string _shapeColorR = "100";
    
    [ObservableProperty]
    private string _shapeColorG = "149";
    
    [ObservableProperty]
    private string _shapeColorB = "237";
    
    [ObservableProperty]
    private string _textColorR = "255";
    
    [ObservableProperty]
    private string _textColorG = "255";
    
    [ObservableProperty]
    private string _textColorB = "255";
    
    public void UpdateShapeColor()
    {
        if (CurrentShape == null) return;
    
        if (byte.TryParse(ShapeColorR, out byte r) &&
            byte.TryParse(ShapeColorG, out byte g) &&
            byte.TryParse(ShapeColorB, out byte b))
        {
            CurrentShape.ShapeColor = Color.FromRgb(r, g, b);
        }
    }
    
    public void UpdateTextColor()
    {
        if (CurrentShape == null) return;
    
        if (byte.TryParse(TextColorR, out byte r) &&
            byte.TryParse(TextColorG, out byte g) &&
            byte.TryParse(TextColorB, out byte b))
        {
            CurrentShape.TextColor = Color.FromRgb(r, g, b);
        }
    }
}
