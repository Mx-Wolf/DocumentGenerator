using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Aweton.Mxw.DocxGenerator.Test
{
  [TestClass]
  public class DocxGeneratorGetFilesAsTests
  {
    [TestMethod]
    public void GetFilesAsPathsThrowsIfCalledBeforeGenerated()
    {
      var dg = new DocumentGenerator.DocxGenerator($"{Guid.NewGuid()}", 0);
      _ = Assert.ThrowsException<NullReferenceException>(() => dg.GetFilesAsPaths(string.Empty));
    }
    [TestMethod]
    public void GetFilesAsBytesReturnsNullIfCalledBeforGenerated()
    {
      var dg = new DocumentGenerator.DocxGenerator($"{Guid.NewGuid()}", 0);
      Assert.IsNull(dg.GetFilesAsBytes());
    }
  }
}
