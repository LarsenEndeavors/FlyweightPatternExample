using System;

namespace FlyweightPatternExample.Objects
{
    public class FighterCharacter : Character
    {
        public static int _fighterCharacterCount;
        

        public FighterCharacter()
        {
            _fighterCharacterCount++;
            Class = "Fighter";
        }

        public override void PrintCharacterSkills()
        {
            Console.WriteLine("Fighting Style: Archery - Level 1");
            Console.WriteLine("Second Wind - Level 2");
            Console.WriteLine("Extra Attack - Level 3");
        }
    }
}