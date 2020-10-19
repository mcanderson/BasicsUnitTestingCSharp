using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;
using System;

namespace MyClassesTest
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileNameDoesExist()
        {
            // Step 1 Arrange
            // Class used in method
            FileProcess fp = new FileProcess();
            // Boolean returned from process
            bool fromCall;

            // Step 2 Act
            fromCall = fp.FileExists(@"C:\Windows\Regedit.exe");

            // Step 3 Assert
            Assert.IsTrue(fromCall);
        }
        [TestMethod]
        public void FileNameDoesNotExist()
        {
            // Step 1 Arrange
            // Class used in method
            FileProcess fp = new FileProcess();
            // Boolean returned from process
            bool fromCall;

            // Step 2 Act
            fromCall = fp.FileExists(@"C:\BadFileName.bad");

            // Step 3 Assert
            Assert.IsFalse(fromCall);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_ThrowsArgumentNullException()
        {
            FileProcess fp = new FileProcess();

            fp.FileExists("");
        }

        [TestMethod]
        public void FileNameNullOrEmpty_ThrowsArgumentNullException_UseTryCatch()
        {
            FileProcess fp = new FileProcess();

            try
            {
                fp.FileExists("");
            }
            catch(ArgumentNullException)
            {
                // Test was successful
                return;
            }

            // Shouldn't go this far so add Assert.Fail if it does
            Assert.Fail("Call to FileExists did NOT throw an ArgumentNullException.");
        }
    }
}
