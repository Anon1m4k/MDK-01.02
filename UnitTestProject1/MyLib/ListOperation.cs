using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class ListOperation
    {
        static public List<int> unite(List<int> l1, List<int> l2)
        {
            List<int> result = new List<int>();
            result.AddRange(l1);
            result.AddRange(l2);

            return result;
        }

        static public List<int> substract(List<int> l1, List<int> l2)
        {
            return new List<int>();
        }
    }
}
