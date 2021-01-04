// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

using Xunit;

namespace ProjectEuler.Tests
{
  public partial class UnitTests
  {
    [Fact]
    public void Test017()
    {
      Assert.Equal(21124, Program017.GetResult());
    }
  }
}
