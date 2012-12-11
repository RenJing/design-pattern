namespace VisitorRaw.Item
{
    public class Food : IPostable
    {
        private double Weight { get; set; }

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


