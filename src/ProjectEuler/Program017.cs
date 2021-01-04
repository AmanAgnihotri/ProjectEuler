// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

using System;
using System.Linq;

namespace ProjectEuler
{
  public static class Program017
  {
    public static int GetResult() =>
      Enumerable.Range(1, 1000).Sum(v => InWords(v).Length);

    private static string InWords(int n) => n switch
    {
      >= 0 and < 20 => Ones[n],
      >= 20 and < 100 => $"{Tens[n / 10]}{(n % 10 == 0 ? "" : Ones[n % 10])}",
      >= 100 and < 1000 => $"{Ones[n / 100]}hundred{GetRest(n, 100)}",
      >= 1000 and < 1000000 => $"{InWords(n / 1000)}thousand{GetRest(n, 1000)}",
      _ => throw new NotImplementedException()
    };

    private static string GetRest(int n, int place) =>
      n % place == 0 ? "" : $"and{InWords(n % place)}";

    private static readonly string[] Ones =
    {
      "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
      "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen",
      "sixteen", "seventeen", "eighteen", "nineteen"
    };

    private static readonly string[] Tens =
    {
      "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy",
      "eighty", "ninety"
    };
  }
}
