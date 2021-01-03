// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

using Xunit;

namespace ProjectEuler.Tests
{
  public partial class UnitTests
  {
    [Fact]
    public void Test010()
    {
      Assert.Equal(142913828922, Program010.GetResult());
    }
  }
}
