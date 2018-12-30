using System.Collections.Generic;
using AmbientWx.Models;
using AmbientWx.Util;

namespace AmbientWx.Requests
{
    /// <summary>
    /// Static class to use when getting User Devices from the Ambient Weather API.
    /// </summary>
    public static class UserDevicesRequest
    {
        /// <summary>
        /// Calls the User Devices Ambient Weather API to get a list of devices.
        /// </summary>
        /// <returns>List of <see cref="UserDevices"/></returns>
        public static List<UserDevices> GetUserDevices()
        {
            var address = Networking.GetFullUri("/v1/devices");
            return Networking.HttpGetCall<List<UserDevices>>(address).Result;
        }
    }


}