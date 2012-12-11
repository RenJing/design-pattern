using System.Collections.Generic;
using System.Linq;
using caculator.Item;

namespace caculator
{
    public class PostageCalculator
    {
        private readonly IEnumerable<IPostageCompany> visitors;

        public PostageCalculator(IEnumerable<IPostageCompany> visitors)
        {
            this.visitors = visitors;
        }

        public string GetPostage(IList<IPostable> items)
        {
            var messages = visitors.Select(v => string.Format("{0}: {1}", v.Name, items.Sum(i => i.GetPostage(v))));
            return string.Join("\r\n", messages);
        }
    }
}
