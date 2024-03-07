namespace Inkapsling3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PersonHandler personHandler = new PersonHandler();
                Person person = new Person();

                person = personHandler.CreatePerson(28, "Patrik", "Högblom", 191, 105);

                Console.WriteLine(person.Age + " " + person.FName + " " + person.LName + " " + person.Height + " " + person.Weight);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadLine();
        }
    }
}
