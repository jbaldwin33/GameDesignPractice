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

namespace MyGame
{
  /// <summary>
  /// Interaction logic for StatusScreen.xaml
  /// </summary>
  public partial class StatusScreen : Page
  {
    public StatusScreen()
    {
      InitializeComponent();
    }


    private void btnCancel_Click(object sender, RoutedEventArgs e)
    {
      MainWindow mw = new MainWindow();
      this.NavigationService.Navigate(mw);
    }

    public Label GetNameLabel()
    {
      return lblName;
    }

    public Label GetLevelLabel()
    {
      return lblLevel;
    }

    public Label GetGoldLabel()
    {
      return lblGold;
    }

    public Label GetExperienceLabel()
    {
      return lblExperience;
    }
  }
}
