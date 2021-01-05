// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

using System;
using System.Collections;

namespace ProjectEuler
{
  public static class Program023
  {
    public static int GetResult()
    {
      const int limit = 28123;

      var isAbundant = new BitArray(limit + 1);

      for (var n = 1; n <= limit; ++n)
        isAbundant.Set(n, GetProperDivisorsSum(n) > n);

      var sum = 0;

      for (var n = 1; n <= limit; ++n)
        if (!IsSumOfTwoAbundantNumbers(n))
          sum += n;

      return sum;

      bool IsSumOfTwoAbundantNumbers(int n)
      {
        for (var i = 0; i <= n; ++i)
          if (isAbundant.Get(i) && isAbundant.Get(n - i))
            return true;

        return false;
      }
    }

    private static int GetProperDivisorsSum(int n)
    {
      if (n == 1) return 0;

      var max = Convert.ToInt32(Math.Sqrt(n));

      var sum = 1;

      var (init, step) = n % 2 == 0 ? (2, 1) : (3, 2);

      for (var i = init; i <= max; i += step)
        if (n % i == 0)
          sum += i + n / i;

      if (max * max == n) sum -= max;

      return sum;
    }
  }
}
