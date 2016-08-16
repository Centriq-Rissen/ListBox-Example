using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            List<Employee> _Emps = null;

            var emp = new Employee();

            object obj = emp;

            _Emps = new List<Employee>()
            {
                new Employee() { FirstName = "Scooby", LastName = "Doo", ID = 1, Position="Dog", ImageFile = "Images/Scooby.jpg" },
                new Employee() { FirstName = "Scrappy", LastName = "Doo", ID=2, Position="Dog", ImageFile = "Images/Scrappy.jpg" },
                new Employee() { FirstName = "Shaggy", LastName = "Rogers", ID=3, Position = "Sandwich Eater", ImageFile="Images/Shaggy.jpg" },
                new Employee() { FirstName = "Fred", LastName = "Jones", ID=4, Position="Lead Detective", ImageFile = "Images/Fred.jpg" },
                new Employee() { FirstName = "Daphne", LastName = "Blake",ID=5, Position="Detective", ImageFile = "Images/Daphne.jpg" },
                new Employee() { FirstName = "Velma", LastName = "Dinkley",ID=6, Position="Forensic Pathologist", ImageFile= "Images/Velma.jpg" },
            };
            listBox.ItemsSource = _Emps;
        }
    }
}
