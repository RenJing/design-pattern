using Visitor.Item;

namespace Visitor.PostageVisitor
{
    public class ZhongTongCalculator : IPostageCalculator
    {
        private const int MIN_WEIGHT = 5;
        private const int MIN_POSTAGE = 10;

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
            return item.Weight <= MIN_WEIGHT ? MIN_POSTAGE : MIN_POSTAGE + (item.Weight - MIN_WEIGHT)*4;
        }
    }
}
