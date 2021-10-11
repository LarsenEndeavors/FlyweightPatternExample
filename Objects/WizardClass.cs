using System;

namespace FlyweightPatternExample.Objects
{
    public class WizardCharacter : Character
    {
        public static int _wizardCharacterCount;

        public WizardCharacter()
        {
            _wizardCharacterCount++;
            Class = "Wizard";
        }

        public override void PrintCharacterSkills()
        {
            Console.WriteLine("Spellcasting: Tier 1 Spells - Level 1");
            Console.WriteLine("Arcane Senses - Level 2");
            Console.WriteLine("Spellcasting: Tier 2 Spells - Level 3");
        }
    }
}