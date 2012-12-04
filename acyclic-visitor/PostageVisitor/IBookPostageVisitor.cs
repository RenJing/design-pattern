using acyclic_visitor.Item;

namespace acyclic_visitor.PostageVisitor
{
    public interface IBookPostageVisitor : IPostageVisitor
    {
        double Visit(Book book);
    }
}