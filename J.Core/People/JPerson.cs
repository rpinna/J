using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cofamilies.J.Core.People
{
  //{"email":"rob.pinna@cofamilies.com",
  // "firstName":"Rob",
  // "lastName":"Pinna",
  // "id":"PERSglmd63prcjdopwuhohw4h7owcgeu",
  // "avatarUrl":"",
  // "isDeleted":false,
  // "isZombie":false,
  // "memberSince":"2012-02-25T02:51:03.3582813Z",
  // "timezoneInfoId":"Central Standard Time"}

  public interface IJPerson
  {
    string AvatarUrl { get; set; }
    string Email { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    string Id { get; set; }
    bool IsDeleted { get; set; }
    bool IsZombie { get; set; }
    string MemberSinceISOString { get; set; }
    string TimeZoneInfoId { get; set; }
  }

  public class JPerson : IJPerson
  {
    [JsonProperty("avatarUrl")]
    public string AvatarUrl { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("firstName")]
    public string FirstName { get; set; }
 
    [JsonProperty("lastName")]
    public string LastName { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("isDeleted")]
    public bool IsDeleted { get; set; }

    [JsonProperty("isZombie")]
    public bool IsZombie { get; set; }

    [JsonProperty("memberSince")]
    public string MemberSinceISOString { get; set; }

    [JsonProperty("timeZoneInfoId")]
    public string TimeZoneInfoId { get; set; }
  }
}
