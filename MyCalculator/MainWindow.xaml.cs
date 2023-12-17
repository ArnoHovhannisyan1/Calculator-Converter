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

namespace MyCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public char oper;
        public double initial_value;
        public double stored_value;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonOne_Click(object sender, RoutedEventArgs e)
        {
            outputTxt.Text += 1;
        }

        private void buttonTwo_Click(object sender, RoutedEventArgs e)
        {
            outputTxt.Text += 2;
        }

        private void buttonThree_Click(object sender, RoutedEventArgs e)
        {
            outputTxt.Text += 3;
        }

        private void buttonFour_Click(object sender, RoutedEventArgs e)
        {
            outputTxt.Text += 4;
        }

        private void buttonFive_Click(object sender, RoutedEventArgs e)
        {
            outputTxt.Text += 5;
        }

        private void buttonSix_Click(object sender, RoutedEventArgs e)
        {
            outputTxt.Text += 6;
        }

        private void buttonSeven_Click(object sender, RoutedEventArgs e)
        {
            outputTxt.Text += 7;
        }

        private void buttonEight_Click(object sender, RoutedEventArgs e)
        {
            outputTxt.Text += 8;
        }

        private void buttonNine_Click(object sender, RoutedEventArgs e)
        {
            outputTxt.Text += 9;
        }

        private void buttonZero_Click(object sender, RoutedEventArgs e)
        {
            outputTxt.Text += 0;
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
          
            if (!string.IsNullOrEmpty(outputTxt.Text))
            {
                initial_value = Double.Parse(outputTxt.Text);

                if (string.IsNullOrEmpty(txtBlock.Text))
                {
                    txtBlock.Text = initial_value.ToString();
                    oper = '+';
                }
                else
                {  
                    stored_value = Double.Parse(txtBlock.Text);
                        switch (oper)
                        {
                            case '+':
                                stored_value += initial_value;
                                oper = '+';
                                break;
                            case '-':
                                stored_value -= initial_value;
                                oper = '+';
                                break;
                            case 'X':
                                stored_value *= initial_value;
                                oper = '+';
                                break;
                            case '/':
                            if (initial_value != 0)
                            {
                                stored_value /= initial_value;
                                oper = '+';
                            }
                            else
                            {
                                MessageBox.Show("Cannot divide on 0.");
                                outputTxt.Text = "";

                            }
                            break;
                        }
                    
                    txtBlock.Text = stored_value.ToString();
                }
            }
            else
            {
                oper = '+';
            }
            txtOPer.Text = oper.ToString();

            outputTxt.Text = "";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(outputTxt.Text))
            {
                initial_value = Double.Parse(outputTxt.Text);
                if (string.IsNullOrEmpty(txtBlock.Text))
                {
                    txtBlock.Text = initial_value.ToString();
                    oper = '-';
                }
                else
                {
                    stored_value = Double.Parse(txtBlock.Text);
                    switch (oper)
                    {
                        case '+':
                            stored_value += initial_value;
                            oper = '-';
                            break;
                        case '-':
                            stored_value -= initial_value;
                            oper = '-';
                            break;
                        case 'X':
                            stored_value *= initial_value;
                            oper = '-';
                            break;
                        case '/':
                            if (initial_value != 0)
                            {
                                stored_value /= initial_value;
                                oper = '-';
                            }
                            else
                            {
                                MessageBox.Show("Cannot divide on 0");
                                outputTxt.Text = "";
                            }
                            break;
                    }
                    txtBlock.Text = stored_value.ToString();
                }
            }
            else
            {
                oper = '-';
            }
            txtOPer.Text = oper.ToString();

            outputTxt.Text = "";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(outputTxt.Text))
            {
                initial_value = Double.Parse(outputTxt.Text);
                if (initial_value != 0)
                {

                    if (string.IsNullOrEmpty(txtBlock.Text))
                    {
                        txtBlock.Text = initial_value.ToString();
                        oper = '/';
                    }
                    else
                    {
                        stored_value = Double.Parse(txtBlock.Text);
                        switch (oper)
                        {
                            case '+':
                                stored_value += initial_value;
                                oper = '/';
                                break;
                            case '-':
                                stored_value -= initial_value;
                                oper = '/';
                                break;
                            case 'X':
                                stored_value *= initial_value;
                                oper = '/';
                                break;
                            case '/':
                                if (initial_value != 0)
                                {
                                    stored_value /= initial_value;
                                    oper = '/';
                                }
                                else
                                {
                                    MessageBox.Show("Cannot divide on 0");
                                }
                                break;
                        }
                        txtBlock.Text = stored_value.ToString();
                    }
                }else
                {
                    MessageBox.Show("Cannot divide on 0.");
                    outputTxt.Text = "";
                }
            }
            else
            {
                oper = '/';
            }
            txtOPer.Text = oper.ToString();

            outputTxt.Text = "";
        }
        
        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(outputTxt.Text))
            {
                initial_value = Double.Parse(outputTxt.Text);
                if (string.IsNullOrEmpty(txtBlock.Text))
                {
                    txtBlock.Text = initial_value.ToString();
                    oper = 'X';
                } 
                else
                {
                    stored_value = Double.Parse(txtBlock.Text);
                    switch (oper)
                    {
                        case '+':
                            stored_value += initial_value;
                            oper = 'X';
                            break;
                        case '-':
                            stored_value -= initial_value;
                            oper = 'X';
                            break;
                        case 'X':
                            stored_value *= initial_value;
                            oper = 'X';
                            break;
                        case '/':
                            if (initial_value != 0)
                            {
                                stored_value /= initial_value;
                                oper = 'X';
                            }
                            else
                            {
                                MessageBox.Show("Cannot divide on 0");
                                outputTxt.Text = "";
                            }
                            break;
                    }
                    txtBlock.Text = stored_value.ToString();
                }
            }
            else
            {
                oper = 'X';
            }
            txtOPer.Text = oper.ToString();

            outputTxt.Text = "";
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtOPer.Text))
            {
                txtOPer.Text = "";
            }
            if(string.IsNullOrEmpty(outputTxt.Text) && string.IsNullOrEmpty(txtBlock.Text))
            {
                outputTxt.Text = "";
            }
            else if(!string.IsNullOrEmpty(outputTxt.Text) && string.IsNullOrEmpty(txtBlock.Text))
            {
                initial_value = Double.Parse(outputTxt.Text);
            }
            else if(string.IsNullOrEmpty(outputTxt.Text) && !string.IsNullOrEmpty(txtBlock.Text))
            {
                outputTxt.Text = stored_value.ToString();
                txtBlock.Text = "";
                initial_value = stored_value;
            }
            else
            {
                initial_value = Double.Parse(outputTxt.Text);
                stored_value = Double.Parse(txtBlock.Text);
                switch (oper)
                {
                    case '+':
                        outputTxt.Text = (stored_value + initial_value).ToString();
                        txtBlock.Text = "";
                        break;
                    case '-':
                        outputTxt.Text = (stored_value - initial_value).ToString();
                        txtBlock.Text = "";
                        break;
                    case 'X':
                        outputTxt.Text = (stored_value * initial_value).ToString();
                        txtBlock.Text = "";
                        break;
                    case '/':
                        if (initial_value != 0)
                        {
                            outputTxt.Text = ((double)stored_value / (double)initial_value).ToString();
                            txtBlock.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Cannot divide on 0");
                            outputTxt.Text = "";
                        }
                        break;
                }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtOPer.Text = "";
            txtBlock.Text = "";
            outputTxt.Text = "";
            initial_value = default;
            stored_value = default;
        }

        private void buttonDot_Click(object sender, RoutedEventArgs e)
        {
            bool pressed = true;
            if(pressed)
            if(string.IsNullOrEmpty(outputTxt.Text))
            {
                outputTxt.Text += 0;
            }
            outputTxt.Text += '.';
            
        }

        private void btnInverse_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(outputTxt.Text))
            {
                return;
            }
            else
            {
                initial_value = double.Parse(outputTxt.Text);
                initial_value = (-1) * initial_value;
                outputTxt.Text = initial_value.ToString();
            }
        }

        private void outputTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = outputTxt.Text;
            int dotCount = text.Count(c => c == '.');
            if(outputTxt.Text.Length >= 13)
            {
                outputTxt.FontSize = 20;
            }
            else
            {
                outputTxt.FontSize = 40;
            }

            if (dotCount > 1)
            {
                outputTxt.Text = text.Substring(0, text.LastIndexOf('.'));
                outputTxt.SelectionStart = text.LastIndexOf('.');
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(outputTxt.Text))
            {
            outputTxt.Text = outputTxt.Text.Remove(outputTxt.Text.Length - 1, 1);
            }
        }

        private void buttonMenu_Click(object sender, RoutedEventArgs e)
        {
            Menu targetWindow = new Menu();

            // Show the target window
           // targetWindow.WindowState = WindowState.Normal;

            targetWindow.Show();

            // Close the current window if desired
            this.Close();
        }
    }
}

//do better design

//add a moment about negative input
//and if input is - then = is pressed, block prints 0-

