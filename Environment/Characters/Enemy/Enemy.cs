using System;
using System.Collections.Generic;

namespace Environment
{
  public class Enemy : LivingCreature
  {
    public Enemy(int id, string name, double maximumHitPoints, double currentHitPoints, int maximumDamage, int rewardExperiencePoints, int rewardGold) : base(name, maximumHitPoints, currentHitPoints)
    {
      ID = id;
      MaximumDamage = maximumDamage;
      RewardExperiencePoints = rewardExperiencePoints;
      RewardGold = rewardGold;
      LootTable = new List<LootItem>();
    }

    public int ID { get; set; }
    public int MaximumDamage { get; set; }
    public int RewardExperiencePoints { get; set; }
    public int RewardGold { get; set; }
    public List<LootItem> LootTable { get; set; }
  }
}
