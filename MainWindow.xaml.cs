using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;


namespace WpfApp1
{
    
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

    
        private void ClearList_Click(object sender, RoutedEventArgs e)
        {
            numbers.Clear();
            UpdateListBox();
        }
    
}
        
         

