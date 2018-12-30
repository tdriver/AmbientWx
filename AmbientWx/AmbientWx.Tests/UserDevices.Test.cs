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
        }
    }
}