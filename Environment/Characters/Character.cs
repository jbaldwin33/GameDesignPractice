using System;
using System.Collections.Generic;
using System.Text;

namespace Environment
{
  public class Character
  {
    public Character(double health)
    {
      this.health = health;
    }

    public void DoAttackOrDefend(Character attacker, double attackStat, Character defender, double defenseStat)
    {
      defender.Health = Utilities.DamageCalculater(attackStat, defenseStat);
    }

    private double health;
    public double Health { get; set; }

    private double attack;
    public double Attack { get; set; }

    private double defense;
    public double Defense { get; set; }

    private double dexterity;
    public double Dexterity { get; set; }
  }
}
