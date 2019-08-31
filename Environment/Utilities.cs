using System;
using System.Collections.Generic;
using System.Text;

namespace Environment
{
  public class Utilities
  {
    public static double DamageCalculater(double attack, double defense)
    {
      return Math.Floor((double)(attack - (defense / 3)));
    }
  }
}
