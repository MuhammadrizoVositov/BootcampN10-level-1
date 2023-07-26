// shartlari 

//N11 - T1

//Contact List dasturi tuzing
//Contact - aloqaga chiqish uchun ma'lumot, kontakt

//- kontakt uchun Contact modelidan foydalaning ( ismi, sharifi, telefon raqami, email manzili )
//-kontaktlarni boshqarish uchun ContactList serivisidan foydalaning  
//- ContactList servisida kontaktlar kolleksiyada saqlansin
//- ContactList servisida quyidagi metodlar bo'lsin
//  Display - hamma kontaktlarni ekranga chiqarsin 
//  Search - ism bo'yicha topilgan hamma kontakrlarni ekranga chiqarsin
//- dasturda ContactList ga boshidan 5 ta kontakt qo'shib qo'ying


//Example 

//Dastur : Choose a command ( display all - d / search- f )
//Foydalanuvchi: f
//Dastur : Enter a firstname 
//Foydalanuvchi : G'ishtmat
//Dastur : 

//G'ishtmat Teshavoyev    +998 99 123 45 67      g`ishmat.dizayner@gmail.com
//G'ishtmat G`ishtmatov   +998 99 123 45 67      g`ishmat.007@gmail.com
//G'ishtmat G`ayratov     +998 99 123 45 67      g`ishmat.coder@gmail.com


// Tushunchalar


// Model
// Service

// Role - vazifasi
// Ba'zi tiplarni vazifasi faqat ma'lumot saqlash - model
// Ba'zi tiplar ko'proq nimadir ish qiladi - service

// Contact - kontakt - model
// Contacts app - dastur - service

// Logika







// Array - massiv, bir xil tipdagi bir nechta elementlarni saqlash, qo'shish va o'chirish mumkinmas
// List - nimanidir qo'shish va o'chirish imkonini beradi - dynamic array

// shart - do'stlarni ismini saqlash

// logika :

// ko'pgina ismlarni alohida o'zgaruvchilarda saqlash kerak - xato
// ko'pgina ismlarni bitta o'zgaruvchida saqlash kerak - xato
// ismlarni string tipidagi arrayda saqlash kerak - xato - chunki yangi element qo'shib bo'lmaydi
//var friends = new string[]
//{
//    "John",
//    "Bob",
//    "Tom"
//};

//friends[2] = "Tim";

//foreach (var friend in friends)
//    Console.WriteLine(friend);

//// ismlarni string tipidagi listda saqlash kerak
//var friends = new List<string>
//{
//    "John",
//    "Bob",
//    "Tom"
//};

//friends.Add("Tim");
//friends.Remove("Tim");


//foreach (var friend in friends)
//{
//    // probellar borligini tekshirish
//    if (friend == friend.Trim())
//    {
//    }
//    Console.WriteLine(friend);
//}

////for -elementlarni xohlagancha process qilish uchun va bemalol o'zgartirish mumkin
//for (int i = friends.Count; i > 0; i--)
//{
//    // probellar borligini tekshirish
//    if (friends[i] == friends[i].Trim())
//    {
//    }

//    friends[i] = "G'ayrat";


//    Console.WriteLine(friends[i]);
//}


//// foreach - elementlarni bitta bitta process qilish uchun faqat o'zgartirish mumkinmas ( qo'shish va o'chirish )
//foreach (var friend in friends)
//{
//    friend = "G'ayrat";
//    Console.WriteLine(friend);
//}

// code

// example #1 - teleefon raqamlarini kolleksiyada saqlang va ular orasidan 333 qatnashgan telefon raqamni o'chiring

// logika
// string tipidagi list o'zgaruvchi ocish
// listga boshlang'ich telefonlarini qo'shish
// for bilan elementlarni bitta bitta olish
// bitta elementni Contains bilan tekshiramiz - agar 333 bo'lsa - Remove qilamiz

// continue - elementni keyingisiga o'tish
// break - ishni umumiy to'xtatish

var phoneNumbers = new List<string>()
{
  "John",
  "Tom",
  "Alex",
  "Khan",
};
for (int i = 0; i < phoneNumbers.Count; i++)
{
    if (phoneNumbers[i].Contains("John"))
    {
        Console.WriteLine(phoneNumbers[i]);
    }

    // Nimadir qilish 
}

// example #2 - foydalanuvchini ( ismi ) foydalanuvchilar kolleksiyasidan ismi bo'yicha toping - John va ekranga chiqaring

// logika
// User tipini yaratish
// User tipiga FirstName fieldini qo'shish 
// foydalanuvchilarni User tipidagi kolleksiyaga ismi bilan saqlash saqlash 
// foydalanuvchilarni bitta bitta olib
// 

//ismlarni tekshirib chiqib 
//ichidan john deganini topish 

var users = new List<User>()
{
    new User
    {
        FirstName = "John",
    },
   new User
   {
       FirstName="Tom"
   },
   new User
   {
       FirstName="Alex"
   },
   new User
   {
       FirstName="Khan"
   }
};

for (int index = 0; index < users.Count; index++)
{
    var user = users[index];

    if (user.FirstName.Contains("John") && user.Age == 30)
    {
        Console.WriteLine(user.FirstName);
    }
}

class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    
}


// code


// example #3 







