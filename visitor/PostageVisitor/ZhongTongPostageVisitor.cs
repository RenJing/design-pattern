using Visitor.Item;

namespace Visitor.PostageVisitor
{
    public class ZhongTongPostageVisitor : IPostageVisitor
    {
        public double Visit(Book book)
        {
            return GetPostage(book);
        }

        public double Visit(Oven oven)
        {
            return GetPostage(oven);
        }

        public double Visit(Food food)
        {
            return GetPostage(food);
        }

        private static double GetPostage<T>(T item) where T:IPostable
        {
            return item.Weight <= 5 ? 10 : 10 + (item.Weight - 5)*4;
        }
    }
}
