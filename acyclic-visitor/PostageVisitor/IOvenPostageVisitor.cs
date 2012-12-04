using acyclic_visitor.Item;

namespace acyclic_visitor.PostageVisitor
{
    public interface IOvenPostageVisitor : IPostageVisitor
    {
        double Visit(Oven book);
    }
}