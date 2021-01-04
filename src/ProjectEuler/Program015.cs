// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

namespace ProjectEuler
{
  public static class Program015
  {
    public static long GetResult()
    {
      const int size = 20;

      return GetNChooseK(2 * size, size);
    }

    private static long GetNChooseK(int n, int k)
    {
      var result = 1L;

      for (var i = 0; i < k; ++i)
      {
        result *= n - i;
        result /= i + 1;
      }

      return result;
    }
  }
}
