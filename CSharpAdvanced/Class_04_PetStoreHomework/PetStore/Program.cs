using PetStore.Classes;
using PetStore.Generics;
using System;

namespace PetStore

{
    class Program
    {
        static void Main(string[] args)
        {
            PetStore<Dog> FirstDog = new PetStore<Dog>();
            PetStore<Dog> SecondDog = new PetStore<Dog>();

            PetStore<Cat> FirstCat = new PetStore<Cat>();
            PetStore<Cat> SecondCat = new PetStore<Cat>();

            PetStore<Fish> FirstFish = new PetStore<Fish>();
            PetStore<Fish> SecondFish = new PetStore<Fish>();

            FirstDog.Insert(new Dog() { Name = "Dzoki", Age = 5, FavouriteFood = "meat", GoodBoi = true, Type = "Terrier" });
            SecondDog.Insert(new Dog() { Name = "Luna", Age = 6, FavouriteFood = "hotDogs", GoodBoi = true, Type = "Doberman" });

            FirstCat.Insert(new Cat() { Name = "Marko", Age = 2, IsLazy = false, Type = "Some cat type", LivesLeft = 5 });
            SecondCat.Insert(new Cat() { Name = "Petra", Age = 3, IsLazy = true, Type = "Some cat type3", LivesLeft = 4 });

            FirstFish.Insert(new Fish() { Name = "Fishyfish", Age = 1, Type = "littleFish", Color = "yellow", Size = 2 });
            SecondFish.Insert(new Fish() { Name = "GoldFish", Age = 2, Type = "bigFish", Color = "gold", Size = 3 });

            FirstDog.PrintPets();
            SecondDog.PrintPets();

            FirstCat.PrintPets();
            SecondCat.PrintPets();

            FirstFish.PrintPets();
            SecondFish.PrintPets();

            FirstDog.BuyPet("ThirtDog");
            FirstCat.BuyPet("ThirdCat");

            Console.ReadLine();
        }
    }
}