using Visitor.PostageVisitor;

namespace Visitor.Item
{
    public class Book : IPostable
    {
        public Book(double weight)
        {
            Weight = weight;
        }

        public double Weight { get; private set; }
        public double Accept(IPostageCalculator calculator)
        {
            return calculator.Visit(this);
        }
    }
}


