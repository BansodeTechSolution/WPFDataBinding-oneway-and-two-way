using System.Windows;

namespace WPFDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person p = new Person { Name = "Ajay", Age = 28 };
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = p;
        }

        private void ButtonSubmit_Click(object sender, RoutedEventArgs e)
        {
            string message = p.Name + " is " + p.Age;
            MessageBox.Show(message);
        }
    }

    public class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private double _age;
        public double Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
}
