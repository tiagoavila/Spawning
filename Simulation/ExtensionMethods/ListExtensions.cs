﻿using System;
using System.Collections.Generic;

namespace Game.ExtensionMethods
{
    public static class ListExtensions
    {
        private static readonly Random Rng = new();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = Rng.Next(n + 1);
                (list[k], list[n]) = (list[n], list[k]);
            }
        }
    }
}
