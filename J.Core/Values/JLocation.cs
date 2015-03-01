using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cofamilies.J.Core.Values
{
  public class JLocation
  {
    [JsonProperty("lat")]
    public string Lattitude { get; set; }

    [JsonProperty("lng")]
    public string Longitude { get; set; }
  }
}
