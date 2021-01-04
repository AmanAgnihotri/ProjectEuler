// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

using System;

namespace ProjectEuler
{
  public static class Program019
  {
    public static int GetResult()
    {
      var start = new DateTime(1901, 1, 1);
      var end = new DateTime(2001, 1, 1);

      var count = 0;

      for (var date = start; date < end; date = date.AddMonths(1))
        if (date.DayOfWeek is DayOfWeek.Sunday)
          ++count;

      return count;
    }
  }
}
