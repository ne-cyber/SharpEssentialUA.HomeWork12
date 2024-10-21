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

namespace _04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            new Presenter(this);
        }

        public event EventHandler addEvent = null;
        public event EventHandler subEvent = null;
        public event EventHandler mulEvent = null;
        public event EventHandler divEvent = null;

        public event EventHandler divisionByZeroEvent = null;


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.Add.IsChecked == true)
                addEvent.Invoke(sender, e);
            else if (this.Sub.IsChecked == true)
                subEvent.Invoke(sender, e);
            else if (this.Mul.IsChecked == true)
                mulEvent.Invoke(sender, e);
            else if (this.Div.IsChecked == true && double.Parse(this.b.Text) != 0)
                divEvent.Invoke(sender, e);
            else if (this.Div.IsChecked == true && double.Parse(this.b.Text) == 0)
                divisionByZeroEvent.Invoke(sender, e);
        }


    }
}
