// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright © 2021 Aman Agnihotri

using Xunit;

namespace ProjectEuler.Tests
{
  public partial class UnitTests
  {
    [Fact]
    public void Test005()
    {
      Assert.Equal(232792560U, Program005.GetResult());
    }
  }
}
