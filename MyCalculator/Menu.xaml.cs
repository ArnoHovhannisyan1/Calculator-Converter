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
using System.Windows.Shapes;

namespace MyCalculator
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow targetWindow = new MainWindow();

            // Show the target window
            targetWindow.Show();

            // Close the current window if desired
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Converter targetWindow = new Converter();

            // Show the target window
            targetWindow.Show();

            // Close the current window if desired
            this.Close();
        }
    }
}
