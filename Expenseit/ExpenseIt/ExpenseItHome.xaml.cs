using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Collections.ObjectModel;

namespace ExpenseIt
{
    /// <summary>
    /// Interaction logic for ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Window,INotifyPropertyChanged
    {

        public ExpenseItHome()
        {
            InitializeComponent();
            MainCaptionText = "View Expense Report :";
            LastChecked = DateTime.Now;
            this.DataContext = this;
            PersonsChecked = new ObservableCollection<string>();
            ExpenseDataSource = new List<Person>()
            {
                new Person()
                {
                    Name="Mike",
                    Department="Legal",
                    Expense=new List<Expense>()
                    {
                        new Expense() { ExpenseType="Lunch", ExpenseAmount =50 },
                        new Expense() { ExpenseType="Transportation", ExpenseAmount=50 }
                    }

                },
                new Person()
                {
                     Name ="Lisa",
                     Department ="Marketing",
                   Expense = new List<Expense>()
                {
                 new Expense() { ExpenseType="Document printing", ExpenseAmount=50 },
                 new Expense() { ExpenseType="Gift", ExpenseAmount=125 }
                }
                },
                new Person()
                {
                  Name="John",
                  Department ="Engineering",
                  Expense = new List<Expense>()

                {
                 new Expense() { ExpenseType="New machine", ExpenseAmount=600 },
                 new Expense() { ExpenseType="Software", ExpenseAmount=500 }
                }
               },
                new Person()
                {
                 Name="Mary",
                 Department ="Finance",
                 Expense = new List<Expense>()
                 {
                  new Expense() { ExpenseType="Dinner", ExpenseAmount=100 }
                 }
                },
                new Person()
                {
                 Name="Theo",
                 Department ="Marketing",
                 Expense = new List<Expense>()
                 {
                 new Expense() { ExpenseType="Dinner", ExpenseAmount=100 }
                 }
                 },
                new Person()
                {
                 Name="James",
                 Department ="Finance",
                 Expense = new List<Expense>()
                 {
                 new Expense() { ExpenseType="Dinner", ExpenseAmount=100 }
                 }
                 },
                new Person()
                {
                 Name="David",
                 Department ="Cyber security",
                 Expense = new List<Expense>()
                 {
                 new Expense() { ExpenseType="Dinner", ExpenseAmount=100 }
                 }
                 }
            };

        }
        public event PropertyChangedEventHandler PropertyChanged;
        private DateTime lastChecked;
        public DateTime LastChecked
        {
            get { return lastChecked; }
            set
            {
                lastChecked = value;
                // Извикване на PropertyChanged
                if (PropertyChanged!=null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Last checked"));
                }
            }

        }


        public string MainCaptionText { get; set; }
        public List<Person> ExpenseDataSource { get; set; }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
             ExpenseReport expenseReport = new ExpenseReport(peopleListBox.SelectedItem);
            
             expenseReport.Show();



        }
        public ObservableCollection<string> PersonsChecked
        { get; set; }
        
        private void peopleListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
           
            LastChecked = DateTime.Now;
            PersonsChecked.Add(peopleListBox.SelectedItem.ToString());
            
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
