﻿using System.Windows;

namespace SerialsApp.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var helper = new SQLiteHelper();
            helper.PopulateTree(serialsTree);
        }
    }
}
