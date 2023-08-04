




var message = new NotificationMessage();
message.Add("SuccRegistration", "You saccessful");
message.Add("AskPassword", "Enter yur password");
message.Add("Blocked", "Your accaunt has been blocked");

Console.WriteLine(message.Searchmessage("Qalesan"));

class NotificationMessage
{
    //private dictionary shu
    private Dictionary<string, string> messageAddContent = new Dictionary<string, string>();//kalleksiyalar(dictionary ,array,linkedlist)
    //Bittadan kop narsalar kalleksiyalar deiladi va ular listga saqlanadi
    public void Add(string key, string value)
    {
        messageAddContent[key] = value;
    }
    protected string FindMessage(string name) //Protect methodi      //NotificationMessage ni ichidagi FindMessage methodi shu
    {
        // bu KeyValuePair  tipida qaytarish
        return (messageAddContent.ContainsKey(name) ? KeyValuePair.Create(name, messageAddContent[name]).ToString():"h77y77ggg7g7g");
        //Shu messageni qaytaryotgan joyi shu
    }
    public string Searchmessage(string message)//searchmessage public methodi
    {
        return(FindMessage(message));
    }
  

}