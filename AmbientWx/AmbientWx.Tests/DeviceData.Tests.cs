using NUnit.Framework;
using AmbientWx.Requests;
using AmbientWx.Util;

namespace AmbientWx.Tests
{
    [TestFixture]
    public class DeviceDataTests
    {       
        [Test]
        public void TestDeviceData()
        {       
            var myData = DeviceDataRequest.GetDeviceData();
            Assert.That(myData.Count == 288);
            Assert.That(myData[0].Baromabsin > 0);
            Assert.That(myData[287].Baromabsin > 0);
        }
    }
}