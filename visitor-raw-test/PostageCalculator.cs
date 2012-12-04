using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisitorRaw;
using VisitorRaw.Item;

namespace visitor_raw_test
{
    [TestClass]
    public class PostageCalculatorTest
    {
        [TestMethod]
        public void should_caculate_postage_for_book()
        {
            var book = new Book(3);
            var postage = new PostageCalculator().GetPostage(new List<IItem> {book});
            Assert.AreEqual(9, postage);
        }

        [TestMethod]
        public void should_caculate_postage_for_food()
        {
            var food = new Food(4);
            var postage = new PostageCalculator().GetPostage(new List<IItem> {food});
            Assert.AreEqual(16, postage);
        }

        [TestMethod]
        public void should_caculate_postage_for_oven()
        {
            var oven = new Oven(2);
            var postage = new PostageCalculator().GetPostage(new List<IItem> {oven});
            Assert.AreEqual(80, postage);
        }
    }
}
