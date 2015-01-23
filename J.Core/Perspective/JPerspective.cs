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
