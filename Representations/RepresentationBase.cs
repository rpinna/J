using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cofamilies.Representations
{
  public abstract class RepresentationBase : IRestRepresentation
  {
    // Constructors

    protected RepresentationBase()
    {
      Links = new Links();
    }

    // Properties

    public Links Links;

    // Methods

    public LinkRep GetLink(string rel)
    {
      return Links.SingleOrDefault(x => x.Relationship == rel);
    }

    public List<LinkRep> GetLinks()
    {
      return Links.ToList();
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

    public bool HasRelationship(string rel)
    {
      return GetLinkRelationship(rel) != null;
    }

    protected string ToUrn(string s)
    {
      if (string.IsNullOrEmpty(s))
        return "";

      if (s.Contains("urn:"))
        return s;

      return "urn:cofamilies:" + s;
    }

    public virtual string RepresentationName
    {
      get { return GetType().Name; }
    }
  }
}
