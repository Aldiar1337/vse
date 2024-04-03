using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;


namespace WpfApp1
{
    public partial class MainWindow : Window
    {
    

    private void SortAscending_Click(object sender, RoutedEventArgs e)
    {
        numbers.Sort();
        UpdateListBox();
    }

    // Отсортировать по убыванию
    private void SortDescending_Click(object sender, RoutedEventArgs e)
    {
        numbers.Sort();
        numbers.Reverse();
        UpdateListBox();
    }
}
        
}

