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
using Library1;

namespace PR10
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
            if (double.TryParse(SquareDlina.Text, out double n))
            {
                double length = double.Parse(SquareDlina.Text);
                var (area, perimeter) = Class1.Square(length);
                SquareResult.Text = $"Площадь: {area}, Преиметр: {perimeter}";
            }
            else
            {
                MessageBox.Show("Введите корректное число.");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(CircusRadius.Text, out double n))
            {
                double radius = double.Parse(CircusRadius.Text);
                var (area, dlina) = Class1.Circle(radius);
                CircusResult.Text = $"Площадь: {area}, Преиметр: {dlina}";
            }
            else
            {
                MessageBox.Show("Введите корректное число.");
            }
        }
    }
}
