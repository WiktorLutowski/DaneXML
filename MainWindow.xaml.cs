using System.Collections.ObjectModel;
using System.IO;
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
        XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Employee>));

        public MainWindow()
        {
            InitializeComponent();

            employees = new ObservableCollection<Employee>();

            dataGrid.ItemsSource = employees;
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            var stream = File.Create("save.xml");

            serializer.Serialize(stream, employees);

            stream.Close();
        }

        private void loadButton_Click(object sender, RoutedEventArgs e)
        {
            var stream = File.OpenRead("save.xml");

            employees = (ObservableCollection<Employee>)serializer.Deserialize(stream);

            dataGrid.ItemsSource = employees;

            stream.Close();
        }
    }
}
