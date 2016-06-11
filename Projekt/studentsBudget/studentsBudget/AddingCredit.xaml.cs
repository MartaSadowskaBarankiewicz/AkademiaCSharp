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
using System.Windows.Shapes;

namespace studentsBudget
{
    /// <summary>
    /// Interaction logic for AddingCredit.xaml
    /// </summary>
    public partial class AddingCredit : Window
    {
        private MainWindow ParentWindow { get; set; }

        public AddingCredit(MainWindow parent)
        {
            InitializeComponent();
            this.ParentWindow = parent;
        }

        private void CancelButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = this.NameItemTextBox.Text;
                int value = int.Parse(this.ValueItemTextBox.Text);
                string date = this.DateItemTextBox.Text;
                string payDate = this.PayDateItemTextBox.Text;
                string lender=this.LenderItemTextBox.Text;
                Credit newItem = new Credit(name, value, date, payDate, lender);
                this.ParentWindow.mainBalance.AddCredit(newItem);
                this.Close();  
            }
            catch (System.ArgumentNullException)
            {
                MessageBox.Show("Nie uzupełniono wszystkich pól!", "Błąd dodania");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Zły format danych!", "Błąd dodania");
            }         
        }
    }
}
