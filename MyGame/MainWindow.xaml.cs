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

namespace MyGame
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    

    public MainWindow()
    {
      InitializeComponent();
    }


    private void btnStatus_Click(object sender, RoutedEventArgs e)
    {
      StatusScreen statusScreen = new StatusScreen();
      statusScreen.Show();
      this.Close();
    }

    private void btnInventory_Click(object sender, RoutedEventArgs e)
    {
      InventoryScreen inventoryScreen = new InventoryScreen();
      inventoryScreen.Show();
      this.Close();
    }
  }
}
