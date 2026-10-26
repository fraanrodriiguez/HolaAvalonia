using Avalonia.Controls;
using Avalonia.Media;
using Avalonia;
using Avalonia.Interactivity;

namespace HolaAvalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        // Lo que escribas a partir de aquí se ejecuta después de cargar el XAML
        Title = "Título cambiado desde C#";
        saludo.Text = "Este texto lo ha puesto el C#";
        saludo.Foreground = Brushes.Crimson;

        var extra = new Button
        {
            Content = "Botón creado en C#",
            Margin = new Thickness(0, 10, 0, 0)
        };
        extra.Click += AbrirVentanaCS;
        panel.Children.Add(extra);
    }
    private void Boton_Click(object? sender, RoutedEventArgs e)
        {
            saludo.Text = "HOLAAA!!!";
        }
    private void AbrirVentanaCS(object? sender, RoutedEventArgs e)
        {
            new VentanaCS().Show();
        }
}