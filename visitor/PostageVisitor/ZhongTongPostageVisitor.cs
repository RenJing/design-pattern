using Visitor.Item;

namespace Visitor.PostageVisitor
{
    public class ZhongTongPostageVisitor : IPostageVisitor
    {
        public double Visit(Book book)
        {
            return 0;
        }

        public double Visit(Oven oven)
        {
            return 0;
        }

        public double Visit(Food food)
        {
            return 0;
        }

    }
}
