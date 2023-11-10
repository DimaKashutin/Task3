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

namespace Variant1
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
            TextBox[] textBoxes = new[] { number_one, number_two, number_three };

            int proiz = 1;
            foreach (var td in textBoxes)
            {
                int number = 0;
                int.TryParse(td.Text, out number);
                proiz *= number;
            }
            result.Text = "Произведение: " + proiz;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox[] textBoxes = new[] { number_one, number_two, number_three };

            int sum = 0;
            foreach(var td in textBoxes)
            {
                int number = 0;
                int.TryParse(td.Text, out number);
                sum += number;
            }
            result.Text = "Сумма: " + sum;

        }
    }
}
