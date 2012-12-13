using Visitor.PostageVisitor;

namespace Visitor.Item
{
    public class Oven : IPostable
    {
        public double Count { get; private set; }
        public double Weight{ get; private set; }

        public Oven(double count, double singleWeight)
        {
            Weight = singleWeight * count;
            Count = count;
        }

        public double Accept(IPostageCalculator calculator)
        {
            return calculator.Visit(this);
        }
    }
}


