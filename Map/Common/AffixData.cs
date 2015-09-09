namespace Map.Common
{
    using System.Collections.Generic;
    using Model;

    public static class AffixData
    {
        public static List<Prefix> Prefixes;
        public static List<Suffix> Suffixes;
        public static List<Prefix> CurrentPrefixes;
        public static List<Suffix> CurrentSuffixes;

        public static void Initialize()
        {
            Prefix.Initialize();
            Suffix.Initialize();
            CurrentPrefixes = new List<Prefix>();
            CurrentSuffixes = new List<Suffix>();
        }

        public static bool IsOutOfBound(int maxPrefixNum, int maxSuffixNum)
        {
            return maxSuffixNum < CurrentSuffixes.Count || maxPrefixNum < CurrentPrefixes.Count;
        }

        public static bool IsMatch(int maxPrefixNum, int maxSuffixNum)
        {
            return maxSuffixNum == CurrentSuffixes.Count && maxPrefixNum == CurrentPrefixes.Count;
        }
    }
}
