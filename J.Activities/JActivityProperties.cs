using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace J.Cofamilies.Activities
{
  public class JActivityProperties
  {
    [JsonProperty("actor_id")]
    public string ActorId { get; set; }

    [JsonProperty("created")]
    public DateTime Created { get; set; }

    [JsonProperty("object_type")]
    public string ObjectType { get; set; }

    [JsonProperty("properties")]
    public string Properties { get; set; }

    [JsonProperty("verb")]
    public string Verb { get; set; }
  }
}
