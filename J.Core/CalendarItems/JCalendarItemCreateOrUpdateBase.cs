using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cofamilies.J.Core.Values;
using Newtonsoft.Json;

namespace Cofamilies.J.Core.CalendarItems
{
  public class JCalendarItemCreateOrUpdateBase
  {
    [JsonProperty("activityId")]
    public string ActivityId { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("endDate")]
    public string EndDate { get; set; }

    [JsonProperty("endDateTime")]
    public string EndDateTime { get; set; }

    [JsonProperty("eventId")]
    public string EventId { get; set; }

    [JsonProperty("isAllDay")]
    public bool IsAllDay { get; set; }

    [JsonProperty("location")]
    public JLocation Location { get; set; }

    [JsonProperty("locationText")]
    public string LocationText { get; set; }

    [JsonProperty("people")]
    public List<JEventPerson> People { get; set; }

    [JsonProperty("range")]
    public string Range { get; set; }

    [JsonProperty("recurrenceRule")]
    public string RecurrenceRule { get; set; }

    [JsonProperty("startDate")]
    public string StartDate { get; set; }

    [JsonProperty("startDateTime")]
    public string StartDateTime { get; set; }

    [JsonProperty("summary")]
    public string Summary { get; set; }
  }
}
