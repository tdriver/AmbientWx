using Newtonsoft.Json;
using System;

namespace AmbientWx.Models
{
    public class DeviceData
    {
        [JsonProperty("baromabsin")]
        public double Baromabsin { get; set; }

        [JsonProperty("monthlyrainin")]
        public double Monthlyrainin { get; set; }

        [JsonProperty("hourlyrainin")]
        public double Hourlyrainin { get; set; }

        [JsonProperty("weeklyrainin")]
        public double Weeklyrainin { get; set; }

        [JsonProperty("baromrelin")]
        public double Baromrelin { get; set; }

        [JsonProperty("dailyrainin")]
        public double Dailyrainin { get; set; }

        [JsonProperty("winddir")]
        public double Winddir { get; set; }

        [JsonProperty("windgustmph")]
        public double Windgustmph { get; set; }

        [JsonProperty("tempf")]
        public double Tempf { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        [JsonProperty("yearlyrainin")]
        public double Yearlyrainin { get; set; }

        [JsonProperty("feelsLike")]
        public double FeelsLike { get; set; }

        [JsonProperty("lastRain")]
        public DateTimeOffset LastRain { get; set; }

        [JsonProperty("eventrainin")]
        public double Eventrainin { get; set; }

        [JsonProperty("uv")]
        public double Uv { get; set; }

        [JsonProperty("dateutc")]
        public long Dateutc { get; set; }

        [JsonProperty("tempinf")]
        public double Tempinf { get; set; }

        [JsonProperty("humidityin")]
        public double Humidityin { get; set; }

        [JsonProperty("dewPoint")]
        public double DewPoint { get; set; }

        [JsonProperty("solarradiation")]
        public double Solarradiation { get; set; }

        [JsonProperty("windspeedmph")]
        public double Windspeedmph { get; set; }

        [JsonProperty("maxdailygust")]
        public double Maxdailygust { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        // Following properties were added and not part of the data returned by my WS-2000.
        // the provided data below is from the Ambient Weather Data Spec 
        // https://github.com/ambient-weather/api-docs/wiki/Device-Data-Specs
        [JsonProperty("windgustdir")]
        public double Windgustdir { get; set; }

        [JsonProperty("windspdmph_avg2m")]
        public double Windspdmph_avg2m { get; set; }

        [JsonProperty("winddir_avg2m")]
        public double Winddir_avg2m { get; set; }

        [JsonProperty("windspdmph_avg10m")]
        public double Windspdmph_avg10m { get; set; }

        [JsonProperty("winddir_avg10m")]
        public double Winddir_avg10m { get; set; }

        [JsonProperty("humidity1")]
        public double Humidity1 { get; set; }

        [JsonProperty("humidity2")]
        public double Humidity2 { get; set; }

        [JsonProperty("humidity3")]
        public double Humidity3 { get; set; }

        [JsonProperty("humidity4")]
        public double Humidity4 { get; set; }

        [JsonProperty("humidity5")]
        public double Humidity5 { get; set; }

        [JsonProperty("humidity6")]
        public double Humidity6 { get; set; }

        [JsonProperty("humidity7")]
        public double Humidity7 { get; set; }

        [JsonProperty("humidity8")]
        public double Humidity8 { get; set; }

        [JsonProperty("humidity9")]
        public double Humidity9 { get; set; }

        [JsonProperty("humidity10")]
        public double Humidity10 { get; set; }

        [JsonProperty("temp1f")]
        public double Temp1f { get; set; }

        [JsonProperty("temp2f")]
        public double Temp2f { get; set; }

        [JsonProperty("temp3f")]
        public double Temp3f { get; set; }

        [JsonProperty("temp4f")]
        public double Temp4f { get; set; }

        [JsonProperty("temp5f")]
        public double Temp5f { get; set; }

        [JsonProperty("temp6f")]
        public double Temp6f { get; set; }

        [JsonProperty("temp7f")]
        public double Temp7f { get; set; }

        [JsonProperty("temp8f")]
        public double Temp8f { get; set; }

        [JsonProperty("temp9f")]
        public double Temp9f { get; set; }

        [JsonProperty("temp10f")]
        public double Temp10f { get; set; }

        [JsonProperty("battout")]
        public string Battout { get; set; }

        [JsonProperty("24hourrainin")]
        public double Twentyfourhourrainin { get; set; }

        [JsonProperty("Totalrainin")]
        public double Totalrainin { get; set; }

        [JsonProperty("c02")]
        public double C02 { get; set; }

        [JsonProperty("batt1")]
        public string Batt1 { get; set; }

        [JsonProperty("batt2")]
        public string Batt2 { get; set; }

        [JsonProperty("batt3")]
        public string Batt3 { get; set; }

        [JsonProperty("batt4")]
        public string Batt4 { get; set; }

        [JsonProperty("batt5")]
        public string Batt5 { get; set; }

        [JsonProperty("batt6")]
        public string Batt6 { get; set; }

        [JsonProperty("batt7")]
        public string Batt7 { get; set; }

        [JsonProperty("batt8")]
        public string Batt8 { get; set; }

        [JsonProperty("batt9")]
        public string Batt9 { get; set; }

        [JsonProperty("batt10")]
        public string Batt10 { get; set; }

        [JsonProperty("relay1")]
        public bool Relay1 { get; set; }

        [JsonProperty("relay2")]
        public bool Relay2 { get; set; }

        [JsonProperty("relay3")]
        public bool Relay3 { get; set; }

        [JsonProperty("relay4")]
        public bool Relay4 { get; set; }

        [JsonProperty("relay5")]
        public bool Relay5 { get; set; }

        [JsonProperty("relay6")]
        public bool Relay6 { get; set; }

        [JsonProperty("relay7")]
        public bool Relay7 { get; set; }

        [JsonProperty("relay8")]
        public bool Relay8 { get; set; }

        [JsonProperty("relay9")]
        public bool Relay9 { get; set; }

        [JsonProperty("relay10")]
        public bool Relay10 { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this,Formatting.Indented);
        }
    }
}
