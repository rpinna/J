using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cofamilies.Representations
{
  public class RegistrationRep : RepresentationBase
  {
    // Properties

    public string Email { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string TimeZone { get; set; }
  }
}
