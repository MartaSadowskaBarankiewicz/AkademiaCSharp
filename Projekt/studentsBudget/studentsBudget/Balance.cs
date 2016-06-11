using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Xml.Linq;

namespace studentsBudget
{
    public class Balance
    {
        public string Name { get; set; }
        public int SumValue { get; set; }
        private List<Item> _expenses;
        private List<Item> _incomes;
        private List<Credit> _credits;

        public Balance()
        {
            this.Name = "";
            this.SumValue = 0;
            this._expenses = new List<Item>();
            this._incomes = new List<Item>();
            this._credits = new List<Credit>();
        }
        public Balance(string name)
        {
            this.Name = name;
            this.SumValue = 0;
            this._expenses = new List<Item>();
            this._incomes = new List<Item>();
            this._credits = new List<Credit>();

        }

        public void AddIncome(Item newIncome)
        {
            this._incomes.Add(newIncome);
            this.SumValue += newIncome.Value;
        }

        public void AddExpense(Item newExpense)
        {
            this._expenses.Add(newExpense);
            this.SumValue -= newExpense.Value;
        }

        public void AddCredit(Credit newCredit)
        {
            this._credits.Add(newCredit);
            this.SumValue -= newCredit.Value;
        }

        public List<Item> GetIncomes()
        {
            this._incomes.Sort((IComparer<Item>) Item.sortItem());
            return this._incomes;
        }

        public List<Item> GetExpenses()
        {
            this._expenses.Sort(Item.sortItem());
            return this._expenses;
        }

        public List<Credit> GetCredits()
        {
            this._credits.Sort(Item.sortItem());
            return this._credits;
        }

        public List<Item> GetAll()
        {
            List<Item> all = new List<Item>();

            foreach (Item item in this._incomes)
            {
                all.Add(item);
            }
            foreach (Item item in this._expenses)
            {
                all.Add(item);
            }
            foreach (Credit item in this._credits)
            {
                all.Add(item);
            }

            all.Sort(Item.sortItem());
            return all;
        }

        public void RemoveItem(Item deleteItem)
        {
            try
            {
                switch (deleteItem.GetItemType())
                {
                    case Types.income:
                        {
                            this._incomes.Remove(deleteItem);
                            Item.SaveItemToXML(this._incomes, MainWindow.incomesFileName);
                            break;
                        }
                    case Types.expense:
                        {
                            this._expenses.Remove(deleteItem);
                            Item.SaveItemToXML(this._expenses, MainWindow.expensesFileName);
                            break;
                        }
                    case Types.credit:
                        {
                            this._credits.Remove(deleteItem as Credit);
                            Credit.SaveItemToXML(this._credits, MainWindow.creditsFileName);
                            break;
                        }

                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Nie wybrano wpisu do usunięcia.", "Błąd usunięcia");

            }
        }

        public void SetIncomes(List<Item>list)
        {
            this._incomes = list;
        }
        public void SetExpenses(List<Item> list)
        {
            this._expenses = list;
        }
        public void SetCredits(List<Credit> list)
        {
            this._credits = list;
        }

        public void CountBalance()
        {
            this.SumValue = 0;
            foreach (Item item in this._incomes)
            {
                this.SumValue += item.Value;
            }
            foreach (Item item in this._expenses)
            {
                this.SumValue -= item.Value;
            }
            foreach (Credit item in this._credits)
            {
                this.SumValue -= item.Value;
            }
        }
    }
}
