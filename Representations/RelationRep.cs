using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cofamilies.Representations
{
  public class RelationChild
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
  }

  public class RelationRep : RepresentationBase
  {
    public bool IsConfirmed { get; set; }
    public string Name { get; set; }

    public RelationChild[] Children { get; set; }
  }
}
