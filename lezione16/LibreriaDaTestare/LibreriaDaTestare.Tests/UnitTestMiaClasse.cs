using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDaTestare.Tests
{
    [TestClass]
    public class UnitTestMiaClasse
    {
        [TestMethod]
        public void TestaMioMetodo()
        {
            // Arrange
            // ISmtpSender smtpSender = new SmtpSender();
            var mockSmptSender = new Mock<ISmtpSender>();
            mockSmptSender.Setup(x => x.SendEmail(It.IsAny<string>())).Returns(true);

            var miaClasse = new MiaClasse(mockSmptSender.Object);
            var valoreCalcolato = miaClasse.MioMetodo();
            Assert.IsTrue(valoreCalcolato);
        }
    }
}
