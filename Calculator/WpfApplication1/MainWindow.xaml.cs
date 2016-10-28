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
            textBox.Text = "";
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "7";

        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "5";
        }

        private void button_Copy4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Copy6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {

        }
        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
