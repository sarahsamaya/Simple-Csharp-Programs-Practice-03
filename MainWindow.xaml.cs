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

namespace AssLoanAmountCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double myPV; // loan amoybt
        double myI; //Interest rate
        int myN; //number of months
        double myPMT; //monthly payment result
        public MainWindow()
        {
            InitializeComponent();

            lbError.Visibility = Visibility.Hidden;

            tbIntRate.Visibility = Visibility.Visible;
            tbLoanAmount.Visibility = Visibility.Visible;
            tbNumbMonth.Visibility = Visibility.Visible;


            lbLoanAmount.Visibility = Visibility.Visible;
            lbInterestRat.Visibility = Visibility.Visible;
            lbNumberMonths.Visibility = Visibility.Visible;




        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if ((myPV > 0) && (myI > 0) && (myN > 0))
            {
                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Calculate Confirmation", System.Windows.MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {

                    try
                    {

                        double rateCompounded = myI / 1200;
                        myPMT = (rateCompounded * myPV) / (1 - Math.Pow(1 + rateCompounded, myN * (-1)));

                        tblockResult.Visibility = Visibility.Visible;



                    }
                    catch
                    {
                        MessageBox.Show("Something went wrong!");
                    }
                }
                else if (messageBoxResult == MessageBoxResult.No)
                {
                    tbLoanAmount.Clear();
                    tbIntRate.Clear();
                    tbNumbMonth.Clear();
                    lbError.Content = "";
                    LbResult.Content = "";

                    myPV = 0;
                    myI = 0;
                    myN = 0;
                    myPMT = 0;
                }


                if (myPMT > 0 && !myPMT.Equals(null))
                {
                    LbResult.Content = "Monthly Payment is " + myPMT.ToString("C");
                }
            }
            else
            {
                MessageBox.Show("All fields are mandatory and need to be greater than 0, please complete.");
            }
        }

    

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            tbLoanAmount.Clear();
            tbIntRate.Clear();
            tbNumbMonth.Clear();
            lbError.Content = "";
            LbResult.Content = "";

            myPV = 0;
            myI = 0;
            myN = 0;
            myPMT = 0;

        }

        private void tbLoanAmount_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            try
            {
                myPV = double.Parse(tbLoanAmount.Text);
                if (double.TryParse(tbLoanAmount.Text, out myPV))
                {
                    lbError.Visibility = Visibility.Hidden;
                }
            }
            catch (Exception ex)
            {
                lbError.Visibility = Visibility.Visible;
                lbError.Content = ex.GetBaseException().Message;
                tbLoanAmount.Clear();
            }
        }

        private void tbIntRate_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            try
            {
                myI = double.Parse(tbIntRate.Text);
                if (double.TryParse(tbIntRate.Text, out myI))
                {
                    lbError.Visibility = Visibility.Hidden;


                }

            }
            catch (Exception ex)
            {
                lbError.Visibility = Visibility.Visible;
                lbError.Content = ex.GetBaseException().Message;
                tbIntRate.Clear();
            }
        }

        private void tbNumbMonth_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            try
            {
                myN = int.Parse(tbNumbMonth.Text);

                if (int.TryParse(tbNumbMonth.Text, out myN))
                {
                    lbError.Visibility = Visibility.Hidden;

                    if (myN <= 0 || myN  > 12)
                    {
                        MessageBox.Show("The number of months must be greater than 0, and less than or equal to 12");
                        tbNumbMonth.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                lbError.Visibility = Visibility.Visible;
                lbError.Content = ex.GetBaseException().Message;
                tbNumbMonth.Clear();
            }
        }
    }
}
