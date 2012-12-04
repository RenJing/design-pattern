using acyclic_visitor.PostageVisitor;

namespace acyclic_visitor.Item
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

        public double Accept(IPostageVisitor visitor)
        {
            if (!(visitor is IOvenPostageVisitor))
            {
                return 0;
            }
            return ((IOvenPostageVisitor)visitor).Visit(this);
        }
    }
}


