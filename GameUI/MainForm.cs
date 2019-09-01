using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Environment;

namespace GameUI
{
  public partial class MainForm : Form
  {
    private static PlayerCharacter player;

    public MainForm()
    {
      InitializeComponent();
      player = new PlayerCharacter("Kaito");
    }

    public static PlayerCharacter GetPlayer()
    {
      return player;
    }

    private void btnStatusScreen_Click(object sender, System.EventArgs e)
    {
      StatusScreen statusScreen = new StatusScreen();
      statusScreen.Show();
    }

    private void btnInventoryScreen_Click(object sender, System.EventArgs e)
    {
      throw new System.NotImplementedException();
    }

    private void btnCancel_Click(object sender, System.EventArgs e)
    {
      throw new System.NotImplementedException();
    }
  }
}
