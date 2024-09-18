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
            Assert.That(request.Count >= 1);
            Assert.That(string.IsNullOrEmpty(request[0].MacAddress), Is.False);
            Assert.That(string.IsNullOrEmpty(request[0].Info.Location), Is.False);
            Assert.That(string.IsNullOrEmpty(request[0].Info.Name), Is.False);
            Assert.That(string.IsNullOrEmpty(request[0].LastData.ToString()), Is.False);
        }
    }
}