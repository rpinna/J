using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cofamilies.J.Core.Values
{
  public class JEventPerson
  {
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("role")]
    public string Role { get; set; }
  }
}
