using Microsoft.VisualStudio.TestTools.UnitTesting;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Tests
{
    [TestClass()]
    public class HostTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            Host host = new Host
            {
                HostKey = "01234",
                PrivateName = "David",
                FamilyName = "Efrati",
                PhoneNumber = "718-234345",
                BankAccount = "Barclays bank, 770 Branch, Crown Height, Yenem",
                CollectionClearance = "No",
                MailAddress = "kukuforever@gmail.com"
            };
            Console.WriteLine(host);
            Assert.IsTrue(true);
        }
    }
}