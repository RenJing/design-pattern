using System.Collections.Generic;
using System.Linq;
using acyclic_visitor.Item;
using acyclic_visitor.PostageVisitor;

namespace acyclic_visitor
{
    public class PostageCalculator
    {
        private readonly IList<IPostageVisitor> visitors;
        public PostageCalculator(IList<IPostageVisitor> visitors)
        {
            this.visitors = visitors;
        }

        public double GetPostage(IList<IPostable> items)
        {
            return items.Sum(i => visitors.Sum(v => i.Accept(v)));
        }
    }
}
