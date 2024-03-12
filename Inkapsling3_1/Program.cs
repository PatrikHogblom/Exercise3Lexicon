﻿namespace Inkapsling3_1
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
                /*
                

                //try to see if DoSound() works
                foreach (Animal animal in animals)
                {
                    Console.WriteLine(animal.Name);
                    animal.DoSound();
                }

                //test to se if wolfman can talk
                WolfMan wolfman2 = new WolfMan(name: "Jason", age: 32, gender: "male", weight: 106.5, packLeader: false);  
                Console.WriteLine(wolfman2.Name);
                wolfman2.Talk();*/

                //Uppgift 3.4 

                //3.4.3:  Skapa en lista Animals i Program.cs som tar emot djur
                List<Animal> animals = new List<Animal>();
                //3.4.4. Skapa några djur (av olika typ) i din lista.
                animals.Add(new Horse(name: "Diamanten", age: 9, gender: "male", weight: 200.8, horseOccupation: "Racing Horse"));
                animals.Add(new Dog(name: "Dexter", age: 4, gender: "male", weight: 10.5, dogBreed: "Shcäfer"));
                animals.Add(new Dog(name: "Sixten", age: 2, gender: "female", weight: 9.5, dogBreed: "Siberian Husky"));
                animals.Add(new Dog(name: "Freja", age: 1, gender: "female", weight: 11.5, dogBreed: "Golden Retriever"));
                animals.Add(new Dog(name: "Thor", age: 8, gender: "male", weight: 7.5, dogBreed: "Rottweiler"));
                animals.Add(new Hegdehog(name: "Needle", age: 0, gender: "female", weight: 0.5, nrOfSpikes: 200));
                animals.Add(new Worm(name: "Digger", age: 1, gender: "unkown", weight: 0.05, isPoisonus: false));
                animals.Add(new Bird(name: "Chirper", age: 5, gender: "female", weight: 0.2, wingSpan: 20));
                animals.Add(new Wolf(name: "Growler", age: 12, gender: "male", weight: 20.9, packLeader: true));
                animals.Add(new Pelican(name: "Fisher", age: 8, gender: "male", weight: 7.0, wingSpan: 60, mounthLength: 30));
                animals.Add(new Flamingo(name: "Doflamingo", age: 15, gender: "male", weight: 4.6, wingSpan: 80, legLength: 40));
                animals.Add(new Swan(name: "Bella", age: 10, gender: "female", weight: 3.5, wingSpan: 40, neckLength: 30));
                animals.Add(new WolfMan(name: "Daemon", age: 32, gender: "male", weight: 106.5, packLeader: false));

                //3.4.5 Skriv ut vilka djur som finns i listan med hjälp av en foreach-loop
                Console.WriteLine("Print which animals that exists in the list, also call doSound() and talk() methods");
                foreach (var animal in animals)
                {
                    Console.WriteLine($"\nAnimal Type: {animal.GetType().Name}");
                    // 3.4.6 Anropa ävenAnimals Sound() metod i foreach-loopen
                    animal.DoSound();

                    // 3.4.7 Gör en check i for-loopen ifall ett djur även är av typen IPerson, om den är det
                    // type - casta till IPerson och anropa dess Talk() metod
                    if (animal is IPerson)
                    {
                        ((IPerson)animal).Talk();
                    }
                }

                //Skapa en lista för hundar.
                List<Dog> dogsList = new List<Dog>();
                dogsList.Add(new Dog(name: "Dexter", age: 4, gender: "male", weight: 10.5, dogBreed: "German Shepard"));
                dogsList.Add(new Dog(name: "Sixten", age: 2, gender: "female", weight: 9.5, dogBreed: "Siberian Husky"));
                dogsList.Add(new Dog(name: "Freja", age: 1, gender: "female", weight: 11.5, dogBreed: "Golden Retriever"));
                dogsList.Add(new Dog(name: "Thor", age: 8, gender: "male", weight: 7.5, dogBreed: "Rottweiler"));

                //3.4.9 F:Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
                //Svar: Fungerar inte att lägga till en häst då listan är av typen Dog, att ha en lista av typen Dog så 
                //betyder det kan enbart lägga till objekt av typen Dog  
                //dogsList.Add(new Horse(name: "Diamanten", age: 9, gender: "male", weight: 200.8, horseOccupation: "Racing Horse"));

                //3.4.10.F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
                // Svar: För alla klasser skall kunna lagrs tillsammans så behöver Listan vara av typen List <Animal>,
                // dvs vara en objekt på parent-klassen Animal då alla djur ärver av denna klass

                //3.4.11.Skriv ut samtliga Animals Stats() genom en foreachloop.
                //3.4.12. Testa och se så det fungerar.
                Console.WriteLine("\nPrints Animal stats of animal list are printed below:");
                foreach (var animal in animals)
                {
                    //Console.WriteLine($"\nAnimal Type: {animal.GetType().Name}");
                    Console.WriteLine(animal.Stats());
                }
                //3.4.13. F: Förklara vad det är som händer.
                //svar: Foreach skriver ut djurets namn, ålder, kön, vikt, samt dess unika egenskaper genom att använda Stats()
                //metoden som i sin tur returnerar en textsträng av det vi har lagrat i dess properties när vi skapade en listan
                //animals som innehåller alla djur vi lagt till.

                // 3.4.14: Skriv ut Stats() metoden enbart för alla hundar genom en foreach på Animals.
                Console.WriteLine("\nPrint out the stats of dogs in animals list:");
                foreach (var animal in animals)
                {
                    if(animal.GetType().Name == "Dog") 
                    {
                        Console.WriteLine(animal.Stats());
                    }
                }


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
