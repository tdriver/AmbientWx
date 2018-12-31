
using System;
using System.Collections.Generic;
using System.Globalization;
using AmbientWx.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AmbientWx.Models
{
    public partial class UserDevices
    {
        [JsonProperty("macAddress")]
        public string MacAddress { get; set; }

        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("lastData")]
        public LastData LastData { get; set; }
    }

    public partial class Info
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public partial class LastData
    {
        [JsonProperty("dateutc")]
        public long Dateutc { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("winddir")]
        public long Winddir { get; set; }

        [JsonProperty("windspeedmph")]
        public double Windspeedmph { get; set; }

        [JsonProperty("windgustmph")]
        public long Windgustmph { get; set; }

        [JsonProperty("maxdailygust")]
        public long Maxdailygust { get; set; }

        [JsonProperty("windgustdir")]
        public long Windgustdir { get; set; }

        [JsonProperty("winddir_avg2m")]
        public long WinddirAvg2M { get; set; }

        [JsonProperty("windspdmph_avg2m")]
        public double WindspdmphAvg2M { get; set; }

        [JsonProperty("winddir_avg10m")]
        public long WinddirAvg10M { get; set; }

        [JsonProperty("windspdmph_avg10m")]
        public double WindspdmphAvg10M { get; set; }

        [JsonProperty("tempf")]
        public double Tempf { get; set; }

        [JsonProperty("humidity")]
        public long Humidity { get; set; }

        [JsonProperty("baromrelin")]
        public double Baromrelin { get; set; }

        [JsonProperty("baromabsin")]
        public double Baromabsin { get; set; }

        [JsonProperty("tempinf")]
        public double Tempinf { get; set; }

        [JsonProperty("humidityin")]
        public long Humidityin { get; set; }

        [JsonProperty("hourlyrainin")]
        public long Hourlyrainin { get; set; }

        [JsonProperty("dailyrainin")]
        public long Dailyrainin { get; set; }

        [JsonProperty("monthlyrainin")]
        public long Monthlyrainin { get; set; }

        [JsonProperty("yearlyrainin")]
        public long Yearlyrainin { get; set; }

        [JsonProperty("feelsLike")]
        public double FeelsLike { get; set; }

        [JsonProperty("dewPoint")]
        public double DewPoint { get; set; }
    }
}
