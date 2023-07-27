var time = new DateTime();

var Generate = new PasswordGenerate(10,true);
Console.WriteLine(Generate.Generate());

class PasswordGenerate
{
    public string Password="";
    public int passwordLength;
    public bool hasDigits;    //Field jarayoni
    public bool hasLetters;

    
    public PasswordGenerate(int lenght, bool hasLetters, bool hasDigit = true)
    {
        this.passwordLength = lenght;
        this.hasDigits = hasLetters;  // Construktor 
        this.hasLetters = hasDigit;
    }
   
    public string Generate(/*Parametr  joyi   shu */)// Method deyiladi shu
    {

        var ran = new Random();
        while (Password.Length<passwordLength)
        {
            if(hasLetters) 
            {
                Password += (char)ran.Next(65, 91);// Casting shu joyi Birinchi pipdn boshqa tipga otkazilishi
            }

            if(hasDigits)
            {
                Password += (char)ran.Next(47, 58);
            }
            // Generate     qilish bu 
            
        }
        return Password;

    }
    

}
















