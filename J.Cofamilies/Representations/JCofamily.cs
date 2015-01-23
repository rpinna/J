using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cofamilies.J.People.Representations;

namespace Cofamilies.J.Cofamilies.Representations
{
  public class JCofamily
  {
    // Constructors

    public JCofamily()
    {
      people = new List<JPersonInRole>();
    }

    // Properties

    // ReSharper disable InconsistentNaming
    public IList<JPersonInRole> people;
    public string id;
    public bool isRemoved;
    public string name;
    public string ownership;
    public string primaryCoparentId;
    public string primaryHouseholdId;
    public string secondaryCoparentId;
    public string secondaryHouseholdId;
  }
}
