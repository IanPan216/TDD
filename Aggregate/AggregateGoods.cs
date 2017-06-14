using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate
{
    public class AggregateGoods
    {
        public List<int> Sum<T>(List<T> goods, int rows, string column)
        {
            if (rows < 0 ) {
                throw new ArgumentException();
            }
          
            var result = new List<int> { };
            
            

            return result;
        }
    }
}
