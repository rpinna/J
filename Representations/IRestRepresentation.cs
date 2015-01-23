using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cofamilies.Representations
{
  public interface IRestRepresentation
  {
    string RepresentationName { get; }

    Uri GetLinkRelationship(string rel);
    Uri GetRequiredLinkRelationship(string rel);

    bool HasRelationship(string rel);
  }
}
