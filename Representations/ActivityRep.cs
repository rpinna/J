using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cofamilies.Representations
{
  public class ActivityRep : RepresentationBase
  {
    // Constructors

    public ActivityRep()
    {
    }

    // Properties

    public string Id { get; set; }
    public string ActorId { get; set; }
    public string ObjectId { get; set; }
    public string Verb { get; set; }
    public string TargetId { get; set; }
    public DateTime Published { get; set; }
    public DateTime Updated { get; set; }
    public string Title { get; set; }
  }
}
