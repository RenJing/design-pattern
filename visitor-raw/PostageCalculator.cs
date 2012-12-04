using System.Collections.Generic;
using System.Linq;
using VisitorRaw.Item;

namespace VisitorRaw
{
    public class PostageCalculator
    {
        public double GetPostage(IList<IItem> items)
        {
            return items.Sum(i => i.Postage());
        }
    }
}
