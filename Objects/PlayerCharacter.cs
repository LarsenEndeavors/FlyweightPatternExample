using FlyweightPatternExample.Factories;

namespace FlyweightPatternExample.Objects
{
    public class PlayerCharacter
    {
        public string Name { get; set; }
        public CharacterClass CharacterClass { get; set; }

        public PlayerCharacter(string name, string className)
        {
            Name = name;
            CharacterClass = CharacterClassFactory.GetCharacter(className);
        }
    }
}