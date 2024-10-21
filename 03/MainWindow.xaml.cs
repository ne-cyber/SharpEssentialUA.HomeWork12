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

namespace _03
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

        public event EventHandler start = null;
        public event EventHandler stop = null;
        public event EventHandler clear = null;


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            start.Invoke(sender, e);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            stop.Invoke(sender, e);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            clear.Invoke(sender, e);
        }
    }
}
