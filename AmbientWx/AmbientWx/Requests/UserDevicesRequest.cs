using System.Collections.Generic;
using AmbientWx.Models;
using AmbientWx.Util;

namespace AmbientWx.Requests{
    public static class UserDevicesRequest{

        public static List<UserDevices> GetUserDevices(){
            var address = Networking.GetFullUri("/v1/devices");
            return Networking.HttpGetCall<List<UserDevices>>(address).Result;
        }
    }


}