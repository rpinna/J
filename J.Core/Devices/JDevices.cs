using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cofamilies.J.Core.Devices
{
  public class JDevices
  {
    public JDevices()
    {
      Devices = new List<JDevice>();
    }

    [JsonProperty("devices")]
    public List<JDevice> Devices { get; private set; } 
  }
}
