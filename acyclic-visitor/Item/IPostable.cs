using acyclic_visitor.PostageVisitor;

namespace acyclic_visitor.Item
{
    public interface IPostable
    {
        double Weight { get; }
        double Accept(IPostageVisitor visitor);
    }
}