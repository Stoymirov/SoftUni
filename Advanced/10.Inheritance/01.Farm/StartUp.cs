using Farm;

public class StartUp
{
    public static void Main(string[] args)
    {
        Cat cat = new Cat();
        Dog dog = new Dog();
        cat.Meow();
        dog.Eat();
        dog.Bark();
    }

}