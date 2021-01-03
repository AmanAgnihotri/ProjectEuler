// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

using Xunit;

namespace ProjectEuler.Tests
{
  public partial class UnitTests
  {
    [Fact]
    public void Test004()
    {
      Assert.Equal(906609, Program004.GetResult());
    }
  }
}
