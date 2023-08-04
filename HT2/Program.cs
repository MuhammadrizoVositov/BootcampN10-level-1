
using System.Runtime.InteropServices;



var name = new SmartHomeService();
name.ExpectedTemperture = 20;
name.CurrentTepmereature = 22;
name.CurrentTepmereature = 23;
name.CurrentTepmereature = 21;
name.CurrentTepmereature = 20;
name.ExpectedTemperture = 25;
name.CurrentTepmereature = 21;
name.CurrentTepmereature = 22;
name.CurrentTepmereature = 23;
name.Display();

class SmartHomeService : Temperature
{
    private double _expectedTemperature;
    private string _devicename;
    private double _temperature;
    public readonly bool isActivated;
    public string DeviceName
    {
        init
        {
            _devicename = value;
        }
    }
    public double ExpectedTemperture
    {
        get => _expectedTemperature;
        set
        {
            _expectedTemperature = value;
            if (!temperatures.ContainsKey(value))
            {
                temperatures[_expectedTemperature] = new List<double>();
            }
        }
    }
    public double CurrentTepmereature
    {
        set
        {
            temperatures[ExpectedTemperture].Add(value);
            _temperature = value;
        }
    }




    public void Display()
    {
        foreach (var t in temperatures)
        {
            foreach (var c in temperatures[t.Key])
            {
                Console.WriteLine($"Expected - {t.Key},  Current - {c}");
            }
        }
    }

}

class Temperature
{
    private protected Dictionary<double, List<double>> temperatures = new Dictionary<double, List<double>>();
}