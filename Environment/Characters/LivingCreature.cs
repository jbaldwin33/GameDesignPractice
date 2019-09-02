using System;
using System.Collections.Generic;
using System.Text;

namespace Environment
{
  public class LivingCreature
  {
    public LivingCreature(string name, double maximumHitPoints, double currentHitPoints)
    {
      Name = name;
      MaximumHitPoints = maximumHitPoints;
      CurrentHitPoints = currentHitPoints;
    }

    public string Name { get; set; }
    public double MaximumHitPoints { get; set; }
    public double CurrentHitPoints { get; set; }
  }
}
