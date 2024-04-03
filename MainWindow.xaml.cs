using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace WpfApp1
{


    public partial class MainWindow : Window
    {
        List<int> numbers = new List<int>();

        public MainWindow()
        {
            InitializeComponent();

        }

        // Помножить все числа на множитель
        private void MultiplyByFactor_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(numberTextBox.Text))
            {
                if (int.TryParse(numberTextBox.Text, out int factor))
                {
                    numbers = numbers.Select(num => num * factor).ToList();
                    UpdateListBox();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите допустимый множитель.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите множитель.");
            }
        }

        // Добавить число
        private void AddNumber_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(numberTextBox.Text))
            {
                if (int.TryParse(numberTextBox.Text, out int number))
                {
                    numbers.Add(number);
                    UpdateListBox();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите допустимое целое число».");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите число.");
            }
        }
        
        private void UpdateListBox()
        {
            numberListBox.ItemsSource = null;
            numberListBox.ItemsSource = numbers;
        }

    }


}