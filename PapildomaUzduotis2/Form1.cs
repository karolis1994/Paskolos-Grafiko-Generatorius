using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PapildomaUzduotis2
{
    public partial class Form1 : Form
    {

        private DateTime _date;
        private float _loan;
        private float _interestRate;
        private int _paymentCount;
        private StringBuilder csv = new StringBuilder();
        private float _monthlyRate;
        private float _monthlyPayment;

        public Form1()
        {
            InitializeComponent();
        }

        private void loanTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!checkIfInt32(loanTextBox.Text))
                loanTextBox.Text = string.Empty;
        }

        private void interestRateTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(interestRateTextBox.Text, "^[0-9]+$"))
                interestRateTextBox.Text = string.Empty;
            else if (Int32.Parse(interestRateTextBox.Text) > 100)
                interestRateTextBox.Text = string.Empty;
        }

        private void paymentsCountTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!checkIfInt32(paymentsCountTextBox.Text))
                paymentsCountTextBox.Text = string.Empty;
        }

        private bool checkIfInt32(string text)
        {
            int number;
            if (!System.Text.RegularExpressions.Regex.IsMatch(text, "^[0-9]+$"))
                return false;
            if (!Int32.TryParse(text, out number))
                return false;
            return true;
        }

        private bool CheckIfDate(string text)
        {
            if (!DateTime.TryParseExact(text, "yyyy/mm/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _date))
                return false;
            return true;
        }

        private bool CheckIfParametersNotEmpty()
        {
            if (startingDateTextBox.Text == string.Empty)
                return false;
            if (loanTextBox.Text == string.Empty)
                return false;
            if (interestRateTextBox.Text == string.Empty)
                return false;
            if (paymentsCountTextBox.Text == string.Empty)
                return false;
            return true;
        }

        private void AssignAllParameters()
        {
            string s1 = "Payment #";
            string s2 = "Payment date";
            string s3 = "Remaining amount";
            string s4 = "Principal payment";
            string s5 = "Interest payment";
            string s6 = "Total payment";
            string s7 = "Interest rate";
            string newLine = string.Format("{0},{1},{2},{3},{4},{5},{6}", s1, s2, s3, s4, s5, s6, s7);
            csv.AppendLine(newLine);
            _loan = Int32.Parse(loanTextBox.Text);
            _interestRate = Int32.Parse(interestRateTextBox.Text);
            _paymentCount = Int32.Parse(paymentsCountTextBox.Text);
            _interestRate = Int32.Parse(interestRateTextBox.Text);
            _monthlyRate = _interestRate / 100 / 12;
            _monthlyPayment = (float)((_monthlyRate / (1 - (Math.Pow((1 + _monthlyRate), -(_paymentCount))))) * _loan);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (!CheckIfParametersNotEmpty())
            {
                resultLabel.Text = "Type in the parameters";
                return;
            }
            if (!CheckIfDate(startingDateTextBox.Text))
            {
                startingDateTextBox.Text = string.Empty;
                resultLabel.Text = "Incorrect date format";
                return;
            }
            AssignAllParameters();
            int paymentNum = 0;
            for (var i = 0; i < _paymentCount; i++)
            {
                paymentNum++;
                float interestForMonth = _loan*_monthlyRate;
                float principalForMonth = _monthlyPayment - interestForMonth;
                string newLine = string.Format("{0},{1},{2},{3},{4},{5},{6}", paymentNum,
                    _date.ToShortDateString(), _loan.ToString("0.00"), principalForMonth.ToString("0.00"),
                    interestForMonth.ToString("0.00"), (principalForMonth + interestForMonth).ToString("0.00"),
                    _interestRate);
                _loan -= principalForMonth;
                csv.AppendLine(newLine);
                _date = _date.AddMonths(1);
            }
            File.WriteAllText(Directory.GetCurrentDirectory() + "\\Uzduotis.csv", csv.ToString());
            resultLabel.Text = "The file has been generated";
        }

    }
}
