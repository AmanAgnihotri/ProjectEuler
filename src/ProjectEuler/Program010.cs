// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

using System;

namespace ProjectEuler
{
  public static class Program010
  {
    public static long GetResult()
    {
      var sum = 2L;

      for (var num = 3; num < 2000000; num += 2)
        if (IsPrime(num))
          sum += num;

      return sum;
    }

    private static bool IsPrime(int n)
    {
      switch (n)
      {
        case <= 1: return false;
        case < 4: return true;
      }

      if (n % 2 == 0) return false;
      if (n < 9) return true;
      if (n % 3 == 0) return false;

      var max = Convert.ToInt32(Math.Sqrt(n));

      for (var i = 5; i <= max; i += 6)
        if (n % i == 0 || n % (i + 2) == 0)
          return false;

      return true;
    }
  }
}
