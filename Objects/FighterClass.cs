using System;

namespace FlyweightPatternExample.Objects
{
    public class FighterClass : CharacterClass
    {
        public static int FighterClassCount { get; private set; }
        public override string Name => "Fighter";


        public FighterClass()
        {
            FighterClassCount++;
            
        }

        public override void PrintCharacterSkills()
        {
            Console.WriteLine("Fighting Style: Archery - Level 1");
            Console.WriteLine("Second Wind - Level 2");
            Console.WriteLine("Extra Attack - Level 3");
        }
    }
}