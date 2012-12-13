using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Visitor;
using Visitor.Item;
using Visitor.PostageVisitor;

namespace visitor_test
{
    [TestClass]
    public class PostageCalculatorTest
    {
        [TestMethod]
        public void should_get_shunfeng_postage()
        {
            var items = new List<IPostable>
                            {
                                new Book(2),
                                new Food(4)
                            };
            var calculator = new PostageCalculator(new ShunFengCalculator());
            var actualPostage = calculator.GetPostage(items);
            Assert.AreEqual(22, actualPostage);
        }

        [TestMethod]
        public void should_get_postage_for_zhongtong()
        {
            var items = new List<IPostable>
                            {
                                new Book(2),
                                new Food(4),
                                new Oven(2, 5)
                            };
            var calculator = new PostageCalculator(new ZhongTongCalculator());
            var actualPostage = calculator.GetPostage(items);
            Assert.AreEqual(50, actualPostage);
        }
    }
}