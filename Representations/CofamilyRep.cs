using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cofamilies.Representations
{
  public class CofamilyRep : RepresentationBase
  {
    // Properties

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
  }
}
