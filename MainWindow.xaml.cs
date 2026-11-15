using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LiquidCast;

public partial class MainWindow : Window
{
    private bool _live;
    public MainWindow() => InitializeComponent();

    private void Scene_Click(object sender, RoutedEventArgs e)
    {
        foreach (var child in ScenesPanel.Children.OfType<Button>()) child.Background = new SolidColorBrush(Color.FromArgb(0x20, 0xFF, 0xFF, 0xFF));
        if (sender is Button button) button.Background = new SolidColorBrush(Color.FromArgb(0xA0, 0x67, 0x9C, 0xFF));
    }

    private void Source_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Источник добавлен в текущую сцену.", "LiquidCast", MessageBoxButton.OK, MessageBoxImage.Information);
    private void NewScene_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Создание сцены будет доступно в редакторе проекта.", "Новая сцена");
    private void StartStream_Click(object sender, RoutedEventArgs e) { _live = !_live; ((Button)sender).Content = _live ? "■ Остановить эфир" : "▶ Начать эфир"; }
    private void Record_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Запись готова к запуску после выбора папки сохранения.", "Запись");
    private void Mute_Click(object sender, RoutedEventArgs e) => ((Button)sender).Content = ((Button)sender).Content.ToString()!.Contains("Микрофон") ? "🔇 Микрофон выкл." : "🎙 Микрофон";
    private void AutoTune_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Рекомендуемые настройки: 1080p, 60 FPS, 6000 kb/s.", "Автонастройка");
    private void Settings_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Настройки LiquidCast будут доступны в следующем модуле.", "Настройки");
}
