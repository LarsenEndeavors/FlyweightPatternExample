namespace FlyweightPatternExample.Objects
{
    public abstract class Character
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }

        public abstract void PrintCharacterSkills();
    }
}