using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Syndication;

namespace Cofamilies.Representations
{
  public class Feed<T> where T : class
  {
    // Constructors

    public Feed()
    {
      Items = new List<T>();
      Links = new Links();
    }
    
    // Properties

    protected List<T> Items { get; private set; }
    public Links Links;

    // Methods

    public void Add(T item)
    {
      Items.Add(item);
    }

    public void Add(IEnumerable<SyndicationLink> links)
    {
      foreach (var link in links)
        Links.Add(new LinkRep(link.RelationshipType, link.Uri));
    }

    public List<T> GetItems()
    {
      return Items;
    }
  }
}
