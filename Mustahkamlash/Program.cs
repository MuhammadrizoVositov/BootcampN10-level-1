




var UserA = new User
{
    firstName = "Bobur",
    lastName = "Joraboyev",
    middleName = "MUrotjon"
};
var UserB = new User
{
    firstName = "Bobur",
    lastName = "Joraboyev",
    middleName = "MUrotjon"
};
Console.WriteLine(UserA.Equals(UserB));


class User

{
    private string _firstName;
    private string _lastName;
    private string _middleName;
    public string firstName {
        get => _firstName; 
        set
        {
            _firstName = value;
        }
    }
    public string lastName {
        get => _lastName;
        set
        {
            _lastName = value;
        }
    }
    public string middleName {
        get => _middleName;
        set
        {
            _middleName = value;
        }
    }
    public override bool Equals(object? obj)
    {
        if(obj is  User us) 
        {
            return us.GetHashCode() == this.GetHashCode();
        }
        return false;
    }
    public override int GetHashCode()
    {
        return _firstName.GetHashCode()
                + _lastName.GetHashCode()
                +_middleName.GetHashCode();
    }
}