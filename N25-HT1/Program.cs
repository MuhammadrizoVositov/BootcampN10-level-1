
/*  interfeys elon qilaman ichiga parametrlarini yozaman
 *  laptop class yaratib ichiga berilganini yozaman 
 *  char class yarataman ichiga berilganini yizaman
 *  Monitor class ochaman ichiga berilganini yozaman 
 *  DebidCard yozaman ichiga berilganini yozaman
 *  ProductFilterDataModel shuni modelini yozaman parametri bilan
 *  va men mahsulot nomlarini  hozir mavjud yoki mavjudmasligini tekshiraman
 *  IEnumurable yozmaan 
 *  
 * 
 **/

//using System;
//using System.Collections.Generic;
//using System.Linq;

//// Customer sinfi
//public class Customer
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int Age { get; set; }
//}

//// CustomerFilterModel sinfi
//public class CustomerFilterModel
//{
//    public int MinAge { get; set; }
//    public int MaxAge { get; set; }
//}

//public class Program
//{
//    public static void Main()
//    {
//        // Customer obyektlarini yaratamiz
//        var customers = new List<Customer>
//        {
//            new Customer { Id = 1, Name = "John", Age = 25 },
//            new Customer { Id = 2, Name = "Alice", Age = 30 },
//            new Customer { Id = 3, Name = "Bob", Age = 22 },
//            new Customer { Id = 4, Name = "Eva", Age = 35 },
//        };

//        // Filter modelini yaratamiz
//        var filterModel = new CustomerFilterModel
//        {
//            MinAge = 25,
//            MaxAge = 35
//        };

//        // FilterModel ni ishlatib, natijalarni foreach bilan chiqaramiz
//        var filteredCustomers = FilterCustomers(customers, filterModel);

//        Console.WriteLine("Filter Model natijalari:");
//        foreach (var customer in filteredCustomers)
//        {
//            Console.WriteLine($"Id: {customer.Id}, Name: {customer.Name}, Age: {customer.Age}");
//        }

//        // Yangi Customer qo'shamiz va qo'shilgan Customerlarni chiqaramiz
//        var newCustomer = new Customer { Id = 5, Name = "Linda", Age = 28 };
//        AddCustomerAndPrint(customers, newCustomer);
//    }

//    // Customerlarni filter qilish uchun metod
//    public static IEnumerable<Customer> FilterCustomers(IEnumerable<Customer> customers, CustomerFilterModel filterModel)
//    {
//        return customers.Where(customer => customer.Age >= filterModel.MinAge && customer.Age <= filterModel.MaxAge);
//    }

//    // Customer qo'shish va chiqarish uchun metod
//    public static void AddCustomerAndPrint(List<Customer> customers, Customer newCustomer)
//    {
//        customers.Add(newCustomer);
//        Console.WriteLine("Yangi Customer qo'shildi:");
//        Console.WriteLine($"Id: {newCustomer.Id}, Name: {newCustomer.Name}, Age: {newCustomer.Age}");
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Cast operator
        object[] objects = { 1, "2", 3.0, "4", 5 };
        IEnumerable<int> integers = objects.Cast<int>();

        foreach (int num in integers)
        {
            Console.WriteLine(num);
        }

        // OfType operator
        object[] mixedObjects = { 1, "2", 3.0, "4", 5 };
        IEnumerable<string> strings = mixedObjects.OfType<string>();

        foreach (string str in strings)
        {
            Console.WriteLine(str);
        }
    }
}
