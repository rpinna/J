using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cofamilies.Representations
{
  public class InvitationRep : RepresentationBase
  {
    public string Id { get; set; }
    public string InitiatorId { get; set; }
    public string PersonId { get; set; }
    public string Status { get; set; }
  }
}
