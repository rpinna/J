using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cofamilies.Representations
{
  public class Links : List<LinkRep>, ILinks
  {
    // Methods

    public void Add(string baseURI, string relativeURI, params string[] relationships)
    {
      foreach (string relationship in relationships)
        Add(new LinkRep() { Relationship = relationship, Type = "", Uri = new Uri(baseURI + relativeURI) });
    }

    public LinkRep GetLink(string rel)
    {
      return this.SingleOrDefault(x => x.Relationship == rel);
    }

    public Uri GetLinkRelationship(string rel)
    {
      var link = GetLink(rel);
      return link == null ? null : link.Uri;
    }

    public Uri GetRequiredLinkRelationship(string rel)
    {
      var result = GetLinkRelationship(rel);
      if (result == null)
        throw new ArgumentException("Required relationship not found: " + rel);

      return result;
    }

    public List<LinkRep> GetLinkReps()
    {
      return this.ToList();
    }
  }
}
