using acyclic_visitor.Item;

namespace acyclic_visitor.PostageVisitor
{
    public class ZhongTongFoodVisitor : ZhongTongVisitorBase, IFoodPostageVisitor
    {
        public double Visit(Food food)
        {
            return GetPostage(food);
        }
    }
}
