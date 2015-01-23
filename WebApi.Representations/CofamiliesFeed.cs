using System.Collections.Generic;

namespace Cofamilies.WebApi.Representations
{
  public class CofamiliesFeed
  {
    public CofamiliesFeed()
    {
      items = new List<Cofamily>();
    }

    public List<Cofamily> items { get; set; }
  }
}
