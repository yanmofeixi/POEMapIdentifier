namespace Map.Model
{
    using System.Collections.Generic;
    using System.Linq;
    using Common;

    public class Prefix : Affix
    {
        public Prefix()
        {

        }
        public Prefix(Prefix other)
            : base(other)
        {

        }

        public static void Initialize()
        {
            AffixData.Prefixes = new List<Prefix>
                                     {
                                         new Prefix()
                                             {
                                                 Id = 0,
                                                 Quantity = 6,
                                                 Rarity = 3,
                                                 ModsList =
                                                     new List<string>()
                                                         {
                                                             Constant.skeletonString,
                                                             Constant.seawitchString
                                                         }
                                             },
                                         new Prefix()
                                             {
                                                 Id = 1,
                                                 Quantity = 10,
                                                 Rarity = 5,
                                                 ModsList =
                                                     new List<string>()
                                                         {
                                                             Constant.undeadString,
                                                             Constant.varityString,
                                                             Constant.bossLifeAOEString,
                                                             Constant
                                                                 .bossDamageSpeedString
                                                         }
                                             },
                                         new Prefix()
                                             {
                                                 Id = 2,
                                                 Quantity = 15,
                                                 Rarity = 8,
                                                 ModsList =
                                                     new List<string>()
                                                         {
                                                             Constant.animalString,
                                                             Constant.demonString,
                                                             Constant.humanString,
                                                             Constant.exileString,
                                                             Constant.chainString,
                                                             Constant.lifeString,
                                                             Constant.fireDamageString,
                                                             Constant.coldDamageString,
                                                             Constant.lightDamageString,
                                                             Constant.projectileString
                                                         }
                                             },
                                         new Prefix()
                                             {
                                                 Id = 3,
                                                 Quantity = 16,
                                                 Rarity = 8,
                                                 ModsList =
                                                     new List<string>()
                                                         {
                                                             Constant.phyReflectString,
                                                             Constant.eleReflectString,
                                                             Constant.goatString,
                                                             Constant.curseString
                                                         }
                                             },
                                         new Prefix()
                                             {
                                                 Id = 4,
                                                 Quantity = 12,
                                                 Rarity = 6,
                                                 ModsList =
                                                     new List<string>()
                                                         {
                                                             Constant.beyondString,
                                                             Constant.totemString,
                                                             Constant.rangeString,
                                                             Constant.rareString,
                                                             Constant.phyReductionString,
                                                             Constant.doubleBossString,
                                                             Constant.fireResistString,
                                                             Constant.coldResistString,
                                                             Constant.lightResistString
                                                         }
                                             },
                                         new Prefix()
                                             {
                                                 Id = 5,
                                                 Quantity = 18,
                                                 Rarity = 9,
                                                 ModsList =
                                                     new List<string>()
                                                         {
                                                             Constant.lifeStunString,
                                                             Constant.damageString
                                                         }
                                             },
                                         new Prefix()
                                             {
                                                 Id = 6,
                                                 Quantity = 20,
                                                 Rarity = 10,
                                                 ModsList =
                                                     new List<string>() { Constant.speedString }
                                             }
                                     };

            AffixData.Prefixes.Find(x => x.Id == 1).ModsValueList[0].Add(25);
            AffixData.Prefixes.Find(x => x.Id == 1).ModsValueList[0].Add(20);
            AffixData.Prefixes.Find(x => x.Id == 1).ModsValueList[1].Add(30);
            AffixData.Prefixes.Find(x => x.Id == 1).ModsValueList[1].Add(25);
            AffixData.Prefixes.Find(x => x.Id == 1).ModsValueList[2].Add(35);
            AffixData.Prefixes.Find(x => x.Id == 1).ModsValueList[2].Add(30);
            AffixData.Prefixes.Find(x => x.Id == 2).ModsValueList[0].Add(20);
            AffixData.Prefixes.Find(x => x.Id == 2).ModsValueList[0].Add(29);
            AffixData.Prefixes.Find(x => x.Id == 2).ModsValueList[0].Add(50);
            AffixData.Prefixes.Find(x => x.Id == 2).ModsValueList[0].Add(69);
            AffixData.Prefixes.Find(x => x.Id == 2).ModsValueList[0].Add(2);
            AffixData.Prefixes.Find(x => x.Id == 2).ModsValueList[1].Add(30);
            AffixData.Prefixes.Find(x => x.Id == 2).ModsValueList[1].Add(39);
            AffixData.Prefixes.Find(x => x.Id == 2).ModsValueList[1].Add(70);
            AffixData.Prefixes.Find(x => x.Id == 2).ModsValueList[1].Add(89);
            AffixData.Prefixes.Find(x => x.Id == 2).ModsValueList[1].Add(3);
            AffixData.Prefixes.Find(x => x.Id == 2).ModsValueList[2].Add(40);
            AffixData.Prefixes.Find(x => x.Id == 2).ModsValueList[2].Add(49);
            AffixData.Prefixes.Find(x => x.Id == 2).ModsValueList[2].Add(90);
            AffixData.Prefixes.Find(x => x.Id == 2).ModsValueList[2].Add(110);
            AffixData.Prefixes.Find(x => x.Id == 2).ModsValueList[2].Add(4);
            AffixData.Prefixes.Find(x => x.Id == 3).ModsValueList[0].Add(13);
            AffixData.Prefixes.Find(x => x.Id == 3).ModsValueList[1].Add(15);
            AffixData.Prefixes.Find(x => x.Id == 3).ModsValueList[2].Add(18);
            AffixData.Prefixes.Find(x => x.Id == 4).ModsValueList[0].Add(20);
            AffixData.Prefixes.Find(x => x.Id == 4).ModsValueList[0].Add(40);
            AffixData.Prefixes.Find(x => x.Id == 4).ModsValueList[1].Add(30);
            AffixData.Prefixes.Find(x => x.Id == 4).ModsValueList[1].Add(60);
            AffixData.Prefixes.Find(x => x.Id == 4).ModsValueList[2].Add(40);
            AffixData.Prefixes.Find(x => x.Id == 4).ModsValueList[2].Add(80);
            AffixData.Prefixes.Find(x => x.Id == 5).ModsValueList[0].Add(15);
            AffixData.Prefixes.Find(x => x.Id == 5).ModsValueList[0].Add(19);
            AffixData.Prefixes.Find(x => x.Id == 5).ModsValueList[1].Add(20);
            AffixData.Prefixes.Find(x => x.Id == 5).ModsValueList[1].Add(24);
            AffixData.Prefixes.Find(x => x.Id == 5).ModsValueList[2].Add(25);
            AffixData.Prefixes.Find(x => x.Id == 5).ModsValueList[2].Add(30);
            AffixData.Prefixes.Find(x => x.Id == 6).ModsValueList[0].Add(15);
            AffixData.Prefixes.Find(x => x.Id == 6).ModsValueList[0].Add(20);
            AffixData.Prefixes.Find(x => x.Id == 6).ModsValueList[0].Add(20);
            AffixData.Prefixes.Find(x => x.Id == 6).ModsValueList[0].Add(25);
            AffixData.Prefixes.Find(x => x.Id == 6).ModsValueList[1].Add(20);
            AffixData.Prefixes.Find(x => x.Id == 6).ModsValueList[1].Add(25);
            AffixData.Prefixes.Find(x => x.Id == 6).ModsValueList[1].Add(25);
            AffixData.Prefixes.Find(x => x.Id == 6).ModsValueList[1].Add(35);
            AffixData.Prefixes.Find(x => x.Id == 6).ModsValueList[2].Add(25);
            AffixData.Prefixes.Find(x => x.Id == 6).ModsValueList[2].Add(30);
            AffixData.Prefixes.Find(x => x.Id == 6).ModsValueList[2].Add(35);
            AffixData.Prefixes.Find(x => x.Id == 6).ModsValueList[2].Add(45);
        }

        public static void DetectAndRemoveHabit(string text)
        {
            switch (text)
            {
                case "未知":
                    return;
                case "骷髅":
                    AffixData.CurrentPrefixes.Add(new Prefix(AffixData.Prefixes.First(x => x.Id == 0)));
                    AffixData.CurrentPrefixes.Last().ModsList.Clear();
                    AffixData.CurrentPrefixes.Last().ModsList.Add(Constant.skeletonString);
                    break;
                case "海妖":
                    AffixData.CurrentPrefixes.Add(new Prefix(AffixData.Prefixes.First(x => x.Id == 0)));
                    AffixData.CurrentPrefixes.Last().ModsList.Clear();
                    AffixData.CurrentPrefixes.Last().ModsList.Add(Constant.seawitchString);
                    break;
                case "亡灵":
                    AffixData.CurrentPrefixes.Add(new Prefix(AffixData.Prefixes.First(x => x.Id == 1)));
                    AffixData.CurrentPrefixes.Last().ModsList.Clear();
                    AffixData.CurrentPrefixes.Last().ModsList.Add(Constant.undeadString);
                    break;
                case "人类":
                    AffixData.CurrentPrefixes.Add(new Prefix(AffixData.Prefixes.First(x => x.Id == 2)));
                    AffixData.CurrentPrefixes.Last().ModsList.Clear();
                    AffixData.CurrentPrefixes.Last().ModsList.Add(Constant.humanString);
                    break;
                case "恶魔":
                    AffixData.CurrentPrefixes.Add(new Prefix(AffixData.Prefixes.First(x => x.Id == 2)));
                    AffixData.CurrentPrefixes.Last().ModsList.Clear();
                    AffixData.CurrentPrefixes.Last().ModsList.Add(Constant.demonString);
                    break;
                case "动物":
                    AffixData.CurrentPrefixes.Add(new Prefix(AffixData.Prefixes.First(x => x.Id == 2)));
                    AffixData.CurrentPrefixes.Last().ModsList.Clear();
                    AffixData.CurrentPrefixes.Last().ModsList.Add(Constant.animalString);
                    break;
                case "羊人":
                    AffixData.CurrentPrefixes.Add(new Prefix(AffixData.Prefixes.First(x => x.Id == 3)));
                    AffixData.CurrentPrefixes.Last().ModsList.Clear();
                    AffixData.CurrentPrefixes.Last().ModsList.Add(Constant.goatString);
                    break;
                case "远程怪":
                    AffixData.CurrentPrefixes.Add(new Prefix(AffixData.Prefixes.First(x => x.Id == 4)));
                    AffixData.CurrentPrefixes.Last().ModsList.Clear();
                    AffixData.CurrentPrefixes.Last().ModsList.Add(Constant.rangeString);
                    break;
            }
            AffixData.Prefixes.First(x => x.Id == 0).ModsList.Remove(Constant.skeletonString);
            AffixData.Prefixes.First(x => x.Id == 0).ModsList.Remove(Constant.seawitchString);
            AffixData.Prefixes.First(x => x.Id == 1).ModsList.Remove(Constant.undeadString);
            AffixData.Prefixes.First(x => x.Id == 2).ModsList.Remove(Constant.animalString);
            AffixData.Prefixes.First(x => x.Id == 2).ModsList.Remove(Constant.demonString);
            AffixData.Prefixes.First(x => x.Id == 2).ModsList.Remove(Constant.humanString);
            AffixData.Prefixes.First(x => x.Id == 3).ModsList.Remove(Constant.goatString);
            AffixData.Prefixes.First(x => x.Id == 4).ModsList.Remove(Constant.rangeString);
        }

        public static void DetectAndRemove(string text, int Id, string constantString)
        {
            if (text == "未知")
            {
                return;
            }
            var prefix = AffixData.Prefixes.First(x => x.Id == Id);
            if (text == "有")
            {
                AffixData.CurrentPrefixes.Add(new Prefix(prefix));
                AffixData.CurrentPrefixes.Last().ModsList.Clear();
                AffixData.CurrentPrefixes.Last().ModsList.Add(constantString);
            }
            prefix.ModsList.Remove(constantString);
        }
    }
}
