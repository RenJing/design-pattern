namespace VisitorRaw.Item
{
    public class Oven : IPostable
    {
        public double Count { get; private set; }

        public Oven(double count)
        {
            Count = count;
        }

        public double Postage()
        {
            return 40 * Count;
        }
    }
}


