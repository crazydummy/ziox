namespace Ziox.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using Ziox;

    [TestClass()]
    public class NotImplementedFileSystemTests
    {
        [TestMethod()]
        public void OpenFileTest()
        {
            Assert.ThrowsException<NotImplementedException>(()=>new NotImplementedFileSystem().CanWatch(""));
        }

    }
}