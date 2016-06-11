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

namespace studentsBudget
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Balance mainBalance;
        private AddingIncome addingIncomeWindow;
        private AddingExpense addingExpenseWindow;
        private AddingCredit addingCreditWindow;
        public static string incomesFileName = "Incomes";
        public static string expensesFileName = "Expenses";
        public static string creditsFileName = "Credits";

        public MainWindow()
        {
            InitializeComponent();
            mainBalance = new Balance("Moje");

           this.mainBalance.SetIncomes(Item.OpenItemFromXML(incomesFileName));
           this.mainBalance.SetExpenses(Item.OpenItemFromXML(expensesFileName));
           this.mainBalance.SetCredits(Credit.OpenItemFromXML(creditsFileName));
           this.SummaryView.ItemsSource = mainBalance.GetAll();
           this.mainBalance.CountBalance();
           this.BalanceValueLabel.Content = this.mainBalance.SumValue.ToString();
        }

        public void RemoveItem_OnClick(object sender, RoutedEventArgs routedEventArgs)
        {
            Item selected = (Item)this.SummaryView.SelectedItem;
            this.mainBalance.RemoveItem(selected);
            this.SummaryView.ItemsSource = mainBalance.GetAll();
            this.BalanceCount();
        }

        private void ShowIncomsButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.SummaryView.ItemsSource = mainBalance.GetIncomes();
        }

        private void ShowExpensesButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.SummaryView.ItemsSource = mainBalance.GetExpenses();
        }

        private void ShowCreditsButton_OnClick(object sender, RoutedEventArgs e)
        {

            this.SummaryView.ItemsSource = mainBalance.GetCredits();
        }
        private void ShowAllButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.SummaryView.ItemsSource = mainBalance.GetAll();
        }

        private void Balance_OnLoaded(object sender, RoutedEventArgs e)
        {
            this.BalanceCount();
        }

        private void BalanceCount()
        {
            this.mainBalance.CountBalance();
            this.BalanceValueLabel.Content = this.mainBalance.SumValue.ToString();

            if (mainBalance.SumValue <= 0)
            {
                this.BalanceValueLabel.Foreground = Brushes.Crimson;
            }
            else
            {
                this.BalanceValueLabel.Foreground = Brushes.Green;
            }
        }
        private void AddIncomeButton_OnClick(object sender, RoutedEventArgs e)
        {
            addingIncomeWindow = new AddingIncome(this);
            addingIncomeWindow.ShowDialog();
            this.SummaryView.ItemsSource = mainBalance.GetAll();
            this.BalanceCount();
            Item.SaveItemToXML(this.mainBalance.GetIncomes(), incomesFileName);
        }

        private void AddExpenseButton_OnClick(object sender, RoutedEventArgs e)
        {
            addingExpenseWindow = new AddingExpense(this);
            addingExpenseWindow.ShowDialog();
            this.SummaryView.ItemsSource = mainBalance.GetAll();
            this.BalanceCount();
            Item.SaveItemToXML(this.mainBalance.GetExpenses(), expensesFileName);
        }

        private void AddCreditButton_OnClick(object sender, RoutedEventArgs e)
        {
            addingCreditWindow=new AddingCredit(this);
            addingCreditWindow.ShowDialog();
            this.SummaryView.ItemsSource = mainBalance.GetAll();
            this.BalanceCount();
            Credit.SaveItemToXML(this.mainBalance.GetCredits(), creditsFileName);
        }
    }
}
