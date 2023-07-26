//User tipi yaratiladi
//ism sharf qoshiladi
//property yasaldi 
//field yasaladi va elon qilinadi


var UserA = new User
{
    firsttName = "Muhammadrizo",
    LastName = "Vositov",
    middletName = "Muhammadtolib"
};
var UserB = new User
{
    firsttName = "Muhammadrizo",
    LastName = "Vositov",
    middletName = "Muhammadtolib"
};
Console.WriteLine(UserA.Equals(UserB));



class User
{
    private string _firstName;
    private string _lastName;
    private string _middleName;
    public string firsttName 
    { 
        get=>_firstName;
        set
        {
            _firstName = value;
        } 
    }
    public string LastName {
        get => _lastName; // Return qilishlik
        set
        {
            _lastName = value;    // Qiymat qaytarishlik
        }
    
    }
    public string middletName {
        get => _middleName; 
        set
        {
            _middleName = value;
        }
    
    }

    public override bool Equals(object? obj)  /// Solishtiriishlik
    {
        if (obj is User us)
        {
            return us.GetHashCode() == this.GetHashCode();
        }
        return false;
    }
    public override int GetHashCode()
    {
        return _firstName.GetHashCode()
               + _lastName.GetHashCode()
               + _middleName.GetHashCode();
    }
}