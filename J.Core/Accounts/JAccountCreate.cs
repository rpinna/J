using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cofamilies.J.Core.Accounts
{
  public interface IJAccountCreate
  {
    bool AcceptTerms { get; set; }
    string Email { get; set; }
    string Name { get; set; }
    string Password { get; set; }
    bool SendActivationEmail { get; set; }
  }

  public class JAccountCreate : IJAccountCreate
  {
    [JsonProperty("acceptTerms")]
    public bool AcceptTerms { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("password")]
    public string Password { get; set; }

    [JsonProperty("sendActivationEmail")]
    public bool SendActivationEmail { get; set; }
  }
}

#if false
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cofamilies.J.Core.Perspective
{
  // Enumerations

  //public enum PerspectiveKind
  //{
  //  HeadOfHousehold = 1,
  //  Child = 2,
  //  Caregiver = 3,
  //  Professional = 4
  //}

  //public enum RootKind
  //{
  //  Cofamily = 1,
  //  Household = 2
  //}

  public interface IJPerspective
  {
    string Id { get; set; }
    string Kind { get; set; }
    string PersonId { get; set; }
    string RootKind { get; set; }
    string RootId { get; set; }
  }

  public class JPerspective : IJPerspective
  {
    public const string Kind_HeadOfHousehold = "HeadOfHousehold";
    public const string Kind_Child = "Child";

    public const string RootKind_Cofamily = "Cofamily";
    public const string RootKind_Household = "Household";

    [JsonProperty("id")]
    public string Id { get; set; }
    [JsonProperty("kind")]
    public string Kind { get; set; }
    [JsonProperty("person_id")]
    public string PersonId { get; set; }
    [JsonProperty("root_kind")]
    public string RootKind { get; set; }
    [JsonProperty("root_id")]
    public string RootId { get; set; }
  }
}

#endif
