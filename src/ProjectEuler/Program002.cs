// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

namespace ProjectEuler
{
  public static class Program002
  {
    public static int GetResult()
    {
      var sum = 0;
      var a = 0;
      var b = 1;

      while (a <= 4000000)
      {
        if (a % 2 == 0) sum += a;

        var c = a + b;
        a = b;
        b = c;
      }

      return sum;
    }
  }
}
