// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

namespace ProjectEuler
{
  public static class Program006
  {
    public static int GetResult() =>
      Square(GetSeriesSum(100)) - GetSquaredSeriesSum(100);

    private static int Square(int n) => n * n;

    private static int GetSeriesSum(int n) =>
      n * (n + 1) / 2;

    private static int GetSquaredSeriesSum(int n) =>
      n * (n + 1) * (2 * n + 1) / 6;
  }
}
