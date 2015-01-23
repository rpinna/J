using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cofamilies.Representations
{
  public class SeriesInfoRep : RepresentationBase
  {
    // Constructors

    public SeriesInfoRep()
    {
    }

    // Properties

    public string EventId { get; set; }
    public DateTime NextOccurrenceStartDateTime { get; set; }
  }
}
