using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofamilies.J.Core.Results
{
  // ReSharper disable InconsistentNaming
  public class JResult
  {
    // Constructors

    public JResult()
    {
    }

    public JResult(Uri next, bool isSuccess = true, JErrorEntry error = null)
    {
      this.next = next;
      this.isSuccess = isSuccess;
      if (!isSuccess && error != null)
      {
        errorCount = 1;
        errors.Add(error);
      }
    }

    public JResult(bool isSuccess = true, JErrorEntry error = null)
    {
      this.isSuccess = isSuccess;
      if (!isSuccess && error != null)
      {
        errorCount = 1;
        errors.Add(error);
      }
    }

    // Properties

    public List<JErrorEntry> errors = new List<JErrorEntry>();
    public int errorCount = 0;
    public string id = null;
    public bool isSuccess = true;
    public bool isSessionExpired = false;
    public Uri next = null;

    // Methods

    public void Add(JErrorEntry error)
    {
      errors.Add(error);
      errorCount++;
    }
  }
  // ReSharper restore InconsistentNaming
}
