using caculator;
using caculator.Item;

namespace shunfeng
{
    public class ShunFengPostageCompany : IPostageCompany
    {
        private const int POSTAGE_FOR_ONE_OVEN = 40;
        private const int POSTAGE_FOR_ONE_KILO_BOOK = 3;
        private const int POSTAGE_FOR_ONE_KILO_FODD = 4;

        public string Name
        {
            get { return "ShunFeng"; }
        }

        public double Postage(Book book)
        {
            return book.Weight * POSTAGE_FOR_ONE_KILO_BOOK;
        }

        public double Postage(Oven oven)
        {
            return oven.Count * POSTAGE_FOR_ONE_OVEN;
        }

        public double Postage(Food food)
        {
            return food.Weight * POSTAGE_FOR_ONE_KILO_FODD;
        }
    }
}
