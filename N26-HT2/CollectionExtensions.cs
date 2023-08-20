using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N26_HT2
{
    public static class CollectionExtensions
    {
      static List<Skill> Update(this ICollection<Skill> first, ICollection<Skill> second)
        {
            var list=first.ToList();
            var addItmen=second.ExceptBy(first.Select(firstItem=>firstItem.Id),item=>item.Id);
            var removeItem = first.ExceptBy(second.Select(firstItem => firstItem.Id), item => item.Id);
            var IntersectedKeys= first.Select(item=>item.Id).Intersect(second.Select(item=>item.Id));
            foreach(var item in addItmen) 
                list.Add(item);
            foreach(var item in removeItem)
                list.Remove(item);
            foreach (var key in IntersectedKeys)
            {
                var firstItem=list.First(item=>item.Id==key);
                var secondItem = first.First(item => item.Id == key);

                firstItem.Name=secondItem.Name;
                firstItem.Name = secondItem.Name;

            }
            return list;
                
            
        }

    }
}
