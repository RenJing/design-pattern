using Visitor.PostageVisitor;

namespace Visitor.Item
{
    public interface IItem
    {
        double Accept(IPostageVisitor visitor);
    }
}