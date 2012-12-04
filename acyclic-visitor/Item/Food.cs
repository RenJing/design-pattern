using acyclic_visitor.PostageVisitor;

namespace acyclic_visitor.Item
{
    public class Food : IPostable
    {
        public Food(double weight)
        {
            Weight = weight;
        }

        public double Weight { get; private set; }
        public double Accept(IPostageVisitor visitor)
        {
            if (!(visitor is IFoodPostageVisitor))
            {
                return 0;
            }
            return ((IFoodPostageVisitor)visitor).Visit(this);
        }
    }
}


