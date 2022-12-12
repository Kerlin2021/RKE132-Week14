using System;

Console.WriteLine("Name your Dog:");
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName);
Dog neighboursDog = new Dog("Good Girl");


Console.WriteLine($"My Dogs name is {myDog.Name}.");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}.");

myDog.Rename("Bad Boy");

while (myDog.levelOfHapiness != 5)
{
    myDog.Bark();
}
myDog.WagTail();

class Dog
{
    private string _name = "Koer";
    private int  _levelOfHapiness;

    public Dog(string name)
    {
        _name = name;
        _levelOfHapiness = 0;
    }

    public string Name
    {
        get { return _name; }  
    }
    public int levelOfHapiness
    {
        get { return _levelOfHapiness;}
    }
    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }
    public void Bark()
    {
        Console.WriteLine("Woof-Woof!");
        _levelOfHapiness ++;
    }
    public void WagTail()
    {
        Console.WriteLine("Wiggle-Wiggle");
    }
}

