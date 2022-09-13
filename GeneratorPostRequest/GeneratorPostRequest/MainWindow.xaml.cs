using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace GeneratorPostRequest
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(XValye.Text) || string.IsNullOrEmpty(YValye.Text) || string.IsNullOrWhiteSpace(XValye.Text) || string.IsNullOrWhiteSpace(YValye.Text))
            {
                ErrorValye.Text = "Не введены данные";
                return;
            }

            ErrorValye.Text = "";

            HttpClient httpClient = new HttpClient();
            SumValue.Text = httpClient.PostAsync("http://172.16.193.234:10223/01/SSA/", new StringContent(XValye.Text.Trim() + " " + YValye.Text.Trim() + " " + "FourthTask")).Result.Content.ReadAsStringAsync().Result;

        }
    }
}