using AcquireLibrary.Model;
using System;
using System.Collections.Generic;
using System.Threading;

namespace AcquireLibrary
{
    public static class ThreadSafeRandom
    {
        [ThreadStatic]
        private static Random Local;

        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }
    }

    public static class Extension
    {
        public static bool IsHotel(this HotelEnum item)
        {
            return item != HotelEnum.NotUsed &&
                   item != HotelEnum.Used &&
                   item != HotelEnum.NotPlayable;
        }
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static string ToTile(this string value)
        {
            return value.ToString().Replace("_", "");
        }
        public static int ToTileNumber(this TileEnum value)
        {
            if (value.ToString().Length == 4)
            {
                return int.Parse(value.ToString().Substring(1, 2));
            }
            return int.Parse(value.ToString().Substring(1, 1));
        }
        public static char ToTileChar(this TileEnum value)
        {
            if (value.ToString().Length == 4)
            {
                return value.ToString()[3];
            }
            return value.ToString()[2];
        }
    }
}
