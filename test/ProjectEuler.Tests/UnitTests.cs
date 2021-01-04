// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

using Xunit;
using static Xunit.Assert;

namespace ProjectEuler.Tests
{
  public sealed class UnitTests
  {
    [Fact]
    public void Test001() => Equal(233168, Program001.GetResult());

    [Fact]
    public void Test002() => Equal(4613732, Program002.GetResult());

    [Fact]
    public void Test003() => Equal(6857, Program003.GetResult());

    [Fact]
    public void Test004() => Equal(906609, Program004.GetResult());

    [Fact]
    public void Test005() => Equal(232792560, Program005.GetResult());

    [Fact]
    public void Test006() => Equal(25164150, Program006.GetResult());

    [Fact]
    public void Test007() => Equal(104743, Program007.GetResult());

    [Fact]
    public void Test008() => Equal(23514624000, Program008.GetResult());

    [Fact]
    public void Test009() => Equal(31875000, Program009.GetResult());

    [Fact]
    public void Test010() => Equal(142913828922, Program010.GetResult());

    [Fact]
    public void Test011() => Equal(70600674, Program011.GetResult());

    [Fact]
    public void Test012() => Equal(76576500, Program012.GetResult());

    [Fact]
    public void Test013() => Equal(5537376230, Program013.GetResult());

    [Fact]
    public void Test014() => Equal(837799, Program014.GetResult());

    [Fact]
    public void Test015() => Equal(137846528820, Program015.GetResult());

    [Fact]
    public void Test016() => Equal(1366, Program016.GetResult());

    [Fact]
    public void Test017() => Equal(21124, Program017.GetResult());

    [Fact]
    public void Test018() => Equal(1074, Program018.GetResult());

    [Fact]
    public void Test019() => Equal(171, Program019.GetResult());
  }
}
