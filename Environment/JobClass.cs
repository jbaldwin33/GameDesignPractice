using System;
using System.Collections.Generic;
using System.Text;

namespace Environment
{
  public class JobClass
  {
    private double attack;
    public double Attack { get; set; }

    private double defense;
    public double Defense { get; set; }

    private double dexterity;
    public double Dexterity { get; set; }
  }

  public class ThiefClass : JobClass
  {
    public ThiefClass()
    {
      this.Attack = 2;
      this.Defense = 5;
      this.Dexterity = 10;
    }
  }

  public class Warrior : JobClass
  {
    public Warrior()
    {
      this.Attack = 7;
      this.Defense = 7;
      this.Dexterity = 4;
    }
  }

  public class Knight : JobClass
  {
    public Knight()
    {
      this.Attack = 5;
      this.Defense = 7;
      this.Dexterity = 5;
    }
  }
}
