using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofamilies.J.Perspective
{
  // Enumerations

  public enum PerspectiveKind
  {
    HeadOfHousehold = 1,
    Child = 2,
    Caregiver = 3,
    Professional = 4
  }

  public enum RootKind
  {
    Cofamily = 1,
    Household = 2
  }

  public interface IJPerspective
  {
    string Id { get; set; }
    PerspectiveKind Kind { get; set; }
    RootKind RootKind { get; set; }
    string RootId { get; set; }
  }

  public class JPerspective : IJPerspective
  {
    public string Id { get; set; }
    public PerspectiveKind Kind { get; set; }
    public RootKind RootKind { get; set; }
    public string RootId { get; set; }
  }
}
