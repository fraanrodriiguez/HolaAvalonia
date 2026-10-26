using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
 
namespace HolaAvalonia;   // copia aquí el namespace de MainWindow.axaml.cs
 
public class VentanaCS : Window
{
    // Campo para poder usar el TextBlock desde cualquier método
    private TextBlock saludo = null!;
 
    public VentanaCS()
    {
        InitializeComponent();
    }
 
    // Este método lo escribes tú: aquí se construye la interfaz
    private void InitializeComponent()
    {
        // 1) Propiedades de la ventana: Title, Width y Height
        Title = "Mi ventana";
        Width = 500;
        Height = 250;
        // 2) Crea el TextBlock con tu nombre y guárdalo en "saludo"
        // Guardado en un campo de la clase (sin var):
        saludo = new TextBlock
        {
            Text = "Este texto lo ha puesto el C#",
            FontSize = 24,
            Foreground = Brushes.Crimson,
            Margin = new Thickness(10)
        };
        // 3) Crea el Button con el mismo texto que en MainWindow
        var boton1 = new Button
        {
            Content = "Púlsame",
            Margin = new Thickness(0, 10, 0, 0)
        };
        boton1.Click += Boton_Click;

        var boton2 = new Button
        {
            Content = "Botón creado en C#",
            Margin = new Thickness(0, 10, 0, 0)
        };
        boton2.Click += AbrirVentanaCS;
        // 4) Asigna a Content un StackPanel que contenga los dos
        var panel = new StackPanel { Margin = new Thickness(20) };
        panel.Children.Add(saludo);
        panel.Children.Add(boton1);
        panel.Children.Add(boton2);
        Content = panel;
    }
    private void Boton_Click(object? sender, RoutedEventArgs e)
        {
            saludo.Text = "HOLAAA!!!";
        }
    private void AbrirVentanaCS(object? sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
        }
}