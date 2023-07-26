// Car classini yarataman \
//Klassga 10 tipe qoshaman
//va object yaratib uni qoshaman
//va kalleksiyani tekshiraman



var car = new List<Car>()
{
new Car{Name="Accord",Brand= "Honda" },
new Car{Name="Camry", Brand="Toyota" },
new Car{Name="Civic", Brand="Honda" },
new Car{Name="Accord",Brand= "Honda" },
new Car{Name="Elantra",Brand= "Hyundai" },
new Car{Name="Accord",Brand= "Honda" },
new Car{Name="Sonata",Brand= "Hyundai" },
new Car{Name="Elantra",Brand= "Hyundai" },
new Car{Name="Fusion",Brand= "Ford" },
new Car{Name="Malibu",Brand= "Chevrolet" },
};
Dictionary<Car, int> list = new Dictionary<Car, int>();    


for (int indexA = 0; indexA < car.Count -1; indexA++)
{
    var cnt = 0;
    for (int indexB = indexA ; indexB < car.Count; indexB++)
    {
        if (car[indexA].Equals(car[indexB]))
        {
            cnt++;
        }
    }

    if (cnt > 1)
    {
        if (!list.ContainsKey(car[indexA]))
        {
            list.Add(car[indexA], cnt);
        }
    }
        
}
foreach(var cars in list)
{
    Console.WriteLine(cars.Key.Name+' '+cars.Key.Brand+' '+cars.Value);
}

class Car
{
    public string Name { get; set; }
    public string Brand { get; set; }
    public override bool Equals(object? obj)
    {
        if (obj is Car cr)
        {
            return cr.GetHashCode() == this.GetHashCode();
        }

        return false;
    }



    public override int GetHashCode()
    {
        return Name.GetHashCode()
            + Brand.GetHashCode();
    }

}
