using Microsoft.VisualStudio.TestTools.UnitTesting;
using Visitor.Item;
using Visitor.PostageVisitor;

namespace visitor_raw_test
{
    [TestClass]
    public class ShunFengPostageVisitorTest
    {
        [TestMethod]
        public void should_get_postage_for_items()
        {
            Assert.AreEqual(6, new ShunFengPostageVisitor().Visit(new Book(2)));
            Assert.AreEqual(12, new ShunFengPostageVisitor().Visit(new Food(3)));
            Assert.AreEqual(80, new ShunFengPostageVisitor().Visit(new Oven(2, 4)));
        }
    }
}
