using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generix
{
    public class SwapList<T> : List<T>
    {
        public SwapList() { }

        public void swaper(int index1, int index2)
        {
            T temp = this[index1];
            this[index1] = this[index2];
            this[index2] = temp;
        }
    }
}
