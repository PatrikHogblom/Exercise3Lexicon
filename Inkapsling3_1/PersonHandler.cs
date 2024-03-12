namespace Inkapsling3_1
{
    //uppg: 3.1.2
    internal class PersonHandler
    {

        private List<Person> personList = new List<Person>();

        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }

        //uppg 3.1.3
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            return new Person
            {
                Age = age,
                FName = fname,
                LName = lname,
                Height = height,
                Weight = weight
            };
        }

        //uppg 3.1.4
        //methods to create

        //updateAge,
        public void UpdateAge(Person person, int newAge)
        {
            person.Age = newAge;
        }
        //updateName,
        public void UpdateFirstName(Person person, string newFirstName)
        {
            person.FName = newFirstName;
        }
        public void UpdateLastName(Person person, string newLastName)
        {
            person.LName = newLastName;
        }
        //updateHeight,
        public void UpdateHeight(Person person, int newHeight)
        {
            person.Height = newHeight;
        }
        //updateWeight,
        public void UpdateWeight(Person person, int newWeight)
        {
            person.Weight = newWeight;
        }

        //the code that comes below might not be necessary 

        //store the person in a list
        public void StorePersonInList(Person person)
        {
            personList.Add(person);
        }

        //print the current person information
        public void PrintPerson(Person person)
        {
            Console.WriteLine($"Age:{person.Age} \nName: {person.FName} {person.LName} \nHeight: {person.Height} \nWeight: {person.Weight}");
        }

        //Remove person from list 
        public void DeletePerson(Person person)
        {
            personList.Remove(person);
        }

        //print the list
        public void PrintPersonList()
        {
            foreach (Person person in personList)
            {
                Console.WriteLine($"Age:{person.Age} Name: {person.FName} {person.LName} Height: {person.Height} Weight: {person.Weight}");
            }
        }
    }
}