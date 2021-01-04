// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

namespace ProjectEuler
{
  public static class Program014
  {
    public static int GetResult()
    {
      const int limit = 1_000_000;

      var chainLengths = new short[limit];

      var maxNum = 0;
      var maxChainLength = 0;

      for (var num = 500_000; num < limit; ++num)
      {
        var chainLength = GetChainLength(num);

        if (chainLength <= maxChainLength) continue;

        maxNum = num;
        maxChainLength = chainLength;
      }

      return maxNum;

      short GetChainLength(long num)
      {
        while (true)
          switch (num)
          {
            case 1: return 1;
            case < limit:
            {
              if (chainLengths[num] == 0)
                chainLengths[num] = GetLength();

              return chainLengths[num];
            }
            default: return GetLength();
          }

        short GetLength() => (short) ((num & 1) == 0
          ? 1 + GetChainLength(num >> 1)
          : 2 + GetChainLength(3 * num + 1));
      }
    }
  }
}
