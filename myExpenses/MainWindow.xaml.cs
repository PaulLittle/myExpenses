using System;
using System.Collections;
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

namespace myExpenses
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        ArrayList expense = new ArrayList();

        string[] categories = new string[] { "Travel", "Entertainment", "Office" };
        //double totalCost, totCost;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {           
            populateExpense();
        }

        private void populateExpense()
        {
            DateTime start;
            Random gen;
            int range;
            generateDate(out start, out gen, out range);

            Random rng = new Random(Environment.TickCount);
            expense.Add(new Expense()
            {
                Category = categories[rng.Next(categories.Length)],
                Cost = 0.01 + rng.NextDouble() * 100.00,
                IncurredDate = start.AddDays(gen.Next(range))
            });

            updateListbox();
            updateTextbox();
        }

        private void generateDate(out DateTime start, out Random gen, out int range)
        {
            start = new DateTime(2015, 9, 23);
            gen = new Random();
            range = (DateTime.Today - start).Days;
        }

        private void updateListbox()
        {
            lbxExpenses.Items.Clear();
            for (int i = 0; i < expense.Count; i++)
            {
                lbxExpenses.Items.Add(expense[i]);
            }
        }

        private void updateTextbox()
        {
            
           // totCost += tc;
            tbkTotalExpense.Text = ("Total is: €{0}")/*,Cost*/;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            populateExpense();
            updateListbox();
        }

        
    }
}
