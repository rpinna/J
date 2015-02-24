using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cofamilies.J.Core.Activities
{
  public interface IJActivity
  {
    string ActorId { get; }
    DateTime Created { get; }
    string Id { get; }
    string Instance { get; }
    bool IsRemoved { get; }
    DateTime LastModified { get; }
    string ObjectId { get; }
    string Properties { get; }
    string TargetId { get; }
    string Title { get; }
    string Verb { get; }
  }

  public class JActivity : IJActivity
  {
    [JsonProperty("actorId")]
    public string ActorId { get; set; }

    [JsonProperty("created")]
    public DateTime Created { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }
    
    [JsonProperty("instance")]
    public string Instance { get; set; }
    
    [JsonProperty("isRemoved")]
    public bool IsRemoved { get; set; }
    
    [JsonProperty("lastModified")]
    public DateTime LastModified { get; set; }

    [JsonProperty("objectId")]
    public string ObjectId { get; set; }

    [JsonProperty("properties")]
    public string Properties { get; set; }

    [JsonProperty("targetId")]
    public string TargetId { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("verb")]
    public string Verb { get; set; }
  }
}

