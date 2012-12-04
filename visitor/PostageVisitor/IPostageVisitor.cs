using Visitor.Item;

namespace Visitor.PostageVisitor
{
    public interface IPostageVisitor
    {
        double Visit(Book book);
        double Visit(Oven oven);
        double Visit(Food food);
    }
}