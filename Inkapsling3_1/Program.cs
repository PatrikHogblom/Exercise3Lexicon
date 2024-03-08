namespace Inkapsling3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Person person = new Person();
                PersonHandler personHandler = new PersonHandler();

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
                personHandler.PrintPersonList();

                //Console.WriteLine(person.Age + " " + person.FName + " " + person.LName + " " + person.Height + " " + person.Weight);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadLine();
        }
    }
}
