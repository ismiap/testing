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

namespace InputOutput
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>    
    public partial class MainWindow : Window
    {
        public string name { get; set; }
        public string major { get; set; }
        public string myclass { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }
        private void InputButton_Click(object sender, RoutedEventArgs e)
        {
            name = NameTextBox.Text;
            major = MajorTextBox.Text;
            myclass = ClassTextBox.Text;

            MessageBox.Show($"Hello, Perkenalkan saya {name.ToString().ToUpper()} jurusan {major.ToString().ToUpper()} dari kelas {myclass.ToString().ToUpper()}");
        }
    }
}
