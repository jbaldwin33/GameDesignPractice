using System;
using System.Collections.Generic;
using System.Text;

namespace Environment
{
  public class GlobalVariables
  {
    public List<Attack> attackList = new List<Attack>();

    public void InitializeAttacks()
    {
      attackList.Add(new Attack("Tackle", 1, 40, 10, 100));
      attackList.Add(new Attack("Scratch", 2, 40, 10, 100));
      attackList.Add(new Attack("Bite", 2, 40, 15, 100));
      attackList.Add(new Attack("DoubleEdge", 5, 20, 50, 80));
    }
  }
}
