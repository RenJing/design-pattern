using Visitor.Item;

namespace Visitor.PostageVisitor
{
    public interface IPostageCalculator
    {
        double Visit(Book book);
        double Visit(Oven oven);
        double Visit(Food food);
    }

    public class BusySeasonCalculator : IPostageCalculator
    {
        private const double BOOK_POSTAGE_INCREASE_RATE = 0.15;
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
            throw new System.NotImplementedException();
        }

        public double Visit(Food food)
        {
            throw new System.NotImplementedException();
        }
    }
}