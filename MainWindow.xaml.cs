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

        private void buttonHailstoneStart_Click(object sender, RoutedEventArgs e)
        {
            HailstoneSeq();
        }

        public void LoanCalc()
        {
            int amount = Convert.ToInt32(textBoxLoanAmount.Text);
            int payment = Convert.ToInt32(textBoxPaymentAmount.Text);
            int months = 0;

            for(amount = Convert.ToInt32(textBoxLoanAmount.Text); amount > 0; months ++)
            {
                amount = amount - payment;
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
                while (count >= 0);
                textBlockXToTheNthAnswer.Text = Convert.ToString(answer);
            if (count == 0)
            {
                answer = 1;
            }

        }

        public void HailstoneSeq()
        {
            int number = Convert.ToInt32(textBoxHailstoneStart.Text);
            string text = Convert.ToString(number);
            while (number != 1)
            {
                if(number == 1)
                {
                    break;
                }
                if(number % 2 == 0)
                {
                    number = number / 2;
                }
                else
                {
                    number = number * 3 + 1;
                }
                text = text + ", " + Convert.ToString(number);
                textBlockhailstoneAnswer.Text = text;
            }

        }

    }
}
