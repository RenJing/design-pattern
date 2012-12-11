namespace caculator.Item
{
    public class Oven : IPostable
    {
        public double Count { get; private set; }
        public double Weight{ get; private set; }

        public Oven(double count, double singleWeight)
        {
            Weight = singleWeight * count;
            Count = count;
        }

        public double GetPostage(IPostageCompany company)
        {
            return company.Postage(this);
        }
    }
}


