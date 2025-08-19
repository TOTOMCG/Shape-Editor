using Avalonia.Controls;
using ShapeEditor.ViewModels;

namespace ShapeEditor.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void OnShapeColorChanged(object sender, TextChangedEventArgs e)
    {
        if (DataContext is MainWindowViewModel vm)
        {
            vm.UpdateShapeColor();
        }
    }
    
    private void OnTextColorChanged(object sender, TextChangedEventArgs e)
    {
        if (DataContext is MainWindowViewModel vm)
        {
            vm.UpdateTextColor();
        }
    }
}