using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Taschenrechner
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
        bool symbolUsed = false;

        public void takeInput(object sender, EventArgs e) {
            Button btn = (Button)sender;
            tbx.Text += Convert.ToString(btn.Content);
        }

        public void takeSymbol(object sender, EventArgs e){
            Button btn = (Button)sender;
            if(symbolUsed == true)
            {
                MessageBox.Show("Error");
            }
            else
            {
                if(tbx.Text != "")
                {
                    tbx.Text += Convert.ToString(btn.Content);
                    symbolUsed = true;
                }
            }
        }

        public void calculate(object sender, EventArgs e){
            string input = Convert.ToString(tbx.Text);
            string[] inputParts = input.Split('+', '-', '*', '/');
            string chosenOperator = inputParts[1];
            switch (chosenOperator)
            {
                case "+":
                    tbx.Text = Convert.ToString(Convert.ToDouble(inputParts[0]) + Convert.ToDouble(inputParts[2]));
                    break;
                case "-":
                    break;
                case "*":
                    break;
                case "/":
                    break;
                default:
                    break;
            }


            symbolUsed = false;
        }

        public void cancel(object sender, EventArgs s){
            tbx.Text = "";
            symbolUsed = false;
        }
        
    }
}
