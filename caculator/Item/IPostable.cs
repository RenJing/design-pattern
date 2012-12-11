namespace caculator.Item
{
    public interface IPostable
    {
        double Weight { get; }
        double GetPostage(IPostageCompany company);
    }
}