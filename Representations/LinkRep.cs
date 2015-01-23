using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cofamilies.Representations
{
  public class LinkRep
  {
    // Constructors

    public LinkRep()
    {
      
    }

    public LinkRep(string relationship, Uri uri)
    {
      Relationship = relationship;
      Uri = uri;
    }

    // Properties

    public string Relationship { get; set; }
    public string Type { get; set; }
    public Uri Uri { get; set; }
  }
}
