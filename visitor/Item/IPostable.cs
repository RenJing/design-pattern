using Visitor.PostageVisitor;

namespace Visitor.Item
{
    public interface IPostable
    {
        double Weight { get; }
        double Accept(IPostageCalculator calculator);
    }
}