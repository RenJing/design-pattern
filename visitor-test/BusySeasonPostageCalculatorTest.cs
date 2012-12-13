using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Visitor;
using Visitor.Item;
using Visitor.PostageVisitor;

namespace visitor_test
{
    [TestClass]
    public class BusySeasonPostageCalculatorTest
    {
        [TestMethod]
        public void should_ZT_increase_postage_for_book_by_15_percent_in_busy_seaon()
        {
            var items = new List<IPostable>
                            {
                                new Book(2)
                            };
            var calculator = new PostageCalculator(new BusySeasonCalculator(new ZhongTongCalculator()));
            Assert.AreEqual(10 * 1.15, calculator.GetPostage(items), 0.001);
        }

        [TestMethod]
        public void should_SF_increase_postage_for_book_by_15_percent_in_busy_seaon()
        {
            var items = new List<IPostable>
                            {
                                new Book(2)
                            };
            var calculator = new PostageCalculator(new BusySeasonCalculator(new ShunFengCalculator()));
            Assert.AreEqual(6 * 1.15, calculator.GetPostage(items), 0.001);
        }

        [TestMethod]
        public void should_ZT_increase_postage_for_food_by_20_percent_in_busy_seaon()
        {
            var items = new List<IPostable>
                            {
                                new Food(2)
                            };
            var calculator = new PostageCalculator(new BusySeasonCalculator(new ZhongTongCalculator()));
            Assert.AreEqual(10 * 1.2, calculator.GetPostage(items), 0.001);
        }

        [TestMethod]
        public void should_SF_increase_postage_for_food_by_20_percent_in_busy_seaon()
        {
            var items = new List<IPostable>
                            {
                                new Food(2)
                            };
            var calculator = new PostageCalculator(new BusySeasonCalculator(new ShunFengCalculator()));
            Assert.AreEqual(8 * 1.2, calculator.GetPostage(items), 0.001);
        }

        [TestMethod]
        public void should_ZT_increase_postage_for_Oven_by_50_percent_in_busy_seaon()
        {
            var items = new List<IPostable>
                            {
                                new Oven(2, 10)
                            };
            var calculator = new PostageCalculator(new BusySeasonCalculator(new ZhongTongCalculator()));
            Assert.AreEqual(70 * 1.5, calculator.GetPostage(items), 0.001);
        }

        [TestMethod]
        public void should_SF_increase_postage_for_Oven_by_50_percent_in_busy_seaon()
        {
            var items = new List<IPostable>
                            {
                                new Oven(2, 10)
                            };
            var calculator = new PostageCalculator(new BusySeasonCalculator(new ShunFengCalculator()));
            Assert.AreEqual(80 * 1.5, calculator.GetPostage(items), 0.001);
        }
    }
}
