using LinqTraining.ViewModels;
using System.Windows;

namespace LinqTraining
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new StudentsViewModel();
        }
    }
}
