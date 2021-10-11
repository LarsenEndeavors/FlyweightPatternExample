using System;
using FlyweightPatternExample.Factories;
using FlyweightPatternExample.Objects;

namespace FlyweightPatternExample
{
    internal static class FlyweightPatternExample
    {
        /*
         * The majority of this code is mocked or directly taken from tutorials on the internet in
         * an effort to teach myself and get familiar with these patterns.  None of this is meant to be
         * original content, and if you see this and wonder why it's in my repo, mostly it's for me, but
         * I'm happy that you're here and here's proof that I have at least heard of this particular
         * pattern!
         *
         * Author: Nicholas Larsen
         * Date: 2021/10/11
         */
        
        private static void Main()
        {
            // Here we have the gist of the flyweight pattern, although a client can sometimes add another layer of encapsulation
            // The main point is that we are creating several of these objects, and while they can have their own properties, they
            // are built from the same instance, saving time and resources
            
            // We can see even though 6 characters are built, only one of each class instance is instantiated 

            var wiz1 = new PlayerCharacter("Bruenor", "Wizard");
            var wiz2 = new PlayerCharacter("Lim", "Wizard");
            var wiz3 = new PlayerCharacter("Jimson", "Wizard");
            
            var fighter1 = new PlayerCharacter("Twonor", "Fighter");
            var fighter2 = new PlayerCharacter("Skathix", "Fighter");
            var fighter3 = new PlayerCharacter("Cajun", "Fighter");

            wiz1.CharacterClass.PrintCharacterSkills();
            Console.WriteLine(wiz2.Name);
            Console.WriteLine(fighter1.CharacterClass.Name);
            fighter3.CharacterClass.PrintCharacterSkills();

            // Three new objects each, one instance each
            Console.WriteLine("Fighter Instances: " + FighterClass.FighterClassCount);
            Console.WriteLine("Wizard Instances: " + WizardClass.WizardCharacterCount);
            
        }
    }
}