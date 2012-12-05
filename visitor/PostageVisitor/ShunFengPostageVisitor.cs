using Visitor.Item;

namespace Visitor.PostageVisitor
{
    public class ShunFengPostageVisitor : IPostageVisitor
    {
        private const int POSTAGE_FOR_ONE_OVEN = 40;
        private const int POSTAGE_FOR_ONE_KILO_BOOK = 3;
        private const int POSTAGE_FOR_ONE_KILO_FODD = 4;

        public double Visit(Book book)
        {
            return book.Weight * POSTAGE_FOR_ONE_KILO_BOOK;
        }

        public double Visit(Oven oven)
        {
            return oven.Count * POSTAGE_FOR_ONE_OVEN;
        }

        public double Visit(Food food)
        {
            return food.Weight * POSTAGE_FOR_ONE_KILO_FODD;
        }
    }
}
