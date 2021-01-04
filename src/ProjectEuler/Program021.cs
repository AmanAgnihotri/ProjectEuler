// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

using System;

namespace ProjectEuler
{
  public static class Program021
  {
    public static int GetResult()
    {
      var sum = 0;

      for (var a = 1; a < 10_000; ++a)
      {
        var b = GetProperDivisorsSum(a);

        if (b > a && GetProperDivisorsSum(b) == a)
          sum += a + b;
      }

      return sum;
    }

    private static int GetProperDivisorsSum(int n)
    {
      if (n == 1) return 0;

      var max = Convert.ToInt32(Math.Sqrt(n));

      var sum = max * max == n ? 1 + max : 1;

      var (init, step) = n % 2 == 0 ? (2, 1) : (3, 2);

      for (var i = init; i < max; i += step)
        if (n % i == 0)
          sum += i + n / i;

      return sum;
    }
  }
}
