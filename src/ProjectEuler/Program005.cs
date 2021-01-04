// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

using System;

namespace ProjectEuler
{
  public static class Program005
  {
    public static long GetResult()
    {
      ulong multiple = 1;

      for (ulong num = 2; num <= 20; ++num)
        multiple = GetLeastCommonMultiple(num, multiple);

      return Convert.ToInt64(multiple);
    }

    private static ulong GetLeastCommonMultiple(ulong a, ulong b) =>
      a * b / GetGreatestCommonDivisor(a, b);

    private static ulong GetGreatestCommonDivisor(ulong a, ulong b)
    {
      while (a != 0 && b != 0)
        if (a > b) a %= b;
        else b %= a;

      return a | b;
    }
  }
}
