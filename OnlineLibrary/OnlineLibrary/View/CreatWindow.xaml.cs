using OnlineLibrary.Model;
using OnlineLibrary.View;
using OnlineLibrary.ViewModel;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace OnlineLibrary.View
{
    /// <summary>
    /// Логика взаимодействия для CreatWindow.xaml
    /// </summary>
    public partial class CreatWindow : Window
    {
        public CreatWindow()
        {
            InitializeComponent();
            DataContext = new CreateViewModel();
        }
    }
}
