// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

using System;

namespace ProjectEuler
{
  public static class Program003
  {
    public static long GetResult()
    {
      var num = 600851475143L;

      while (true)
      {
        var factor = GetSmallestFactor(num);

        if (factor >= num) return factor;

        while (num % factor == 0) num /= factor;
      }
    }

    private static long GetSmallestFactor(long num)
    {
      var max = Convert.ToInt64(Math.Sqrt(num));

      for (var i = 2L; i <= max; ++i)
        if (num % i == 0)
          return i;

      return num;
    }
  }
}
