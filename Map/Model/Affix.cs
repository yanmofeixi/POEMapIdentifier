namespace Map.Model
{
    using System.Collections.Generic;
    using System.Linq;

    public class Affix
    {
        protected Affix()
        {
            this.Id = 0;
            this.Quantity = 0;
            this.Rarity = 0;
            this.PackSize = 0;
            this.LevelRequire = 68;
            this.ModsList = new List<string>();
            this.ModsValueList = new List<List<object>>();
            for (var i = 0; i < 3; i++)
            {
                this.ModsValueList.Add(new List<object>());
            }
        }
        protected Affix(Affix other)
        {
            this.Id = other.Id;
            this.Quantity = other.Quantity;
            this.Rarity = other.Rarity;
            this.PackSize = other.PackSize;
            this.LevelRequire = other.LevelRequire;
            this.ModsList = new List<string>(other.ModsList);
            this.ModsValueList = new List<List<object>>(other.ModsValueList);
        }
        public int Id;
        public int Quantity;
        public int Rarity;
        public int PackSize;
        public int LevelRequire;
        public List<string> ModsList;
        public List<List<object>> ModsValueList;
        public string GetName(int mapLevel)
        {
            var valueList = this.ModsValueList[0].ToArray();
            if (mapLevel >= 79)
            {
                valueList = this.ModsValueList[2].ToArray();
            }
            else if (mapLevel >= 74)
            {
                valueList = this.ModsValueList[1].ToArray();
            }
            return this.ModsValueList.Count > 0 ? string.Format(string.Join(" / ", this.ModsList), valueList) : string.Join(" / ", this.ModsList);
        }

        public int Max
        {
            get
            {
                return this.ModsList.Count(x => !x.Contains("聚居地")) + (this.ModsList.Any(x => x.Contains("聚居地")) ? 1 : 0);
            }
        }
    }
}
