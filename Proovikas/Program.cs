Cat newCat = new name ("Garfield", "ginger");
Console.WriteLine($"{newCat.name} wants a rub on its belly.");
while (newCat.BellyFull != 10)
{
    newCat.Sleep();
}
newCat.sleep();
newCat.ShowCatData();
class Cat
{
    private string _name;
    private string _color;
    private int _BellyFull;
    public Cat (string name, string color)
    {
        _name = name;
        _color = color;
        _BellyFull = 10;
        Console.WriteLine($"a {color} cat {name} has been created.");
    }
    public string Name
    {
        get { return _name; }
    }
    public int BellyFull
    {
        get { return _BellyFull; }
    }
    public void sleep()
    {
        _BellyFull--;
        Console.WriteLine($"{_name} says :z-z-z-z-z ");
    }
    public void MEow()
    {
        Console.WriteLine($"{_name} says: Meow!");
    }
    public void ShowCatData()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Color: {_color}");
        Console.WriteLine($"Level of hungriness: {_BellyFull}");
    }

}