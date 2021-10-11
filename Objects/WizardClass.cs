using System;

namespace FlyweightPatternExample.Objects
{
    public class WizardClass : CharacterClass
    {
        public static int WizardCharacterCount { get; private set; }
        public override string Name => "Wizard";

        public WizardClass()
        {
            WizardCharacterCount++;
        }

        public override void PrintCharacterSkills()
        {
            Console.WriteLine("Spellcasting: Tier 1 Spells - Level 1");
            Console.WriteLine("Arcane Senses - Level 2");
            Console.WriteLine("Spellcasting: Tier 2 Spells - Level 3");
        }
    }
}