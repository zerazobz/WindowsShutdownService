using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsShutdown.Service;

namespace WindowsShutDown.Service.Test
{
    [TestClass]
    public class TestNTPService
    {
        [TestMethod]
        public void GetCurrentDate()
        {
            DateTime expected = DateTime.Now;
            NTPService ntpService = new NTPService();

            var currentDate = ntpService.GetNetworkTime();

            Console.WriteLine($"Current: {expected.ToLocalTime()}");
            Console.WriteLine($"NTP: {currentDate.ToLocalTime()}");
            Assert.AreEqual(expected.Date, currentDate.Date);
        }
    }
}
