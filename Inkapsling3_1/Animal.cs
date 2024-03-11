namespace Inkapsling3_1
{
    abstract class Animal
    {
        //need to have abstract after public if you want to implement it in subclass 
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Weight { get; set; }
        public abstract void DoSound();
        public Animal(string name, int age, string gender, double weight)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Weight = weight;
        }
    }

    //uppg: 3.2.5 -> 3.2.7
    class Horse : Animal
    {
        public string HorseOccupation { get; set; }

        public Horse(string name, int age, string gender, double weight, string horseOccupation) : base(name, age, gender, weight)
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

        public Dog(string name, int age, string gender, double weight, string dogBreed) : base(name, age, gender, weight)
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

        public Hegdehog(string name, int age, string gender, double weight, int nrOfSpikes) : base(name, age, gender, weight)
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
        public Worm(string name, int age, string gender, double weight, bool isPoisonus) : base(name, age, gender, weight)
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

        public Bird(string name, int age, string gender, double weight, double wingSpan) : base(name, age, gender, weight)
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

        public Wolf(string name, int age, string gender, double weight, bool packLeader) : base(name, age, gender, weight)
        {
            PackLeader = packLeader;
        }

        public override void DoSound()
        {
            Console.WriteLine("Wolf sounds: growl! growl!");
        }
    }

    //uppg 3.2.8, 3.2.9
    class Pelican : Bird
    {
        public double MouthLength { get; set; }
        public Pelican(string name, int age, string gender, double weight, double wingSpan, double mounthLength) : base(name, age, gender, weight, wingSpan)
        {
            MouthLength = mounthLength;
        }
    }

    class Flamingo : Bird
    {
        public double LegLength { get; set; }
        public Flamingo(string name, int age, string gender, double weight, double wingSpan, double legLength) : base(name, age, gender, weight, wingSpan)
        {
            LegLength = legLength;
        }
    }

    class Swan : Bird
    {
        public double NeckLength { get; set; }
        public Swan(string name, int age, string gender, double weight, double wingSpan, double neckLength) : base(name, age, gender, weight, wingSpan)
        {
            NeckLength = neckLength;
        }
    }

    //uppg 3.2.10
    interface IPerson
    {
        public void Talk();
    }

    //uppgift 3.2.11 och 3.2.12
    class WolfMan : Wolf,IPerson
    {
        public WolfMan(string name, int age, string gender, double weight, bool packLeader) : base(name, age, gender, weight, packLeader)
        {
        }

        public void Talk()
        {
            Console.WriteLine("I'm only a werewolf under full moon, rest assured because i will turn to human again!");
        }
    }

}