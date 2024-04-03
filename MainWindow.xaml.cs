using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;


namespace WpfApp1
{
    public partial class MainWindow : Window
    {

        private void ClearList_Click(object sender, RoutedEventArgs e)
        {
            numbers.Clear();
            UpdateListBox();
        }

    }
}
        
         

