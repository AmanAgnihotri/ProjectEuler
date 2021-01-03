// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

using System;

namespace ProjectEuler
{
  public static class Program009
  {
    public static long GetResult()
    {
      for (var a = 1; a < 1000; ++a)
      for (var b = a + 1; b < 1000; ++b)
      {
        var c = 1000 - a - b;

        if (a * a + b * b == c * c) return a * b * c;
      }

      throw new ArithmeticException();
    }
  }
}
