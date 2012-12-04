namespace VisitorRaw.Item
{
    public class Food : IItem
    {
        public double Weight { get; private set; }

        public Food(double weight)
        {
            Weight = weight;
        }

        public double Postage()
        {
            return Weight * 4;
        }
    }
}


