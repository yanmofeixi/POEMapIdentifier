namespace Map.Model
{
    using System;
    using System.IO;
    using System.Xml;
    using Common;

    public class Map : ViewModelBase
    {
        private bool mapIdentified;
        private bool mapFragments;
        private bool mapCorrupted;
        private bool mapYellow;
        private int mapLevel;
        private int mapQuantity;
        private int mapQuality;
        private int mapZanaLevel;
        private int mapRarity;
        private int mapPackSize;

        public bool MapIdentified
        {
            get
            {
                return this.mapIdentified;
            }
            set
            {
                this.mapIdentified = value;
                this.OnPropertyChanged();
            }
        }
        public bool MapCorrupted
        {
            get
            {
                return this.mapCorrupted;
            }
            set
            {
                this.mapCorrupted = value;
                this.OnPropertyChanged();
            }
        }
        public bool MapFragments
        {
            get
            {
                return this.mapFragments;
            }
            set
            {
                this.mapFragments = value;
                this.OnPropertyChanged();
            }
        }
        public bool MapYellow
        {
            get
            {
                return this.mapYellow;
            }
            set
            {
                this.mapYellow = value;
                this.OnPropertyChanged();
            }
        }
        public int MaxPrefixNum
        {
            get
            {
                if (!this.mapYellow)
                {
                    return 1;
                }
                return !this.mapCorrupted ? 3 : 4;
            }
        }
        public int MaxSuffixNum
        {
            get
            {
                if (!this.mapYellow)
                {
                    return 1;
                }
                return !this.mapCorrupted ? 3 : 4;
            }
        }
        public int MinPrefixNum
        {
            get
            {
                return !this.mapYellow ? 0 : 1;
            }
        }
        public int MinSuffixNum
        {
            get
            {
                return !this.mapYellow ? 0 : 1;
            }
        }
        public int MinTotalAffixNum
        {
            get
            {
                return !this.mapYellow ? 1 : 3;
            }
        }
        public int MapLevel
        {
            get
            {
                return this.mapLevel;
            }
            set
            {
                this.mapLevel = value;
                this.OnPropertyChanged();
            }
        }
        public int MapQuantity
        {
            get
            {
                return this.mapQuantity;
            }
            set
            {
                this.mapQuantity = value;
                this.OnPropertyChanged();
            }
        }
        public int MapQuality
        {
            get
            {
                return this.mapQuality;
            }
            set
            {
                this.mapQuality = value;
                this.OnPropertyChanged();
            }
        }
        public int MapZanaLevel
        {
            get
            {
                return this.mapZanaLevel;
            }
            set
            {
                this.mapZanaLevel = value;
                this.OnPropertyChanged();
            }
        }
        public int MapRarity
        {
            get
            {
                return this.mapRarity;
            }
            set
            {
                this.mapRarity = value;
                this.OnPropertyChanged();
            }
        }
        public int MapPackSize
        {
            get
            {
                return this.mapPackSize;
            }
            set
            {
                this.mapPackSize = value;
                this.OnPropertyChanged();
            }
        }

        public void Reset()
        {
            this.MapIdentified = false;
            this.MapFragments = false;
            this.MapCorrupted = false;
            this.MapYellow = true;
            this.MapLevel = 68;
            this.MapQuantity = 0;
            this.MapQuality = 0;
            this.MapZanaLevel = 7;
            this.MapRarity = 0;
            this.MapPackSize = 0;
        }

        public void Initialize()
        {
            this.Reset();
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + Constant.settingFileName))
            {
                return;
            }
            var stream = Stream.Null;
            try
            {
                stream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + Constant.settingFileName, FileMode.Open, FileAccess.Read);
                using (
                    var reader = XmlReader.Create(
                        stream,
                        new XmlReaderSettings() { ConformanceLevel = ConformanceLevel.Fragment }))
                {
                    while (reader.Read())
                    {
                        if (!reader.NodeType.Equals(XmlNodeType.Element))
                        {
                            continue;
                        }

                        switch (reader.Name)
                        {
                            case "Map":
                                this.MapZanaLevel = int.Parse(Utility.ReadXMLAttribute(reader, "mapZanaLevel"));
                                this.MapLevel = int.Parse(Utility.ReadXMLAttribute(reader, "mapLevel"));
                                break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                // ignored
            }
            finally
            {
                if (stream != null)
                {
                    stream.Dispose();
                }
            }
        }

        public void SaveMapSetting()
        {
            var stream = Stream.Null;
            try
            {
                stream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + Constant.settingFileName, FileMode.Create, FileAccess.Write);
                var xws = new XmlWriterSettings() { Async = true, Indent = true, CloseOutput = true };
                using (var writer = XmlWriter.Create(stream, xws))
                {
                    stream = null;
                    writer.WriteStartElement("Map");
                    Utility.WriteXMLAttribute(writer, "mapZanaLevel", this.mapZanaLevel.ToString());
                    Utility.WriteXMLAttribute(writer, "mapLevel", this.mapLevel.ToString());
                    writer.WriteFullEndElement();
                }
            }
            catch (Exception)
            {
                // ignored
            }
            finally
            {
                if (stream != null)
                {
                    stream.Dispose();
                }
            }
        }

        public bool IsMatch()
        {
            var totalQuantity = 0;
            var totalRarity = 0;
            var totalPackSize = 0;
            this.CalculateMapStats(ref totalQuantity, ref totalRarity, ref totalPackSize);
            if (totalQuantity != this.mapQuantity || totalRarity != this.mapRarity || this.mapPackSize != totalPackSize)
            {
                return false;
            }
            return AffixData.CurrentPrefixes.Count >= this.MinPrefixNum 
                && AffixData.CurrentSuffixes.Count >= this.MinSuffixNum 
                && AffixData.CurrentPrefixes.Count + AffixData.CurrentSuffixes.Count >= this.MinTotalAffixNum;
        }

        public bool IsOutOfBound()
        {
            var totalQuantity = 0;
            var totalRarity = 0;
            var totalPackSize = 0;
            this.CalculateMapStats(ref totalQuantity, ref totalRarity, ref totalPackSize);

            return totalQuantity > this.mapQuantity || totalRarity > this.mapRarity || totalPackSize > this.mapPackSize;
        }

        private void CalculateMapStats(ref int totalQuantity, ref int totalRarity, ref int totalPackSize)
        {
            foreach (var prefix in AffixData.CurrentPrefixes)
            {
                totalQuantity += prefix.Quantity;
                totalRarity += prefix.Rarity;
                totalPackSize += prefix.PackSize;
            }
            foreach (var suffix in AffixData.CurrentSuffixes)
            {
                totalQuantity += suffix.Quantity;
                totalRarity += suffix.Rarity;
                totalPackSize += suffix.PackSize;
            }

            totalQuantity += this.mapZanaLevel;
            totalQuantity += this.MapQuality;

            if (!this.mapIdentified)
            {
                totalQuantity += 30;
            }

            if (this.mapFragments)
            {
                totalQuantity += 5;
            }
        }
    }
}
