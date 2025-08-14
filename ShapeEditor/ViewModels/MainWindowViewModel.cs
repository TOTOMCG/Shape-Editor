using CommunityToolkit.Mvvm.ComponentModel;

namespace ShapeEditor.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public RectangleViewModel RectangleState { get; } = new();
    public CircleViewModel CircleState { get; } = new();

    [ObservableProperty]
    private ShapeViewModel? _currentShape;

    [ObservableProperty]
    private bool _isRectangleSelected = true;

    public MainWindowViewModel()
    {
        _currentShape = RectangleState;
    }
    
    partial void OnIsRectangleSelectedChanged(bool value)
    {

        CurrentShape = value ? RectangleState : CircleState;
    }
}