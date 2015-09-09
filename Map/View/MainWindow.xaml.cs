namespace Map.View
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows;

    using Common;
    using Model;

    public partial class MainWindow : Window
    {
        List<List<string>> resultArr = new List<List<string>>();

        public MainWindow()
        {
            this.InitializeComponent();
            MapData.CurrentMap.Initialize();
            this.ContentPanel.DataContext = MapData.CurrentMap;
        }

        private void Cal_Button_Click(object sender, RoutedEventArgs e)
        {
            AffixData.Initialize();
            this.resultArr = new List<List<string>>();
            this.FinalResultText.Text = string.Empty;

            Prefix.DetectAndRemoveHabit(this.Habit.SelectedValue as string);

            //Prefix.DetectAndRemove(this.Chain.SelectedValue as string, 2, Constant.chainString);

            Prefix.DetectAndRemove(this.Exile.SelectedValue as string, 2, Constant.exileString);

            Prefix.DetectAndRemove(this.Projectile.SelectedValue as string, 2, Constant.projectileString);

            Prefix.DetectAndRemove(this.EleReflect.SelectedValue as string, 3, Constant.eleReflectString);

            Prefix.DetectAndRemove(this.PhyReflect.SelectedValue as string, 3, Constant.phyReflectString);

            Prefix.DetectAndRemove(this.Rare.SelectedValue as string, 4, Constant.rareString);

            if (AffixData.CurrentPrefixes.Any(x => x.Id == 4))
            {
                AffixData.CurrentPrefixes.First(x => x.Id == 4).ModsList[0] = Constant.rareStringLong;
            }

            Prefix.DetectAndRemove(this.Beyond.SelectedValue as string, 4, Constant.beyondString);

            Prefix.DetectAndRemove(this.DoubleBoss.SelectedValue as string, 4, Constant.doubleBossString);

            Prefix.DetectAndRemove(this.Totem.SelectedValue as string, 4, Constant.totemString);

            Prefix.DetectAndRemove(this.FireResist.SelectedValue as string, 4, Constant.fireResistString);

            Prefix.DetectAndRemove(this.ColdResist.SelectedValue as string, 4, Constant.coldResistString);

            Prefix.DetectAndRemove(this.LightResist.SelectedValue as string, 4, Constant.lightResistString);

            Prefix.DetectAndRemove(this.Curse.SelectedValue as string, 3, Constant.curseString);

            Suffix.DetectAndRemove(this.Magic.SelectedValue as string, 1, Constant.magicString);

            Suffix.DetectAndRemove(this.Power.SelectedValue as string, 2, Constant.powerString);

            Suffix.DetectAndRemove(this.Frenzy.SelectedValue as string, 2, Constant.frenzyString);

            Suffix.DetectAndRemove(this.Endurance.SelectedValue as string, 2, Constant.enduranceString);

            Suffix.DetectAndRemove(this.Poison.SelectedValue as string, 5, Constant.poisonString);

            Suffix.DetectAndRemove(this.NoRegen.SelectedValue as string, 7, Constant.noRegenString);

            Suffix.DetectAndRemove(this.Fracture.SelectedValue as string, 8, Constant.fractureString);

            Suffix.DetectAndRemoveGround(this.Ground.SelectedValue as string);

            Suffix.DetectAndRemove((bool)this.Ele.IsChecked ? "有" : "无", 11, Constant.eleString);

            Suffix.DetectAndRemove((bool)this.Enf.IsChecked ? "有" : "无", 11, Constant.enfString);

            Suffix.DetectAndRemove((bool)this.Temp.IsChecked ? "有" : "无", 11, Constant.tempString);

            Suffix.DetectAndRemove((bool)this.Vul.IsChecked ? "有" : "无", 11, Constant.vulString);

            Suffix.DetectAndRemove((bool)this.BM.IsChecked ? "有" : "无", 12, Constant.bmString);

            Suffix.DetectAndRemove((bool)this.Max.IsChecked ? "有" : "无", 13, Constant.maxString);

            this.BackTrack(0, 0);
            if (this.resultArr.Count != 0)
            {
                for(var i = 0; i < this.resultArr.Count; i++)
                {
                    this.FinalResultText.Text += string.Join(Environment.NewLine, this.resultArr[i]);
                    if (i == this.resultArr.Count - 1)
                    {
                        continue;
                    }
                    this.FinalResultText.Text += Environment.NewLine;
                    this.FinalResultText.Text += Environment.NewLine;
                    this.FinalResultText.Text += "或";
                    this.FinalResultText.Text += Environment.NewLine;
                    this.FinalResultText.Text += Environment.NewLine;
                }
            }else
            {
                this.FinalResultText.Text = "No Result";
            }

            MapData.CurrentMap.SaveMapSetting();
        }

        private void BackTrack(int preIdx,  int sufIdx)
        {
            if (MapData.CurrentMap.IsOutOfBound() || AffixData.IsOutOfBound(MapData.CurrentMap.MaxPrefixNum, MapData.CurrentMap.MaxSuffixNum))
            {
                return;
            }
            if (MapData.CurrentMap.IsMatch())
            {
                var currentResult = AffixData.CurrentPrefixes.Select(prefix => prefix.GetName(MapData.CurrentMap.MapLevel)).ToList();
                currentResult.AddRange(AffixData.CurrentSuffixes.Select(suffix => suffix.GetName(MapData.CurrentMap.MapLevel)));
                this.resultArr.Add(currentResult);
            }
            if (AffixData.IsMatch(MapData.CurrentMap.MaxPrefixNum, MapData.CurrentMap.MaxSuffixNum))
            {
                return;
            }
            if (AffixData.CurrentSuffixes.Count < MapData.CurrentMap.MaxSuffixNum)
            {
                for (var i = sufIdx; i < AffixData.Suffixes.Count; i++)
                {
                    if (AffixData.CurrentSuffixes.Count(x => x.Id == AffixData.Suffixes[i].Id)
                        >= AffixData.Suffixes[i].Max
                        || MapData.CurrentMap.MapLevel < AffixData.Suffixes[i].LevelRequire
                        || AffixData.Suffixes[i].ModsList.Count == 0)
                    {
                        continue;
                    }
                    AffixData.CurrentSuffixes.Add(AffixData.Suffixes[i]);
                    this.BackTrack(preIdx, i);
                    AffixData.CurrentSuffixes.Remove(AffixData.Suffixes[i]);
                }
            }

            if (AffixData.CurrentPrefixes.Count >= MapData.CurrentMap.MaxPrefixNum)
            {
                return;
            }
            for (var i = preIdx; i < AffixData.Prefixes.Count; i++)
            {
                if (AffixData.CurrentPrefixes.Count(x => x.Id == AffixData.Prefixes[i].Id)
                    >= AffixData.Prefixes[i].Max
                    || MapData.CurrentMap.MapLevel < AffixData.Prefixes[i].LevelRequire
                    || AffixData.Prefixes[i].ModsList.Count == 0)
                {
                    continue;
                }
                AffixData.CurrentPrefixes.Add(AffixData.Prefixes[i]);
                this.BackTrack(i, AffixData.Suffixes.Count);
                AffixData.CurrentPrefixes.Remove(AffixData.Prefixes[i]);
            }
        }

        private void Reset_Button_Click(object sender, RoutedEventArgs e)
        {
            MapData.CurrentMap.Initialize();
            AffixData.Initialize();
            this.resultArr = new List<List<string>>();
            this.FinalResultText.Text = string.Empty;

            this.Habit.SelectedValue = "未知";
            this.Exile.SelectedValue = "未知";
            this.Projectile.SelectedValue = "未知";
            this.EleReflect.SelectedValue = "未知";
            this.PhyReflect.SelectedValue = "未知";
            this.Rare.SelectedValue = "未知";
            this.Beyond.SelectedValue = "未知";
            this.DoubleBoss.SelectedValue = "未知";
            this.Totem.SelectedValue = "未知";
            this.FireResist.SelectedValue = "未知";
            this.ColdResist.SelectedValue = "未知";
            this.LightResist.SelectedValue = "未知";
            this.Curse.SelectedValue = "未知";
            this.Magic.SelectedValue = "未知";
            this.Power.SelectedValue = "未知";
            this.Frenzy.SelectedValue = "未知";
            this.Endurance.SelectedValue = "未知";
            this.Poison.SelectedValue = "未知";
            this.NoRegen.SelectedValue = "未知";
            this.Fracture.SelectedValue = "未知";
            this.Ground.SelectedValue = "无";
            this.Ele.IsChecked = false;
            this.Enf.IsChecked = false;
            this.Temp.IsChecked = false;
            this.Vul.IsChecked = false;
            this.BM.IsChecked = false;
            this.Max.IsChecked = false;
        }
    }
}
