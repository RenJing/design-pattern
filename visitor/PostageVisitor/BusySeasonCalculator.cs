using Visitor.Item;

namespace Visitor.PostageVisitor
{
    public class BusySeasonCalculator : IPostageCalculator
    {
        private const double BOOK_POSTAGE_INCREASE_RATE = 1.15;
        private const double FOOD_POSTAGE_INCREASE_RATE = 1.2;
        private const double OVEN_POSTAGE_INCREASE_RATE = 1.5;
        private readonly IPostageCalculator postageCalculator;

        public BusySeasonCalculator(IPostageCalculator postageCalculator)
        {
            this.postageCalculator = postageCalculator;
        }

        public double Visit(Book book)
        {
            return postageCalculator.Visit(book) * BOOK_POSTAGE_INCREASE_RATE;
        }

        public double Visit(Oven oven)
        {
            return postageCalculator.Visit(oven) * OVEN_POSTAGE_INCREASE_RATE;
        }

        public double Visit(Food food)
        {
            return postageCalculator.Visit(food) * FOOD_POSTAGE_INCREASE_RATE;
        }
    }
}