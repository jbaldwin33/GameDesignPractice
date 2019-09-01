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

    public string Name { get { return name; } set { name = value; } }
    public int CurrentHP { get { return currentHP; } set { currentHP = value; } }
    public int MaxHP { get { return maxHP; } set { maxHP = value; } }
    public int GoldAmount { get { return goldAmount; } set { goldAmount = value; } }
    public int CurrentExperience { get { return currentExperience; } set { currentExperience = value; } }
    public int CurrentLevel { get { return currentLevel; } set { currentLevel = value; } }
  }
}
