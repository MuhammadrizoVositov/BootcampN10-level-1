using System.Collections;
using System.ComponentModel;


var renter = new CarRentalManagement();


CarRental bmr1 = new Bmw("A5");
CarRental bmr2 = new Bmw("B5");
CarRental audi = new Audi("S5");
CarRental bmr3 = new Bmw("C5");
renter.Add(bmr1);
renter.Add(bmr2);
renter.Add(audi);
renter.Add(bmr3);

var rent1 = renter.Rent("BMW");

var rent2 = renter.Rent("BMW");

var rent3 = renter.Rent("AUDI");


var rent4 = renter.Rent("BMW");
giveRent(rent1, renter, 3000);
giveRent(rent2, renter, 2000);
giveRent(rent3, renter, 4000);
//giveRent(rent4,renter,2000);

renter.CalculateBalance();

static void giveRent(CarRental car, CarRentalManagement rentalHouse, int seconds)
{
    if (car == null)
    {
        Console.WriteLine("Kechirasiz hozirda barcha avtomobillarimiz ijarada");
    }
    else
    {
        Thread.Sleep(seconds);
        rentalHouse.Return(car);
    }
}

class CarRentalManagement : CarRental
{
    private List<CarRental> Cars = new List<CarRental>();
    public CarRentalManagement()
    {
        Cars = new List<CarRental>();
    }

    public void CalculateBalance()
    {
        var ne = new Bmw("BMW");
        Console.WriteLine($"Balance: {Balance}");
    }
    public void Add(CarRental car)
    {
        Cars.Add(car);
    }
    public void Return(CarRental car)
    {
        foreach (var ca in Cars)
        {
            if (ca is Bmw bmw1)
            {
                if (car.Id == bmw1.Id)
                {
                    var time = DateTime.Now - bmw1.RentStartTime;
                    bmw1.isRendted = false;
                    var returningMoney = (time.Seconds) * bmw1.RentPricePerHour;
                    Balance += returningMoney;
                    Console.WriteLine($"rent {bmw1.ModelName} {bmw1.BrandName} - {time.Seconds} second - return {time.Seconds} * {bmw1.RentPricePerHour} = {returningMoney}");
                    break;
                }
            }
            else
            if (ca is Audi audi1)
            {
                if (audi1.Id == car.Id)
                {
                    var time = DateTime.Now - audi1.RentStartTime;
                    audi1.isRendted = false;
                    var returningMoney = (time.Seconds) * audi1.RentPricePerHour;
                    Balance += returningMoney;
                    Console.WriteLine($"rent {audi1.ModelName} {audi1.BrandName} - {time.Seconds} second - return {time.Seconds} * {audi1.RentPricePerHour} = {returningMoney}");
                    break;
                }
            }
        }
    }

    public CarRental Rent(string brandName)
    {
        foreach (CarRental car in Cars)
        {
            if (car.BrandName == brandName && !car.isRendted)
            {
                car.isRendted = true;
                car.RentStartTime = DateTime.Now;
                return car;
            }
        }
        return null;
    }

}

sealed class Bmw : CarRental
{
    public string ModelName { get; set; }
    public decimal RentPricePerHour = 20;
    public Bmw(string modelName)
    {
        ModelName = modelName;
        BrandName = "BMW";
        Id = Guid.NewGuid();
    }
}

sealed class Audi : CarRental
{
    public string ModelName { get; set; }
    public decimal RentPricePerHour = 30;
    public Audi(string modelName)
    {
        ModelName = modelName;
        BrandName = "AUDI";
        Id = Guid.NewGuid();
    }
}



abstract class CarRental
{
    public bool isRendted { get; set; }
    public DateTime RentStartTime { get; set; }
    public decimal Balance = 0;
    public string BrandName { get; set; }
    public Guid Id { get; set; }

}