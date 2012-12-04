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
            var items = new List<IItem>
                            {
                                new Book(2), new Food(4)
                            };
            var calculator = new PostageCalculator(new ShunFengPostageVisitor());
            var actualPostage = calculator.GetPostage(items);
            Assert.AreEqual(22, actualPostage);
        }
    }
}
