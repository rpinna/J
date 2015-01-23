using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cofamilies.Representations
{
  public class PersonRep : RepresentationBase
  {
    // Constructors

    public PersonRep()
    {
      IsRemoved = false;
    }

    // Properties

    public string Email { get; set; }
    public string FirstName { get; set; }
    public string Id
    {
      get
      {
        return _id;
      }
      set
      {
        _id = ToUrn(value);
      }
    }
    private string _id;

    public bool IsApproved { get; set; }
    public bool IsMember { get; set; }
    public bool IsRemoved { get; set; }
    public DateTime? LastInviteDate { get; set; }
    public string LastName { get; set; }
    public string TimeZoneInfo { get; set; }
  }
}
