// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

using System.Linq;
using System.Numerics;

namespace ProjectEuler
{
  public static class Program016
  {
    public static int GetResult()
    {
      var number = BigInteger.One << 1000;

      return number.ToString().Sum(digit => digit - '0');
    }
  }
}
