// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

using System;

namespace ProjectEuler
{
  public static class Program012
  {
    public static int GetResult()
    {
      var triangle = 0;

      for (var i = 1; i < int.MaxValue; ++i)
        if (GetDivisorsCount(triangle += i) > 500)
          return triangle;

      throw new ArithmeticException();
    }

    private static int GetDivisorsCount(int n)
    {
      var max = Convert.ToInt32(Math.Sqrt(n));

      var count = max * max == n ? 2 : 1;

      for (var i = 2; i < max; ++i)
        if (n % i == 0)
          count += 2;

      return count;
    }
  }
}
