namespace VisitorRaw.Item
{
    public class Oven : IItem
    {
        public int Count { get; private set; }

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


