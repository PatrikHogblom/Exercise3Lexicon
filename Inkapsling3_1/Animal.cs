namespace Inkapsling3_1
{
    abstract class Animal
    {
        //need to have abstract after public if you want to implement it in subclass 
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Weight { get; set; }
        public abstract void DoSound();
        public Animal(string name, int age, string gender, int weight)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Weight = weight;
        }
    }

    class Horse : Animal
    {
        public string HorseOccupation { get; set; }

        public Horse(string name, int age, string gender, int weight, string horseOccupation) : base(name, age, gender, weight)
        {
            HorseOccupation = horseOccupation; //wild, breeding, racing, work, farm 
        }

        public override void DoSound()
        {
            Console.WriteLine("Horse sounds: Neigh! Neigh!");
        }
    }

    class Dog : Animal
    {
        public string DogBreed { get; set; }

        public Dog(string name, int age, string gender, int weight, string dogBreed) : base(name, age, gender, weight)
        {
            DogBreed = dogBreed;
        }

        public override void DoSound()
        {
            Console.WriteLine("Dog sounds: woof! woof!");
        }
    }

    class Hegdehog : Animal
    {
        public int NrOfSpikes { get; set; }

        public Hegdehog(string name, int age, string gender, int weight, int nrOfSpikes) : base(name, age, gender, weight)
        {
            NrOfSpikes = nrOfSpikes;
        }


        public override void DoSound()
        {
            Console.WriteLine("Hegdedog sounds: gruff! gruff!");
        }
    }

    class Worm : Animal
    {
        public bool IsPoisonus { get; set; }
        public Worm(string name, int age, string gender, int weight, bool isPoisonus) : base(name, age, gender, weight)
        {
            IsPoisonus = isPoisonus;
        }

        public override void DoSound()
        {
            Console.WriteLine("Worm sounds: rattle! rattle!");
        }
    }

    class Bird : Animal
    {
        public double WingSpan { get; set; }

        public Bird(string name, int age, string gender, int weight, double wingSpan) : base(name, age, gender, weight)
        {
            WingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine("Bird sounds: chirp! chirp!");
        }
    }

    class Wolf : Animal
    {
        public bool PackLeader { get; set; }

        public Wolf(string name, int age, string gender, int weight, bool packLeader) : base(name, age, gender, weight)
        {
            PackLeader = packLeader;
        }

        public override void DoSound()
        {
            Console.WriteLine("Wolf sounds: growl! growl!");
        }
    }

    class Pelican : Bird
    {
        public Pelican(string name, int age, string gender, int weight, double wingSpan) : base(name, age, gender, weight, wingSpan)
        {
        }
    }

    class Flamingo : Bird
    {
        public Flamingo(string name, int age, string gender, int weight, double wingSpan) : base(name, age, gender, weight, wingSpan)
        {
        }
    }

    class Swan : Bird
    {
        public Swan(string name, int age, string gender, int weight, double wingSpan) : base(name, age, gender, weight, wingSpan)
        {
        }
    }

}