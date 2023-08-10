// - Add(item ) - bitta element qo'shadi - item 
// - AddRange(items ) - bir nechta element qo'shadi
// - Contains(item ) - bitta element bor/yo'qligini tekshiradi
// - CopyTo(array ) - list elementlarini berilgan arrayga copy qiladi
// - IndexOf(item ) - berilgan element listda uchrassa index qaytaradi, bo'lmasa -1
// - Insert(index, item ) - berilgan index mavjud bo'lsa element qo'shadi, bo'lmasa exception
// - InsertRange(index, items ) - berilgan index mavjud bo'lsa elementlarni qo'shadi bo'lmasa exception
// - Remove(item ) - berilgan element listda uchrasa o'chiradi va true qaytaradi, bo'lmasa false
// - RemoveAt(index ) - berilgan indexdagi elementni o'chiradi va true qaytaradi, bo'lmasa false
// - ToArray - list elementlarini array ko'rinishida qaytaradi 

//var list = new List<int> { 1, 234, 64, 23, 5 };
////                                 0   1   2   3   4

//var index =  list.IndexOf(15);
//Console.WriteLine(index);


//var list = new CustomList<int>(10);



public class CustomList<T> // Generics
{
    private readonly List<T> _items;

    public CustomList()
    {
        _items = new List<T>(); 
    }

    public CustomList(int capacity)
    {
        _items = new List<T>(capacity);
    }

    public void Add(T item)
    {
        _items.Add(item);
    }


    public void AddRange(IEnumerable<T> items)
    {
        _items.AddRange(items);

        //foreach (var item in items)
        //{
        //    if(_items==)
        //    {

        //    }
        //    _items.Add(item);
        //}
    }
    public bool Contains(T item)
    {
        return _items.Contains(item);
    }

    public Array CopyTo(List<T> list)
    {
        if (list != null)
        {
            return list.ToArray();
        }
        else return null;
    }

    public int IndexOf(T item)
    {
        //return _items.IndexOf(item);

        for (int index = 0; index < _items.Count; index++)
            if (item.Equals(_items[index]))
                return index;

        return -1;
    }

    public void Insert(int index, T item)
    {
        if (_items.Equals(_items[index]))
        {
            _items.Insert(index, item);
        }
        else
        {
            throw new ArgumentException();
        }
        
    }
    public void InsertRange(int index, IEnumerable<T> items)
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
    public  bool Remove(T item) 
    {
        if (_items.Contains(item))
        {
            _items.Remove(item);
            return true;
        }
        return false;
    }
    public bool RemoveAt(int index) 
    {
        if(_items.Contains(_items[index]))
        {
            _items.RemoveAt(index);
            return true;
        }
        return false;
    }
}




