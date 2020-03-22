using AmbientWx.Requests;
using NUnit.Framework;
using System;

namespace AmbientWx.Tests
{
    [TestFixture]
    public class DeviceDataTests
    {       
        [Test]
        public void TestDeviceData()
        {       
            var myData = DeviceDataRequest.GetDeviceData("",new DateTimeOffset(new DateTime(2020,2,1,0,0,0,DateTimeKind.Local)));
            Assert.That(myData.Count == 288);
            Assert.That(myData[0].Baromabsin > 0);
            Assert.That(myData[287].Baromabsin > 0);
        }
    }
}