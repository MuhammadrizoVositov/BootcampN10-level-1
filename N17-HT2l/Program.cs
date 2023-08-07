try
{
    var mess = new Chat();
    mess.Add("Hi everyone");
    mess.Add("Let's get started");
    mess.Add("we will start message in 10 minitues");
    mess.Update("we will start message in 10 minitues", "Sorry guys we are having technicual issues,let's wait for another 10 minutes");
    mess.Update("Sorry guys we are having technicual issues,let's wait for another 10 minutes", "I'm really sorry the meeting is canceled");
    mess.Display();
}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}

public static class MessageValidator
{
    public static bool ValidMessage(string content)
    {
        if (string.IsNullOrWhiteSpace(content))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}

class Chat
{
    private Dictionary<Guid, ChatMessage> messages { get; set; }

    public void Add(string content)
    {
        var newMessage = new ChatMessage(content);
        if (messages == null)
        {
            messages = new Dictionary<Guid, ChatMessage>();
        }
        messages.Add(newMessage.Id, newMessage);

    }

    public void Update(string content, string newcontent)
    {
        var isIN = false;
        foreach (var message in messages)
        {
            if (message.Value.Content.CompareTo(content) == 0)
            {
                Console.WriteLine("qale");

                var newMessage = new ChatMessage(message.Value, newcontent);
                messages[message.Key] = newMessage;

            }
        }


    }


    public void Display()
    {
        foreach (var message in messages)
        {
            var time = message.Value.EditTime == null ? message.Value.SentTime : message.Value.EditTime;
            Console.WriteLine(message.Value.Content + " - " + time.ToString("dd.MM.yyyy hh:mm:ss"));
        }
    }

}


class ChatMessage
{
    public Guid Id { get; set; }
    public DateTime SentTime { get; set; }
    public DateTime EditTime { get; set; }
    public string Content { get; set; }
    public ChatMessage(string content)
    {
        Id = Guid.NewGuid();
        Content = content;
        SentTime = DateTime.Now;
    }
    public ChatMessage(ChatMessage chatMessage, string newContent)
    {
        Id = chatMessage.Id;
        Content = newContent;
        SentTime = chatMessage.SentTime;
        EditTime = DateTime.Now;
    }
}
