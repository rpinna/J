using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cofamilies.J.People.Registrations
{
  public class JRegistrationCommandProperties
  {
    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("first_name")]
    public string FirstName { get; set; }

    [JsonProperty("host_address")]
    public string HostAddress { get; set; }

    [JsonProperty("last_name")]
    public string LastName { get; set; }

    [JsonProperty("partner_key")]
    public string PartnerKey { get; set; }

    [JsonProperty("password")]
    public string Password { get; set; }
  }
}
