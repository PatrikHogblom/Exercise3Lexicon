namespace Inkapsling3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Uppgift 3.1
                //Person person = new Person();
                /*PersonHandler personHandler = new PersonHandler();

                Person person = personHandler.CreatePerson(28, "Patrik", "Högblom", 191, 105);
                personHandler.PrintPerson(person);
                

                Console.WriteLine("\nUpdate age method is used");
                personHandler.UpdateAge(person, 40);
                personHandler.PrintPerson(person);
                Console.WriteLine("\nUpdate firstname method is used");
                personHandler.UpdateFirstName(person,"Henrik");
                personHandler.PrintPerson(person);
                Console.WriteLine("\nUpdate Lastname method is used");
                personHandler.UpdateLastName(person, "Jönsson");
                personHandler.PrintPerson(person);
                Console.WriteLine("\nUpdate Height method is used");
                personHandler.UpdateHeight(person, 180);
                personHandler.PrintPerson(person);
                Console.WriteLine("\nUpdate Weight method is used");
                personHandler.UpdateWeight(person, 90);
                personHandler.PrintPerson(person);


                //add the person to a list
                Console.WriteLine("\nAdds people to list method is used");
                personHandler.StorePersonInList(person);
                //personHandler.PrintPersonList();

                //add another person to the list
                Person person2 = personHandler.CreatePerson(28, "Patrik", "Högblom", 191, 105);
                personHandler.StorePersonInList(person2);
                personHandler.PrintPersonList();

                Console.WriteLine("\nDelete person from list method is used");
                personHandler.DeletePerson(person);
                //personHandler.StorePersonInList(person);
                personHandler.PrintPersonList();*/

                //uppgift 3.2
                /*List<UserError> UserErrors = new List<UserError>();

                UserErrors.Add(new NumericInputError());
                UserErrors.Add(new TextInputError());
                UserErrors.Add(new DateFormatInputError());
                UserErrors.Add(new PasswordInputError());
                UserErrors.Add(new IllegalSymbolTextInputError());

                foreach (UserError error in UserErrors)
                {
                    Console.WriteLine(error.UEMessage());
                }*/


                //uppg3.3
                Animal horse = new Horse(name: "Diamanten", age: 9, gender: "male", weight: 200.8, horseOccupation: "Racing Horse");
                Animal dog = new Dog(name: "Dexter", age: 4, gender: "male", weight: 10.5, dogBreed: "Shcäfer");
                Animal hegdehog = new Hegdehog(name: "Needle", age: 0, gender: "female", weight: 0.5, nrOfSpikes: 200);
                Animal worm = new Worm(name: "Digger", age: 1, gender: "unkown", weight: 0.05, isPoisonus: false);
                Animal bird = new Bird(name: "Chirper", age: 5, gender: "female", weight: 0.2, wingSpan: 20);
                Animal wolf = new Wolf(name: "Growler", age: 12, gender: "male", weight: 20.9, packLeader: true);
                Animal pelican = new Pelican(name: "Fisher", age: 8, gender: "male", weight: 7.0, wingSpan: 60, mounthLength: 30);
                Animal flamingo = new Flamingo(name: "Doflamingo", age: 15, gender: "male", weight: 4.6, wingSpan: 80, legLength: 40);
                Animal swan = new Swan(name: "Bella", age: 10, gender: "female", weight: 3.5, wingSpan: 40, neckLength: 30);
                Animal wolfman = new WolfMan(name: "Daemon", age: 32, gender: "male", weight: 106.5, packLeader: false);
                
                //Add each animal to a list
                List<Animal> animals = new List<Animal>();
                animals.Add(horse);
                animals.Add(dog);
                animals.Add(hegdehog);
                animals.Add(worm);
                animals.Add(bird);
                animals.Add(wolf);
                animals.Add(pelican);
                animals.Add(flamingo);
                animals.Add(swan);
                animals.Add(wolfman);

                //try to see if DoSound() works
                foreach (Animal animal in animals)
                {
                    Console.WriteLine(animal.Name);
                    animal.DoSound();
                }

                //test to se if wolfman can talk
                WolfMan wolfman2 = new WolfMan(name: "Jason", age: 32, gender: "male", weight: 106.5, packLeader: false);  
                Console.WriteLine(wolfman2.Name);
                wolfman2.Talk();

                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadLine();
        }
    }
}
