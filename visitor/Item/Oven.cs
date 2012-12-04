using Visitor.PostageVisitor;

namespace Visitor.Item
{
    public class Oven : IItem
    {
        public double Count { get; private set; }    

        public Oven(double count)
        {
            Count = count;
        }

        public double Accept(IPostageVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}


