namespace VisitorRaw.Item
{
    public class Book : IPostable
    {
        private double Weight { get; set; }

        public Book(double weight)
        {
            Weight = weight;
        }

        public double Postage()
        {
            return Weight * 3;
        }
    }
}


