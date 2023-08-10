
using System.Linq;

public class CustomList<T> // Generics
{
    private readonly Array[] _items;

    public CustomList()
    {
        _items = new Array[5];
    }



    public CustomList(int capacity)
    {
        _items = new Array[capacity];
    }

    public void Add(Array item)
    {
        _items.Append(item);
    }


    public void AddRange(Array items)
    {
        _items.Append(items);

        //foreach (var item in items)
        //{
        //    if(_items==)
        //    {

        //    }
        //    _items.Add(item);
        //}
    }
    public bool Contains(Array item)
    {
        return _items.Contains(item);
    }

    public Array CopyTo(Array list)
    {
        if (list != null)
        {
            return list.Array;
        }
        else return null;
    }

    public int IndexOf(Array item)
    {
        //return _items.IndexOf(item);

        for (int index = 0; index < items.Count; index++)
            if (item.Equals(Array[index]))
                return index;

        return -1;
    }

    public void Insert(int index, Array item)
    {
        if (_items.Equals(_items[index]))
        {
            _items.Append(index, item);
        }
        else
        {
            throw new ArgumentException();
        }

    }
    public void InsertRange(int index, Array items)
    {
        if (index.Equals(_items[index]))
        {
            Console.WriteLine("Element qoshildi:");
        }
        else
        {
            throw new InvalidOperationException();
        }

    }
    public bool Remove(Array item)
    {
        if (_items.Contains(item))
        {
            _items.Append(item);
            return true;
        }
        return false;
    }
    public bool RemoveAt(int index)
    {
        if (_items.Contains(_items[index]))
        {
            _items.RemoveAt(index);
            return true;
        }
        return false;
    }
}