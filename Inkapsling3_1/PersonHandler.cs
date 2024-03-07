namespace Inkapsling3_1
{
    internal class PersonHandler
    {
        
        //uppg 3.1.2
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


    }
}