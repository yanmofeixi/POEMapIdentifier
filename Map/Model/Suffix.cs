namespace Map.Model
{
    using System.Collections.Generic;
    using System.Linq;
    using Common;

    public class Suffix : Affix
    {
        public Suffix()
        {

        }
        public Suffix(Suffix other)
            : base(other)
        {

        }

        public static void Initialize()
        {
            AffixData.Suffixes = new List<Suffix>
                                     {
                                         new Suffix
                                             {
                                                 Id = 0,
                                                 Quantity = 10,
                                                 Rarity = 5,
                                                 PackSize = 10,
                                                 ModsList = new List<string> { Constant.eeString }
                                             },
                                         new Suffix
                                             {
                                                 Id = 1,
                                                 Quantity = 12,
                                                 Rarity = 6,
                                                 ModsList = new List<string> { Constant.magicString }
                                             },
                                         new Suffix
                                             {
                                                 Id = 2,
                                                 Quantity = 14,
                                                 Rarity = 7,
                                                 ModsList =
                                                     new List<string>
                                                         {
                                                             Constant.powerString,
                                                             Constant.frenzyString,
                                                             Constant.enduranceString
                                                         }
                                             },
                                         new Suffix
                                             {
                                                 Id = 3,
                                                 Quantity = 15,
                                                 Rarity = 8,
                                                 ModsList = new List<string> { Constant.aoeString }
                                             },
                                         new Suffix
                                             {
                                                 Id = 4,
                                                 Quantity = 18,
                                                 Rarity = 9,
                                                 ModsList =
                                                     new List<string>
                                                         {
                                                             Constant.eleStatusString,
                                                             Constant.critString
                                                         }
                                             },
                                         new Suffix
                                             {
                                                 Id = 5,
                                                 Quantity = 16,
                                                 Rarity = 8,
                                                 ModsList = new List<string> { Constant.poisonString }
                                             },
                                         new Suffix
                                             {
                                                 Id = 6,
                                                 Quantity = 20,
                                                 Rarity = 15,
                                                 PackSize = 15,
                                                 ModsList =
                                                     new List<string> { Constant.slowRegenString }
                                             },
                                         new Suffix
                                             {
                                                 Id = 7,
                                                 Quantity = 20,
                                                 Rarity = 10,
                                                 PackSize = 12,
                                                 LevelRequire = 74,
                                                 ModsList =
                                                     new List<string> { Constant.noRegenString }
                                             },
                                         new Suffix
                                             {
                                                 Id = 8,
                                                 Quantity = 25,
                                                 Rarity = 12,
                                                 LevelRequire = 74,
                                                 ModsList =
                                                     new List<string> { Constant.fractureString }
                                             },
                                         new Suffix
                                             {
                                                 Id = 9,
                                                 Quantity = 25,
                                                 Rarity = 12,
                                                 LevelRequire = 79,
                                                 ModsList =
                                                     new List<string> { Constant.noLeechString }
                                             },
                                         new Suffix
                                             {
                                                 Id = 10,
                                                 Quantity = 12,
                                                 Rarity = 6,
                                                 LevelRequire = 68,
                                                 ModsList = new List<string> { Constant.groundString }
                                             },
                                         new Suffix
                                             {
                                                 Id = 11,
                                                 Quantity = 18,
                                                 Rarity = 9,
                                                 PackSize = 14,
                                                 LevelRequire = 74,
                                                 ModsList =
                                                     new List<string>
                                                         {
                                                             Constant.eleString,
                                                             Constant.enfString,
                                                             Constant.tempString,
                                                             Constant.vulString
                                                         }
                                             },
                                         new Suffix
                                             {
                                                 Id = 12,
                                                 Quantity = 15,
                                                 Rarity = 8,
                                                 PackSize = 10,
                                                 LevelRequire = 74,
                                                 ModsList = new List<string> { Constant.bmString }
                                             },
                                         new Suffix
                                             {
                                                 Id = 13,
                                                 Quantity = 18,
                                                 Rarity = 9,
                                                 PackSize = 16,
                                                 LevelRequire = 74,
                                                 ModsList = new List<string> { Constant.maxString }
                                             }
                                     };

            AffixData.Suffixes.Find(x => x.Id == 2).ModsValueList[0].Add(1);
            AffixData.Suffixes.Find(x => x.Id == 2).ModsValueList[1].Add(2);
            AffixData.Suffixes.Find(x => x.Id == 2).ModsValueList[2].Add(3);
            AffixData.Suffixes.Find(x => x.Id == 3).ModsValueList[0].Add(20);
            AffixData.Suffixes.Find(x => x.Id == 3).ModsValueList[1].Add(30);
            AffixData.Suffixes.Find(x => x.Id == 3).ModsValueList[2].Add(40);
            AffixData.Suffixes.Find(x => x.Id == 4).ModsValueList[0].Add(40);
            AffixData.Suffixes.Find(x => x.Id == 4).ModsValueList[0].Add(160);
            AffixData.Suffixes.Find(x => x.Id == 4).ModsValueList[0].Add(200);
            AffixData.Suffixes.Find(x => x.Id == 4).ModsValueList[0].Add(25);
            AffixData.Suffixes.Find(x => x.Id == 4).ModsValueList[1].Add(60);
            AffixData.Suffixes.Find(x => x.Id == 4).ModsValueList[1].Add(260);
            AffixData.Suffixes.Find(x => x.Id == 4).ModsValueList[1].Add(300);
            AffixData.Suffixes.Find(x => x.Id == 4).ModsValueList[1].Add(30);
            AffixData.Suffixes.Find(x => x.Id == 4).ModsValueList[2].Add(100);
            AffixData.Suffixes.Find(x => x.Id == 4).ModsValueList[2].Add(360);
            AffixData.Suffixes.Find(x => x.Id == 4).ModsValueList[2].Add(400);
            AffixData.Suffixes.Find(x => x.Id == 4).ModsValueList[2].Add(35);
            AffixData.Suffixes.Find(x => x.Id == 6).ModsValueList[0].Add(20);
            AffixData.Suffixes.Find(x => x.Id == 6).ModsValueList[1].Add(40);
            AffixData.Suffixes.Find(x => x.Id == 6).ModsValueList[2].Add(60);
            AffixData.Suffixes.Find(x => x.Id == 12).ModsValueList[0].Add(8);
            AffixData.Suffixes.Find(x => x.Id == 12).ModsValueList[0].Add(12);
            AffixData.Suffixes.Find(x => x.Id == 12).ModsValueList[1].Add(8);
            AffixData.Suffixes.Find(x => x.Id == 12).ModsValueList[1].Add(12);
            AffixData.Suffixes.Find(x => x.Id == 12).ModsValueList[2].Add(12);
            AffixData.Suffixes.Find(x => x.Id == 12).ModsValueList[2].Add(16);
        }

        public static void DetectAndRemoveGround(string text)
        {
            var groundSuffix = AffixData.Suffixes.First(x => x.Id == 10);
            if (text != "无")
            {
                groundSuffix.ModsList[0] = text;
                AffixData.CurrentSuffixes.Add(groundSuffix);
            }
            else
            {
                AffixData.Suffixes.Remove(groundSuffix);
            }
        }

        public static void DetectAndRemove(string text, int Id, string constantString)
        {
            if (text == "未知")
            {
                return;
            }
            var suffix = AffixData.Suffixes.First(x => x.Id == Id);
            if (text == "有")
            {
                AffixData.CurrentSuffixes.Add(new Suffix(suffix));
                AffixData.CurrentSuffixes.Last().ModsList.Clear();
                AffixData.CurrentSuffixes.Last().ModsList.Add(constantString);
            }
            suffix.ModsList.Remove(constantString);
        }
    }
}
