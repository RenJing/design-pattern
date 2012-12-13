using System.Collections.Generic;
using System.Linq;
using Visitor.Item;
using Visitor.PostageVisitor;

namespace Visitor
{
    public class PostageCalculator
    {
        private readonly IPostageCalculator calculator;
        public PostageCalculator(IPostageCalculator calculator)
        {
            this.calculator = calculator;
        }

        public double GetPostage(IList<IPostable> items)
        {
            return items.Sum(i => i.Accept(calculator));
        }
    }
}
