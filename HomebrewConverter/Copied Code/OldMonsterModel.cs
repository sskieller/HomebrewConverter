using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomebrewConverter.Copied_Code
{
    class OldMonsterModel
    {
    }

    public Monster()
    {
        SubtitleType = "Aberration";
        SubtitleSize = "Tiny";
        SubtitleAlignment = "Any";

    }

    public Monster(string title, string subtitleSize, string subtitleType, string subtitleAlignment,
        int armorClass, string armorType, int hitPoints, int speed, int climb, int fly, int str, int strMod,
        int dex, int dexMod, int con, int conMod, int _int, int intMod, int wis, int wisMod, int cha, int chaMod)
    {
        Title = title;
        SubtitleSize = subtitleSize;
        SubtitleType = subtitleType;
        SubtitleAlignment = subtitleAlignment;

        ArmorClass = armorClass;
        ArmorType = armorType;
        HitPoints = hitPoints;
        Speed = speed;
        Climb = climb;
        Fly = fly;

        Str = str;
        StrMod = strMod;
        Dex = dex;
        DexMod = dexMod;
        Con = con;
        ConMod = conMod;
        Int = _int;
        IntMod = intMod;
        Wis = wis;
        WisMod = wisMod;
        Cha = cha;
        ChaMod = chaMod;

    }

    public string Title { get; set; }
    public string SubtitleSize { get; set; }
    public string SubtitleType { get; set; }
    public string SubtitleAlignment { get; set; }



    public int ArmorClass { get; set; }
    public string ArmorType { get; set; }

    public int HitPoints { get; set; }
    public int Speed { get; set; }
    public int Climb { get; set; }
    public int Fly { get; set; }

    public int Str { get; set; }
    public int StrMod { get; set; }
    public int Dex { get; set; }
    public int DexMod { get; set; }
    public int Con { get; set; }
    public int ConMod { get; set; }
    public int Int { get; set; }
    public int IntMod { get; set; }
    public int Wis { get; set; }
    public int WisMod { get; set; }
    public int Cha { get; set; }
    public int ChaMod { get; set; }



    public void ChangeStat(string statName, int statValue)
    {
        Debug.WriteLine($"Name: {statName} Value: {statValue}");

        if (statName == nameof(Str))
            StrMod = CalculateModifierScore(statValue);
        if (statName == nameof(Dex))
            DexMod = CalculateModifierScore(statValue);
        if (statName == nameof(Con))
            ConMod = CalculateModifierScore(statValue);
        if (statName == nameof(Int))
            IntMod = CalculateModifierScore(statValue);
        if (statName == nameof(Wis))
            WisMod = CalculateModifierScore(statValue);
        if (statName == nameof(Cha))
            ChaMod = CalculateModifierScore(statValue);

    }


    private int CalculateModifierScore(int statValue)
    {
        if (statValue == 1)
            return -5;
        if (statValue == 2 || statValue == 3)
            return -4;
        if (statValue == 4 || statValue == 5)
            return -3;
        if (statValue == 6 || statValue == 7)
            return -2;
        if (statValue == 8 || statValue == 9)
            return -1;
        if (statValue == 10 || statValue == 11)
            return +0;
        if (statValue == 12 || statValue == 13)
            return +1;
        if (statValue == 14 || statValue == 15)
            return +2;
        if (statValue == 16 || statValue == 17)
            return +3;
        if (statValue == 18 || statValue == 19)
            return +4;
        if (statValue == 20 || statValue == 21)
            return +5;
        if (statValue == 22 || statValue == 23)
            return +6;
        if (statValue == 24 || statValue == 25)
            return +7;
        if (statValue == 26 || statValue == 27)
            return +8;
        if (statValue == 28 || statValue == 29)
            return +9;
        if (statValue == 30)
            return +10;

        return -1;
    }
}
