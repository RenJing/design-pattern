using Visitor.PostageVisitor;

namespace Visitor.Item
{
    public class Food : IItem
    {
        public Food(double weight)
        {
            Weight = weight;
        }

        public double Weight { get; private set; }
        public double Accept(IPostageVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}


