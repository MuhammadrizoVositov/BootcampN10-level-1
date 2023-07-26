// Tourist Queue
var tourist = new Queue<string>();

tourist.Enqueue("Gayrat");
tourist.Enqueue("John");
tourist.Enqueue("Bobir");
tourist.Enqueue("Johon");

// Planes schedule dictionary
var planets = new Dictionary<DateTime, int>
{
    { new DateTime(2023, 07, 09, 9, 00, 00), 3},
    { new DateTime(2023, 07, 09,12, 00, 00), 3},
    { new DateTime(2023, 07, 09, 15, 00, 00), 3},
};

// Constants for message tokens and values
// Token - o'zgarishi kerak bo'lgan textlarni ushlab turadi
// const - Constant - Konstanta - o'zgarmas
// var - Variable - o'zgaruvchi
const string companyName = "The Travel Guru";
const string nameToken = " messagelarda {{Name}}";
const string companyNameToken = "{{CompanyName}}";
const string cicketDateToken = "{{TicketDate}}";

// Email templates in linked list
var email = new LinkedList<string>();
email.AddLast("Hello {{Name}}. Welcome to onboard. {{CompanyName}} Team.");
email.AddLast("Your data is being processed and we will inform updates for you as soon as possible. {{CompanyName}} Team");
email.AddLast("Congratulations! Your flight ticket is booked for {{TicketDate}}. {{CompanyName}} Team.");

// Enter a user with firstname and age
var validName = false;
var input = Console.ReadLine();
do
{
    Console.WriteLine("Iltimos ismingizni kiriting");

    // Validate name
    // date type - primtive
    // array operations - iterate, access
    // string operations - concat, interpolation, formatting
    // collections - list, 
    // control structures - if, switch, for, do, while, foreach

    // string = char array
    // "John" = 'J' + 'o' + 'h' + 'n'
    // "John" = new char[] {'J','o','h','n'};

    for (var index = 0; index < input.Length; index++)
        if (char.IsDigit(input[index]))
        {
            Console.WriteLine("Invalid Name");

            // For dan chiqish kerak
            // continue - 
            // break - 
            
            break;
        }
} while (!validName);

// cast
// conversion
// parse

Console.WriteLine("Iltimos yoshingizni kiriting:");
if (input=)
{

}
else
{

}






