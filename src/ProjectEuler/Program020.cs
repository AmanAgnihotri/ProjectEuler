// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

using System.Linq;
using System.Numerics;

namespace ProjectEuler
{
  public static class Program020
  {
    public static int GetResult()
    {
      var number = Enumerable.Range(1, 100)
        .Aggregate(BigInteger.One, (acc, val) => acc * val);

      return number.ToString().Sum(digit => digit - '0');
    }
  }
}
