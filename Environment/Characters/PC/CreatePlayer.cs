using System;
using System.Collections.Generic;
using System.Text;

namespace Environment
{
  public class CreatePlayer
  {
    public void DoCreatePlayer(string name, double health, JobClass jobClass)
    {
      PlayerCharacter player = new PlayerCharacter(name, health, jobClass);
    }
  }
}
