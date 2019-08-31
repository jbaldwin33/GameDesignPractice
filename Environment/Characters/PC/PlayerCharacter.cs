using System;
using System.Collections.Generic;
using System.Text;

namespace Environment
{
  public class PlayerCharacter
  {
    private string name;
    private int currentHP = 20;
    private int maxHP = 20;
    private int goldAmount = 0;
    private int currentExperience = 0;
    private int currentLevel = 1;
    //List<Items> heldItems;



    public PlayerCharacter(string name)
    {
      this.name = name;
    }

    public string Name { get; set; }
    public int CurrentHP { get; set; }
    public int MaxHP { get; set; }
    public int GoldAmount { get; set; }
    public int CurrentExperience { get; set; }
    public int CurrentLevel { get; set; }
  }
}
