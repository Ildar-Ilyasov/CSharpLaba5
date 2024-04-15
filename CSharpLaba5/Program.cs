using System;

class Animal
{
    public string Food { get; set; }
    public string Location { get; set; }
    public string Color { get; set; }

    public virtual void MakeNoise()
    {
        Console.WriteLine("Животное издает звук");
    }
    public virtual void Eat()
    {
        Console.WriteLine("Животное ест");
    }
    public void Sleep()
    {
        Console.WriteLine("Животное спит");
    }
}

class Dog : Animal
{
    public override void MakeNoise()
    {
        Console.WriteLine("Собака гавкает");
    }
    public override void Eat()
    {
        Console.WriteLine("Собака ест корм");
    }
}

class Cat : Animal
{
    public override void MakeNoise()
    {
        Console.WriteLine("Кошка мяукает");
    }
    public override void Eat()
    {
        Console.WriteLine("Кошка ест рыбу");
    }
}

class Horse : Animal
{
    public override void MakeNoise()
    {
        Console.WriteLine("Лошадь ржет");
    }
    public override void Eat()
    {
        Console.WriteLine("Лошадь ест сено");
    }
}

class Veterinarian
{
    public void TreatAnimal(Animal animal)
    {
        Console.WriteLine($"Еда: {animal.Food}, Местоположение: {animal.Location}, Цвет шерсти:{animal.Color}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog { Food = "Корм для собак", Location = "Дом", Color = " Черный" };
        Cat cat = new Cat { Food = "Рыба", Location = "Квартира", Color = " Белый" };
        Horse horse = new Horse { Food = "Сено", Location = "Ферма", Color = " Пятнистый" };

        Veterinarian veterinarian = new Veterinarian();
        veterinarian.TreatAnimal(dog);
        veterinarian.TreatAnimal(cat);
        veterinarian.TreatAnimal(horse);

        dog.MakeNoise();
        dog.Eat();
        dog.Sleep();

        cat.MakeNoise();
        cat.Eat();
        cat.Sleep();

        horse.MakeNoise();
        horse.Eat();
        horse.Sleep();
    }
}