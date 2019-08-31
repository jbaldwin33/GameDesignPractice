using System;
using System.Collections.Generic;
using System.Text;

namespace Environment
{
  public class Attack
  {
    string name;
    int mpCost;
    int uses;
    int power;
    int accuracy;

    public Attack(string name, int mpCost, int uses, int power, int accuracy)
    {
      this.name = name;
      this.mpCost = mpCost;
      this.uses = uses;
      this.power = power;
      this.accuracy = accuracy;
    }
  }
}
