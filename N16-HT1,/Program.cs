var space = new SpaceShip(15.5, "Petrol", "straight", 220);


Console.WriteLine(space);


class SpaceShip
{
    private double _fuel;
    private string _name;
    private string _trajectory;
    public string Name
    {
        init
        {
            _name = value;
        }
    }
    public double Fuel => _fuel;
    public double Speed { get; set; }
    public string Trajectory
    {
        set
        {
            _trajectory = value;
        }
    }

    public SpaceShip(double fuel, string name, string trajectory, double speed)
    {
        _fuel = fuel;
        Name = name;
        Trajectory = trajectory;
        Speed = speed;
    }

    public override string ToString()
    {
        return $"Name: {_name}\nFuel amount: {Fuel}\nTrajectory: {_trajectory}\nSpeed: {Speed}";
    }
}