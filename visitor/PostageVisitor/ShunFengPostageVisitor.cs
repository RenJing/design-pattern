using Visitor.Item;

namespace Visitor.PostageVisitor
{
    public class ShunFengPostageVisitor : IPostageVisitor
    {
        public double Visit(Book book)
        {
            return book.Weight * 3;
        }

        public double Visit(Oven oven)
        {
            return oven.Count * 40;
        }

        public double Visit(Food food)
        {
            return food.Weight * 4;
        }
    }
}
