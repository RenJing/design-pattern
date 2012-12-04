using acyclic_visitor.Item;

namespace acyclic_visitor.PostageVisitor
{
    public interface IFoodPostageVisitor : IPostageVisitor
    {
        double Visit(Food book);
    }
}