using caculator.Item;

namespace caculator
{
    public interface IPostageCompany
    {
        string Name { get; }
        double Postage(Book book);
        double Postage(Oven oven);
        double Postage(Food food);
    }
}