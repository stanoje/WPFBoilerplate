using System.Windows;
using WpfBoilerplate.Factory;

namespace WpfBoilerplate.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IMainViewModelFactory factory)
        {
            InitializeComponent();
            DataContext = factory.Create();
        }
    }
}
