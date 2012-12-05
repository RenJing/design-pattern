using Microsoft.VisualStudio.TestTools.UnitTesting;
using Visitor.Item;
using Visitor.PostageVisitor;

namespace visitor_test
{
    [TestClass]
    public class ZhongTongPostageVisitorTest
    {
        [TestMethod]
        public void should_get_postage_for_book_when_weight_is_no_more_then_5()
        {
            Assert.AreEqual(10, new ZhongTongPostageVisitor().Visit(new Book(1)));
            Assert.AreEqual(10, new ZhongTongPostageVisitor().Visit(new Book(5)));
        }

        [TestMethod]
        public void should_get_postage_for_book_when_weight_is_more_then_5()
        {
            Assert.AreEqual(14, new ZhongTongPostageVisitor().Visit(new Book(6)));
            Assert.AreEqual(30, new ZhongTongPostageVisitor().Visit(new Book(10)));
        }

        [TestMethod]
        public void should_get_postage_for_food_when_weight_is_no_more_then_5()
        {
            Assert.AreEqual(10, new ZhongTongPostageVisitor().Visit(new Food(1)));
            Assert.AreEqual(10, new ZhongTongPostageVisitor().Visit(new Food(5)));
        }

        [TestMethod]
        public void should_get_postage_for_food_when_weight_is_more_then_5()
        {
            Assert.AreEqual(14, new ZhongTongPostageVisitor().Visit(new Food(6)));
            Assert.AreEqual(30, new ZhongTongPostageVisitor().Visit(new Food(10)));
        }

        [TestMethod]
        public void should_get_postage_for_oven_when_weight_is_no_more_then_5()
        {
            Assert.AreEqual(10, new ZhongTongPostageVisitor().Visit(new Oven(1, 4)));
            Assert.AreEqual(10, new ZhongTongPostageVisitor().Visit(new Oven(1, 5)));
            Assert.AreEqual(10, new ZhongTongPostageVisitor().Visit(new Oven(2, 2.5)));
        }

        [TestMethod]
        public void should_get_postage_for_food_when_oven_weight_is_more_than_5()
        {
            Assert.AreEqual(22, new ZhongTongPostageVisitor().Visit(new Oven(2, 4)));
            Assert.AreEqual(30, new ZhongTongPostageVisitor().Visit(new Oven(1, 10)));
        }
    }
}
