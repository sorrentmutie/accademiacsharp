using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace LibreriaDaTestare.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FileEsiste()
        {
            // ARRANGE
            var helper = new FileHelper();
            var risultatoAtteso = true;

            //ACT
            var risultatoCalcolato = helper.FileEsiste(@"c:\windows\Notepad.exe");

            Assert.AreEqual(risultatoAtteso, risultatoCalcolato);
        }

        [TestMethod]
        public void FileNonEsiste()
        {
            // ARRANGE
            var helper = new FileHelper();
            var risultatoAtteso = false;

            //ACT
            var risultatoCalcolato = helper.FileEsiste(@"c:\windows\Notepadi.exe");

            Assert.AreEqual(risultatoAtteso, risultatoCalcolato);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EccezioneSollevataSeArgomentoNullo()
        {
            var helper = new FileHelper();

            
            var risultato = helper.FileEsiste("");
            
            Assert.Fail("Non è stata restituita una ArgumentNullException");
        }

        [TestMethod]
        public void ProvaMoq()
        {
         //   var mockedFileHelper = new Mock<FileHelper>();
         ////   mockedFileHelper.Setup(x => x.MyProperty).Returns(10);
         //   mockedFileHelper.Setup(x => x.FileEsiste(It.IsAny<string>())).Returns(true);
         //   var fileHelper = mockedFileHelper.Object;
            // ... 
            Assert.Inconclusive();
        }

    }
}