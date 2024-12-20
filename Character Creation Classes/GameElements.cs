﻿using System;

namespace CharacterCreationSystem
{
    // Structure to save character's information
    public struct CharacterInfo
    {
        public string Name { get; set; }
        public Element MoonCycles { get; set; }
        public Element Form { get; set; }
        public bool PirateCode { get; set; }

        public CharacterInfo(string name, Element moonCycles, Element form, bool pirateCode)
        {
            this.Name = name;
            this.MoonCycles = moonCycles;
            this.Form = form;
            this.PirateCode = pirateCode;
        }
    }  
    // Class containing all of the character's weapons
    public class CharacterWeapons
    {
        public Element MainWeapon { get; set; }
        public Element SecondarySkill { get; set; }
        public Element NatureSkill {  get; set; }   
        public Element AdditionalSkill { get; set; }

    }
    // Class containing all of the character's traits
    public class CharacterTraits
    {
        public Element PhysicalTrademark { get; set; }
        public Element SkinTone { get; set; }
        public Element HairStyle { get; set; }
        public Element FacialHair { get; set; }
        public Element BaseClothing { get; set; }
        public Element Accessory { get; set; }
        public Element PirateOrigin { get; set; }
        public Element ShipType { get; set; }
        public Element ShipSize { get; set; }
        public Element Pet { get; set; }
        public Element Crew { get; set; }
        public Element Trigger { get; set; }
        public Element Debuff { get; set; }
    }
    // Class containing all of the character's stats
    public class CharacterStats
    {
        public int Agility { get; set; }
        public int Charisma { get; set; }
        public int Intelligence { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
    }
    // Structure to define each game element
    public struct Element
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int HealthBoost { get; set; }
        public int AgilityBoost { get; set; }
        public int StrengthBoost { get; set; }
        public int IntelligenceBoost { get; set; }
        public int CharismaBoost { get; set; }

        public Element(string name, string description, int agilityBoost, int charismaBoost, int healthBoost, int intelligenceBoost, int strengthBoost)
        {
            this.Name = name;
            this.Description = description;
            this.HealthBoost = healthBoost;
            this.AgilityBoost = agilityBoost;
            this.StrengthBoost = strengthBoost;
            this.IntelligenceBoost = intelligenceBoost;
            this.CharismaBoost = charismaBoost;
        }
    }
}