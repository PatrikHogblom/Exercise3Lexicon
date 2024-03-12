namespace Exercise3
{
    //uppg 3.1.1
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        //properties
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be bigger than 0");
                }
                else
                {
                    age = value;
                }
            }
        }
        public string FName
        {
            get { return fName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Firstname is required");
                }
                else
                {
                    if (value.Length >= 2 && value.Length <= 10)
                    {
                        fName = value;
                    }
                    else
                    {
                        throw new ArgumentException("Firstname cannot be smaller than 2 letters or bigger than 10 letters");
                    }
                }
            }
        }
        public string LName
        {
            get
            {
                return lName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Lastname is required");
                }
                else
                {
                    if (value.Length >= 3 && value.Length <= 15)
                    {
                        lName = value;
                    }
                    else
                    {
                        throw new ArgumentException("Lastname cannot be smaller than 3 letters or bigger than 15 letters");
                    }
                }
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
    }
}