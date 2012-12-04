using acyclic_visitor.Item;

namespace acyclic_visitor.PostageVisitor
{
    public class ShunFengOvenVisitor : IOvenPostageVisitor
    {
        public double Visit(Oven oven)
        {
            return oven.Count * 40;
        }
    }
}