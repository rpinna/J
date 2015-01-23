using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Representations.Get
{
  public class DeviceGet
  {
    public DateTime created { get; set; }
    public string id { get; set; }
    public string name { get; set; }
    public string os { get; set; }
    public string status { get; set; }
    public string token { get; set; }
  }
}
