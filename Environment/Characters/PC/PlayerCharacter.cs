using System;
using System.Collections.Generic;
using System.Text;

namespace Environment
{
  public class PlayerCharacter : Character
  {
    string name;
    JobClass jobClass;


    public PlayerCharacter(string name, double health, JobClass jobClass) : base(health)
    {
      this.name = name;
      this.jobClass = jobClass;
    }
  }
}
