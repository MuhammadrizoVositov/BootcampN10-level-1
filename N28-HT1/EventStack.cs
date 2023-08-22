using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N28_HT1
{
    public class EventStack<TEvent> : List<TEvent> where TEvent : IEvent
    {
        public void Push(TEvent events)
        {
            if (Count!=0 &&  base[Count - 1].Date > events.Date)
                throw new Exception("Bu kun allaqachon o'tib ketgan");
            Add(events);
        }
        public TEvent Peek()
        {
            if (Count == 0)
                throw new Exception("LIst bo'sh");
            return base[Count - 1];
        }
        public TEvent Pop()
        {
            if (Count == 0)
                throw new Exception("List bo'sh");
            var last = base[Count - 1];
            Remove(last);
            return last;
        }

    }
}
