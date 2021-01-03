// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

namespace ProjectEuler
{
  public static class Program001
  {
    public static int GetResult()
    {
      var sum = 0;

      for (var i = 0; i < 1000; ++i)
        if (i % 3 == 0 || i % 5 == 0)
          sum += i;

      return sum;
    }
  }
}
