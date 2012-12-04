using acyclic_visitor.Item;

namespace acyclic_visitor.PostageVisitor
{
    public class ShunFengBookVisitor : IBookPostageVisitor
    {
        public double Visit(Book book)
        {
            return book.Weight * 3;
        }
    }
}
