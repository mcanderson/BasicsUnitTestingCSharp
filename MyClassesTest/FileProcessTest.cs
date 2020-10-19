using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;

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
        public void FileNameNullOrEmpty_ThrowsArgumentNullException()
        {
            // TODO write unit test
            Assert.Inconclusive();
        }
    }
}
