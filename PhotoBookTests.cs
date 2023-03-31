using Hands_On;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hands_On_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DefaultPhotoBook()
        {
            PhotoBook obj = new PhotoBook();
            int pageCount = obj.GetNumberPages();
            Assert.AreEqual(pageCount, 15);
        }

        [TestMethod]
        public void PhotoBookTesting()
        {
            PhotoBook obj = new PhotoBook(32);
            int pageCount = obj.GetNumberPages();
            Assert.AreEqual(pageCount, 32);
        }

        [TestMethod]
        public void LargePhotoBookTesting()
        {
            PhotoBook obj = new PhotoBook(200);
            int pageCount = obj.GetNumberPages();
            Assert.AreEqual(pageCount, 200);
        }

        [TestMethod]
        public void AlbumBookTesting()
        {
            AddPhotoBook obj1 = new AddPhotoBook();
            int pageCount = obj1.GetNumberPages();
            Assert.AreEqual(pageCount, 64);
        }
    }
}