using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Representations.Get;

namespace Cofamilies.WebApi.Representations.Feed
{
  public class DeviceFeed
  {
    public DeviceFeed()
    {
      devices = new List<DeviceGet>();
    }

    public List<DeviceGet> devices { get; set; }
  }
}
