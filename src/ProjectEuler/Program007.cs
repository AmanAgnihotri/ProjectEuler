// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

using System;

namespace ProjectEuler
{
  public static class Program007
  {
    public static int GetResult()
    {
      for (int num = 2, count = 0;; ++num)
      {
        if (IsPrime(num)) ++count;

        if (count == 10001) return num;
      }
    }

    private static bool IsPrime(int n)
    {
      if (n < 2) return false;
      if (n % 2 == 0) return n == 2;

      var max = Convert.ToInt32(Math.Sqrt(n));

      for (var i = 3; i <= max; i += 2)
        if (n % i == 0)
          return false;

      return true;
    }
  }
}
