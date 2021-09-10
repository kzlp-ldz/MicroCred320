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

namespace MicroCred320
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double loanSum = double.Parse(tbxCreditSum.Text);
            int term = int.Parse(tbxCreditTerm.Text);

            //Сделать ввод из текстового файла. Возможно словарь - день:процент. В тхт файле "от до %"
            double percent = 0.8;

            double percentSum = loanSum * percent / 100 * term;

            tbPaymentSum.Text = $"Общая сумма выплаты: {Convert.ToString(loanSum + percentSum)}";
            tbCreditSum.Text = $"Сумма долга: {Convert.ToString(percentSum)}";
            tbEffRate.Text = $"Эффективная ставка: {Convert.ToString(Math.Round(percentSum / loanSum / term * 100, 2))}";
            tbxResult.Text = Convert.ToString(loanSum);
        }
    }
}
