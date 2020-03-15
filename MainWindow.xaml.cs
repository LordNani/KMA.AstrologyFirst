using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using pr_1_Gaivoronskyi.ViewModels;
namespace pr_1_Gaivoronskyi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SignViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();

            DataContext = _viewModel = new SignViewModel();
            
        }
    }
}
