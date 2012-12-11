using caculator;
using caculator.Item;

namespace zhongtong
{
    public class ZhongTongPostageCompany : IPostageCompany
    {
        private const int MIN_WEIGHT = 5;
        private const int MIN_POSTAGE = 10;

        public string Name
        {
            get { return "Zhong Tong"; }
        }

        public double Postage(Book book)
        {
            return GetPostage(book);
        }

        public double Postage(Oven oven)
        {
            return GetPostage(oven);
        }

        public double Postage(Food food)
        {
            return GetPostage(food);
        }

        private static double GetPostage<T>(T item) where T:IPostable
        {
            return item.Weight <= MIN_WEIGHT ? MIN_POSTAGE : MIN_POSTAGE + (item.Weight - MIN_WEIGHT)*4;
        }
    }
}
