using Övning_3;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //SVAREN PÅ FRÅGORNA FINNS I README.MD
            //
            PersonHandler personHandler = new PersonHandler();
            Person lisa = personHandler.CreatePerson(25, "Lisa", "Lisasson", 1.75, 65);
            
            List<UserError> errors = new List<UserError>();

            errors.Add(new TextInputError());
            errors.Add(new ErrorMessages());
            errors.Add(new LengthInputError());
            errors.Add(new HeightInputError());
            errors.Add(new WeightInputError());

            
            List<Animal> animals = new List<Animal>();

            animals.Add(new Dog("Fido", 5, 25, 3));
            animals.Add(new Hedgehog("Sonic", 2, 0.5));
            animals.Add(new Wolf("Wolfie", 7, 40, true));
            animals.Add(new Wolfman("Logan", 125, 145, false));
            animals.Add(new Bird("Tweety", 1, 0.1, 1));
            animals.Add(new Pelican("Pelle", 3, 5, 13, 32));
            animals.Add(new Flamingo("Flamey", 2, 3, 23, 2));
            animals.Add(new Swan("Swanny", 4, 7, 10, 11));
            animals.Add(new Horse("Horsy", 6, 400, 31));
            animals.Add(new Worm("Wormy", 1, 0.01, true));

            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("Lassy", 5, 25, 301));
            dogs.Add(new Dog("Dogge", 3, 20, 3));
            // dogs.Add(new Wolf("Bella", 7, 30, true));
           
            //foreach (Animal animal in animals)
            //{
            //    if(animal is IPerson)
            //    {
            //        IPerson wolfman = (IPerson)animal;
            //        Console.WriteLine(wolfman.Talk());
            //    }
            //    animal.DoSound();
            //   Console.WriteLine( animal.Stats());
            //}

            //foreach (Dog dog in dogs)
            //{
            //    Console.WriteLine(dog.Stats());
           
              
            //}

            foreach (Animal animal in animals)
            {
              if(animal is Dog)
                {
                    Console.WriteLine("Dog likes to eat: " + ((Dog)animal).bestDogFood());  
                }
            }


            //foreach (var error in errors)
            //{
            //    Console.WriteLine(error.UEMessage());
            //}

        }
    }
}