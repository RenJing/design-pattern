using acyclic_visitor.Item;

namespace acyclic_visitor.PostageVisitor
{
    public class ZhongTongOvenVisitor : ZhongTongVisitorBase, IOvenPostageVisitor
    {
        public double Visit(Oven oven)
        {
            return GetPostage(oven);
        }
    }
}