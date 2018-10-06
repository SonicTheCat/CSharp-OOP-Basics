using System;

class Program
{
    static void Main()
    {
        Cat cat = new Cat();
        Dog dog = new Dog();

        cat.Eat();
        cat.Meow();

        dog.Eat();
        dog.Bark();
    }
}

