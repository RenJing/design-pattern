using acyclic_visitor.Item;

namespace acyclic_visitor.PostageVisitor
{
    public class ShunFengFoodVisitor : IFoodPostageVisitor
    {
        public double Visit(Food food)
        {
            return food.Weight * 4;
        }
    }
}