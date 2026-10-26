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
            Text = "Texto de ejemplo",
            FontSize = 20,
            Margin = new Thickness(10)
        };
        // Variable local (con var):
        var otro = new TextBlock { Text = "Otro texto" };
        // 3) Crea el Button con el mismo texto que en MainWindow
        var boton1 = new Button
        {
            Content = "Púlsame",
            Margin = new Thickness(0, 10, 0, 0)
        };
        var boton2 = new Button
        {
            Content = "Botón creado en C#",
            Margin = new Thickness(0, 10, 0, 0)
        };
        // 4) Asigna a Content un StackPanel que contenga los dos
        var panel = new StackPanel { Margin = new Thickness(20) };
        panel.Children.Add(boton1);
        panel.Children.Add(boton2);
        Content = panel;
    }
}