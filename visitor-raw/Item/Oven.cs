namespace VisitorRaw.Item
{
    public class Oven : IPostable
    {
        private int Count { get; set; }

        public Oven(int count)
        {
            Count = count;
        }

        public double Postage()
        {
            return 40 * Count;
        }
    }
}


