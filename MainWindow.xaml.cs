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

        private void buttonXToTheNthStart_Click(object sender, RoutedEventArgs e)
        {
            XToTheNth();
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

        public void XToTheNth()
        {
            int n = Convert.ToInt32(textBoxNth.Text);
            int x = Convert.ToInt32(textBoxX.Text);
            int count = n;
            int answer = 1;
            do
            {
                answer = answer * x;
                count--;
            }
            while (count != 0);
            textBlockXToTheNthAnswer.Text = Convert.ToString(answer);

        }


    }
}
