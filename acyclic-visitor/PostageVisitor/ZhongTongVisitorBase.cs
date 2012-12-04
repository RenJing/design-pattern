using acyclic_visitor.Item;

namespace acyclic_visitor.PostageVisitor
{
    public class ZhongTongVisitorBase
    {
        protected static double GetPostage<T>(T item) where T:IPostable
        {
            return item.Weight <= 5 ? 10 : 10 + (item.Weight - 5)*4;
        }
    }
}