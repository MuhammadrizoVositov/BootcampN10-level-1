

public class Program
{
    public void Main()
    {
        Animal GeneticAnimal = new Animal();
        GeneticAnimal.MakeSound();

        Bird GeneticBird = new Bird();
        GeneticBird.MakeSound();


        Mammal mammal = new Mammal();
        mammal.Run();

        Fish fish = new Fish();
        fish.Swim();

    }

}

public class Animal
{




    public void MakeSound()
    {
        Console.WriteLine(".......");
    }


}
class Bird:Animal
{
    public void Fly()
    {
        Console.WriteLine("Fly"); 
    }




}

class Mammal : Animal
{
    public void Run()
    {
        Console.WriteLine("Run");
    }



}

class Fish : Animal
{
    public void Swim()
    {
        Console.WriteLine("Swim");
    }



}
class Sparrov:Bird
{


}

class GreatWhiteShark:Fish
{


}

