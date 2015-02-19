using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cofamilies.J.Core.Accounts
{
  public interface IJAccountCreateResult
  {
    string ActivationCode { get; set; }
  }

  public class JAccountCreateResult
  {
    [JsonProperty("activationCode")]
    public string ActivationCode { get; set; }

    [JsonProperty("personId")]
    public string PersonId { get; set; }
  }
}
