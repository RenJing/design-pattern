namespace VisitorRaw.Item
{
    public class Book : IItem
    {
        public double Weight { get; private set; }

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


