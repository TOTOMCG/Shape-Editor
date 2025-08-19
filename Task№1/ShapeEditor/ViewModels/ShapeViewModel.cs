using Avalonia.Media;

namespace ShapeEditor.ViewModels;

public abstract class ShapeViewModel : ViewModelBase
{
    public abstract Color ShapeColor { get; set; }
    public abstract string DisplayText { get; set; }
    public abstract Color TextColor { get; set; }

}