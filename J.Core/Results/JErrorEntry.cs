using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofamilies.J.Core.Results
{
  // ReSharper disable InconsistentNaming
  public class JErrorEntry
  {
    // Constructors

    #region JErrorEntry
    /// <summary>
    /// Creates a new JErrorEntry
    /// </summary>
    /// <param name="property">Name of property involved in the error</param>
    /// <param name="message">Error message</param>
    /// <param name="value">Value of property involved in the error</param>
    public JErrorEntry(string property, string message, string value = null)
    {
      property = property;
      message = message;
      value = value;
    }
    #endregion

    // Properties

    public string property;
    public string message;
    public string value;

    // Methods

    public string ToLogString()
    {
      if (string.IsNullOrEmpty(property))
        return message;

      return string.Format("{0}={2} ({1})", property, message, value);
    }
  }
  // ReSharper restore InconsistentNaming
}
