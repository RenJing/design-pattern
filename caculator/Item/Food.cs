namespace caculator.Item
{
    public class Food : IPostable
    {
        public Food(double weight)
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


