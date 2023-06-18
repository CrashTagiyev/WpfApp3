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
namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public List<User> Users { get; set; } = new List<User> { };
        public MainWindow()
        {
            try
            {

                InitializeComponent();
                this.UsersList.ItemsSource = Users;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Name_tbox.Text == "" || Surname_tbox.Text == "") throw new Exception("Fill the boxes");
                UsersList.ItemsSource = null;
                Users.Add(new User(Name_tbox.Text, Surname_tbox.Text));
                UsersList.ItemsSource = Users;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
