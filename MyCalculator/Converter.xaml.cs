using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
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
    /// Interaction logic for Converter.xaml
    /// </summary>
    public partial class Converter : Window
    {
        string[] types = new string[] { "Binary", "Decimal", "Octal", "Hexadecimal" };
            
        public Converter()
        {
            InitializeComponent();
        }

        private void buttonMenu_Click(object sender, RoutedEventArgs e)
        {
            Menu targetWindow = new Menu();

            // Show the target window
            targetWindow.Show();

            // Close the current window if desired
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (input_Type.SelectedIndex == 1)
            {
                if (output_Type.SelectedIndex == 0)
                {
                    binaryBox.Text = Convert.ToString(Int32.Parse(decimalBox.Text), 2);
                }
                else if (output_Type.SelectedIndex == 1)
                {
                    binaryBox.Text = decimalBox.Text;
                }
                else if (output_Type.SelectedIndex == 2)
                {
                    binaryBox.Text = Convert.ToString(Int32.Parse(decimalBox.Text), 8);
                }
                else if (output_Type.SelectedIndex == 3)
                {
                    binaryBox.Text = Convert.ToString(Int32.Parse(decimalBox.Text), 16);
                }
            }
            else if (input_Type.SelectedIndex == 0)
            {
                if (output_Type.SelectedIndex == 0)
                {
                    binaryBox.Text = decimalBox.Text;

                }
                else
                { 
                    int decValue = Convert.ToInt32(decimalBox.Text, 2);
                    if (output_Type.SelectedIndex == 1)
                    {
                        binaryBox.Text = decValue.ToString();
                    }
                    else if (output_Type.SelectedIndex == 2)
                    {
                        binaryBox.Text = Convert.ToString(decValue, 8);
                    }
                    else if (output_Type.SelectedIndex == 3)
                    {
                        binaryBox.Text = Convert.ToString(decValue, 16);
                    }
                }
            }
            else if(input_Type.SelectedIndex == 2)
            {
                if (output_Type.SelectedIndex == 2)
                {
                    binaryBox.Text = decimalBox.Text;
                }
                else
                {
                    int decValue = Convert.ToInt32(decimalBox.Text, 8);
                    if (output_Type.SelectedIndex == 0)
                    {
                        binaryBox.Text = Convert.ToString(decValue, 2);
                    }
                    else if (output_Type.SelectedIndex == 1)
                    {
                        binaryBox.Text = Convert.ToString(decValue);
                    }
                    else if (output_Type.SelectedIndex == 3)
                    {
                        binaryBox.Text = Convert.ToString(decValue, 16);
                    }
                }
            }
            else if (input_Type.SelectedIndex == 3)
            {
                if (output_Type.SelectedIndex == 3)
                {
                    binaryBox.Text = decimalBox.Text;
                }
                else
                {
                    int decValue = Convert.ToInt32(decimalBox.Text, 16);
                    if (output_Type.SelectedIndex == 0)
                    {
                        binaryBox.Text = Convert.ToString(decValue, 2);
                    }
                    else if (output_Type.SelectedIndex == 1)
                    {
                        binaryBox.Text = Convert.ToString(decValue);
                    }
                    else if (output_Type.SelectedIndex == 2)
                    {
                        binaryBox.Text = Convert.ToString(decValue, 8);
                    }
                }
            }
        }

        private void fromCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(input_Type.SelectedIndex==0)
            {
                askBlock.Text = "Enter binary number";
            }
            else if(input_Type.SelectedIndex==1)
            {
                askBlock.Text = "Enter decimal number";
            }
            else if (input_Type.SelectedIndex == 2)
            {
                askBlock.Text = "Enter octal number";
            }
            else if (input_Type.SelectedIndex == 3)
            {
                askBlock.Text = "Enter hexadecimal number";
            }
        }

        private void toCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (output_Type.SelectedIndex == 0)
            {
                toldBlock.Text = "Binary number";
            }
            else if (output_Type.SelectedIndex == 1)
            {
                toldBlock.Text = "Decimal number";
            }
            else if (output_Type.SelectedIndex == 2)
            {
                toldBlock.Text = "Octal number";
            }
            else if (output_Type.SelectedIndex == 3)
            {
                toldBlock.Text = "Hexadecimal number";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int temp = input_Type.SelectedIndex;
            input_Type.SelectedIndex = output_Type.SelectedIndex;
            output_Type.SelectedIndex = temp;
            decimalBox.Text = "";
            binaryBox.Text = "";
        }
    }
}
