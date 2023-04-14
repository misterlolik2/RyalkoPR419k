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

namespace RyalkoPR419k
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

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox.Text.Length < 10 || textBox.Text.Length > 70) // в этой строке указывается диапазон длинны по заданию в билете
            {
                textBox.Background = Brushes.Red;
                string text = "не верно";
                textBlock.Text = text;

            }
            else
            {
                textBox.Background = Brushes.Green;
                string text1 = "верно";
                textBlock.Text = text1;
            }
        }

    }
}

