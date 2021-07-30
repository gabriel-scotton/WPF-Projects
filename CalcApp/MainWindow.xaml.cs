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

namespace CalcApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    enum Operation
    {
        ADD,
        MULTIPLY,
        DIVIDE,
        SUBTRACT,
        ROUND,
        NONE
        
    }
    public partial class MainWindow : Window
    {
        private double previousValueFloat;
        public MainWindow()
        {
            InitializeComponent();
            double f = 1.2;
            
            textSb = new StringBuilder(f.ToString());
            updateText();
            
        }
        static Operation op = Operation.NONE;

        public double PreviousValue { get => previousValueFloat; set => previousValueFloat = value; }
        public static StringBuilder textSb = new StringBuilder("0");

        public void updateText()
        {
            /*This is only here because I forgot to trim the 0 in the buttons*/
            try {
                int x = int.Parse(textSb.ToString());
                textSb = new StringBuilder(x.ToString());

            }
            catch(Exception)
            {
                // if its not an int, must be a float, if its a malformed float, we just wait for next input
                /*try
                {
                    float r  = float.Parse(textSb.ToString());
                    textSb = new StringBuilder(r.ToString());
                    
                }
                catch (Exception )
                {
                    ResultLabel.Content = textSb.ToString();
                }*/
            }

            ResultLabel.Content = textSb.ToString();
            





        }

        private void ButtonAC_Click(object sender, RoutedEventArgs e)
        {
            op = Operation.NONE;
            previousValueFloat = 0;
            textSb = new StringBuilder("0");
            Console.WriteLine(textSb.ToString());
            updateText();
        }

        
        private void ButtonPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            textSb.Insert(0, "-");

        }

        private void ButtonRound_Click(object sender, RoutedEventArgs e)
        {
            previousValueFloat = float.Parse(textSb.ToString());
            op = Operation.ROUND;
            textSb = new StringBuilder("0");
            Console.WriteLine(textSb.ToString());
            updateText();
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            if (true)
            {
                previousValueFloat = float.Parse(textSb.ToString());
                op = Operation.DIVIDE;
                textSb = new StringBuilder("0");
                Console.WriteLine(textSb.ToString());
                updateText();

            }
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            previousValueFloat = float.Parse(textSb.ToString());
            op = Operation.MULTIPLY;
            textSb = new StringBuilder("0");
            Console.WriteLine(textSb.ToString());
            updateText();
        }

        private void ButtonSubtract_Click(object sender, RoutedEventArgs e)
        {
            previousValueFloat = float.Parse(textSb.ToString());
            op = Operation.SUBTRACT;
            textSb = new StringBuilder("0");
            Console.WriteLine(textSb.ToString());
            updateText();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            previousValueFloat = float.Parse(textSb.ToString());
            op = Operation.ADD;
            textSb = new StringBuilder("0");
            Console.WriteLine(textSb.ToString());
            updateText();
        }

        private void ButtonResult_Click(object sender, RoutedEventArgs e)
        {
            double f = double.Parse(textSb.ToString());
            if (op!= Operation.DIVIDE || (op == Operation.DIVIDE && f!=0.0))
            {
                if(op == Operation.ADD)
                {
                    f = f + previousValueFloat;
                }else if (op == Operation.SUBTRACT)
                {
                    f = previousValueFloat - f;
                }
                else if (op == Operation.MULTIPLY)
                {
                    f = previousValueFloat * f;
                }else if(op == Operation.ROUND)
                {
                    f = Math.Round(previousValueFloat, (int)f);
                   
                }
                else
                {
                    f = previousValueFloat / f;
                }

                textSb = new StringBuilder(f.ToString());
                updateText();
            }
            else
            {
                textSb = new StringBuilder("infinity");
            }
        }

        private void ButtonNumber1_Click(object sender, RoutedEventArgs e)
        {
            textSb.Append("1");
            updateText();
        }

        private void ButtonNumber2_Click(object sender, RoutedEventArgs e)
        {
            textSb.Append("2");
            updateText();
        }
        private void ButtonNumber3_Click(object sender, RoutedEventArgs e)
        {
            textSb.Append("3");
            updateText();
        }

        private void ButtonNumber4_Click(object sender, RoutedEventArgs e)
        {
            textSb.Append("4");
            updateText();
        }

        private void ButtonNumber5_Click(object sender, RoutedEventArgs e)
        {
            textSb.Append("5");
            updateText();
        }

        private void ButtonNumber6_Click(object sender, RoutedEventArgs e)
        {
            textSb.Append("6");
            updateText();
        }

        private void ButtonNumber7_Click(object sender, RoutedEventArgs e)
        {
            textSb.Append("7");
            updateText();
        }

        private void ButtonNumber8_Click(object sender, RoutedEventArgs e)
        {
            textSb.Append("8");
            updateText();
        }

        private void ButtonNumber9_Click(object sender, RoutedEventArgs e)
        {
            textSb.Append("9");
            updateText();
        }

        private void ButtonNumber0_Click(object sender, RoutedEventArgs e)
        {
            textSb.Append("0");
            updateText();
        }

        private void ButtonDecimalPoint_Click(object sender, RoutedEventArgs e)
        {
            textSb.Append(",");
            updateText();
        }

        
    }
}
