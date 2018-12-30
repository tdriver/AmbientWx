using NUnit.Framework;
using AmbientWx.Requests;

namespace AmbientWx.Tests
{
    [TestFixture]
    public class UserDeviceTests
    {       
        [Test]
        public void TestUserDevice()
        {            
            var request = UserDevicesRequest.GetUserDevices();
            Assert.That(request.Count>=1);
            Assert.False(string.IsNullOrEmpty(request[0].MacAddress));
            Assert.False(string.IsNullOrEmpty(request[0].Info.Location));
            Assert.False(string.IsNullOrEmpty(request[0].Info.Name));
            Assert.False(string.IsNullOrEmpty(request[0].LastData.ToString()));
        }
    }
}