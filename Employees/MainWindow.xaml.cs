﻿using System;
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


namespace Employees
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

        private void saveInfo(object sender, RoutedEventArgs e)
        {
            Employee emp = new Employee();
            emp.Name = textbox1.Text;
            emp.Age = int.Parse(textbox2.Text);
            emp.Country = combobox.Text;

        }

        

        //private void onSearch(object sender, TextChangedEventArgs e)
        //{
            
        //}
    }
}