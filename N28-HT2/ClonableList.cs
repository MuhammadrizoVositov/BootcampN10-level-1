using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N28_HT2
{
    public class ClonableList<T> : List<T>, ICloneable where T : ICloneable
    {
        public object Clone()
        {
            var newList = new ClonableList<T>();
            foreach(var item in this)
            {
                newList.Add(((T)item.Clone()));
            }
            return newList;
        }
    }
}
