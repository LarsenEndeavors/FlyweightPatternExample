using System;
using System.Collections.Generic;
using FlyweightPatternExample.Objects;

namespace FlyweightPatternExample.Factories
{
    public static class CharacterClassFactory
    {
        private static readonly Dictionary<string, CharacterClass> FlyWeights = new();

        public static CharacterClass GetCharacter(string key)
        {
            if (FlyWeights.ContainsKey(key))
            {
                // With no async in the program we can trust this to be a non-null value
                return FlyWeights.GetValueOrDefault(key);
            }

            CharacterClass characterClass = key switch
            {
                "Fighter" => new FighterClass(),
                "Wizard" => new WizardClass(),
                _ => throw new NotSupportedException("Incompatible input detected!")
            };

            FlyWeights.Add(key, characterClass);
            return characterClass;
        }

    }
}