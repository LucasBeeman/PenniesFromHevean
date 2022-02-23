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

namespace PenniesFromHevean
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int inputAmmount = int.Parse(penniesContent.Text);
            int dollarInt = 0;
            int halfDollarInt = 0;
            int quarterInt = 0;
            int dimeInt = 0;
            int nickleInt = 0;
            int pennyInt = 0;
            
            while (inputAmmount > 0)
            {
                if (inputAmmount - 100 >= 0)
                {
                    dollarInt++;
                    inputAmmount -= 100;
                }
                else if (inputAmmount - 50 >= 0)
                {
                    halfDollarInt++;
                    inputAmmount -= 50;
                }
                else if(inputAmmount - 25 >= 0)
                {
                    quarterInt++;
                    inputAmmount -= 25;
                }
                else if(inputAmmount - 10 >= 0)
                {
                    dimeInt++;
                    inputAmmount -= 10;
                }
                else if (inputAmmount - 5 >= 0)
                {
                    nickleInt++;
                    inputAmmount -= 5;
                }
                else if (inputAmmount - 1 >= 0)
                {
                    pennyInt++;
                    inputAmmount -= 1;
                }
            }
            dollarContent.Content = dollarInt.ToString();
            halfDollarContent.Content = halfDollarInt.ToString();
            quarterContent.Content = quarterInt.ToString();
            dimeContent.Content = dimeInt.ToString();
            nickleContent.Content = nickleInt.ToString();
            pennyContent.Content = pennyInt.ToString();

        }
    }
}
