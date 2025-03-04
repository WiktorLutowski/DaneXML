using System.Collections.ObjectModel;
using System.Windows;
using System.Xml.Serialization;

namespace DaneXML
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Employee> employees;
        public MainWindow()
        {
            InitializeComponent();

            employees = new ObservableCollection<Employee>();

            dataGrid.ItemsSource = employees;
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void loadButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
