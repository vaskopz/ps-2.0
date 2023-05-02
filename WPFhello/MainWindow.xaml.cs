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

namespace WPFhello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListBoxItem james = new ListBoxItem();
            james.Content = "James";
            peopleListBox.Items.Add(james);
            ListBoxItem david = new ListBoxItem();
           david.Content = "David";
            peopleListBox.Items.Add(david);
            peopleListBox.SelectedItem = james;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = "";
            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox)
                {
                    s = s + ((TextBox)item).Text;
                    s = s + '\n';
                }
            }
            if (s.Length > 2)
            {
                MessageBox.Show("Здрасти " + s + "!!! \nТова е твоята първа програма на VisualStudio 2012!");
            } else
            {
                MessageBox.Show("Моля въведете повече от 2 символа!");
            }
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is Windows Presentation Foundation!");
            textBlock1.Text = DateTime.Now.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string greetingMsg;
            greetingMsg = peopleListBox.SelectedItem.ToString();
            MyMessage anotherWindow = new MyMessage();
            anotherWindow.Show(); ;
            (peopleListBox.SelectedItem as ListBoxItem).Content.ToString();
        }
    }
}
