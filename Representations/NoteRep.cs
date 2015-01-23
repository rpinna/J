using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cofamilies.Representations
{
  public class NoteRep : RepresentationBase
  {
    // Constructors

    public NoteRep()
    {
    }

    // Properties

    public string Body { get; set; }
    public DateTime? Created { get; set; }
    //public string CreatedByFirstName { get; set; }
    public string Id { get; set; }
  }
}
