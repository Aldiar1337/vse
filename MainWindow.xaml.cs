using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;



    public partial class MainWindow : Window
    {


        // Очистить список
        private void ClearList_Click(object sender, RoutedEventArgs e)
        {
            numbers.Clear();
            UpdateListBox();
        }


    }