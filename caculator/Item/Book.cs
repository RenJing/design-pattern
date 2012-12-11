namespace caculator.Item
{
    public class Book : IPostable
    {
        public Book(double weight)
        {
            Weight = weight;
        }

        public double Weight { get; private set; }
        public double GetPostage(IPostageCompany company)
        {
            return company.Postage(this);
        }
    }
}


