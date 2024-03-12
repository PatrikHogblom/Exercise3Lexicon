namespace Inkapsling3_1
{
    //uppg 3.3.1:  Skapa  abstrakta klassen Animal
    abstract class Animal
    {
        //uppg 3.3.2: Fyll klassen Animal med egenskaper (properties) som alla djur bör ha. Tex namn, vikt, ålder.
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Weight { get; set; }

        // uppg: 3.3.3: Skapa en abstrakt metod som heterDoSound().
        public abstract void DoSound();

        //uppg 3.3.4: Lägg till en konstruktor
        public Animal(string name, int age, string gender, double weight)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Weight = weight;
        }

        // uppg 3.4.4:  Skapa metoden Stats() i klassenAnimal som har returtypen string.
        // Metoden ska kunnaoverridas i dess Subklasser.Metoden ska returnera alla
        // egenskaper (properties) som djuret har.
        public virtual string Stats()
        {
            string textValue = string.Empty;
            textValue += $"\nName: {Name}";
            textValue += $"\nAge: {Age} years";
            textValue += $"\nGender: {Gender}";
            textValue += $"\nWeight: {Weight} kg";

            return textValue;
        }
    }

    //uppg 3.3.5 Skapa Subklasserna (ärver från Animal): Horse, Dog, Hedgehog, Worm och Bird, Wolf.
    class Horse : Animal
    {
        //uppg: 3.3.6: Ge dessa minst en unik egenskap var. Vilken egenskap det är är inte det viktiga här.
        public string HorseOccupation { get; set; }

        public Horse(string name, int age, string gender, double weight, string horseOccupation) : base(name, age, gender, weight)
        {
            HorseOccupation = horseOccupation; //wild, breeding, racing, work, farm 
        }

        public override void DoSound()
        {
            Console.WriteLine("Horse sounds: Neigh! Neigh!");
        }

        // uupg 3.4.2: Skriv enoverride för Stats() i subklasserna för Animal så den returnerar alla properties för det djuret.
        public override string Stats()
        {
            string textValue = base.Stats();
            textValue += $"\nHorse occupation: {HorseOccupation}";
            return textValue;
        }
    }

    class Dog : Animal
    {
        //uppg: 3.3.6: Ge dessa minst en unik egenskap var. Vilken egenskap det är är inte det viktiga här.
        public string DogBreed { get; set; }

        public Dog(string name, int age, string gender, double weight, string dogBreed) : base(name, age, gender, weight)
        {
            DogBreed = dogBreed;
        }

        // uppg 3.3.7. Implementera så att DoSound() metoden skriver ut hur djuret låter..
        public override void DoSound()
        {
            Console.WriteLine("Dog sounds: woof! woof!");
        }

        // uupg 3.4.2: Skriv enoverride för Stats() i subklasserna för Animal så den returnerar alla properties för det djuret.
        public override string Stats()
        {
            string textValue = base.Stats();
            textValue += $"\nDog breed: {DogBreed}";
            return textValue;
        }

        // 3.4.15. Skapa en ny metod med valfritt namn  i klassen Dog som endast returnerar en valfri
        //sträng.
        public string Playfulness()
        {
            if (Age < 6)
            {
                return $"\nThe dog {Name} at age {Age} is very playful, it needs a big space to be active/play";
            }
            else
            {

                return $"\nThe dog {Name} at age {Age}, the playfulness is decreasing and thus the dog no longer need a big space to play";
            }
        }
    }

    class Hegdehog : Animal
    {
        //uppg: 3.3.6: Ge dessa minst en unik egenskap var. Vilken egenskap det är är inte det viktiga här.
        public int NrOfSpikes { get; set; }

        public Hegdehog(string name, int age, string gender, double weight, int nrOfSpikes) : base(name, age, gender, weight)
        {
            NrOfSpikes = nrOfSpikes;
        }

        // uppg 3.3.7. Implementera så att DoSound() metoden skriver ut hurdjuret låter..
        public override void DoSound()
        {
            Console.WriteLine("Hegdedog sounds: gruff! gruff!");
        }

        // uupg 3.4.2: Skriv enoverride för Stats() i subklasserna för Animal så den returnerar alla properties för det djuret.
        public override string Stats()
        {
            string textValue = base.Stats();
            textValue += $"\nNumber of spikes: {NrOfSpikes}";
            return textValue;
        }
    }

    class Worm : Animal
    {
        //uppg: 3.3.6: Ge dessa minst en unik egenskap var. Vilken egenskap det är är inte det viktiga här.
        public bool IsPoisonus { get; set; }
        public Worm(string name, int age, string gender, double weight, bool isPoisonus) : base(name, age, gender, weight)
        {
            IsPoisonus = isPoisonus;
        }

        // uppg 3.3.7. Implementera så att DoSound() metoden skriver ut hurdjuret låter..
        public override void DoSound()
        {
            Console.WriteLine("Worm sounds: rattle! rattle!");
        }

        // uupg 3.4.2: Skriv enoverride för Stats() i subklasserna för Animal så den returnerar alla properties för det djuret.
        public override string Stats()
        {
            string textValue = base.Stats();
            textValue += $"\nIs Poisonus: {(IsPoisonus == true ? "Yes" : "No")}";
            return textValue;
        }
    }

    class Bird : Animal
    {
        //uppg: 3.3.6: Ge dessa minst en unik egenskap var. Vilken egenskap det är är inte det viktiga här.
        public double WingSpan { get; set; }

        public Bird(string name, int age, string gender, double weight, double wingSpan) : base(name, age, gender, weight)
        {
            WingSpan = wingSpan;
        }

        // uppg 3.3.7. Implementera så att DoSound() metoden skriver ut hurdjuret låter..
        public override void DoSound()
        {
            Console.WriteLine("Bird sounds: chirp! chirp!");
        }

        // uupg 3.4.2: Skriv enoverride för Stats() i subklasserna för Animal så den returnerar alla properties för det djuret.
        public override string Stats()
        {
            string textValue = base.Stats();
            textValue += $"\nWingspan: {WingSpan} cm";
            return textValue;
        }
    }

    class Wolf : Animal
    {
        //uppg: 3.3.6: Ge dessa minst en unik egenskap var. Vilken egenskap det är är inte det viktiga här.
        public bool PackLeader { get; set; }

        public Wolf(string name, int age, string gender, double weight, bool packLeader) : base(name, age, gender, weight)
        {
            PackLeader = packLeader;
        }

        // uppg 3.3.7. Implementera så att DoSound() metoden skriver ut hurdjuret låter..
        public override void DoSound()
        {
            Console.WriteLine("Wolf sounds: growl! growl!");
        }

        // uupg 3.4.2: Skriv enoverride för Stats() i subklasserna för Animal så den returnerar alla properties för det djuret.
        public override string Stats()
        {
            string textValue = base.Stats();
            textValue += $"\nPackleader: {(PackLeader == true ? "Yes" : "No")}";
            return textValue;
        }
    }


    //3.3.8. Skapa nu följande tre klasser: Pelican, Flamingo ochSwan. Dessa ska ärva från Bird.
    class Pelican : Bird
    {
        //3.3.9. Ge dessa minst en unik egenskap var.
        public double MouthLength { get; set; }
        public Pelican(string name, int age, string gender, double weight, double wingSpan, double mounthLength) : base(name, age, gender, weight, wingSpan)
        {
            MouthLength = mounthLength;
        }

        // uupg 3.4.2: Skriv enoverride för Stats() i subklasserna för Animal så den returnerar alla properties för det djuret.
        public override string Stats()
        {
            string textValue = base.Stats();
            textValue += $"\nMouth length: {MouthLength} cm";
            return textValue;
        }
    }

    class Flamingo : Bird
    {
        //3.3.9. Ge dessa minst en unik egenskap var.
        public double LegLength { get; set; }
        public Flamingo(string name, int age, string gender, double weight, double wingSpan, double legLength) : base(name, age, gender, weight, wingSpan)
        {
            LegLength = legLength;
        }

        // uupg 3.4.2: Skriv enoverride för Stats() i subklasserna för Animal så den returnerar alla properties för det djuret.
        public override string Stats()
        {
            string textValue = base.Stats();
            textValue += $"\nLeg length: {LegLength} cm";
            return textValue;
        }
    }

    class Swan : Bird
    {
        //3.3.9. Ge dessa minst en unik egenskap var.
        public double NeckLength { get; set; }
        public Swan(string name, int age, string gender, double weight, double wingSpan, double neckLength) : base(name, age, gender, weight, wingSpan)
        {
            NeckLength = neckLength;
        }

        // uupg 3.4.2: Skriv enoverride för Stats() i subklasserna för Animal så den returnerar alla properties för det djuret.
        public override string Stats()
        {
            string textValue = base.Stats();
            textValue += $"\nNeck length: {NeckLength} cm";
            return textValue;
        }
    }

    //uppg 3.2.10: Skapa gränssnittet (interface) IPerson med en metod deklaration Talk();
    interface IPerson
    {
        public void Talk();
    }

    //uppgift 3.2.11:  Skapa klassen Wolfman som ärver från Wolf och implementerar IPerson gränssnittet.
    class WolfMan : Wolf, IPerson
    {
        public WolfMan(string name, int age, string gender, double weight, bool packLeader) : base(name, age, gender, weight, packLeader)
        {
        }

        //uppg 3.2.12: Implementera Talk() som skriver ut vad Wolfman säger.
        public void Talk()
        {
            Console.WriteLine("I'm only a werewolf under full moon, rest assured because i will turn to human again!");
        }
    }

}