using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cofamilies.Representations
{
  public class EventAttendee
  {
    public string Id { get; set; }
    public string Role { get; set; }
  }

  public class EventRep : RepresentationBase
  {
    // Properties

    public string Description { get; set; }
    public DateTime EndDateTime { get; set; }
    public string Location { get; set; }
    public string OccurrenceId { get; set; }
    public string PersonId { get; set; }
    public string RecurrenceRule { get; set; }
    public string SourceId { get; set; }
    public DateTime StartDateTime { get; set; }
    public string Summary { get; set; }

    public EventAttendee[] Attendees { get; set; }
  }
}
