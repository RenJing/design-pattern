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
                                new Book(2), new Food(4)
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
                                new Book(2), new Food(4), new Oven(2, 5)
                            };
            var calculator = new PostageCalculator(new ZhongTongCalculator());
            var actualPostage = calculator.GetPostage(items);
            Assert.AreEqual(50, actualPostage);
        }

        [TestMethod]
        public void should_ZT_increase_postage_for_book_by_15_percent_in_busy_seaon()
        {
            var items = new List<IPostable>
                            {
                                new Book(2)
                            };
            var calculator = new PostageCalculator(new BusySeasonCalculator(new ZhongTongCalculator()));
            Assert.AreEqual(10*1.15, calculator.GetPostage(items), 0.001);
        }
        
        [TestMethod]
        public void should_SF_increase_postage_for_book_by_15_percent_in_busy_seaon()
        {
            var items = new List<IPostable>
                            {
                                new Book(2)
                            };
            var calculator = new PostageCalculator(new BusySeasonCalculator(new ShunFengCalculator()));
            Assert.AreEqual(6*1.15, calculator.GetPostage(items), 0.001);
        }
    }
}
