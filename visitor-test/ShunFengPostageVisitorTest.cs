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
            Assert.AreEqual(6, new ShunFengCalculator().Visit(new Book(2)));
            Assert.AreEqual(12, new ShunFengCalculator().Visit(new Food(3)));
            Assert.AreEqual(80, new ShunFengCalculator().Visit(new Oven(2, 4)));
        }
    }
}
