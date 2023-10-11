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

namespace Grid.MyPages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainTbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MainLb.Content = MainTbox.Text;
            //List<string> a = new List<string>{MainTbox.Text};
            MainCb.ItemsSource = new List<string> { MainTbox.Text };
            MaintBtn.Content = MainTbox.Text;
            MainTb.Text = MainTbox.Text;
            MainPb.Password = MainTbox.Text;
        }

        private void MaintBtn_Click(object sender, RoutedEventArgs e)
        {
            MainTbox.Text = "";
        }
    }
}
