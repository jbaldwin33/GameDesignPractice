using System;
using static Environment.Action;

namespace Environment
{
  public class Enemy : Character
  {
    string habitat;
    double aggro;
    double aggroRadius;
    double maxAggro;
    double maxWaryTime;
    EnemyType enemyType;

    public Enemy(double health, double attack, double defense, string habitat, double aggro, double aggroRadius, double maxAggro, double maxWaryTime, EnemyType enemyType) : base(health)
    {
      this.Attack = attack * (int)enemyType;
      this.Defense = defense * (int)enemyType;
      this.habitat = habitat;
      this.aggro = aggro;
      this.aggroRadius = aggroRadius;
      this.maxAggro = maxAggro;
      this.maxWaryTime = maxWaryTime;
      this.enemyType = enemyType;
    }

    public void DoAction(ActionType action)
    {
      switch (action)
      {
        case ActionType.Talk:
          break;
      }
    }
  }
}
