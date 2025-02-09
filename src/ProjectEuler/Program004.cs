// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

namespace ProjectEuler
{
  public static class Program004
  {
    public static int GetResult()
    {
      var maxPalindrome = 0;

      for (var i = 999; i >= 100; --i)
      for (var j = 999; j >= i; --j)
      {
        var product = i * j;

        if (product > maxPalindrome && product == Reverse(product))
          maxPalindrome = product;
      }

      return maxPalindrome;
    }

    private static int Reverse(int num)
    {
      var reverse = 0;

      while (num > 0)
      {
        reverse = reverse * 10 + num % 10;

        num /= 10;
      }

      return reverse;
    }
  }
}
