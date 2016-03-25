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

namespace Looping
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

        private void buttonLoanCalculator_Click(object sender, RoutedEventArgs e)
        {
            LoanCalc();
        }



        public void LoanCalc()
        {
            int amount = Convert.ToInt32(textBoxLoanAmount.Text);
            int payment = Convert.ToInt32(textBoxPaymentAmount.Text);
            int months = 0;
            while (true)
            {
                months++;
                amount -= payment;
                if (amount <= 0)
                {
                    break;
                }

            }
            textBlockLoanAnswer.Text = "The Loan Was Payed Off In " + months + " Months.";
        }


    }
}
