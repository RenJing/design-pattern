using acyclic_visitor.Item;

namespace acyclic_visitor.PostageVisitor
{
    public class ZhongTongBookVisitor : ZhongTongVisitorBase
    {
        public double Visit(Book book)
        {
            return GetPostage(book);
        }
    }
}