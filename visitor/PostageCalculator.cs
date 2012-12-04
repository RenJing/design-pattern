using System.Collections.Generic;
using System.Linq;
using Visitor.Item;
using Visitor.PostageVisitor;

namespace Visitor
{
    public class PostageCalculator
    {
        private readonly IPostageVisitor visitor;
        public PostageCalculator(IPostageVisitor visitor)
        {
            this.visitor = visitor;
        }

        public double GetPostage(IList<IPostable> items)
        {
            return items.Sum(i => i.Accept(visitor));
        }
    }
}
