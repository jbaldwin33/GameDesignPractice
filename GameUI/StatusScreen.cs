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
  public partial class StatusScreen : Form
  {
    PlayerCharacter player = MainForm.GetPlayer();
    public StatusScreen()
    {
      InitializeComponent();
      ShowStatus();
    }

    private void ShowStatus()
    {
      lblName2.Text = player.Name;
      lblLevel2.Text = player.CurrentLevel.ToString();
      lblExperience2.Text = player.CurrentExperience.ToString();
      lblGold2.Text = player.GoldAmount.ToString();
    }

    private void btnCancel_Click(object sender, System.EventArgs e)
    {
      this.Close();
    }

    public Label GetNameLabel()
    {
      return lblName2;
    }


    public Label GetLevelLabel()
    {
      return lblLevel2;
    }


    public Label GetExperienceLabel()
    {
      return lblExperience2;
    }

    public Label GetGoldLabel()
    {
      return lblGold2;
    }
  }
}
