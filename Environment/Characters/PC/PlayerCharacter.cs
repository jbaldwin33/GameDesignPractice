using System;
using System.Collections.Generic;
using System.Text;

namespace Environment
{
  public class PlayerCharacter : LivingCreature
  {
    public PlayerCharacter(string name) : base(name, 20, 20)
    {
      GoldAmount = 0;
      CurrentExperience = 0;
      CurrentLevel = 1;
      Inventory = new List<InventoryItem>();
      Quests = new List<PlayerQuest>();
    }

    public int GoldAmount { get; set; }
    public int CurrentExperience { get; set; }
    public int CurrentLevel { get; set; }
    public List<InventoryItem> Inventory { get; set; }
    public List<PlayerQuest> Quests { get; set; }
  }
}
