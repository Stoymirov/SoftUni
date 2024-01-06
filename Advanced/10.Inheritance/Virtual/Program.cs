using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

Lion lio = new Lion();
lio.Eat();
Animal ani =new Animal();
ani.Eat();
Console.WriteLine(lio);
Console.WriteLine(new Animal().Name);
Console.WriteLine(new Lion().Name);
class Animal
{
    public virtual void Eat()
    {
        Console.WriteLine("Eating");
    }

    public virtual string Name
    {
        get
        {
            return "Jivotno";
        }
    }
}

class Lion : Animal
{

    public string Name
    {
        get { return "lyvcho"; }
    }

    public override void Eat()
    {
        base.Eat();
        Console.WriteLine("Everything I see");
    }

    public override string ToString()
    {
        return $"{base.ToString()} - Simba";
    }
}