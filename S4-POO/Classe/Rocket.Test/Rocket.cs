namespace Rocket.Test;
class Rocket
{
    public string Name { get; set;}
    int Fuel { get; set;} = 0;
    public decimal Price { get; set;}

    public Rocket()
    {
    }

    // overload
    public Rocket(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}