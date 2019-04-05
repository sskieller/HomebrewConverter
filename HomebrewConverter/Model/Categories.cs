using System.Collections.Generic;

namespace HomebrewConverter.Model
{
    public static class Categories
    {
        public static List<string> MonsterSizeList { get; } = new List<string>
        {
            "Tiny",
            "Small",
            "Medium",
            "Large",
            "Huge",
            "Gargantuan",
        };

        public static List<string> MonsterTypeList { get; } = new List<string>
        {
            "Aberration",
            "Beast",
            "Celestial",
            "Construct",
            "Dragon",
            "Elemental",
            "Fey",
            "Fiend",
            "Giant",
            "Humanoid",
            "Monstrosity",
            "Ooze",
            "Plant",
            "Undead",
        };

        public static List<string> MonsterAlignmentList { get; } = new List<string>
        {
            "Any",
            "Lawful Good",
            "Lawful Neutral",
            "Lawful Evil",
            "Neutral Good",
            "True Neutral",
            "Neutral Evil",
            "Chaotic Good",
            "Chaotic Neutral",
            "Chaotic Evil",
        };

        public static List<string> MonsterSkillsList { get; } = new List<string>
        {
            "None",
            "Acrobatics",
            "Animal Handling",
            "Arcana",
            "Athletics",
            "Deception",
            "History",
            "Insight",
            "Intimidation",
            "Investigation",
            "Medicine",
            "Nature",
            "Perception",
            "Performance",
            "Persuasion",
            "Religion",
            "Sleight of Hand",
            "Stealth",
            "Survival",
        };
    }
}