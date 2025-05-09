namespace AdventureMan.HelpingTools
{
    public class Konstraktor
    {
        private int id;
        private string name;
        private int level;
        private int health;
        private int strength;
        private int attack;

        public Konstraktor(int id, string name, int level, int health, int strength, int attack)
        {
            this.id = id;
            this.name = name;
            this.level = level;
            this.health = health;
            this.strength = strength;
            this.attack = attack;
        }

        public Konstraktor()
        {
           
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Level
        {
            get => level;
            set => level = value;
        }

        public int Health
        {
            get => health;
            set => health = value;
        }

        public int Strength
        {
            get => strength;
            set => strength = value;
        }

        public int Attack
        {
            get => attack;
            set => attack = value;
        }
    }
}