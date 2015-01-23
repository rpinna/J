using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cofamilies.J.Core.Perspective;
using Newtonsoft.Json;

namespace Cofamilies.J.Core.CommandMessages
{
  public class JGenericCommandMessage
  {
    [JsonProperty("command_uri")]
    public string CommandUri { get; set; }

    [JsonProperty("object_id")]
    public string ObjectId { get; set; }

    [JsonProperty("perspective")]
    public JPerspective Perspective { get; set; }

    [JsonProperty("properties")]
    public string Properties { get; set; }
  }
}
