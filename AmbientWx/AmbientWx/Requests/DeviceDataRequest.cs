using System;
using System.Collections.Generic;
using AmbientWx.Models;
using AmbientWx.Util;

namespace AmbientWx.Requests
{
    /// <summary>
    /// Static class to use when getting Device data from the Ambient Weather API.
    /// </summary>
    public static class DeviceDataRequest
    {
        /// <summary>
        /// Calls the Device data Ambient Weather API to get data from a device by mac address
        /// </summary>
        /// <returns>List of <see cref="DeviceData"/></returns>
        public static List<DeviceData> GetDeviceData(string macAddress = "",
                                                     DateTimeOffset? endDate = null,
                                                     int limit = 288)
        {
            // if the endDate is null, assume current UTC, and do not send a date
            // get the macAddress from the config file if not supplied
            string ma = macAddress;
            if(string.IsNullOrEmpty(ma)){
                ma = Networking.MacAddress;
                if(string.IsNullOrEmpty(ma)){
                    throw new ArgumentException(
                        "The macAddress is not defined in the config file and must be supplied to this method");
                }
            }

            // generate the query parameters
            var qp = new List<string>();
            if(endDate != null && endDate.HasValue){
                qp.Add("endDate");
                qp.Add(endDate.Value.ToUniversalTime().ToString("o"));
            }
            qp.Add("limit");
            qp.Add(limit.ToString());

            var address = Networking.GetFullUri("/v1/devices/" + ma,qp.ToArray());

            return Networking.HttpGetCall<List<DeviceData>>(address).Result;
        }
    }


}