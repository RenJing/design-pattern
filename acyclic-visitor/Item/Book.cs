using acyclic_visitor.PostageVisitor;

namespace acyclic_visitor.Item
{
    public class Book : IPostable
    {
        public Book(double weight)
        {
            Weight = weight;
        }

        public double Weight { get; private set; }
        public double Accept(IPostageVisitor visitor)
        {
            if(!(visitor is IBookPostageVisitor))
            {
                return 0;
            }
            return ((IBookPostageVisitor)visitor).Visit(this);
        }
    }
}


