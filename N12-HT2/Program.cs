
using System.Text.RegularExpressions;


var EmailA = new Email
{
    to = "hullas@gmail.com",
    from = "mashi@gmail.com",
    subject = "ertaga tugilgan kunim",
    content = "Tugilgan kunga aytish"
};
Console.WriteLine(EmailA);


class Email
{
    private string _to;
    private string _from;
    private string _subject;
    private string _content;

    public string to {
        get
        {
            return _to;
        }
        set
        {
            if(string.IsNullOrWhiteSpace(value) || !Regex.IsMatch(value,@"[a-z0-9]+@[a-z]+\.[a-z]{2,3}"))//Validation  qilishlik
            {
                throw new FormatException("Email kiritinshda hatolik");
            }
            _to = value;
        }
    }

    public string from {
        get
        {
            return _from;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || ! Regex.IsMatch(value, @"[a-z0-9]+@[a-z]+\.[a-z]{2,3}"))
            {
                throw new FormatException(" Kiritilgan Email notogri");
            }
            _from = value;

        }

             
    }
    public string subject {
        get
        {
            return _subject;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || Regex.IsMatch(value,@"[a-z0-9]+@[a-z]+\.[a-z]{2,3}"))
            {
                throw new FormatException("ushbu emaildan maqsad yoq");
            }
            _subject = value;
        }
    }
    public string content {
        get
        {
            return _content;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || Regex.IsMatch(value, @"[a-z0-9]+@[a-z]+\.[a-z]{2,3}"))
            {
                throw new FormatException("Bu email mazmunsiz"); 
            }
        }
    }
    public override string ToString()
    {
        return $" to-{to} from-{from} subject-{subject} content-{content}";
    }
}

