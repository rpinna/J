using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cofamilies.Representations
{
  public class DefaultReminderRep : RepresentationBase
  {
    // Constructors

    public DefaultReminderRep()
    {
    }

    // Properties

    public string Id { get; set; }
    public string PersonId { get; set; }
    public int Delta { get; set; }
    public string Transport { get; set; }
    public string EntityType { get; set; }
  }
}
