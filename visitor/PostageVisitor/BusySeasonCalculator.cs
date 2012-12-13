using Visitor.Item;

namespace Visitor.PostageVisitor
{
    public class BusySeasonCalculator : IPostageCalculator
    {
        private const double BOOK_POSTAGE_INCREASE_RATE = 0.15;
        private const double FOOD_POSTAGE_INCREASE_RATE = 0.2;
        private const double OVEN_POSTAGE_INCREASE_RATE = 0.5;
        private readonly IPostageCalculator postageCalculator;

        public BusySeasonCalculator(IPostageCalculator postageCalculator)
        {
            this.postageCalculator = postageCalculator;
        }

        public double Visit(Book book)
        {
            return postageCalculator.Visit(book)*(1 + BOOK_POSTAGE_INCREASE_RATE);
        }

        public double Visit(Oven oven)
        {
            return postageCalculator.Visit(oven)*(1 + OVEN_POSTAGE_INCREASE_RATE);
        }

        public double Visit(Food food)
        {
            return postageCalculator.Visit(food)*(1 + FOOD_POSTAGE_INCREASE_RATE);
        }
    }
}