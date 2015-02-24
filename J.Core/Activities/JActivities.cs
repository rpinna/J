using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cofamilies.J.Core.Activities
{
  public class JActivities
  {
    public JActivities()
    {
      Activities = new List<JActivity>();
    }

    [JsonProperty("activities")]
    public List<JActivity> Activities { get; private set; } 
  }
}
